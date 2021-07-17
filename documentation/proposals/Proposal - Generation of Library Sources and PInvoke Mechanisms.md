# Summary
Proposal design for a platform invoke (P/Invoke) mechanism for Silk.NET 3.0.

# Contributors
- Dylan Perks (@Perksey)
- Kai Jellinghaus (@HurricanKai)

# Current Status
- [x] Proposed
- [ ] Discussed with Working Group (WG)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- This proposal builds on the foundations laid out by Silk.NET's move to source generators in 2.0, and the introduction of the SilkTouch source generator as a result of this.
- This proposal assumes no knowledge of Silk.NET 2.0's SilkTouch. 
- This takes the knowledge and insight gained during development of SilkTouch, and uses it to create a new set of generators which incorporate lessons learnt.
- This proposal breaks down the generator process into three distinct stages:

## SilkTouch Scraper

The Scraper is responsible for creating partial classes from some input source. It is a drop-in replacement for what BuildTools does today. Instead of doing all the parsing and interpretation of the input source ourselves, the proposed Scraper will instead use only C headers and have a "preburner" for gathering minimal metadata to feed into the generation process.

The generation process of the proposed Scraper will be entirely different. Silk.NET will no longer do any parsing and interpretation of C headers or XML of C headers, instead we will delegate this to the ClangSharp P/Invoke Generator in the form of a "subagent" (a separate process spun up by the Scraper), adding appropriate modifications to ClangSharp P/Invoke Generator as necessary. This means that we will no longer be using the Khronos XML registries for generating bindings. Instead, we'll use the preburner stage to use the XML registry only to gather minimal metadata instructing the ClangSharp subagent to add metadata attributes to certain functions, parameters, or types; which will then be picked up on by the later stages of SilkTouch. An example of such metadata would be parsing the flow and len XML attributes to add appropriate C# attributes to influence overload generation.

This also naturally makes us entirely dependent on an external dependency, but I propose we work with Microsoft as much as possible to add the functionality we need in the least breaking way possible, and in a way that satisfies both us and Microsoft. All designs for such modifications will be formalized in the ClangSharp repo. Should we fail to do this, we'll maintain a fork so we can still benefit from improvements made upstream, while giving ourselves the freedom to add the functionality we need.

Microsoft have already stated that they're happy to work with us to get Silk.NET using ClangSharp, one maintainer even saying they're happy to add a CI test stage into the ClangSharp repo to ensure no incoming changes break Silk.NET's generation process.

There is no required behaviour for the Scraper (due to a lot of unknowns at the moment) other than it **MUST** invoke ClangSharp to generate C# Emitter-compatible classes, and it **MUST** add appropriate attributes to invoke the Overloader stage according to any metadata available from Khronos XML if applicable.

## SilkTouch Emitter
The Emitter, one of the two final stages whose resources **MUST** be entirely independent of eachother, is responsible for generating the actual indirect calls for performing the P/Invoke.

The Emitter operates on partial methods, the behaviour of the implementations of which depending on the context in which it's used.

All attributes **MUST** be name matched only, to allow the user to define these themselves and not create a hard dependency on a specific Silk.NET library such as the Silk.NET Core. 

Candidate methods for implementation by the Emitter **MUST** be partial and not have an implementation part yet. Their containing types **MUST** also be partial.

The Emitter **MUST** be able to be invoked via the SilkTouch CLI and **MAY** be able to be invoked via an incremental Roslyn source generator.

### Call Styles

The Emitter's primary purpose is to load and use function pointers in a native library sourced from an operating system's kernel, though this doesn't necessarily have to be the case. This logic will be emitted by the Emitter itself, and will not require an external dependency like the Silk.NET Core. However, this logic will no longer be implicit.

#### Built-in: Dynamic-Link Library Call Style

Consider the following example:
```cs
[UseDynamicLibrary("glfw3.dll")]
public partial class Glfw
{
    public partial void glfwInit();
}
```

The `UseDynamicLibrary` attribute instructs the Emitter that it **MUST** use [`DllImport`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-5.0) to access native functions. [`NativeLibrary`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.nativelibrary?view=net-5.0) can be used to modify the libsuperrary loading process per other requirements defined below. For the entry point, the function name **MUST** be used unless a `NativeApi` attribute is provided, in which case the `EntryPoint` indicated by that attribute **MUST** be used.

Consider the following example:
```cs
[UseDynamicLibrary("glfw3.dll", "libglfw3.dylib")]
public partial class Glfw { /* ... */ }
```

`UseDynamicLibrary` **MUST** be able to be specified on either a function or type.

The Emitter **MUST** allow multiple candidate library names and cycle through each candidate until one loads successfully.

#### Built-in: Static-Link Library Call Style

Consider the following example:
```cs
[UseStaticLibrary]
public partial class Glfw
{
    public partial void glfwInit();
}
```

The `UseStaticLibrary` attribute instructs the Emitter that it **MUST** use [`DllImport`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-5.0) to access native functions. `__Internal` **MUST** be used for the library name. For the entry point, the function name **MUST** be used unless a `NativeApi` attribute is provided, in which case the `EntryPoint` indicated by that attribute **MUST** be used.

`UseStaticLibrary` **MUST** be able to be specified on either a function or type.

Consider the following example:
```cs
#if __IOS__
[UseStaticLibrary]
#endif
[UseDynamicLibrary("glfw3.dll")]
public partial class Glfw
{
    public partial void glfwInit();
}
```

The Emitter **MUST** only generate code if all preprocessor directives guarding the `UseStaticLibrary` attribute evaluate to true. If the attribute is defined on both the function and the containing type, the preprocessor directives surrounding the function's attribute **MUST** be used instead of the preprocessor directives surrounding the type.

Note to the reader: Given preprocessor directives are processed at parse time in Roslyn, both of those last requirements are basically benign.

#### Custom Call Style: Procedure Address Expressions

Custom code may be used as a call style by providing a pointer to SilkTouch using a Procedure Address Expression. This is useful in scenarios such as COM interop.

Procedure Address Expressions are C# expressions that **MUST** evaluate to a `void*`, `nint`, or `IntPtr`. This is the actual address in memory of the function being invoked.

Consider the following example:
```cs
public partial struct IUnknown
{
    public void** LpVtbl;
    [UseExpression("LpVtbl[1]")]
    public partial uint AddRef();
}
```

`GetProcAddress` indicates that the C# code given **MUST** be used as the Procedure Address Expression to retrieve the function address to call. Any arbritrary code can be inserted into this attribute, so long as the result of the code once evaluated meets the Procedure Address Expression definition. For example, this is valid:
```cs
public partial struct IUnknownNullableContainer
{
    public IUnknownPtr? Value;
    [UseExpression("Value.GetValueOrDefault().InnerValue->LpVtbl[1]")]
    public partial uint AddRef();
}

public struct IUnknownPtr
{
    public IUnknown* InnerValue;
}

public struct IUnknown
{
    public void** LpVtbl;
}
```

The Emitter **SHOULD** implicitly parenthesise the expression given in the attribute.

Unless another call style is applicable, the Emitter **MUST** mandate that every function has a `UseExpression` (Procedure Address Expression) specified.

The Emitter **MUST** call the function pointer returned by the Procedure Address Expression as part of this call style.

#### Custom Call Style: Procedure Address Methods

A level more abstracted than Procedure Address Expressions, which allows any custom code to retrieve a function pointer; Procedure Address Methods work similarly to the native library call style from an API perspective, but function similarly to the Procedure Address Expressions call style.

The aim of this call style is to provide flexibility without comprimising code readability. Consider the following example:

```cs
[UseMethod(nameof(GetProcAddressShim))]
public partial class Glfw
{
    [UseDynamicLibrary("glfw3.dll")]
    public partial nint glfwGetProcAddress(byte* str);

    // shim to convert the string, which SilkTouch needs to use, to a byte pointer - THIS IS NOT A MODEL EXAMPLE!
    private nint GetProcAddressShim(string str) => glfwGetProcAddress((byte*) Marshal.StringToHGlobalAnsi(str));

    public partial void glBegin(uint mode);
}
```

Procedure Address Methods are method groups (or an otherwise callable expression) within the scope of the method that **MUST** return a `void*`, `nint`, or `IntPtr` when invoked. This is the actual address in memory of the function being invoked.

Procedure Address Methods **MUST** take one parameter of type `string`.

For the parameter passed into the callable specified in the attribute, the function name **MUST** be used unless the `EntryPoint` property in the `NativeApi` attribute is provided, in which case the `EntryPoint` indicated by the attribute **MUST** be used.

The Emitter **MUST** call the function pointer returned by the Procedure Address Method as part of this call style.

#### Call Style Priority

Consider the following example:

```cs
[UseDynamicLibrary("glfw3.dll")]
public partial class Glfw
{
    public partial nint glfwGetProcAddress(byte* str);
    [UseExpression("glfwGetProcAddress((byte*)Unsafe.AsPointer(ref Unsafe.AsRef(0x006e696765426c67)))")]
    public partial void glBegin(uint mode);
}
```

Here, a class using the Dynamic Library call style has a method which does not follow the call style defined at the class level, and is overridden using a `UseExpression` attribute.

If multiple call styles are applicable, the following order of preference **MUST** be respected:
- Procedure Address Expressions
- Procedure Address Methods
- Static-Link Library
- Dynamic-Link Library

Function-level attributes **MUST** be preferred over type-level ones, and follow the same order of preference.

### Native Calls
For the most part, the resultant native signature used by the Emitter is matched 1:1 with the method signature. However there are certain modifications you can apply. Namely, the `NativeApi` attribute will allow specification of specific calling conventions. For example:

```cs
[NativeApi(Modifiers = CallModifiers.MemberFunction | CallModifiers.SuppressGCTransition | CallModifiers.WinapiConvention)]
public partial D3D12_HEAP_PROPERTIES GetCustomHeapProperties(uint nodeMask, D3D12_HEAP_TYPE heapType);
```

- CallModifiers **MUST** be a bitmask with each modifier having its own unique bit.
- **MemberFunction**: If this modifier is specified, the Emitter **MUST** modify the function pointer call to use the Windows C++ instance member function calling style. This modifier **MUST** only be used with the Procedure Address Method or Procedure Address Expression call styles.
- **SuppressGCTransition**: If this modifier is specified, the Emitter **SHOULD** prevent the .NET garbage collector from transitioning between co-operative and pre-emptive mode during the call.
- **WinapiConvention**: If this modifier is specified, the Emitter **MUST** use the platform default calling convention. This convention **MUST** also be used if no other calling convention bits are set.
- **CdeclConvention**: If this modifier is specified, the Emitter **MUST** use the C `__cdecl` calling convention.
- **StdcallConvention**: If this modifier is specified, the Emitter **MUST** use the C `__stdcall` calling convention.
- **FastcallConvention**: If this modifier is specified, the Emitter **MUST** use the C `__fastcall` calling convention.
- **ThiscallConvention**: If this modifier is specified, the Emitter **MUST** use the C `__thiscall` calling convention.

`CallModifiers` will be used as the primary bitmask for customizing the behaviour of generation, just as `NativeApi` will be used as the primary attribute for this as well. The behaviour of each bit will be described in documentation comments in the Proposed API section.

The Emitter does not do any marshalling. As such, the Emitter **MUST** mandate that every parameter and return type of every function fits the `unmanaged` constraint. For the readers benefit, this can be done using a property on `ITypeSymbol` in Roslyn.

## SilkTouch Overloader
The Overloader, one of the two final stages whose resources **MUST** be entirely independent of eachother, creates overloads of functions that expose a more user-friendly interface than the function it overloads, and do appropriate marshalling to lower the parameter types used down to the original function's types.

The Overloader **MUST** be able to be used on any function and not be tied to any of the Emitter's constraints.

The Overloader **MUST** be able to be invoked via the SilkTouch CLI and **MAY** be able to be invoked via an incremental Roslyn source generator.

The Overloader **MUST** generate all possible permutations of overloads.

The Overloader does not care about existing methods. If the Overloader generates an overload that also happens to exist manually, it is the user's repsonsibility to disable the relevant overloads for these cases.

However, if the Overloader thinks that the overload it's generating may conflict with another overload or the original function, it **SHOULD** output the overload as an extension method rather than a method within the containing type, unless the original method is static in which case it **MUST** discard the overload and generate a warning. It **SHOULD** also do this if the containing type is not partial.

### Parameter Overloads

NB: the activation of all overloaders defined in this section are defined as should level requirements only to grant an implementation the responsibility to refuse to output an overload if there's some other consideration(s) not specified here that would make it unable, illogical, or inapplicable to do so.

The actual functionality of the overloaders are defined as must level requirements, so if the implementation does decide it's safe to output a particular overload, it must follow the functionality of that overload exactly.

#### StringOverloader
Consider the following example:

```cs
[StringOverloads]
public void MethodOne(byte* str);

[StringOverloads]
public void MethodTwo(char* str);

[StringOverloads]
public void MethodThree([UnmanagedType(NativeStringEncoding.Ansi)] void* str);

[StringOverloads]
public void MethodFour([In] byte* str);

[StringOverloads]
public void MethodFive([In, Out] byte* str); 

[StringOverloads]
public void MethodSix(int bufSize, [Out, Count("bufSize")] byte* str);
```

If the string overloader is selected using the `StringOverloads` attribute, the Overloader **SHOULD** overload any parameters recognised to be pointers to a native string to expose a .NET `string` parameter variant as defined below.

`StringOverloads` **MUST** take one optional boolean parameter (defaulting to `true`) where `true` enables the overload, and `false` disables it. `StringOverloads` **MUST** be able to be specified at the function, type, module, or assembly level. If not specifed on the function directly, the value **MUST** be inherited from one of its containers if the attribute is specified on them.

If this overloader is used:
- This overloader **MUST NOT** overload any parameters that are not of types `byte*`, `char*`, or `sbyte*` unless the `NativeStringEncoding` is set using an `UnmanagedType` attribute on a parameter. If this is the case, the parameter **MUST** be a single-dimensional pointer to any type (i.e. `void*`, `T*`, etc)
- The native string created from the `string` parameter in the overload **MUST** use the `NativeStringEncoding` specified in the `UnmanagedType` attribute for a given parameter:
    - If `Ansi` or `LPStr` is used, the native string **MUST** be encoded as a single byte, null-terminated ANSI character string.
    - If `Auto` or `LPTStr` is used, the native string is encoded in an implementation-defined way.
    - If `Uni` or `LPWStr` is used, the native string **MUST** be encoded as a 2-byte, null-terminated Unicode character string.
    - If `UTF8` or `LPUTF8Str` is used, the native string **MUST** be encoded as a null-terminated UTF8 character string.
    - If no attribute is provided `Ansi` **MUST** be used.
- The flow of the string can also be specified, reusing the attributes from `System.Runtime.CompilerServices`:
    - If neither `In` nor `Out` are specified, the string **MUST** be assumed to be `In`.
    - If only `In` is specified, the parameter **MUST** be overloaded as `string`.
    - If `In` and `Out` are specified, the parameter **MUST** be overloaded as `ref string`. The string will be marshalled to the native representation, the underlying method might do some modifications to the buffer created by the Overloader, and then it **MUST** be marshalled back to a C# string, the result being stored in the ref parameter.
    - If only `Out` is specified, the parameter **MUST** be overloaded as `out string`. A buffer of length + 1 **MUST** be allocated and passed to the underlying method, where length is replaced with the expression defined in the `Count` attribute

Example of resultant signatures:

```cs
public void MethodOne(string str);
public void MethodTwo(string str);
public void MethodThree(string str);
public void MethodFour(string str);
public void MethodFive(ref string str);
public void MethodSix(int bufSize, out string str);
```

#### StringListOverloader
Consider the following example:

```cs
[StringListOverloads]
public void MethodOne(byte** strings);

[StringListOverloads]
public void MethodTwo(char** strings);

[StringListOverloads]
public void MethodThree([UnmanagedType(NativeStringEncoding.Ansi)] void** strings);

[StringListOverloads]
public void MethodFour([In] byte** strings);

[StringListOverloads]
public void MethodFive([In, Out] byte** strings);

[StringListOverloads]
public void MethodSix(int numStrings, [Out, Count("numStrings")] byte** strings);
```

If the string list overloader is selected using the `StringListOverloads` attribute, the Overloader **SHOULD** overload any parameters recognised to be pointers to a native string to expose a .NET `string` parameter variant as defined below.

`StringListOverloads` **MUST** take one optional boolean parameter (defaulting to `true`) where `true` enables the overload, and `false` disables it. `StringListOverloads` **MUST** be able to be specified at the function, type, module, or assembly level. If not specifed on the function directly, the value **MUST** be inherited from one of its containers if the attribute is specified on them.

If this overloader is used:
- This overloader **MUST NOT** overload any parameters that are not of types `byte**`, `char**`, or `sbyte**` unless the `NativeStringEncoding` is set using an `UnmanagedType` attribute on a parameter. If this is the case, the parameter **MUST** be a two-dimensional pointer to any type (i.e. `void**`, `T**`, etc)
- The overloader **MUST** allocate a buffer large enough to contain the same number of pointers as elements in the string list parameter. 
- For each string contained in the string list, the string **MUST** be marshalled per the `NativeStringEncoding` rules defined in the StringOverloader section.
- The flow of the string list can also be specified, reusing the attributes from `System.Runtime.CompilerServices`:
    - If neither `In` nor `Out` are specified, the string list **MUST** be assumed to be `In`.
    - If only `In` is specified, the parameter **MUST** be overloaded as `IReadOnlyList<string>`.
    - If `In` and `Out` are specified, the parameter **MUST** be overloaded as `IList<string>`. Each string will be marshalled to the native representation, the underlying method might do some modifications to the buffer created by the Overloader, and then each string **MUST** be marshalled back to a C# string, the results being stored back in the original list.
    - If only `Out` is specified, the parameter **MUST** be overloaded as `out string[]`. A buffer of length pointers **MUST** be allocated and passed to the underlying method, where length is replaced with the expression defined in the `Count` attribute.


Example of resultant signatures:

```cs
public void MethodOne(IReadOnlyList<string> strings);
public void MethodTwo(IReadOnlyList<string> strings);
public void MethodThree(IReadOnlyList<string> strings);
public void MethodFour(IReadOnlyList<string> strings);
public void MethodFive(IList<string> strings);
public void MethodSix(int numStrings, out string[] strings);
```

#### StringSpanOverloader
Consider the following example:

```cs
[StringSpanOverloads]
public void MethodOne(byte** strings);

[StringSpanOverloads]
public void MethodTwo(char** strings);

[StringSpanOverloads]
public void MethodThree([UnmanagedType(NativeStringEncoding.Ansi)] void** strings);

[StringSpanOverloads]
public void MethodFour([In] byte** strings);

[StringSpanOverloads]
public void MethodFive([In, Out] byte** strings);
```

If the string span overloader is selected using the `StringSpanOverloads` attribute, the Overloader **SHOULD** overload any parameters recognised to be pointers to a native string to expose a .NET `string` parameter variant as defined below.

`StringSpanOverloads` **MUST** take one optional boolean parameter (defaulting to `true`) where `true` enables the overload, and `false` disables it. `StringSpanOverloads` **MUST** be able to be specified at the function, type, module, or assembly level. If not specifed on the function directly, the value **MUST** be inherited from one of its containers if the attribute is specified on them.

If this overloader is used:
- This overloader **MUST NOT** overload any parameters that are not of types `byte**`, `char**`, or `sbyte**` unless the `NativeStringEncoding` is set using an `UnmanagedType` attribute on a parameter. If this is the case, the parameter **MUST** be a two-dimensional pointer to any type (i.e. `void**`, `T**`, etc)
- The overloader **MUST** allocate a buffer large enough to contain the same number of pointers as elements in the string span parameter. 
- For each string contained in the string span, the string **MUST** be marshalled per the `NativeStringEncoding` rules defined in the StringOverloader section.
- The flow of the string span can also be specified, reusing the attributes from `System.Runtime.CompilerServices`:
    - If neither `In` nor `Out` are specified, the string span **MUST** be assumed to be `In`.
    - If only `In` is specified, the parameter **MUST** be overloaded as `ReadOnlySpan<string>`.
    - If `In` and `Out` are specified, the parameter **MUST** be overloaded as `Span<string>`. Each string will be marshalled to the native representation, the underlying method might do some modifications to the buffer created by the Overloader, and then each string **MUST** be marshalled back to a C# string, the results being stored back in the original span.
    - If only `Out` is specified, the Overloader **MUST NOT** overload this parameter as this is illegal.


Example of resultant signatures:

```cs
public void MethodOne(ReadOnlySpan<string> strings);
public void MethodTwo(ReadOnlySpan<string> strings);
public void MethodThree(ReadOnlySpan<string> strings);
public void MethodFour(ReadOnlySpan<string> strings);
public void MethodFive(Span<string> strings);
```

#### CastableAlternativeTypeOverloader

Consider the following example:
```cs
public void MethodOne([AlternativeType(nameof(MyOtherEnum))] MyEnum value); // good
public void MethodTwo([AlternativeType(nameof(string))] MyEnum value); // will end up generating a compiler error 
public void MethodThree([AlternativeType(nameof(MyOtherEnum)), AlternativeType(nameof(MyOtherOtherEnum))] MyEnum value); // good
public void MethodFour([AlternativeType(nameof(MyOtherEnum))] MyEnum val1, [AlternativeType(nameof(MyOtherOtherEnum))] MyEnum val2); // good
```

The Overloader **SHOULD** overload any parameters annotated with an `AlternativeType` attribute to expose a parameter of the type specified in the attribute.

`AlternativeType` **MUST** allow multiple usages on a single parameter, and usage on multiple parameters in a single function; generating all applicable combinations accordingly.

If this overloader is used, the Overloader **MUST** generate a regular C# cast to the given alternative type(s), which will allow both static casts and operator-based casts.

The Overloader **MAY NOT** check whether the cast is valid at generation time.

Example of resultant signatures:

```cs
public void MethodOne(MyOtherEnum value);
// MethodTwo has a compiler error...
public void MethodThree(MyOtherEnum value);
public void MethodThree(MyOtherOtherEnum value);
public void MethodFour(MyEnum val1, MyOtherOtherEnum val2);
public void MethodFour(MyOtherEnum val1, MyEnum val2);
public void MethodFour(MyOtherEnum val1, MyOtherOtherEnum val2);
```

#### RefOverloader

Consider the following example:

```cs
[RefOverloads]
public void MethodOne(int* whatever);

[RefOverloads]
public void MethodTwo([In] int* whatever);

[RefOverloads]
public void MethodThree([In, Out] int* whatever);

[RefOverloads]
public void MethodFour([Out] int* whatever);

[RefOverloads]
public void MethodFive<T>([Out] T* whatever) where T : unmanaged;

[RefOverloads]
public void MethodFive(void* whatever);
```

If the ref overloader is selected using the `RefOverloads` attribute, the Overloader **SHOULD** overload any parameters recognised to be pointers to expose a `in`, `out`, or `ref` parameter variant as defined below.

`RefOverloads` **MUST** take one optional boolean parameter (defaulting to `true`) where `true` enables the overload, and `false` disables it. `RefOverloads` **MUST** be able to be specified at the function, type, module, or assembly level. If not specifed on the function directly, the value **MUST** be inherited from one of its containers if the attribute is specified on them.

If this overloader is used:
- The overloaded parameter **MUST** have one less pointer dimension than the original.
- The flow of the reference may be specified, reusing the attributes from `System.Runtime.CompilerServices`:
    - If neither `In` nor `Out` are specified, the ref **MUST** be assumed to be `In`.
    - If only `In` is specified, the parameter **MUST** be overloaded as `in`.
    - If `In` and `Out` are specified, the parameter **MUST** be overloaded as `ref`.
    - If only `Out` is specified, the parameter **MUST** be overloaded as `out`.
- A pinned pointer **MUST** be taken from the overloaded parameter to use as the value passed to the original function.
- Generic types **MUST** be allowed.
- `void*` **MUST** overload with a generic type parameter.

Example of resultant signatures:

```cs
public void MethodOne(in int whatever);
public void MethodTwo(in int whatever);
public void MethodThree(ref int whatever);
public void MethodFour(out int whatever);
public void MethodFive<T>(out T whatever) where T : unmanaged;
```

#### SpanOverloader

Consider the following example:

```cs
[SpanOverloads]
public void MethodOne(int* whatever);

[SpanOverloads]
public void MethodTwo([In] int* whatever);

[SpanOverloads]
public void MethodThree([In, Out] int* whatever);

[SpanOverloads]
public void MethodFour<T>([In, Out] T* whatever) where T : unmanaged;

[SpanOverloads]
public void MethodFive([In, Out] void* whatever);
```

If the ref overloader is selected using the `SpanOverloads` attribute, the Overloader **SHOULD** overload any parameters recognised to be pointers to expose a span parameter variant as defined below.

`SpanOverloads` **MUST** take one optional boolean parameter (defaulting to `true`) where `true` enables the overload, and `false` disables it. `SpanOverloads` **MUST** be able to be specified at the function, type, module, or assembly level. If not specifed on the function directly, the value **MUST** be inherited from one of its containers if the attribute is specified on them.

If this overloader is used:
- This overloader **MUST NOT** overload any parameters that not single-dimensional pointers to any type (i.e. `void*`, `T*`, etc)
- The flow of the span may be specified, reusing the attributes from `System.Runtime.CompilerServices`:
    - If neither `In` nor `Out` are specified, the span **MUST** be assumed to be `In`.
    - If only `In` is specified, the parameter **MUST** be overloaded as `ReadOnlySpan<T>` where `T` is the pointee type.
    - If `In` and `Out` are specified, the parameter **MUST** be overloaded as `Span<T>` where `T` is the pointee type.
    - If only `Out` is specified, the Overloader **MUST NOT** overload this parameter as this is illegal.
- A pinned pointer **MUST** be taken from the overloaded parameter's pinnable reference to use as the value passed to the original function.
- Generic types **MUST** be allowed.
- The original type **MUST NOT** be byref or byref-like.
- `void*` **MUST** overload with a generic type parameter in place of the pointee type.

Example of resultant signatures:

```cs
public void MethodOne(ReadOnlySpan<int> whatever);
public void MethodTwo(ReadOnlySpan<int> whatever);
public void MethodThree(Span<int> whatever);
public void MethodFour<T>(Span<T> whatever) where T : unmanaged;
public void MethodFive<T>(Span<T> whatever) where T : unmanaged;
```

#### ArrayOverloader

Consider the following example:

```cs
[ArrayOverloads]
public void MethodOne(int* whatever);

[ArrayOverloads]
public void MethodTwo<T>(T* whatever) where T : unmanaged;

[ArrayOverloads]
public void MethodThree(void* whatever);
```

If the ref overloader is selected using the `ArrayOverloads` attribute, the Overloader **SHOULD** overload any parameters recognised to be pointers to expose a span parameter variant as defined below.

`ArrayOverloads` **MUST** take one optional boolean parameter (defaulting to `true`) where `true` enables the overload, and `false` disables it. `ArrayOverloads` **MUST** be able to be specified at the function, type, module, or assembly level. If not specifed on the function directly, the value **MUST** be inherited from one of its containers if the attribute is specified on them.

If this overloader is used:
- This overloader **MUST NOT** overload any parameters that not single-dimensional pointers to any type (i.e. `void*`, `T*`, etc)
- The parameter **MUST** be overloaded as `T[]`, `T[,]`, and `T[,,]` where `T` is the pointee type.
- A pinned pointer **MUST** be taken from the overloaded parameter's pinnable reference to use as the value passed to the original function.
- Generic types **MUST** be allowed.
- The original type **MUST NOT** be byref or byref-like.
- `void*` **MUST** overload with a generic type parameter in place of the pointee type.

Example of resultant signatures:

```cs
public void MethodOne(int[] whatever);
public void MethodOne(int[,] whatever);
public void MethodOne(int[,,] whatever);
public void MethodTwo<T>(T[] whatever) where T : unmanaged;
public void MethodTwo<T>(T[,] whatever) where T : unmanaged;
public void MethodTwo<T>(T[,,] whatever) where T : unmanaged;
public void MethodThree<T>(T[] whatever) where T : unmanaged;
public void MethodThree<T>(T[,] whatever) where T : unmanaged;
public void MethodThree<T>(T[,,] whatever) where T : unmanaged;
```

#### ImplicitCountSpanOverloader

Consider the following example:

```cs
[ImplicitCountSpanOverloader]
public void MethodOne(int n, [Count("n")] int* whatever);

[ImplicitCountSpanOverloader]
public void MethodTwo<T>(int n, [Count("n")] T* whatever) where T : unmanaged;

[ImplicitCountSpanOverloader]
public void MethodThree<T>(int n, [Count("n")] void* whatever) where T : unmanaged;

[ImplicitCountSpanOverloader]
public void MethodFour<T>(int n, [Count("n*4")] void* whatever) where T : unmanaged;
```

If the ref overloader is selected using the `ImplicitCountSpanOverloader` attribute, the Overloader **SHOULD** overload any parameters recognised to be pointers to expose a span parameter variant as defined below.

`ImplicitCountSpanOverloader` **MUST** take one optional boolean parameter (defaulting to `true`) where `true` enables the overload, and `false` disables it. `ImplicitCountSpanOverloader` **MUST** be able to be specified at the function, type, module, or assembly level. If not specifed on the function directly, the value **MUST** be inherited from one of its containers if the attribute is specified on them.

If this overloader is used:
- This overloader **MUST NOT** overload any parameters that not single-dimensional pointers to any type (i.e. `void*`, `T*`, etc)
- The flow of the span may be specified, reusing the attributes from `System.Runtime.CompilerServices`:
    - If neither `In` nor `Out` are specified, the span **MUST** be assumed to be `In`.
    - If only `In` is specified, the parameter **MUST** be overloaded as `ReadOnlySpan<T>` where `T` is the pointee type.
    - If `In` and `Out` are specified, the parameter **MUST** be overloaded as `Span<T>` where `T` is the pointee type.
    - If only `Out` is specified, the Overloader **MUST NOT** overload this parameter as this is illegal.
- A pinned pointer **MUST** be taken from the overloaded parameter's pinnable reference to use as the value passed to the original function.
- Generic types **MUST** be allowed.
- The count parameter **MUST** be removed.
- The original type **MUST NOT** be byref or byref-like.
- The span's length **MUST** be used as the value for the parameter referenced by the `Count` attribute.
    - Any expression **MUST** be allowed in the `Count` attribute so long as it evaluates to the type of the count parameter.
    - The type of the referenced parameter **MUST** be a primitive type (i.e. not a pointer)
    - If multiple parameter names are identified in the count expression, the Overloader **SHOULD NOT** overload.
        - Suppose that there is a function with three parameters: `n`, `size`, and `buffer`. If the expression `n*sizeof(int)` is used for the count of the `buffer`, `n` should still be identified as the only parameter name in the expression. The Overloader **SHOULD** make every attempt possible to identify just one parameter name.


Example of resultant signatures:

```cs
public void MethodOne(Span<int> whatever);
public void MethodTwo<T>(Span<T> whatever) where T : unmanaged;
public void MethodThree<T>(Span<T> whatever) where T : unmanaged;
public void MethodFour<T>(Span<T> whatever) where T : unmanaged;
```

#### ImplicitCountArrayOverloader

Consider the following example:

```cs
[ImplicitCountArrayOverloader]
public void MethodOne(int n, [Count("n")] int* whatever);

[ImplicitCountArrayOverloader]
public void MethodTwo<T>(int n, [Count("n")] T* whatever) where T : unmanaged;

[ImplicitCountArrayOverloader]
public void MethodThree<T>(int n, [Count("n")] void* whatever) where T : unmanaged;

[ImplicitCountArrayOverloader]
public void MethodFour<T>(int n, [Count("n*4")] void* whatever) where T : unmanaged;
```

If the ref overloader is selected using the `ImplicitCountArrayOverloader` attribute, the Overloader **SHOULD** overload any parameters recognised to be pointers to expose a span parameter variant as defined below.

`ImplicitCountArrayOverloader` **MUST** take one optional boolean parameter (defaulting to `true`) where `true` enables the overload, and `false` disables it. `ImplicitCountArrayOverloader` **MUST** be able to be specified at the function, type, module, or assembly level. If not specifed on the function directly, the value **MUST** be inherited from one of its containers if the attribute is specified on them.

If this overloader is used:
- This overloader **MUST NOT** overload any parameters that not single-dimensional pointers to any type (i.e. `void*`, `T*`, etc)
- The parameter **MUST** be overloaded as `T[]`, `T[,]`, and `T[,,]` where `T` is the pointee type.
- A pinned pointer **MUST** be taken from the overloaded parameter's pinnable reference to use as the value passed to the original function.
- Generic types **MUST** be allowed.
- The original type **MUST NOT** be byref or byref-like.
- The count parameter **MUST** be removed.
- The span's length **MUST** be used as the value for the parameter referenced by the `Count` attribute.
    - Any expression **MUST** be allowed in the `Count` attribute so long as it evaluates to the type of the count parameter.
    - The type of the referenced parameter **MUST** be a primitive type (i.e. not a pointer)
    - If multiple parameter names are identified in the count expression, the Overloader **SHOULD NOT** overload.
        - Suppose that there is a function with three parameters: `n`, `size`, and `buffer`. If the expression `n*sizeof(int)` is used for the count of the `buffer`, `n` should still be identified as the only parameter name in the expression. The Overloader **SHOULD** make every attempt possible to identify just one parameter name.


Example of resultant signatures:

```cs
public void MethodOne(int[] whatever);
public void MethodOne(int[,] whatever);
public void MethodOne(int[,,] whatever);
public void MethodTwo<T>(T[] whatever) where T : unmanaged;
public void MethodTwo<T>(T[,] whatever) where T : unmanaged;
public void MethodTwo<T>(T[,,] whatever) where T : unmanaged;
public void MethodThree<T>(T[] whatever) where T : unmanaged;
public void MethodThree<T>(T[,] whatever) where T : unmanaged;
public void MethodThree<T>(T[,,] whatever) where T : unmanaged;
public void MethodFour<T>(T[] whatever) where T : unmanaged;
public void MethodFour<T>(T[,] whatever) where T : unmanaged;
public void MethodFour<T>(T[,,] whatever) where T : unmanaged;
```

#### OpenGLDeleteOverloader

#### OpenGLObjectCreationOverloader

# Proposed API
- Here you do some code blocks, this is the heart and soul of the proposal. DON'T DO ANY IMPLEMENTATIONS! Just declarations.

## `UseDynamicLibrary`
```cs
namespace Silk.NET.Core
{
    [AttributeUsage(AttributeTargets.Function | AttributeTargets.Class)]
    public class UseDynamicLibraryAttribute : Attribute
    {
        public UseDynamicLibrary(string libraryName, params string[] alternativeNames);
        public string LibraryName { get; }
        public string[] AlternativeNames { get; }
    }
}
```

## `UseStaticLibrary`
```cs
namespace Silk.NET.Core
{
    [AttributeUsage(AttributeTargets.Function | AttributeTargets.Class)]
    public class UseStaticLibraryAttribute : Attribute
    {
    }
}
```

## `UseExpression`
```cs
namespace Silk.NET.Core
{
    [AttributeUsage(AttributeTargets.Function | AttributeTargets.Class)]
    public class UseExpressionAttribute : Attribute
    {
        public UseExpressionAttribute(string expr);
        public string Expression { get; }
    }
}
```

## `UseMethod`
```cs
namespace Silk.NET.Core
{
    [AttributeUsage(AttributeTargets.Function | AttributeTargets.Class)]
    public class UseMethodAttribute : Attribute
    {
        public UseMethodAttribute(string expr);
        public string Expression { get; }
    }
}
```

## `NativeApi`
```cs
namespace Silk.NET.Core
{
    public class NativeApiAttribute : Attribute
    {
        public string EntryPoint { get; set; }
        public CallModifiers Modifiers { get; set; }
    }
}
```

## `CallModifiers`
```cs
namespace Silk.NET.Core
{
    [Flags]
    public enum CallModifiers
    {
        None = 0,
        MemberFunction = 1 << 0,
        SuppressGCTransition = 1 << 1,
        WinapiConvention = 1 << 2,
        CdeclConvention = 1 << 3,
        StdcallConvention = 1 << 4,
        FastcallConvention = 1 << 5,
        ThiscallConvention = 1 << 6
    }
}
```

## `StringOverloads`
```cs
namespace Silk.NET.Core { public class StringOverloadsAttribute : Attribute { } }
```

## `StringListOverloads`
```cs
namespace Silk.NET.Core { public class StringListOverloadsAttribute : Attribute { } }
```

## `StringSpanOverloads`
```cs
namespace Silk.NET.Core { public class StringSpanOverloadsAttribute : Attribute { } }
```

## `RefOverloads`
```cs
namespace Silk.NET.Core { public class RefOverloadsAttribute : Attribute { } }
```

## `SpanOverloads`
```cs
namespace Silk.NET.Core { public class SpanOverloadsAttribute : Attribute { } }
```

## `ArrayOverloads`
```cs
namespace Silk.NET.Core { public class ArrayOverloadsAttribute : Attribute { } }
```

## `Count`
```cs
namespace Silk.NET.Core
{
    public class CountAttribute : Attribute
    {
        public CountAttribute(string expr);
        public string Expression { get; }
    }
}
```
## `UnmanagedType`
```cs
namespace Silk.NET.Core
{
    public class UnmanagedTypeAttribute : Attribute
    {
        public UnmanagedTypeAttribute(NativeStringEncoding encoding);
        public NativeStringEncoding NativeStringEncoding { get; }
    }
}
```
## `NativeStringEncoding`
```cs
namespace Silk.NET.Core
{
    public enum NativeStringEncoding
    {
        BStr = UnmanagedType.BStr,
        LPStr = UnmanagedType.LPStr,
        LPTStr = UnmanagedType.LPTStr,
        LPUTF8Str = UnmanagedType.LPUTF8Str,
        LPWStr = UnmanagedType.LPWStr,
        Ansi = LPStr,
        Auto = LPTStr,
        Uni = LPWStr,
        UTF8 = LPUTF8Str
    }
}
```
## `AlternativeType`
```cs
namespace Silk.NET.Core
{
    public class AlternativeTypeAttribute : Attribute
    {
        public AlternativeTypeAttribute(string syntax);
        public string Syntax { get; }
    }
}
```
## `ImplicitCountSpanOverloader`
```cs
namespace Silk.NET.Core
{
    public class ImplicitCountSpanOverloaderAttribute : Attribute
    {
    }
}
```
## `ImplicitCountArrayOverloader`
```cs
namespace Silk.NET.Core
{
    public class ImplicitCountArrayOverloaderAttribute : Attribute
    {
    }
}
```
