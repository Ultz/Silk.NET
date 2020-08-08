// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    public abstract unsafe partial class SDL : NativeAPI
    {

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 188, Column 38 in build/submodules/SDL-mirror/include/SDL_platform.h")]
        [NativeApi(EntryPoint = "SDL_GetPlatform")]
        public abstract unsafe byte* GetPlatform();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 361, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_malloc")]
        public abstract unsafe void* Malloc(uint size);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 362, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_calloc")]
        public abstract unsafe void* Calloc(uint nmemb, uint size);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 363, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_realloc")]
        public abstract unsafe void* Realloc(void* mem, uint size);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 363, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_realloc")]
        public abstract unsafe void* Realloc<T0>(Span<T0> mem, uint size) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 364, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_free")]
        public abstract unsafe void Free(void* mem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 364, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_free")]
        public abstract void Free<T0>(Span<T0> mem) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public abstract unsafe void GetMemoryFunctions(void** malloc_func, void** calloc_func, void** realloc_func, void** free_func);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 387, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_SetMemoryFunctions")]
        public abstract unsafe int SetMemoryFunctions(void* malloc_func, void* calloc_func, void* realloc_func, void* free_func);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 387, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_SetMemoryFunctions")]
        public abstract int SetMemoryFunctions<T0, T1, T2, T3>(Span<T0> malloc_func, Span<T1> calloc_func, Span<T2> realloc_func, Span<T3> free_func) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 395, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetNumAllocations")]
        public abstract int GetNumAllocations();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 397, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_getenv")]
        public abstract unsafe byte* Getenv(byte* name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 397, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_getenv")]
        public abstract unsafe byte* Getenv(Span<byte> name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public abstract unsafe int Setenv(byte* name, byte* value, int overwrite);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public abstract int Setenv(Span<byte> name, Span<byte> value, int overwrite);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 400, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_qsort")]
        public abstract unsafe void Qsort(void* @base, uint nmemb, uint size, void* compare);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 400, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_qsort")]
        public abstract void Qsort<T0, T1>(Span<T0> @base, uint nmemb, uint size, Span<T1> compare) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 402, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_abs")]
        public abstract int Abs(int x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 409, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isdigit")]
        public abstract int Isdigit(int x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 410, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isspace")]
        public abstract int Isspace(int x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 411, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isupper")]
        public abstract int Isupper(int x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_islower")]
        public abstract int Islower(int x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 413, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_toupper")]
        public abstract int Toupper(int x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 414, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_tolower")]
        public abstract int Tolower(int x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 416, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memset")]
        public abstract unsafe void* Memset(void* dst, int c, uint len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 416, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memset")]
        public abstract unsafe void* Memset<T0>(Span<T0> dst, int c, uint len) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 453, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcpy")]
        public abstract unsafe void* Memcpy(void* dst, void* src, uint len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 453, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcpy")]
        public abstract unsafe void* Memcpy<T0, T1>(Span<T0> dst, Span<T1> src, uint len) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 455, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memmove")]
        public abstract unsafe void* Memmove(void* dst, void* src, uint len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 455, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memmove")]
        public abstract unsafe void* Memmove<T0, T1>(Span<T0> dst, Span<T1> src, uint len) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 456, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcmp")]
        public abstract unsafe int Memcmp(void* s1, void* s2, uint len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 456, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcmp")]
        public abstract int Memcmp<T0, T1>(Span<T0> s1, Span<T1> s2, uint len) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 458, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslen")]
        public abstract unsafe uint Wcslen(char* wstr);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 458, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslen")]
        public abstract uint Wcslen(Span<char> wstr);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public abstract unsafe uint Wcslcpy(char* dst, char* src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public abstract uint Wcslcpy(Span<char> dst, Span<char> src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public abstract unsafe uint Wcslcat(char* dst, char* src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public abstract uint Wcslcat(Span<char> dst, Span<char> src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 461, Column 34 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsdup")]
        public abstract unsafe char* Wcsdup(char* wstr);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 461, Column 34 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsdup")]
        public abstract unsafe char* Wcsdup(Span<char> wstr);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public abstract unsafe char* Wcsstr(char* haystack, char* needle);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public abstract unsafe char* Wcsstr(Span<char> haystack, Span<char> needle);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public abstract unsafe int Wcscmp(char* str1, char* str2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public abstract int Wcscmp(Span<char> str1, Span<char> str2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public abstract unsafe int Wcsncmp(char* str1, char* str2, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public abstract int Wcsncmp(Span<char> str1, Span<char> str2, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 467, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlen")]
        public abstract unsafe uint Strlen(byte* str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 467, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlen")]
        public abstract uint Strlen(Span<byte> str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public abstract unsafe uint Strlcpy(byte* dst, byte* src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public abstract uint Strlcpy(Span<byte> dst, Span<byte> src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public abstract unsafe uint Utf8strlcpy(byte* dst, byte* src, uint dst_bytes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public abstract uint Utf8strlcpy(Span<byte> dst, Span<byte> src, uint dst_bytes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public abstract unsafe uint Strlcat(byte* dst, byte* src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public abstract uint Strlcat(Span<byte> dst, Span<byte> src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 471, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strdup")]
        public abstract unsafe byte* Strdup(byte* str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 471, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strdup")]
        public abstract unsafe byte* Strdup(Span<byte> str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 472, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrev")]
        public abstract unsafe byte* Strrev(byte* str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 472, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrev")]
        public abstract unsafe byte* Strrev(Span<byte> str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 473, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strupr")]
        public abstract unsafe byte* Strupr(byte* str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 473, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strupr")]
        public abstract unsafe byte* Strupr(Span<byte> str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 474, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlwr")]
        public abstract unsafe byte* Strlwr(byte* str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 474, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlwr")]
        public abstract unsafe byte* Strlwr(Span<byte> str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 475, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strchr")]
        public abstract unsafe byte* Strchr(byte* str, int c);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 475, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strchr")]
        public abstract unsafe byte* Strchr(Span<byte> str, int c);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 476, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrchr")]
        public abstract unsafe byte* Strrchr(byte* str, int c);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 476, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrchr")]
        public abstract unsafe byte* Strrchr(Span<byte> str, int c);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public abstract unsafe byte* Strstr(byte* haystack, byte* needle);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public abstract unsafe byte* Strstr(Span<byte> haystack, Span<byte> needle);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public abstract unsafe byte* Strtokr(byte* s1, byte* s2, byte** saveptr);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public abstract unsafe byte* Strtokr(Span<byte> s1, Span<byte> s2, byte** saveptr);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 479, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlen")]
        public abstract unsafe uint Utf8strlen(byte* str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 479, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlen")]
        public abstract uint Utf8strlen(Span<byte> str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 481, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_itoa")]
        public abstract unsafe byte* Itoa(int value, byte* str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 481, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_itoa")]
        public abstract unsafe byte* Itoa(int value, Span<byte> str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 482, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_uitoa")]
        public abstract unsafe byte* Uitoa(uint value, byte* str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 482, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_uitoa")]
        public abstract unsafe byte* Uitoa(uint value, Span<byte> str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 483, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ltoa")]
        public abstract unsafe byte* Ltoa(int value, byte* str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 483, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ltoa")]
        public abstract unsafe byte* Ltoa(int value, Span<byte> str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 484, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ultoa")]
        public abstract unsafe byte* Ultoa(uint value, byte* str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 484, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ultoa")]
        public abstract unsafe byte* Ultoa(uint value, Span<byte> str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 485, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lltoa")]
        public abstract unsafe byte* Lltoa(long value, byte* str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 485, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lltoa")]
        public abstract unsafe byte* Lltoa(long value, Span<byte> str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 486, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ulltoa")]
        public abstract unsafe byte* Ulltoa(ulong value, byte* str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 486, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ulltoa")]
        public abstract unsafe byte* Ulltoa(ulong value, Span<byte> str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 488, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atoi")]
        public abstract unsafe int Atoi(byte* str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 488, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atoi")]
        public abstract int Atoi(Span<byte> str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 489, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atof")]
        public abstract unsafe double Atof(byte* str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 489, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atof")]
        public abstract double Atof(Span<byte> str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtol")]
        public abstract unsafe int Strtol(byte* str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtol")]
        public abstract unsafe int Strtol(Span<byte> str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoul")]
        public abstract unsafe uint Strtoul(byte* str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoul")]
        public abstract unsafe uint Strtoul(Span<byte> str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoll")]
        public abstract unsafe long Strtoll(byte* str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoll")]
        public abstract unsafe long Strtoll(Span<byte> str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoull")]
        public abstract unsafe ulong Strtoull(byte* str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoull")]
        public abstract unsafe ulong Strtoull(Span<byte> str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtod")]
        public abstract unsafe double Strtod(byte* str, byte** endp);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtod")]
        public abstract unsafe double Strtod(Span<byte> str, byte** endp);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public abstract unsafe int Strcmp(byte* str1, byte* str2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public abstract int Strcmp(Span<byte> str1, Span<byte> str2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public abstract unsafe int Strncmp(byte* str1, byte* str2, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public abstract int Strncmp(Span<byte> str1, Span<byte> str2, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public abstract unsafe int Strcasecmp(byte* str1, byte* str2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public abstract int Strcasecmp(Span<byte> str1, Span<byte> str2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public abstract unsafe int Strncasecmp(byte* str1, byte* str2, uint len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public abstract int Strncasecmp(Span<byte> str1, Span<byte> str2, uint len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public abstract unsafe int Sscanf(byte* text, byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public abstract int Sscanf(Span<byte> text, Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public abstract unsafe int Vsscanf(byte* text, byte* fmt, byte* ap);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public abstract int Vsscanf(Span<byte> text, Span<byte> fmt, Span<byte> ap);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public abstract unsafe int Snprintf(byte* text, uint maxlen, byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public abstract int Snprintf(Span<byte> text, uint maxlen, Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public abstract unsafe int Vsnprintf(byte* text, uint maxlen, byte* fmt, byte* ap);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public abstract int Vsnprintf(Span<byte> text, uint maxlen, Span<byte> fmt, Span<byte> ap);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 512, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_acos")]
        public abstract double Acos(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 513, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_acosf")]
        public abstract float Acosf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 514, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_asin")]
        public abstract double Asin(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 515, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_asinf")]
        public abstract float Asinf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 516, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atan")]
        public abstract double Atan(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 517, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atanf")]
        public abstract float Atanf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 518, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atan2")]
        public abstract double Atan2(double x, double y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 519, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atan2f")]
        public abstract float Atan2f(float x, float y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 520, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ceil")]
        public abstract double Ceil(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 521, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ceilf")]
        public abstract float Ceilf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 522, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_copysign")]
        public abstract double Copysign(double x, double y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 523, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_copysignf")]
        public abstract float Copysignf(float x, float y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 524, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_cos")]
        public abstract double Cos(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 525, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_cosf")]
        public abstract float Cosf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 526, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_exp")]
        public abstract double Exp(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 527, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_expf")]
        public abstract float Expf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 528, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fabs")]
        public abstract double Fabs(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 529, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fabsf")]
        public abstract float Fabsf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 530, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_floor")]
        public abstract double Floor(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 531, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_floorf")]
        public abstract float Floorf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 532, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fmod")]
        public abstract double Fmod(double x, double y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 533, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fmodf")]
        public abstract float Fmodf(float x, float y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 534, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_log")]
        public abstract double Log(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 535, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_logf")]
        public abstract float Logf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 536, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_log10")]
        public abstract double Log10(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 537, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_log10f")]
        public abstract float Log10f(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 538, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_pow")]
        public abstract double Pow(double x, double y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 539, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_powf")]
        public abstract float Powf(float x, float y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 540, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_scalbn")]
        public abstract double Scalbn(double x, int n);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 541, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_scalbnf")]
        public abstract float Scalbnf(float x, int n);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 542, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sin")]
        public abstract double Sin(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 543, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sinf")]
        public abstract float Sinf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 544, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sqrt")]
        public abstract double Sqrt(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 545, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sqrtf")]
        public abstract float Sqrtf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 546, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_tan")]
        public abstract double Tan(double x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 547, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_tanf")]
        public abstract float Tanf(float x);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public abstract unsafe SDLIconvT* IconvOpen(byte* tocode, byte* fromcode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public abstract unsafe SDLIconvT* IconvOpen(Span<byte> tocode, Span<byte> fromcode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 559, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_close")]
        public abstract unsafe int IconvClose(SDLIconvT* cd);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 559, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_close")]
        public abstract int IconvClose(Span<SDLIconvT> cd);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public abstract unsafe uint Iconv(SDLIconvT* cd, byte** inbuf, uint* inbytesleft, byte** outbuf, uint* outbytesleft);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public abstract unsafe uint Iconv(Span<SDLIconvT> cd, byte** inbuf, Span<uint> inbytesleft, byte** outbuf, Span<uint> outbytesleft);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public abstract unsafe byte* IconvString(byte* tocode, byte* fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public abstract unsafe byte* IconvString(Span<byte> tocode, Span<byte> fromcode, Span<byte> inbuf, uint inbytesleft);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_main")]
        public abstract unsafe int Main(int argc, byte** argv);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 131, Column 30 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_SetMainReady")]
        public abstract void SetMainReady();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public abstract unsafe int RegisterApp(byte* name, uint style, void* hInst);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public abstract int RegisterApp<T0>(Span<byte> name, uint style, Span<T0> hInst) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 139, Column 30 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_UnregisterApp")]
        public abstract void UnregisterApp();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 52, Column 25 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "__debugbreak")]
        public abstract void Debugbreak();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public abstract unsafe AssertState ReportAssertion(AssertData* arg0, byte* arg1, byte* arg2, int arg3);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public abstract AssertState ReportAssertion(Span<AssertData> arg0, Span<byte> arg1, Span<byte> arg2, int arg3);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 211, Column 30 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_SetAssertionHandler")]
        public abstract unsafe void SetAssertionHandler(void* handler, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 211, Column 30 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_SetAssertionHandler")]
        public abstract void SetAssertionHandler<T0, T1>(Span<T0> handler, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 225, Column 46 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_GetDefaultAssertionHandler")]
        public abstract unsafe void* GetDefaultAssertionHandler();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 242, Column 46 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_GetAssertionHandler")]
        public abstract unsafe void* GetAssertionHandler(void** puserdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 266, Column 48 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_GetAssertionReport")]
        public abstract unsafe AssertData* GetAssertionReport();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 275, Column 30 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ResetAssertionReport")]
        public abstract void ResetAssertionReport();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 98, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicTryLock")]
        public abstract unsafe SdlBool AtomicTryLock(int* @lock);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 98, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicTryLock")]
        public abstract SdlBool AtomicTryLock(Span<int> @lock);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 105, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicLock")]
        public abstract unsafe void AtomicLock(int* @lock);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 105, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicLock")]
        public abstract void AtomicLock(Span<int> @lock);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 112, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicUnlock")]
        public abstract unsafe void AtomicUnlock(int* @lock);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 112, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicUnlock")]
        public abstract void AtomicUnlock(Span<int> @lock);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 155, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_MemoryBarrierReleaseFunction")]
        public abstract void MemoryBarrierReleaseFunction();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 156, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_MemoryBarrierAcquireFunction")]
        public abstract void MemoryBarrierAcquireFunction();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 225, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCAS")]
        public abstract unsafe SdlBool AtomicCAS(AtomicT* a, int oldval, int newval);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 225, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCAS")]
        public abstract SdlBool AtomicCAS(Span<AtomicT> a, int oldval, int newval);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 232, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSet")]
        public abstract unsafe int AtomicSet(AtomicT* a, int v);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 232, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSet")]
        public abstract int AtomicSet(Span<AtomicT> a, int v);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicGet")]
        public abstract unsafe int AtomicGet(AtomicT* a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicGet")]
        public abstract int AtomicGet(Span<AtomicT> a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 246, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicAdd")]
        public abstract unsafe int AtomicAdd(AtomicT* a, int v);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 246, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicAdd")]
        public abstract int AtomicAdd(Span<AtomicT> a, int v);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public abstract unsafe SdlBool AtomicCASPtr(void** a, void* oldval, void* newval);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public abstract unsafe SdlBool AtomicCASPtr<T0, T1, T2>(void** a, Span<T1> oldval, Span<T2> newval) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 279, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSetPtr")]
        public abstract unsafe void* AtomicSetPtr(void** a, void* v);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 279, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSetPtr")]
        public abstract unsafe void* AtomicSetPtr<T0, T1>(void** a, Span<T1> v) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 284, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicGetPtr")]
        public abstract unsafe void* AtomicGetPtr(void** a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 41, Column 29 in build/submodules/SDL-mirror/include\\SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_SetError")]
        public abstract unsafe int SetError(byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 41, Column 29 in build/submodules/SDL-mirror/include\\SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_SetError")]
        public abstract int SetError(Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 42, Column 37 in build/submodules/SDL-mirror/include\\SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_GetError")]
        public abstract unsafe byte* GetError();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 43, Column 30 in build/submodules/SDL-mirror/include\\SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_ClearError")]
        public abstract void ClearError();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 65, Column 29 in build/submodules/SDL-mirror/include\\SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_Error")]
        public abstract int Error(Errorcode code);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 64, Column 36 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CreateMutex")]
        public abstract unsafe Mutex* CreateMutex();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 72, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_LockMutex")]
        public abstract unsafe int LockMutex(Mutex* mutex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 72, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_LockMutex")]
        public abstract int LockMutex(Span<Mutex> mutex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 79, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_TryLockMutex")]
        public abstract unsafe int TryLockMutex(Mutex* mutex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 79, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_TryLockMutex")]
        public abstract int TryLockMutex(Span<Mutex> mutex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 90, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_UnlockMutex")]
        public abstract unsafe int UnlockMutex(Mutex* mutex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 90, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_UnlockMutex")]
        public abstract int UnlockMutex(Span<Mutex> mutex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 95, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroyMutex")]
        public abstract unsafe void DestroyMutex(Mutex* mutex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 95, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroyMutex")]
        public abstract void DestroyMutex(Span<Mutex> mutex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 112, Column 34 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CreateSemaphore")]
        public abstract unsafe Semaphore* CreateSemaphore(uint initial_value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 117, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroySemaphore")]
        public abstract unsafe void DestroySemaphore(Semaphore* sem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 117, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroySemaphore")]
        public abstract void DestroySemaphore(Span<Semaphore> sem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 124, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemWait")]
        public abstract unsafe int SemWait(Semaphore* sem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 124, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemWait")]
        public abstract int SemWait(Span<Semaphore> sem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 132, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemTryWait")]
        public abstract unsafe int SemTryWait(Semaphore* sem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 132, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemTryWait")]
        public abstract int SemTryWait(Span<Semaphore> sem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 143, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemWaitTimeout")]
        public abstract unsafe int SemWaitTimeout(Semaphore* sem, uint ms);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 143, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemWaitTimeout")]
        public abstract int SemWaitTimeout(Span<Semaphore> sem, uint ms);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 150, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemPost")]
        public abstract unsafe int SemPost(Semaphore* sem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 150, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemPost")]
        public abstract int SemPost(Span<Semaphore> sem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 155, Column 32 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemValue")]
        public abstract unsafe uint SemValue(Semaphore* sem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 155, Column 32 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemValue")]
        public abstract uint SemValue(Span<Semaphore> sem);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 197, Column 35 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CreateCond")]
        public abstract unsafe Cond* CreateCond();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 202, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroyCond")]
        public abstract unsafe void DestroyCond(Cond* cond);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 202, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroyCond")]
        public abstract void DestroyCond(Span<Cond> cond);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 209, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondSignal")]
        public abstract unsafe int CondSignal(Cond* cond);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 209, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondSignal")]
        public abstract int CondSignal(Span<Cond> cond);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondBroadcast")]
        public abstract unsafe int CondBroadcast(Cond* cond);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondBroadcast")]
        public abstract int CondBroadcast(Span<Cond> cond);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 227, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWait")]
        public abstract unsafe int CondWait(Cond* cond, Mutex* mutex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 227, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWait")]
        public abstract int CondWait(Span<Cond> cond, Span<Mutex> mutex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWaitTimeout")]
        public abstract unsafe int CondWaitTimeout(Cond* cond, Mutex* mutex, uint ms);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWaitTimeout")]
        public abstract int CondWaitTimeout(Span<Cond> cond, Span<Mutex> mutex, uint ms);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public abstract unsafe Thread* CreateThread(void* fn, byte* name, void* data, void* pfnBeginThread, void* pfnEndThread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public abstract unsafe Thread* CreateThread<T0, T1, T2, T3>(Span<T0> fn, Span<byte> name, Span<T1> data, Span<T2> pfnBeginThread, Span<T3> pfnEndThread) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public abstract unsafe Thread* CreateThreadWithStackSize(void* fn, byte* name, uint stacksize, void* data, void* pfnBeginThread, void* pfnEndThread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public abstract unsafe Thread* CreateThreadWithStackSize<T0, T1, T2, T3>(Span<T0> fn, Span<byte> name, uint stacksize, Span<T1> data, Span<T2> pfnBeginThread, Span<T3> pfnEndThread) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 227, Column 37 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadName")]
        public abstract unsafe byte* GetThreadName(Thread* thread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 227, Column 37 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadName")]
        public abstract unsafe byte* GetThreadName(Span<Thread> thread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 232, Column 38 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_ThreadID")]
        public abstract uint ThreadID();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 239, Column 38 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadID")]
        public abstract unsafe uint GetThreadID(Thread* thread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 239, Column 38 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadID")]
        public abstract uint GetThreadID(Span<Thread> thread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 244, Column 29 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_SetThreadPriority")]
        public abstract int SetThreadPriority(ThreadPriority priority);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_WaitThread")]
        public abstract unsafe void WaitThread(Thread* thread, int* status);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_WaitThread")]
        public abstract void WaitThread(Span<Thread> thread, Span<int> status);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 292, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_DetachThread")]
        public abstract unsafe void DetachThread(Thread* thread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 292, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_DetachThread")]
        public abstract void DetachThread(Span<Thread> thread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 324, Column 35 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSCreate")]
        public abstract uint TLSCreate();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 336, Column 32 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSGet")]
        public abstract unsafe void* TLSGet(uint id);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 350, Column 29 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSSet")]
        public abstract unsafe int TLSSet(uint id, void* value, void* destructor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 350, Column 29 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSSet")]
        public abstract int TLSSet<T0, T1>(uint id, Span<T0> value, Span<T1> destructor) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 153, Column 36 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWFromFile")]
        public abstract unsafe RWops* RWFromFile(byte* file, byte* mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 153, Column 36 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWFromFile")]
        public abstract unsafe RWops* RWFromFile(Span<byte> file, Span<byte> mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 160, Column 36 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWFromFP")]
        public abstract unsafe RWops* RWFromFP(void* fp, SdlBool autoclose);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 160, Column 36 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWFromFP")]
        public abstract unsafe RWops* RWFromFP<T0>(Span<T0> fp, SdlBool autoclose) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 164, Column 36 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWFromMem")]
        public abstract unsafe RWops* RWFromMem(void* mem, int size);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 164, Column 36 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWFromMem")]
        public abstract unsafe RWops* RWFromMem<T0>(Span<T0> mem, int size) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 165, Column 36 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWFromConstMem")]
        public abstract unsafe RWops* RWFromConstMem(void* mem, int size);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 165, Column 36 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWFromConstMem")]
        public abstract unsafe RWops* RWFromConstMem<T0>(Span<T0> mem, int size) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 171, Column 36 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_AllocRW")]
        public abstract unsafe RWops* AllocRW();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 172, Column 30 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_FreeRW")]
        public abstract unsafe void FreeRW(RWops* area);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 172, Column 30 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_FreeRW")]
        public abstract void FreeRW(Span<RWops> area);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 181, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWsize")]
        public abstract unsafe long RWsize(RWops* context);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 181, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWsize")]
        public abstract long RWsize(Span<RWops> context);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 189, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWseek")]
        public abstract unsafe long RWseek(RWops* context, long offset, int whence);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 189, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWseek")]
        public abstract long RWseek(Span<RWops> context, long offset, int whence);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 195, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWtell")]
        public abstract unsafe long RWtell(RWops* context);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 195, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWtell")]
        public abstract long RWtell(Span<RWops> context);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 203, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWread")]
        public abstract unsafe uint RWread(RWops* context, void* ptr, uint size, uint maxnum);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 203, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWread")]
        public abstract uint RWread<T0>(Span<RWops> context, Span<T0> ptr, uint size, uint maxnum) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 212, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWwrite")]
        public abstract unsafe uint RWwrite(RWops* context, void* ptr, uint size, uint num);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 212, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWwrite")]
        public abstract uint RWwrite<T0>(Span<RWops> context, Span<T0> ptr, uint size, uint num) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 220, Column 29 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWclose")]
        public abstract unsafe int RWclose(RWops* context);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 220, Column 29 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWclose")]
        public abstract int RWclose(Span<RWops> context);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 235, Column 31 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_LoadFile_RW")]
        public abstract unsafe void* LoadFileRW(RWops* src, uint* datasize, int freesrc);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 235, Column 31 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_LoadFile_RW")]
        public abstract unsafe void* LoadFileRW(Span<RWops> src, Span<uint> datasize, int freesrc);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 251, Column 31 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_LoadFile")]
        public abstract unsafe void* LoadFile(byte* file, uint* datasize);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 251, Column 31 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_LoadFile")]
        public abstract unsafe void* LoadFile(Span<byte> file, Span<uint> datasize);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 259, Column 31 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadU8")]
        public abstract unsafe byte ReadU8(RWops* src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 259, Column 31 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadU8")]
        public abstract byte ReadU8(Span<RWops> src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 260, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadLE16")]
        public abstract unsafe ushort ReadLE16(RWops* src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 260, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadLE16")]
        public abstract ushort ReadLE16(Span<RWops> src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 261, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadBE16")]
        public abstract unsafe ushort ReadBE16(RWops* src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 261, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadBE16")]
        public abstract ushort ReadBE16(Span<RWops> src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 262, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadLE32")]
        public abstract unsafe uint ReadLE32(RWops* src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 262, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadLE32")]
        public abstract uint ReadLE32(Span<RWops> src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 263, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadBE32")]
        public abstract unsafe uint ReadBE32(RWops* src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 263, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadBE32")]
        public abstract uint ReadBE32(Span<RWops> src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 264, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadLE64")]
        public abstract unsafe ulong ReadLE64(RWops* src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 264, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadLE64")]
        public abstract ulong ReadLE64(Span<RWops> src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 265, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadBE64")]
        public abstract unsafe ulong ReadBE64(RWops* src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 265, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_ReadBE64")]
        public abstract ulong ReadBE64(Span<RWops> src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 274, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteU8")]
        public abstract unsafe uint WriteU8(RWops* dst, byte value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 274, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteU8")]
        public abstract uint WriteU8(Span<RWops> dst, byte value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 275, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteLE16")]
        public abstract unsafe uint WriteLE16(RWops* dst, ushort value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 275, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteLE16")]
        public abstract uint WriteLE16(Span<RWops> dst, ushort value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 276, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteBE16")]
        public abstract unsafe uint WriteBE16(RWops* dst, ushort value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 276, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteBE16")]
        public abstract uint WriteBE16(Span<RWops> dst, ushort value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 277, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteLE32")]
        public abstract unsafe uint WriteLE32(RWops* dst, uint value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 277, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteLE32")]
        public abstract uint WriteLE32(Span<RWops> dst, uint value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 278, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteBE32")]
        public abstract unsafe uint WriteBE32(RWops* dst, uint value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 278, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteBE32")]
        public abstract uint WriteBE32(Span<RWops> dst, uint value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 279, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteLE64")]
        public abstract unsafe uint WriteLE64(RWops* dst, ulong value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 279, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteLE64")]
        public abstract uint WriteLE64(Span<RWops> dst, ulong value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 280, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteBE64")]
        public abstract unsafe uint WriteBE64(RWops* dst, ulong value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 280, Column 32 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_WriteBE64")]
        public abstract uint WriteBE64(Span<RWops> dst, ulong value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 251, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetNumAudioDrivers")]
        public abstract int GetNumAudioDrivers();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 252, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDriver")]
        public abstract unsafe byte* GetAudioDriver(int index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 263, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioInit")]
        public abstract unsafe int AudioInit(byte* driver_name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 263, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioInit")]
        public abstract int AudioInit(Span<byte> driver_name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioQuit")]
        public abstract void AudioQuit();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 271, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentAudioDriver")]
        public abstract unsafe byte* GetCurrentAudioDriver();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudio")]
        public abstract unsafe int OpenAudio(AudioSpec* desired, AudioSpec* obtained);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudio")]
        public abstract int OpenAudio(Span<AudioSpec> desired, Span<AudioSpec> obtained);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 344, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetNumAudioDevices")]
        public abstract int GetNumAudioDevices(int iscapture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 359, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDeviceName")]
        public abstract unsafe byte* GetAudioDeviceName(int index, int iscapture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public abstract unsafe uint OpenAudioDevice(byte* device, int iscapture, AudioSpec* desired, AudioSpec* obtained, int allowed_changes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public abstract uint OpenAudioDevice(Span<byte> device, int iscapture, Span<AudioSpec> desired, Span<AudioSpec> obtained, int allowed_changes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 401, Column 41 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioStatus")]
        public abstract AudioStatus GetAudioStatus();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 404, Column 1 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDeviceStatus")]
        public abstract AudioStatus GetAudioDeviceStatus(uint dev);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 417, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_PauseAudio")]
        public abstract void PauseAudio(int pause_on);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 418, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_PauseAudioDevice")]
        public abstract void PauseAudioDevice(uint dev, int pause_on);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public abstract unsafe AudioSpec* LoadWAVRW(RWops* src, int freesrc, AudioSpec* spec, byte** audio_buf, uint* audio_len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public abstract unsafe AudioSpec* LoadWAVRW(Span<RWops> src, int freesrc, Span<AudioSpec> spec, byte** audio_buf, Span<uint> audio_len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeWAV")]
        public abstract unsafe void FreeWAV(byte* audio_buf);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeWAV")]
        public abstract void FreeWAV(Span<byte> audio_buf);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_BuildAudioCVT")]
        public abstract unsafe int BuildAudioCVT(AudioCVT* cvt, ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_BuildAudioCVT")]
        public abstract int BuildAudioCVT(Span<AudioCVT> cvt, ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 521, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_ConvertAudio")]
        public abstract unsafe int ConvertAudio(AudioCVT* cvt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 521, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_ConvertAudio")]
        public abstract int ConvertAudio(Span<AudioCVT> cvt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 552, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_NewAudioStream")]
        public abstract unsafe SDLAudioStream* NewAudioStream(ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 574, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamPut")]
        public abstract unsafe int AudioStreamPut(SDLAudioStream* stream, void* buf, int len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 574, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamPut")]
        public abstract int AudioStreamPut<T0>(Span<SDLAudioStream> stream, Span<T0> buf, int len) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 591, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamGet")]
        public abstract unsafe int AudioStreamGet(SDLAudioStream* stream, void* buf, int len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 591, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamGet")]
        public abstract int AudioStreamGet<T0>(Span<SDLAudioStream> stream, Span<T0> buf, int len) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamAvailable")]
        public abstract unsafe int AudioStreamAvailable(SDLAudioStream* stream);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamAvailable")]
        public abstract int AudioStreamAvailable(Span<SDLAudioStream> stream);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 623, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamFlush")]
        public abstract unsafe int AudioStreamFlush(SDLAudioStream* stream);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 623, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamFlush")]
        public abstract int AudioStreamFlush(Span<SDLAudioStream> stream);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 635, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamClear")]
        public abstract unsafe void AudioStreamClear(SDLAudioStream* stream);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 635, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamClear")]
        public abstract void AudioStreamClear(Span<SDLAudioStream> stream);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 647, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeAudioStream")]
        public abstract unsafe void FreeAudioStream(SDLAudioStream* stream);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 647, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeAudioStream")]
        public abstract void FreeAudioStream(Span<SDLAudioStream> stream);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public abstract unsafe void MixAudio(byte* dst, byte* src, uint len, int volume);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public abstract void MixAudio(Span<byte> dst, Span<byte> src, uint len, int volume);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public abstract unsafe void MixAudioFormat(byte* dst, byte* src, ushort format, uint len, int volume);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public abstract void MixAudioFormat(Span<byte> dst, Span<byte> src, ushort format, uint len, int volume);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 709, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_QueueAudio")]
        public abstract unsafe int QueueAudio(uint dev, void* data, uint len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 709, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_QueueAudio")]
        public abstract int QueueAudio<T0>(uint dev, Span<T0> data, uint len) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 755, Column 32 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_DequeueAudio")]
        public abstract unsafe uint DequeueAudio(uint dev, void* data, uint len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 755, Column 32 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_DequeueAudio")]
        public abstract uint DequeueAudio<T0>(uint dev, Span<T0> data, uint len) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 791, Column 32 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetQueuedAudioSize")]
        public abstract uint GetQueuedAudioSize(uint dev);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 827, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_ClearQueuedAudio")]
        public abstract void ClearQueuedAudio(uint dev);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 839, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LockAudio")]
        public abstract void LockAudio();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 840, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LockAudioDevice")]
        public abstract void LockAudioDevice(uint dev);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 841, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_UnlockAudio")]
        public abstract void UnlockAudio();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 842, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_UnlockAudioDevice")]
        public abstract void UnlockAudioDevice(uint dev);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 848, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_CloseAudio")]
        public abstract void CloseAudio();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 849, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_CloseAudioDevice")]
        public abstract void CloseAudioDevice(uint dev);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 46, Column 29 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_SetClipboardText")]
        public abstract unsafe int SetClipboardText(byte* text);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 46, Column 29 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_SetClipboardText")]
        public abstract int SetClipboardText(Span<byte> text);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 53, Column 32 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_GetClipboardText")]
        public abstract unsafe byte* GetClipboardText();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 60, Column 34 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_HasClipboardText")]
        public abstract SdlBool HasClipboardText();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 119, Column 29 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_GetCPUCount")]
        public abstract int GetCPUCount();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 127, Column 29 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_GetCPUCacheLineSize")]
        public abstract int GetCPUCacheLineSize();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 132, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasRDTSC")]
        public abstract SdlBool HasRDTSC();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 137, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAltiVec")]
        public abstract SdlBool HasAltiVec();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 142, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasMMX")]
        public abstract SdlBool HasMMX();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 147, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_Has3DNow")]
        public abstract SdlBool Has3DNow();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 152, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE")]
        public abstract SdlBool HasSSE();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 157, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE2")]
        public abstract SdlBool HasSSE2();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 162, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE3")]
        public abstract SdlBool HasSSE3();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 167, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE41")]
        public abstract SdlBool HasSSE41();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 172, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE42")]
        public abstract SdlBool HasSSE42();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 177, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAVX")]
        public abstract SdlBool HasAVX();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 182, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAVX2")]
        public abstract SdlBool HasAVX2();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 187, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAVX512F")]
        public abstract SdlBool HasAVX512F();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 192, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasARMSIMD")]
        public abstract SdlBool HasARMSIMD();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 197, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasNEON")]
        public abstract SdlBool HasNEON();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 202, Column 29 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_GetSystemRAM")]
        public abstract int GetSystemRAM();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 216, Column 32 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDGetAlignment")]
        public abstract uint SIMDGetAlignment();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 251, Column 32 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDAlloc")]
        public abstract unsafe void* SIMDAlloc(uint len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDFree")]
        public abstract unsafe void SIMDFree(void* ptr);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDFree")]
        public abstract void SIMDFree<T0>(Span<T0> ptr) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 344, Column 37 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetPixelFormatName")]
        public abstract unsafe byte* GetPixelFormatName(uint format);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public abstract unsafe SdlBool PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, uint* Gmask, uint* Bmask, uint* Amask);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public abstract SdlBool PixelFormatEnumToMasks(uint format, Span<int> bpp, Span<uint> Rmask, Span<uint> Gmask, Span<uint> Bmask, Span<uint> Amask);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 368, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MasksToPixelFormatEnum")]
        public abstract uint MasksToPixelFormatEnum(int bpp, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 377, Column 43 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_AllocFormat")]
        public abstract unsafe PixelFormat* AllocFormat(uint pixel_format);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 382, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_FreeFormat")]
        public abstract unsafe void FreeFormat(PixelFormat* format);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 382, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_FreeFormat")]
        public abstract void FreeFormat(Span<PixelFormat> format);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 394, Column 38 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_AllocPalette")]
        public abstract unsafe Palette* AllocPalette(int ncolors);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 399, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPixelFormatPalette")]
        public abstract unsafe int SetPixelFormatPalette(PixelFormat* format, Palette* palette);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 399, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPixelFormatPalette")]
        public abstract int SetPixelFormatPalette(Span<PixelFormat> format, Span<Palette> palette);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPaletteColors")]
        public abstract unsafe int SetPaletteColors(Palette* palette, Color* colors, int firstcolor, int ncolors);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPaletteColors")]
        public abstract int SetPaletteColors(Span<Palette> palette, Span<Color> colors, int firstcolor, int ncolors);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 421, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_FreePalette")]
        public abstract unsafe void FreePalette(Palette* palette);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 421, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_FreePalette")]
        public abstract void FreePalette(Span<Palette> palette);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 428, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MapRGB")]
        public abstract unsafe uint MapRGB(PixelFormat* format, byte r, byte g, byte b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 428, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MapRGB")]
        public abstract uint MapRGB(Span<PixelFormat> format, byte r, byte g, byte b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 436, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MapRGBA")]
        public abstract unsafe uint MapRGBA(PixelFormat* format, byte r, byte g, byte b, byte a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 436, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MapRGBA")]
        public abstract uint MapRGBA(Span<PixelFormat> format, byte r, byte g, byte b, byte a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public abstract unsafe void GetRGB(uint pixel, PixelFormat* format, byte* r, byte* g, byte* b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public abstract void GetRGB(uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, Span<byte> b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public abstract unsafe void GetRGBA(uint pixel, PixelFormat* format, byte* r, byte* g, byte* b, byte* a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public abstract void GetRGBA(uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, Span<byte> b, Span<byte> a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 462, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_CalculateGammaRamp")]
        public abstract unsafe void CalculateGammaRamp(float gamma, ushort* ramp);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 462, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_CalculateGammaRamp")]
        public abstract void CalculateGammaRamp(float gamma, Span<ushort> ramp);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 127, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_HasIntersection")]
        public abstract unsafe SdlBool HasIntersection(Rect* A, Rect* B);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 127, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_HasIntersection")]
        public abstract SdlBool HasIntersection(Span<Rect> A, Span<Rect> B);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public abstract unsafe SdlBool IntersectRect(Rect* A, Rect* B, Rect* result);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public abstract SdlBool IntersectRect(Span<Rect> A, Span<Rect> B, Span<Rect> result);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public abstract unsafe void UnionRect(Rect* A, Rect* B, Rect* result);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public abstract void UnionRect(Span<Rect> A, Span<Rect> B, Span<Rect> result);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public abstract unsafe SdlBool EnclosePoints(Point* points, int count, Rect* clip, Rect* result);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public abstract SdlBool EnclosePoints(Span<Point> points, int count, Span<Rect> clip, Span<Rect> result);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public abstract unsafe SdlBool IntersectRectAndLine(Rect* rect, int* X1, int* Y1, int* X2, int* Y2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public abstract SdlBool IntersectRectAndLine(Span<Rect> rect, Span<int> X1, Span<int> Y1, Span<int> X2, Span<int> Y2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 108, Column 39 in build/submodules/SDL-mirror/include/SDL_blendmode.h")]
        [NativeApi(EntryPoint = "SDL_ComposeCustomBlendMode")]
        public abstract BlendMode ComposeCustomBlendMode(BlendFactor srcColorFactor, BlendFactor dstColorFactor, BlendOperation colorOperation, BlendFactor srcAlphaFactor, BlendFactor dstAlphaFactor, BlendOperation alphaOperation);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 130, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurface")]
        public abstract unsafe Surface* CreateRGBSurface(uint flags, int width, int height, int depth, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 135, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceWithFormat")]
        public abstract unsafe Surface* CreateRGBSurfaceWithFormat(uint flags, int width, int height, int depth, uint format);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 138, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceFrom")]
        public abstract unsafe Surface* CreateRGBSurfaceFrom(void* pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 138, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceFrom")]
        public abstract unsafe Surface* CreateRGBSurfaceFrom<T0>(Span<T0> pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 147, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceWithFormatFrom")]
        public abstract unsafe Surface* CreateRGBSurfaceWithFormatFrom(void* pixels, int width, int height, int depth, int pitch, uint format);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 147, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceWithFormatFrom")]
        public abstract unsafe Surface* CreateRGBSurfaceWithFormatFrom<T0>(Span<T0> pixels, int width, int height, int depth, int pitch, uint format) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 149, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FreeSurface")]
        public abstract unsafe void FreeSurface(Surface* surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 149, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FreeSurface")]
        public abstract void FreeSurface(Span<Surface> surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 158, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfacePalette")]
        public abstract unsafe int SetSurfacePalette(Surface* surface, Palette* palette);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 158, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfacePalette")]
        public abstract int SetSurfacePalette(Span<Surface> surface, Span<Palette> palette);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 180, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LockSurface")]
        public abstract unsafe int LockSurface(Surface* surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 180, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LockSurface")]
        public abstract int LockSurface(Span<Surface> surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UnlockSurface")]
        public abstract unsafe void UnlockSurface(Surface* surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UnlockSurface")]
        public abstract void UnlockSurface(Span<Surface> surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 193, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LoadBMP_RW")]
        public abstract unsafe Surface* LoadBMPRW(RWops* src, int freesrc);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 193, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LoadBMP_RW")]
        public abstract unsafe Surface* LoadBMPRW(Span<RWops> src, int freesrc);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SaveBMP_RW")]
        public abstract unsafe int SaveBMPRW(Surface* surface, RWops* dst, int freedst);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SaveBMP_RW")]
        public abstract int SaveBMPRW(Span<Surface> surface, Span<RWops> dst, int freedst);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 235, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceRLE")]
        public abstract unsafe int SetSurfaceRLE(Surface* surface, int flag);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 235, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceRLE")]
        public abstract int SetSurfaceRLE(Span<Surface> surface, int flag);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 249, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetColorKey")]
        public abstract unsafe int SetColorKey(Surface* surface, int flag, uint key);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 249, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetColorKey")]
        public abstract int SetColorKey(Span<Surface> surface, int flag, uint key);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 257, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_HasColorKey")]
        public abstract unsafe SdlBool HasColorKey(Surface* surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 257, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_HasColorKey")]
        public abstract SdlBool HasColorKey(Span<Surface> surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 269, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetColorKey")]
        public abstract unsafe int GetColorKey(Surface* surface, uint* key);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 269, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetColorKey")]
        public abstract int GetColorKey(Span<Surface> surface, Span<uint> key);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 284, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceColorMod")]
        public abstract unsafe int SetSurfaceColorMod(Surface* surface, byte r, byte g, byte b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 284, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceColorMod")]
        public abstract int SetSurfaceColorMod(Span<Surface> surface, byte r, byte g, byte b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public abstract unsafe int GetSurfaceColorMod(Surface* surface, byte* r, byte* g, byte* b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public abstract int GetSurfaceColorMod(Span<Surface> surface, Span<byte> r, Span<byte> g, Span<byte> b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 314, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceAlphaMod")]
        public abstract unsafe int SetSurfaceAlphaMod(Surface* surface, byte alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 314, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceAlphaMod")]
        public abstract int SetSurfaceAlphaMod(Span<Surface> surface, byte alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public abstract unsafe int GetSurfaceAlphaMod(Surface* surface, byte* alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public abstract int GetSurfaceAlphaMod(Span<Surface> surface, Span<byte> alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 340, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceBlendMode")]
        public abstract unsafe int SetSurfaceBlendMode(Surface* surface, BlendMode blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 340, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceBlendMode")]
        public abstract int SetSurfaceBlendMode(Span<Surface> surface, BlendMode blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceBlendMode")]
        public abstract unsafe int GetSurfaceBlendMode(Surface* surface, BlendMode* blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceBlendMode")]
        public abstract int GetSurfaceBlendMode(Span<Surface> surface, Span<BlendMode> blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 369, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetClipRect")]
        public abstract unsafe SdlBool SetClipRect(Surface* surface, Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 369, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetClipRect")]
        public abstract SdlBool SetClipRect(Span<Surface> surface, Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 378, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetClipRect")]
        public abstract unsafe void GetClipRect(Surface* surface, Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 378, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetClipRect")]
        public abstract void GetClipRect(Span<Surface> surface, Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 384, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_DuplicateSurface")]
        public abstract unsafe Surface* DuplicateSurface(Surface* surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 384, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_DuplicateSurface")]
        public abstract unsafe Surface* DuplicateSurface(Span<Surface> surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 396, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurface")]
        public abstract unsafe Surface* ConvertSurface(Surface* src, PixelFormat* fmt, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 396, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurface")]
        public abstract unsafe Surface* ConvertSurface(Span<Surface> src, Span<PixelFormat> fmt, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 398, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurfaceFormat")]
        public abstract unsafe Surface* ConvertSurfaceFormat(Surface* src, uint pixel_format, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 398, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurfaceFormat")]
        public abstract unsafe Surface* ConvertSurfaceFormat(Span<Surface> src, uint pixel_format, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 406, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertPixels")]
        public abstract unsafe int ConvertPixels(int width, int height, uint src_format, void* src, int src_pitch, uint dst_format, void* dst, int dst_pitch);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 406, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertPixels")]
        public abstract int ConvertPixels<T0, T1>(int width, int height, uint src_format, Span<T0> src, int src_pitch, uint dst_format, Span<T1> dst, int dst_pitch) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 422, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRect")]
        public abstract unsafe int FillRect(Surface* dst, Rect* rect, uint color);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 422, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRect")]
        public abstract int FillRect(Span<Surface> dst, Span<Rect> rect, uint color);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRects")]
        public abstract unsafe int FillRects(Surface* dst, Rect* rects, int count, uint color);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRects")]
        public abstract int FillRects(Span<Surface> dst, Span<Rect> rects, int count, uint color);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public abstract unsafe int UpperBlit(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public abstract int UpperBlit(Span<Surface> src, Span<Rect> srcrect, Span<Surface> dst, Span<Rect> dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public abstract unsafe int LowerBlit(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public abstract int LowerBlit(Span<Surface> src, Span<Rect> srcrect, Span<Surface> dst, Span<Rect> dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public abstract unsafe int SoftStretch(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public abstract int SoftStretch(Span<Surface> src, Span<Rect> srcrect, Span<Surface> dst, Span<Rect> dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public abstract unsafe int UpperBlitScaled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public abstract int UpperBlitScaled(Span<Surface> src, Span<Rect> srcrect, Span<Surface> dst, Span<Rect> dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public abstract unsafe int LowerBlitScaled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public abstract int LowerBlitScaled(Span<Surface> src, Span<Rect> srcrect, Span<Surface> dst, Span<Rect> dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 534, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetYUVConversionMode")]
        public abstract void SetYUVConversionMode(YUVCONVERSIONMODE mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 539, Column 49 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetYUVConversionMode")]
        public abstract YUVCONVERSIONMODE GetYUVConversionMode();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 544, Column 49 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetYUVConversionModeForResolution")]
        public abstract YUVCONVERSIONMODE GetYUVConversionModeForResolution(int width, int height);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 262, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetNumVideoDrivers")]
        public abstract int GetNumVideoDrivers();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 272, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetVideoDriver")]
        public abstract unsafe byte* GetVideoDriver(int index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 288, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_VideoInit")]
        public abstract unsafe int VideoInit(byte* driver_name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 288, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_VideoInit")]
        public abstract int VideoInit(Span<byte> driver_name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 297, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_VideoQuit")]
        public abstract void VideoQuit();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 308, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentVideoDriver")]
        public abstract unsafe byte* GetCurrentVideoDriver();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 315, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetNumVideoDisplays")]
        public abstract int GetNumVideoDisplays();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 324, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayName")]
        public abstract unsafe byte* GetDisplayName(int displayIndex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 334, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayBounds")]
        public abstract unsafe int GetDisplayBounds(int displayIndex, Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 334, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayBounds")]
        public abstract int GetDisplayBounds(int displayIndex, Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayUsableBounds")]
        public abstract unsafe int GetDisplayUsableBounds(int displayIndex, Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayUsableBounds")]
        public abstract int GetDisplayUsableBounds(int displayIndex, Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public abstract unsafe int GetDisplayDPI(int displayIndex, float* ddpi, float* hdpi, float* vdpi);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public abstract int GetDisplayDPI(int displayIndex, Span<float> ddpi, Span<float> hdpi, Span<float> vdpi);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 374, Column 48 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayOrientation")]
        public abstract DisplayOrientation GetDisplayOrientation(int displayIndex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 381, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetNumDisplayModes")]
        public abstract int GetNumDisplayModes(int displayIndex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 394, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayMode")]
        public abstract unsafe int GetDisplayMode(int displayIndex, int modeIndex, DisplayMode* mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 394, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayMode")]
        public abstract int GetDisplayMode(int displayIndex, int modeIndex, Span<DisplayMode> mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 400, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDesktopDisplayMode")]
        public abstract unsafe int GetDesktopDisplayMode(int displayIndex, DisplayMode* mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 400, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDesktopDisplayMode")]
        public abstract int GetDesktopDisplayMode(int displayIndex, Span<DisplayMode> mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentDisplayMode")]
        public abstract unsafe int GetCurrentDisplayMode(int displayIndex, DisplayMode* mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentDisplayMode")]
        public abstract int GetCurrentDisplayMode(int displayIndex, Span<DisplayMode> mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 429, Column 43 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetClosestDisplayMode")]
        public abstract unsafe DisplayMode* GetClosestDisplayMode(int displayIndex, DisplayMode* mode, DisplayMode* closest);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 429, Column 43 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetClosestDisplayMode")]
        public abstract unsafe DisplayMode* GetClosestDisplayMode(int displayIndex, Span<DisplayMode> mode, Span<DisplayMode> closest);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 437, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayIndex")]
        public abstract unsafe int GetWindowDisplayIndex(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 437, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayIndex")]
        public abstract int GetWindowDisplayIndex(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 453, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowDisplayMode")]
        public abstract unsafe int SetWindowDisplayMode(Window* window, DisplayMode* mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 453, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowDisplayMode")]
        public abstract int SetWindowDisplayMode(Span<Window> window, Span<DisplayMode> mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayMode")]
        public abstract unsafe int GetWindowDisplayMode(Window* window, DisplayMode* mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayMode")]
        public abstract int GetWindowDisplayMode(Span<Window> window, Span<DisplayMode> mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPixelFormat")]
        public abstract unsafe uint GetWindowPixelFormat(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPixelFormat")]
        public abstract uint GetWindowPixelFormat(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 514, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindow")]
        public abstract unsafe Window* CreateWindow(byte* title, int x, int y, int w, int h, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 514, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindow")]
        public abstract unsafe Window* CreateWindow(Span<byte> title, int x, int y, int w, int h, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 527, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowFrom")]
        public abstract unsafe Window* CreateWindowFrom(void* data);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 527, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowFrom")]
        public abstract unsafe Window* CreateWindowFrom<T0>(Span<T0> data) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 532, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowID")]
        public abstract unsafe uint GetWindowID(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 532, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowID")]
        public abstract uint GetWindowID(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 537, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowFromID")]
        public abstract unsafe Window* GetWindowFromID(uint id);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 542, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowFlags")]
        public abstract unsafe uint GetWindowFlags(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 542, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowFlags")]
        public abstract uint GetWindowFlags(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public abstract unsafe void SetWindowTitle(Window* window, byte* title);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public abstract void SetWindowTitle(Span<Window> window, Span<byte> title);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowTitle")]
        public abstract unsafe byte* GetWindowTitle(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowTitle")]
        public abstract unsafe byte* GetWindowTitle(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowIcon")]
        public abstract unsafe void SetWindowIcon(Window* window, Surface* icon);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowIcon")]
        public abstract void SetWindowIcon(Span<Window> window, Span<Surface> icon);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public abstract unsafe void* SetWindowData(Window* window, byte* name, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public abstract unsafe void* SetWindowData<T0>(Span<Window> window, Span<byte> name, Span<T0> userdata) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public abstract unsafe void* GetWindowData(Window* window, byte* name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public abstract unsafe void* GetWindowData(Span<Window> window, Span<byte> name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 611, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowPosition")]
        public abstract unsafe void SetWindowPosition(Window* window, int x, int y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 611, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowPosition")]
        public abstract void SetWindowPosition(Span<Window> window, int x, int y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public abstract unsafe void GetWindowPosition(Window* window, int* x, int* y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public abstract void GetWindowPosition(Span<Window> window, Span<int> x, Span<int> y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 646, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowSize")]
        public abstract unsafe void SetWindowSize(Window* window, int w, int h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 646, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowSize")]
        public abstract void SetWindowSize(Span<Window> window, int w, int h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public abstract unsafe void GetWindowSize(Window* window, int* w, int* h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public abstract void GetWindowSize(Span<Window> window, Span<int> w, Span<int> h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public abstract unsafe int GetWindowBordersSize(Window* window, int* top, int* left, int* bottom, int* right);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public abstract int GetWindowBordersSize(Span<Window> window, Span<int> top, Span<int> left, Span<int> bottom, Span<int> right);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 700, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMinimumSize")]
        public abstract unsafe void SetWindowMinimumSize(Window* window, int min_w, int min_h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 700, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMinimumSize")]
        public abstract void SetWindowMinimumSize(Span<Window> window, int min_w, int min_h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public abstract unsafe void GetWindowMinimumSize(Window* window, int* w, int* h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public abstract void GetWindowMinimumSize(Span<Window> window, Span<int> w, Span<int> h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 729, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMaximumSize")]
        public abstract unsafe void SetWindowMaximumSize(Window* window, int max_w, int max_h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 729, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMaximumSize")]
        public abstract void SetWindowMaximumSize(Span<Window> window, int max_w, int max_h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public abstract unsafe void GetWindowMaximumSize(Window* window, int* w, int* h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public abstract void GetWindowMaximumSize(Span<Window> window, Span<int> w, Span<int> h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 759, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowBordered")]
        public abstract unsafe void SetWindowBordered(Window* window, SdlBool bordered);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 759, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowBordered")]
        public abstract void SetWindowBordered(Span<Window> window, SdlBool bordered);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 776, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowResizable")]
        public abstract unsafe void SetWindowResizable(Window* window, SdlBool resizable);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 776, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowResizable")]
        public abstract void SetWindowResizable(Span<Window> window, SdlBool resizable);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 784, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_ShowWindow")]
        public abstract unsafe void ShowWindow(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 784, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_ShowWindow")]
        public abstract void ShowWindow(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 791, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_HideWindow")]
        public abstract unsafe void HideWindow(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 791, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_HideWindow")]
        public abstract void HideWindow(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 796, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_RaiseWindow")]
        public abstract unsafe void RaiseWindow(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 796, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_RaiseWindow")]
        public abstract void RaiseWindow(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 803, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_MaximizeWindow")]
        public abstract unsafe void MaximizeWindow(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 803, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_MaximizeWindow")]
        public abstract void MaximizeWindow(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 810, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_MinimizeWindow")]
        public abstract unsafe void MinimizeWindow(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 810, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_MinimizeWindow")]
        public abstract void MinimizeWindow(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 818, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_RestoreWindow")]
        public abstract unsafe void RestoreWindow(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 818, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_RestoreWindow")]
        public abstract void RestoreWindow(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 828, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowFullscreen")]
        public abstract unsafe int SetWindowFullscreen(Window* window, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 828, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowFullscreen")]
        public abstract int SetWindowFullscreen(Span<Window> window, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 844, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSurface")]
        public abstract unsafe Surface* GetWindowSurface(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 844, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSurface")]
        public abstract unsafe Surface* GetWindowSurface(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurface")]
        public abstract unsafe int UpdateWindowSurface(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurface")]
        public abstract int UpdateWindowSurface(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 864, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        public abstract unsafe int UpdateWindowSurfaceRects(Window* window, Rect* rects, int numrects);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 864, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        public abstract int UpdateWindowSurfaceRects(Span<Window> window, Span<Rect> rects, int numrects);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 879, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGrab")]
        public abstract unsafe void SetWindowGrab(Window* window, SdlBool grabbed);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 879, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGrab")]
        public abstract void SetWindowGrab(Span<Window> window, SdlBool grabbed);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 889, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGrab")]
        public abstract unsafe SdlBool GetWindowGrab(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 889, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGrab")]
        public abstract SdlBool GetWindowGrab(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 898, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetGrabbedWindow")]
        public abstract unsafe Window* GetGrabbedWindow();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowBrightness")]
        public abstract unsafe int SetWindowBrightness(Window* window, float brightness);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowBrightness")]
        public abstract int SetWindowBrightness(Span<Window> window, float brightness);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 917, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBrightness")]
        public abstract unsafe float GetWindowBrightness(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 917, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBrightness")]
        public abstract float GetWindowBrightness(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 930, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowOpacity")]
        public abstract unsafe int SetWindowOpacity(Window* window, float opacity);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 930, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowOpacity")]
        public abstract int SetWindowOpacity(Span<Window> window, float opacity);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 945, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowOpacity")]
        public abstract unsafe int GetWindowOpacity(Window* window, float* out_opacity);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 945, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowOpacity")]
        public abstract int GetWindowOpacity(Span<Window> window, Span<float> out_opacity);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 955, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowModalFor")]
        public abstract unsafe int SetWindowModalFor(Window* modal_window, Window* parent_window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 955, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowModalFor")]
        public abstract int SetWindowModalFor(Span<Window> modal_window, Span<Window> parent_window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 969, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowInputFocus")]
        public abstract unsafe int SetWindowInputFocus(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 969, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowInputFocus")]
        public abstract int SetWindowInputFocus(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public abstract unsafe int SetWindowGammaRamp(Window* window, ushort* red, ushort* green, ushort* blue);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public abstract int SetWindowGammaRamp(Span<Window> window, Span<ushort> red, Span<ushort> green, Span<ushort> blue);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public abstract unsafe int GetWindowGammaRamp(Window* window, ushort* red, ushort* green, ushort* blue);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public abstract int GetWindowGammaRamp(Span<Window> window, Span<ushort> red, Span<ushort> green, Span<ushort> blue);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1079, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowHitTest")]
        public abstract unsafe int SetWindowHitTest(Window* window, void* callback, void* callback_data);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1079, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowHitTest")]
        public abstract int SetWindowHitTest<T0, T1>(Span<Window> window, Span<T0> callback, Span<T1> callback_data) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1086, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_DestroyWindow")]
        public abstract unsafe void DestroyWindow(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1086, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_DestroyWindow")]
        public abstract void DestroyWindow(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1095, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_IsScreenSaverEnabled")]
        public abstract SdlBool IsScreenSaverEnabled();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1103, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_EnableScreenSaver")]
        public abstract void EnableScreenSaver();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1111, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_DisableScreenSaver")]
        public abstract void DisableScreenSaver();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1137, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_LoadLibrary")]
        public abstract unsafe int GLLoadLibrary(byte* path);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1137, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_LoadLibrary")]
        public abstract int GLLoadLibrary(Span<byte> path);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1142, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetProcAddress")]
        public abstract unsafe void* GLGetProcAddress(byte* proc);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1142, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetProcAddress")]
        public abstract unsafe void* GLGetProcAddress(Span<byte> proc);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1149, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_UnloadLibrary")]
        public abstract void GLUnloadLibrary();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1155, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_ExtensionSupported")]
        public abstract unsafe SdlBool GLExtensionSupported(byte* extension);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1155, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_ExtensionSupported")]
        public abstract SdlBool GLExtensionSupported(Span<byte> extension);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1161, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_ResetAttributes")]
        public abstract void GLResetAttributes();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1168, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SetAttribute")]
        public abstract int GLSetAttribute(GLattr attr, int value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1176, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetAttribute")]
        public abstract unsafe int GLGetAttribute(GLattr attr, int* value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1176, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetAttribute")]
        public abstract int GLGetAttribute(GLattr attr, Span<int> value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1184, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_CreateContext")]
        public abstract unsafe void* GLCreateContext(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1184, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_CreateContext")]
        public abstract unsafe void* GLCreateContext(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1192, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_MakeCurrent")]
        public abstract unsafe int GLMakeCurrent(Window* window, void* context);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1192, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_MakeCurrent")]
        public abstract int GLMakeCurrent<T0>(Span<Window> window, Span<T0> context) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1198, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetCurrentWindow")]
        public abstract unsafe Window* GLGetCurrentWindow();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1203, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetCurrentContext")]
        public abstract unsafe void* GLGetCurrentContext();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public abstract unsafe void GLGetDrawableSize(Window* window, int* w, int* h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public abstract void GLGetDrawableSize(Span<Window> window, Span<int> w, Span<int> h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1236, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SetSwapInterval")]
        public abstract int GLSetSwapInterval(int interval);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1249, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetSwapInterval")]
        public abstract int GLGetSwapInterval();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1255, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SwapWindow")]
        public abstract unsafe void GLSwapWindow(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1255, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SwapWindow")]
        public abstract void GLSwapWindow(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1262, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_DeleteContext")]
        public abstract unsafe void GLDeleteContext(void* context);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1262, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_DeleteContext")]
        public abstract void GLDeleteContext<T0>(Span<T0> context) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 60, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardFocus")]
        public abstract unsafe Window* GetKeyboardFocus();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardState")]
        public abstract unsafe byte* GetKeyboardState(int* numkeys);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardState")]
        public abstract unsafe byte* GetKeyboardState(Span<int> numkeys);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 82, Column 36 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetModState")]
        public abstract Keymod GetModState();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 89, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_SetModState")]
        public abstract void SetModState(Keymod modstate);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 99, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyFromScancode")]
        public abstract int GetKeyFromScancode(Scancode scancode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 109, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeFromKey")]
        public abstract Scancode GetScancodeFromKey(int key);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 120, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeName")]
        public abstract unsafe byte* GetScancodeName(Scancode scancode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 129, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeFromName")]
        public abstract unsafe Scancode GetScancodeFromName(byte* name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 129, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeFromName")]
        public abstract Scancode GetScancodeFromName(Span<byte> name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 141, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyName")]
        public abstract unsafe byte* GetKeyName(int key);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 150, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyFromName")]
        public abstract unsafe int GetKeyFromName(byte* name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 150, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyFromName")]
        public abstract int GetKeyFromName(Span<byte> name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 160, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_StartTextInput")]
        public abstract void StartTextInput();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 168, Column 34 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_IsTextInputActive")]
        public abstract SdlBool IsTextInputActive();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 177, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_StopTextInput")]
        public abstract void StopTextInput();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 185, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_SetTextInputRect")]
        public abstract unsafe void SetTextInputRect(Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 185, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_SetTextInputRect")]
        public abstract void SetTextInputRect(Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 196, Column 34 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_HasScreenKeyboardSupport")]
        public abstract SdlBool HasScreenKeyboardSupport();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 207, Column 34 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_IsScreenKeyboardShown")]
        public abstract unsafe SdlBool IsScreenKeyboardShown(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 207, Column 34 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_IsScreenKeyboardShown")]
        public abstract SdlBool IsScreenKeyboardShown(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetMouseFocus")]
        public abstract unsafe Window* GetMouseFocus();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 87, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetMouseState")]
        public abstract unsafe uint GetMouseState(int* x, int* y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 87, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetMouseState")]
        public abstract uint GetMouseState(Span<int> x, Span<int> y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 112, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetGlobalMouseState")]
        public abstract unsafe uint GetGlobalMouseState(int* x, int* y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 112, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetGlobalMouseState")]
        public abstract uint GetGlobalMouseState(Span<int> x, Span<int> y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 121, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetRelativeMouseState")]
        public abstract unsafe uint GetRelativeMouseState(int* x, int* y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 121, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetRelativeMouseState")]
        public abstract uint GetRelativeMouseState(Span<int> x, Span<int> y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 132, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_WarpMouseInWindow")]
        public abstract unsafe void WarpMouseInWindow(Window* window, int x, int y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 132, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_WarpMouseInWindow")]
        public abstract void WarpMouseInWindow(Span<Window> window, int x, int y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 144, Column 29 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_WarpMouseGlobal")]
        public abstract int WarpMouseGlobal(int x, int y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 162, Column 29 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_SetRelativeMouseMode")]
        public abstract int SetRelativeMouseMode(SdlBool enabled);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 193, Column 29 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CaptureMouse")]
        public abstract int CaptureMouse(SdlBool enabled);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 200, Column 34 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetRelativeMouseMode")]
        public abstract SdlBool GetRelativeMouseMode();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public abstract unsafe Cursor* CreateCursor(byte* data, byte* mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public abstract unsafe Cursor* CreateCursor(Span<byte> data, Span<byte> mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 230, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateColorCursor")]
        public abstract unsafe Cursor* CreateColorCursor(Surface* surface, int hot_x, int hot_y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 230, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateColorCursor")]
        public abstract unsafe Cursor* CreateColorCursor(Span<Surface> surface, int hot_x, int hot_y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 239, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateSystemCursor")]
        public abstract unsafe Cursor* CreateSystemCursor(SystemCursor id);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 244, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_SetCursor")]
        public abstract unsafe void SetCursor(Cursor* cursor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 244, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_SetCursor")]
        public abstract void SetCursor(Span<Cursor> cursor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 249, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetCursor")]
        public abstract unsafe Cursor* GetCursor();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 254, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetDefaultCursor")]
        public abstract unsafe Cursor* GetDefaultCursor();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 263, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_FreeCursor")]
        public abstract unsafe void FreeCursor(Cursor* cursor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 263, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_FreeCursor")]
        public abstract void FreeCursor(Span<Cursor> cursor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 273, Column 29 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_ShowCursor")]
        public abstract int ShowCursor(int toggle);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 120, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_LockJoysticks")]
        public abstract void LockJoysticks();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 121, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_UnlockJoysticks")]
        public abstract void UnlockJoysticks();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 126, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_NumJoysticks")]
        public abstract int NumJoysticks();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 133, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNameForIndex")]
        public abstract unsafe byte* JoystickNameForIndex(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 139, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDevicePlayerIndex")]
        public abstract int JoystickGetDevicePlayerIndex(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 145, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceGUID")]
        public abstract JoystickGUID JoystickGetDeviceGUID(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 152, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceVendor")]
        public abstract ushort JoystickGetDeviceVendor(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 159, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceProduct")]
        public abstract ushort JoystickGetDeviceProduct(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 166, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceProductVersion")]
        public abstract ushort JoystickGetDeviceProductVersion(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 172, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceType")]
        public abstract JoystickType JoystickGetDeviceType(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 179, Column 40 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceInstanceID")]
        public abstract int JoystickGetDeviceInstanceID(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 190, Column 39 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickOpen")]
        public abstract unsafe SDLJoystick* JoystickOpen(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 195, Column 39 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickFromInstanceID")]
        public abstract unsafe SDLJoystick* JoystickFromInstanceID(int instance_id);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 200, Column 39 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickFromPlayerIndex")]
        public abstract unsafe SDLJoystick* JoystickFromPlayerIndex(int player_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 206, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickName")]
        public abstract unsafe byte* JoystickName(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 206, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickName")]
        public abstract unsafe byte* JoystickName(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 213, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetPlayerIndex")]
        public abstract unsafe int JoystickGetPlayerIndex(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 213, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetPlayerIndex")]
        public abstract int JoystickGetPlayerIndex(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 218, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickSetPlayerIndex")]
        public abstract unsafe void JoystickSetPlayerIndex(SDLJoystick* joystick, int player_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 218, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickSetPlayerIndex")]
        public abstract void JoystickSetPlayerIndex(Span<SDLJoystick> joystick, int player_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 223, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUID")]
        public abstract unsafe JoystickGUID JoystickGetGUID(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 223, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUID")]
        public abstract JoystickGUID JoystickGetGUID(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 229, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetVendor")]
        public abstract unsafe ushort JoystickGetVendor(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 229, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetVendor")]
        public abstract ushort JoystickGetVendor(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 235, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetProduct")]
        public abstract unsafe ushort JoystickGetProduct(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 235, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetProduct")]
        public abstract ushort JoystickGetProduct(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 241, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetProductVersion")]
        public abstract unsafe ushort JoystickGetProductVersion(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 241, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetProductVersion")]
        public abstract ushort JoystickGetProductVersion(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 246, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetType")]
        public abstract unsafe JoystickType JoystickGetType(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 246, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetType")]
        public abstract JoystickType JoystickGetType(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 252, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDString")]
        public abstract unsafe void JoystickGetGUIDString(JoystickGUID guid, byte* pszGUID, int cbGUID);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 252, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDString")]
        public abstract void JoystickGetGUIDString(JoystickGUID guid, Span<byte> pszGUID, int cbGUID);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 257, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDFromString")]
        public abstract unsafe JoystickGUID JoystickGetGUIDFromString(byte* pchGUID);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 257, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDFromString")]
        public abstract JoystickGUID JoystickGetGUIDFromString(Span<byte> pchGUID);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 262, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAttached")]
        public abstract unsafe SdlBool JoystickGetAttached(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 262, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAttached")]
        public abstract SdlBool JoystickGetAttached(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 267, Column 40 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickInstanceID")]
        public abstract unsafe int JoystickInstanceID(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 267, Column 40 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickInstanceID")]
        public abstract int JoystickInstanceID(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 272, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumAxes")]
        public abstract unsafe int JoystickNumAxes(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 272, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumAxes")]
        public abstract int JoystickNumAxes(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 280, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumBalls")]
        public abstract unsafe int JoystickNumBalls(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 280, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumBalls")]
        public abstract int JoystickNumBalls(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumHats")]
        public abstract unsafe int JoystickNumHats(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumHats")]
        public abstract int JoystickNumHats(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 290, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumButtons")]
        public abstract unsafe int JoystickNumButtons(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 290, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumButtons")]
        public abstract int JoystickNumButtons(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 298, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickUpdate")]
        public abstract void JoystickUpdate();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 309, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickEventState")]
        public abstract int JoystickEventState(int state);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 320, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxis")]
        public abstract unsafe short JoystickGetAxis(SDLJoystick* joystick, int axis);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 320, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxis")]
        public abstract short JoystickGetAxis(Span<SDLJoystick> joystick, int axis);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 332, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxisInitialState")]
        public abstract unsafe SdlBool JoystickGetAxisInitialState(SDLJoystick* joystick, int axis, short* state);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 332, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxisInitialState")]
        public abstract SdlBool JoystickGetAxisInitialState(Span<SDLJoystick> joystick, int axis, Span<short> state);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 366, Column 31 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetHat")]
        public abstract unsafe byte JoystickGetHat(SDLJoystick* joystick, int hat);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 366, Column 31 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetHat")]
        public abstract byte JoystickGetHat(Span<SDLJoystick> joystick, int hat);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public abstract unsafe int JoystickGetBall(SDLJoystick* joystick, int ball, int* dx, int* dy);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public abstract int JoystickGetBall(Span<SDLJoystick> joystick, int ball, Span<int> dx, Span<int> dy);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 384, Column 31 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetButton")]
        public abstract unsafe byte JoystickGetButton(SDLJoystick* joystick, int button);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 384, Column 31 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetButton")]
        public abstract byte JoystickGetButton(Span<SDLJoystick> joystick, int button);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickRumble")]
        public abstract unsafe int JoystickRumble(SDLJoystick* joystick, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickRumble")]
        public abstract int JoystickRumble(Span<SDLJoystick> joystick, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 403, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickClose")]
        public abstract unsafe void JoystickClose(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 403, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickClose")]
        public abstract void JoystickClose(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 408, Column 48 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickCurrentPowerLevel")]
        public abstract unsafe JoystickPowerLevel JoystickCurrentPowerLevel(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 408, Column 48 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickCurrentPowerLevel")]
        public abstract JoystickPowerLevel JoystickCurrentPowerLevel(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 131, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMappingsFromRW")]
        public abstract unsafe int GameControllerAddMappingsFromRW(RWops* rw, int freerw);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 131, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMappingsFromRW")]
        public abstract int GameControllerAddMappingsFromRW(Span<RWops> rw, int freerw);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 145, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMapping")]
        public abstract unsafe int GameControllerAddMapping(byte* mappingString);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 145, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMapping")]
        public abstract int GameControllerAddMapping(Span<byte> mappingString);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 152, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerNumMappings")]
        public abstract int GameControllerNumMappings();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 159, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForIndex")]
        public abstract unsafe byte* GameControllerMappingForIndex(int mapping_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 166, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForGUID")]
        public abstract unsafe byte* GameControllerMappingForGUID(JoystickGUID guid);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 173, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMapping")]
        public abstract unsafe byte* GameControllerMapping(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 173, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMapping")]
        public abstract unsafe byte* GameControllerMapping(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 178, Column 34 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_IsGameController")]
        public abstract SdlBool IsGameController(int joystick_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 185, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerNameForIndex")]
        public abstract unsafe byte* GameControllerNameForIndex(int joystick_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 191, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerTypeForIndex")]
        public abstract GameControllerType GameControllerTypeForIndex(int joystick_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 199, Column 31 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForDeviceIndex")]
        public abstract unsafe byte* GameControllerMappingForDeviceIndex(int joystick_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 210, Column 45 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerOpen")]
        public abstract unsafe SDLGameController* GameControllerOpen(int joystick_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 215, Column 45 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerFromInstanceID")]
        public abstract unsafe SDLGameController* GameControllerFromInstanceID(int joyid);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 220, Column 45 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerFromPlayerIndex")]
        public abstract unsafe SDLGameController* GameControllerFromPlayerIndex(int player_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 225, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerName")]
        public abstract unsafe byte* GameControllerName(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 225, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerName")]
        public abstract unsafe byte* GameControllerName(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 230, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetType")]
        public abstract unsafe GameControllerType GameControllerGetType(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 230, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetType")]
        public abstract GameControllerType GameControllerGetType(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetPlayerIndex")]
        public abstract unsafe int GameControllerGetPlayerIndex(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetPlayerIndex")]
        public abstract int GameControllerGetPlayerIndex(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 242, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerSetPlayerIndex")]
        public abstract unsafe void GameControllerSetPlayerIndex(SDLGameController* gamecontroller, int player_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 242, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerSetPlayerIndex")]
        public abstract void GameControllerSetPlayerIndex(Span<SDLGameController> gamecontroller, int player_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 248, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetVendor")]
        public abstract unsafe ushort GameControllerGetVendor(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 248, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetVendor")]
        public abstract ushort GameControllerGetVendor(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 254, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetProduct")]
        public abstract unsafe ushort GameControllerGetProduct(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 254, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetProduct")]
        public abstract ushort GameControllerGetProduct(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 260, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetProductVersion")]
        public abstract unsafe ushort GameControllerGetProductVersion(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 260, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetProductVersion")]
        public abstract ushort GameControllerGetProductVersion(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 266, Column 34 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAttached")]
        public abstract unsafe SdlBool GameControllerGetAttached(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 266, Column 34 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAttached")]
        public abstract SdlBool GameControllerGetAttached(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 271, Column 39 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetJoystick")]
        public abstract unsafe SDLJoystick* GameControllerGetJoystick(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 271, Column 39 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetJoystick")]
        public abstract unsafe SDLJoystick* GameControllerGetJoystick(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 282, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerEventState")]
        public abstract int GameControllerEventState(int state);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 290, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerUpdate")]
        public abstract void GameControllerUpdate();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 317, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxisFromString")]
        public abstract unsafe GameControllerAxis GameControllerGetAxisFromString(byte* pchString);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 317, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxisFromString")]
        public abstract GameControllerAxis GameControllerGetAxisFromString(Span<byte> pchString);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 322, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetStringForAxis")]
        public abstract unsafe byte* GameControllerGetStringForAxis(GameControllerAxis axis);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 328, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetBindForAxis")]
        public abstract unsafe GameControllerButtonBind GameControllerGetBindForAxis(SDLGameController* gamecontroller, GameControllerAxis axis);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 328, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetBindForAxis")]
        public abstract GameControllerButtonBind GameControllerGetBindForAxis(Span<SDLGameController> gamecontroller, GameControllerAxis axis);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 340, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxis")]
        public abstract unsafe short GameControllerGetAxis(SDLGameController* gamecontroller, GameControllerAxis axis);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 340, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxis")]
        public abstract short GameControllerGetAxis(Span<SDLGameController> gamecontroller, GameControllerAxis axis);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 370, Column 50 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButtonFromString")]
        public abstract unsafe GameControllerButton GameControllerGetButtonFromString(byte* pchString);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 370, Column 50 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButtonFromString")]
        public abstract GameControllerButton GameControllerGetButtonFromString(Span<byte> pchString);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 375, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetStringForButton")]
        public abstract unsafe byte* GameControllerGetStringForButton(GameControllerButton button);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 381, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetBindForButton")]
        public abstract unsafe GameControllerButtonBind GameControllerGetBindForButton(SDLGameController* gamecontroller, GameControllerButton button);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 381, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetBindForButton")]
        public abstract GameControllerButtonBind GameControllerGetBindForButton(Span<SDLGameController> gamecontroller, GameControllerButton button);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 390, Column 31 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButton")]
        public abstract unsafe byte GameControllerGetButton(SDLGameController* gamecontroller, GameControllerButton button);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 390, Column 31 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButton")]
        public abstract byte GameControllerGetButton(Span<SDLGameController> gamecontroller, GameControllerButton button);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 404, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerRumble")]
        public abstract unsafe int GameControllerRumble(SDLGameController* gamecontroller, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 404, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerRumble")]
        public abstract int GameControllerRumble(Span<SDLGameController> gamecontroller, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 409, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerClose")]
        public abstract unsafe void GameControllerClose(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 409, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerClose")]
        public abstract void GameControllerClose(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 72, Column 29 in build/submodules/SDL-mirror/include/SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetNumTouchDevices")]
        public abstract int GetNumTouchDevices();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 77, Column 37 in build/submodules/SDL-mirror/include/SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetTouchDevice")]
        public abstract long GetTouchDevice(int index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 82, Column 45 in build/submodules/SDL-mirror/include/SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetTouchDeviceType")]
        public abstract TouchDeviceType GetTouchDeviceType(long touchID);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 87, Column 29 in build/submodules/SDL-mirror/include/SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetNumTouchFingers")]
        public abstract int GetNumTouchFingers(long touchID);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 92, Column 38 in build/submodules/SDL-mirror/include/SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetTouchFinger")]
        public abstract unsafe Finger* GetTouchFinger(long touchID, int index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 53, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_RecordGesture")]
        public abstract int RecordGesture(long touchId);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 61, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_SaveAllDollarTemplates")]
        public abstract unsafe int SaveAllDollarTemplates(RWops* dst);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 61, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_SaveAllDollarTemplates")]
        public abstract int SaveAllDollarTemplates(Span<RWops> dst);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 68, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_SaveDollarTemplate")]
        public abstract unsafe int SaveDollarTemplate(long gestureId, RWops* dst);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 68, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_SaveDollarTemplate")]
        public abstract int SaveDollarTemplate(long gestureId, Span<RWops> dst);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 76, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_LoadDollarTemplates")]
        public abstract unsafe int LoadDollarTemplates(long touchId, RWops* src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 76, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_LoadDollarTemplates")]
        public abstract int LoadDollarTemplates(long touchId, Span<RWops> src);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 611, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PumpEvents")]
        public abstract void PumpEvents();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 639, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PeepEvents")]
        public abstract unsafe int PeepEvents(Event* events, int numevents, Eventaction action, uint minType, uint maxType);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 639, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PeepEvents")]
        public abstract int PeepEvents(Span<Event> events, int numevents, Eventaction action, uint minType, uint maxType);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 647, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_HasEvent")]
        public abstract SdlBool HasEvent(uint type);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 648, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_HasEvents")]
        public abstract SdlBool HasEvents(uint minType, uint maxType);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 656, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FlushEvent")]
        public abstract void FlushEvent(uint type);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FlushEvents")]
        public abstract void FlushEvents(uint minType, uint maxType);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 667, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PollEvent")]
        public abstract unsafe int PollEvent(Event* @event);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 667, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PollEvent")]
        public abstract int PollEvent(Span<Event> @event);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 677, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_WaitEvent")]
        public abstract unsafe int WaitEvent(Event* @event);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 677, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_WaitEvent")]
        public abstract int WaitEvent(Span<Event> @event);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 689, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_WaitEventTimeout")]
        public abstract unsafe int WaitEventTimeout(Event* @event, int timeout);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 689, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_WaitEventTimeout")]
        public abstract int WaitEventTimeout(Span<Event> @event, int timeout);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 698, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PushEvent")]
        public abstract unsafe int PushEvent(Event* @event);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 698, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PushEvent")]
        public abstract int PushEvent(Span<Event> @event);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 727, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_SetEventFilter")]
        public abstract unsafe void SetEventFilter(void* filter, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 727, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_SetEventFilter")]
        public abstract void SetEventFilter<T0, T1>(Span<T0> filter, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 734, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_GetEventFilter")]
        public abstract unsafe SdlBool GetEventFilter(void** filter, void** userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 740, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_AddEventWatch")]
        public abstract unsafe void AddEventWatch(void* filter, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 740, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_AddEventWatch")]
        public abstract void AddEventWatch<T0, T1>(Span<T0> filter, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 746, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_DelEventWatch")]
        public abstract unsafe void DelEventWatch(void* filter, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 746, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_DelEventWatch")]
        public abstract void DelEventWatch<T0, T1>(Span<T0> filter, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 753, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FilterEvents")]
        public abstract unsafe void FilterEvents(void* filter, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 753, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FilterEvents")]
        public abstract void FilterEvents<T0, T1>(Span<T0> filter, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 771, Column 31 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_EventState")]
        public abstract byte EventState(uint type, int state);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 782, Column 32 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_RegisterEvents")]
        public abstract uint RegisterEvents(int numevents);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 63, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetBasePath")]
        public abstract unsafe byte* GetBasePath();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public abstract unsafe byte* GetPrefPath(byte* org, byte* app);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public abstract unsafe byte* GetPrefPath(Span<byte> org, Span<byte> app);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 819, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_NumHaptics")]
        public abstract int NumHaptics();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 832, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticName")]
        public abstract unsafe byte* HapticName(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 856, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpen")]
        public abstract unsafe SDLHaptic* HapticOpen(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 867, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpened")]
        public abstract int HapticOpened(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 878, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticIndex")]
        public abstract unsafe int HapticIndex(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 878, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticIndex")]
        public abstract int HapticIndex(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 887, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_MouseIsHaptic")]
        public abstract int MouseIsHaptic();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 897, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpenFromMouse")]
        public abstract unsafe SDLHaptic* HapticOpenFromMouse();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_JoystickIsHaptic")]
        public abstract unsafe int JoystickIsHaptic(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_JoystickIsHaptic")]
        public abstract int JoystickIsHaptic(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 927, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpenFromJoystick")]
        public abstract unsafe SDLHaptic* HapticOpenFromJoystick(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 927, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpenFromJoystick")]
        public abstract unsafe SDLHaptic* HapticOpenFromJoystick(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 935, Column 30 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticClose")]
        public abstract unsafe void HapticClose(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 935, Column 30 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticClose")]
        public abstract void HapticClose(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 951, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumEffects")]
        public abstract unsafe int HapticNumEffects(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 951, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumEffects")]
        public abstract int HapticNumEffects(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 967, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumEffectsPlaying")]
        public abstract unsafe int HapticNumEffectsPlaying(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 967, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumEffectsPlaying")]
        public abstract int HapticNumEffectsPlaying(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 985, Column 38 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticQuery")]
        public abstract unsafe uint HapticQuery(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 985, Column 38 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticQuery")]
        public abstract uint HapticQuery(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 993, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumAxes")]
        public abstract unsafe int HapticNumAxes(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 993, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumAxes")]
        public abstract int HapticNumAxes(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1005, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticEffectSupported")]
        public abstract unsafe int HapticEffectSupported(SDLHaptic* haptic, HapticEffect* effect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1005, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticEffectSupported")]
        public abstract int HapticEffectSupported(Span<SDLHaptic> haptic, Span<HapticEffect> effect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1020, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNewEffect")]
        public abstract unsafe int HapticNewEffect(SDLHaptic* haptic, HapticEffect* effect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1020, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNewEffect")]
        public abstract int HapticNewEffect(Span<SDLHaptic> haptic, Span<HapticEffect> effect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1040, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUpdateEffect")]
        public abstract unsafe int HapticUpdateEffect(SDLHaptic* haptic, int effect, HapticEffect* data);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1040, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUpdateEffect")]
        public abstract int HapticUpdateEffect(Span<SDLHaptic> haptic, int effect, Span<HapticEffect> data);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1062, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRunEffect")]
        public abstract unsafe int HapticRunEffect(SDLHaptic* haptic, int effect, uint iterations);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1062, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRunEffect")]
        public abstract int HapticRunEffect(Span<SDLHaptic> haptic, int effect, uint iterations);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1076, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticStopEffect")]
        public abstract unsafe int HapticStopEffect(SDLHaptic* haptic, int effect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1076, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticStopEffect")]
        public abstract int HapticStopEffect(Span<SDLHaptic> haptic, int effect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1090, Column 30 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticDestroyEffect")]
        public abstract unsafe void HapticDestroyEffect(SDLHaptic* haptic, int effect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1090, Column 30 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticDestroyEffect")]
        public abstract void HapticDestroyEffect(Span<SDLHaptic> haptic, int effect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1105, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticGetEffectStatus")]
        public abstract unsafe int HapticGetEffectStatus(SDLHaptic* haptic, int effect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1105, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticGetEffectStatus")]
        public abstract int HapticGetEffectStatus(Span<SDLHaptic> haptic, int effect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1124, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticSetGain")]
        public abstract unsafe int HapticSetGain(SDLHaptic* haptic, int gain);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1124, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticSetGain")]
        public abstract int HapticSetGain(Span<SDLHaptic> haptic, int gain);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1140, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticSetAutocenter")]
        public abstract unsafe int HapticSetAutocenter(SDLHaptic* haptic, int autocenter);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1140, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticSetAutocenter")]
        public abstract int HapticSetAutocenter(Span<SDLHaptic> haptic, int autocenter);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1157, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticPause")]
        public abstract unsafe int HapticPause(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1157, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticPause")]
        public abstract int HapticPause(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1169, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUnpause")]
        public abstract unsafe int HapticUnpause(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1169, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUnpause")]
        public abstract int HapticUnpause(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1177, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticStopAll")]
        public abstract unsafe int HapticStopAll(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1177, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticStopAll")]
        public abstract int HapticStopAll(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1189, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleSupported")]
        public abstract unsafe int HapticRumbleSupported(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1189, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleSupported")]
        public abstract int HapticRumbleSupported(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1202, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleInit")]
        public abstract unsafe int HapticRumbleInit(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1202, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleInit")]
        public abstract int HapticRumbleInit(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1216, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumblePlay")]
        public abstract unsafe int HapticRumblePlay(SDLHaptic* haptic, float strength, uint length);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1216, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumblePlay")]
        public abstract int HapticRumblePlay(Span<SDLHaptic> haptic, float strength, uint length);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1228, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleStop")]
        public abstract unsafe int HapticRumbleStop(SDLHaptic* haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1228, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleStop")]
        public abstract int HapticRumbleStop(Span<SDLHaptic> haptic);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public abstract unsafe SdlBool SetHintWithPriority(byte* name, byte* value, HintPriority priority);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public abstract SdlBool SetHintWithPriority(Span<byte> name, Span<byte> value, HintPriority priority);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public abstract unsafe SdlBool SetHint(byte* name, byte* value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public abstract SdlBool SetHint(Span<byte> name, Span<byte> value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1312, Column 38 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHint")]
        public abstract unsafe byte* GetHint(byte* name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1312, Column 38 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHint")]
        public abstract unsafe byte* GetHint(Span<byte> name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1319, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHintBoolean")]
        public abstract unsafe SdlBool GetHintBoolean(byte* name, SdlBool default_value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1319, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHintBoolean")]
        public abstract SdlBool GetHintBoolean(Span<byte> name, SdlBool default_value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public abstract unsafe void AddHintCallback(byte* name, void* callback, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public abstract void AddHintCallback<T0, T1>(Span<byte> name, Span<T0> callback, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public abstract unsafe void DelHintCallback(byte* name, void* callback, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public abstract void DelHintCallback<T0, T1>(Span<byte> name, Span<T0> callback, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1353, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_ClearHints")]
        public abstract void ClearHints();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 58, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadObject")]
        public abstract unsafe void* LoadObject(byte* sofile);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 58, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadObject")]
        public abstract unsafe void* LoadObject(Span<byte> sofile);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public abstract unsafe void* LoadFunction(void* handle, byte* name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public abstract unsafe void* LoadFunction<T0>(Span<T0> handle, Span<byte> name) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 71, Column 30 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_UnloadObject")]
        public abstract unsafe void UnloadObject(void* handle);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 71, Column 30 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_UnloadObject")]
        public abstract void UnloadObject<T0>(Span<T0> handle) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 117, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetAllPriority")]
        public abstract void LogSetAllPriority(LogPriority priority);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 122, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetPriority")]
        public abstract void LogSetPriority(int category, LogPriority priority);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 128, Column 41 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogGetPriority")]
        public abstract LogPriority LogGetPriority(int category);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 135, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogResetPriorities")]
        public abstract void LogResetPriorities();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 140, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_Log")]
        public abstract unsafe void Log(byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 140, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_Log")]
        public abstract void Log(Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 145, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogVerbose")]
        public abstract unsafe void LogVerbose(int category, byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 145, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogVerbose")]
        public abstract void LogVerbose(int category, Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 150, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogDebug")]
        public abstract unsafe void LogDebug(int category, byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 150, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogDebug")]
        public abstract void LogDebug(int category, Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 155, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogInfo")]
        public abstract unsafe void LogInfo(int category, byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 155, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogInfo")]
        public abstract void LogInfo(int category, Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 160, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogWarn")]
        public abstract unsafe void LogWarn(int category, byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 160, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogWarn")]
        public abstract void LogWarn(int category, Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 165, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogError")]
        public abstract unsafe void LogError(int category, byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 165, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogError")]
        public abstract void LogError(int category, Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 170, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogCritical")]
        public abstract unsafe void LogCritical(int category, byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 170, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogCritical")]
        public abstract void LogCritical(int category, Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 175, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessage")]
        public abstract unsafe void LogMessage(int category, LogPriority priority, byte* fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 175, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessage")]
        public abstract void LogMessage(int category, LogPriority priority, Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public abstract unsafe void LogMessageV(int category, LogPriority priority, byte* fmt, byte* ap);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public abstract void LogMessageV(int category, LogPriority priority, Span<byte> fmt, Span<byte> ap);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 194, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogGetOutputFunction")]
        public abstract unsafe void LogGetOutputFunction(void** callback, void** userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 200, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetOutputFunction")]
        public abstract unsafe void LogSetOutputFunction(void* callback, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 200, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetOutputFunction")]
        public abstract void LogSetOutputFunction<T0, T1>(Span<T0> callback, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowMessageBox")]
        public abstract unsafe int ShowMessageBox(MessageBoxData* messageboxdata, int* buttonid);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowMessageBox")]
        public abstract int ShowMessageBox(Span<MessageBoxData> messageboxdata, Span<int> buttonid);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public abstract unsafe int ShowSimpleMessageBox(uint flags, byte* title, byte* message, Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public abstract int ShowSimpleMessageBox(uint flags, Span<byte> title, Span<byte> message, Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 71, Column 39 in build/submodules/SDL-mirror/include\\SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_CreateView")]
        public abstract unsafe void* MetalCreateView(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 71, Column 39 in build/submodules/SDL-mirror/include\\SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_CreateView")]
        public abstract unsafe void* MetalCreateView(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 81, Column 30 in build/submodules/SDL-mirror/include\\SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_DestroyView")]
        public abstract unsafe void MetalDestroyView(void* view);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 81, Column 30 in build/submodules/SDL-mirror/include\\SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_DestroyView")]
        public abstract void MetalDestroyView<T0>(Span<T0> view) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 65, Column 40 in build/submodules/SDL-mirror/include\\SDL_power.h")]
        [NativeApi(EntryPoint = "SDL_GetPowerInfo")]
        public abstract unsafe PowerState GetPowerInfo(int* secs, int* pct);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 65, Column 40 in build/submodules/SDL-mirror/include\\SDL_power.h")]
        [NativeApi(EntryPoint = "SDL_GetPowerInfo")]
        public abstract PowerState GetPowerInfo(Span<int> secs, Span<int> pct);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 154, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetNumRenderDrivers")]
        public abstract int GetNumRenderDrivers();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 168, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDriverInfo")]
        public abstract unsafe int GetRenderDriverInfo(int index, RendererInfo* info);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 168, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDriverInfo")]
        public abstract int GetRenderDriverInfo(int index, Span<RendererInfo> info);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 182, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowAndRenderer")]
        public abstract unsafe int CreateWindowAndRenderer(int width, int height, uint window_flags, Window** window, Renderer** renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 201, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateRenderer")]
        public abstract unsafe Renderer* CreateRenderer(Window* window, int index, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 201, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateRenderer")]
        public abstract unsafe Renderer* CreateRenderer(Span<Window> window, int index, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 214, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateSoftwareRenderer")]
        public abstract unsafe Renderer* CreateSoftwareRenderer(Surface* surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 214, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateSoftwareRenderer")]
        public abstract unsafe Renderer* CreateSoftwareRenderer(Span<Surface> surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 219, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderer")]
        public abstract unsafe Renderer* GetRenderer(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 219, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderer")]
        public abstract unsafe Renderer* GetRenderer(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererInfo")]
        public abstract unsafe int GetRendererInfo(Renderer* renderer, RendererInfo* info);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererInfo")]
        public abstract int GetRendererInfo(Span<Renderer> renderer, Span<RendererInfo> info);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public abstract unsafe int GetRendererOutputSize(Renderer* renderer, int* w, int* h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public abstract int GetRendererOutputSize(Span<Renderer> renderer, Span<int> w, Span<int> h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 252, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTexture")]
        public abstract unsafe Texture* CreateTexture(Renderer* renderer, uint format, int access, int w, int h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 252, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTexture")]
        public abstract unsafe Texture* CreateTexture(Span<Renderer> renderer, uint format, int access, int w, int h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 270, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTextureFromSurface")]
        public abstract unsafe Texture* CreateTextureFromSurface(Renderer* renderer, Surface* surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 270, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTextureFromSurface")]
        public abstract unsafe Texture* CreateTextureFromSurface(Span<Renderer> renderer, Span<Surface> surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public abstract unsafe int QueryTexture(Texture* texture, uint* format, int* access, int* w, int* h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public abstract int QueryTexture(Span<Texture> texture, Span<uint> format, Span<int> access, Span<int> w, Span<int> h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 302, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureColorMod")]
        public abstract unsafe int SetTextureColorMod(Texture* texture, byte r, byte g, byte b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 302, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureColorMod")]
        public abstract int SetTextureColorMod(Span<Texture> texture, byte r, byte g, byte b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public abstract unsafe int GetTextureColorMod(Texture* texture, byte* r, byte* g, byte* b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public abstract int GetTextureColorMod(Span<Texture> texture, Span<byte> r, Span<byte> g, Span<byte> b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 333, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureAlphaMod")]
        public abstract unsafe int SetTextureAlphaMod(Texture* texture, byte alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 333, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureAlphaMod")]
        public abstract int SetTextureAlphaMod(Span<Texture> texture, byte alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public abstract unsafe int GetTextureAlphaMod(Texture* texture, byte* alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public abstract int GetTextureAlphaMod(Span<Texture> texture, Span<byte> alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 363, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureBlendMode")]
        public abstract unsafe int SetTextureBlendMode(Texture* texture, BlendMode blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 363, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureBlendMode")]
        public abstract int SetTextureBlendMode(Span<Texture> texture, BlendMode blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureBlendMode")]
        public abstract unsafe int GetTextureBlendMode(Texture* texture, BlendMode* blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureBlendMode")]
        public abstract int GetTextureBlendMode(Span<Texture> texture, Span<BlendMode> blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 392, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureScaleMode")]
        public abstract unsafe int SetTextureScaleMode(Texture* texture, ScaleMode scaleMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 392, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureScaleMode")]
        public abstract int SetTextureScaleMode(Span<Texture> texture, ScaleMode scaleMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureScaleMode")]
        public abstract unsafe int GetTextureScaleMode(Texture* texture, ScaleMode* scaleMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureScaleMode")]
        public abstract int GetTextureScaleMode(Span<Texture> texture, Span<ScaleMode> scaleMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public abstract unsafe int UpdateTexture(Texture* texture, Rect* rect, void* pixels, int pitch);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public abstract int UpdateTexture<T0>(Span<Texture> texture, Span<Rect> rect, Span<T0> pixels, int pitch) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public abstract unsafe int UpdateYUVTexture(Texture* texture, Rect* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public abstract int UpdateYUVTexture(Span<Texture> texture, Span<Rect> rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public abstract unsafe int LockTexture(Texture* texture, Rect* rect, void** pixels, int* pitch);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public abstract unsafe int LockTexture<T0>(Span<Texture> texture, Span<Rect> rect, void** pixels, Span<int> pitch) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public abstract unsafe int LockTextureToSurface(Texture* texture, Rect* rect, Surface** surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public abstract unsafe int LockTextureToSurface(Span<Texture> texture, Span<Rect> rect, Surface** surface);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 498, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UnlockTexture")]
        public abstract unsafe void UnlockTexture(Texture* texture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 498, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UnlockTexture")]
        public abstract void UnlockTexture(Span<Texture> texture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 507, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderTargetSupported")]
        public abstract unsafe SdlBool RenderTargetSupported(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 507, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderTargetSupported")]
        public abstract SdlBool RenderTargetSupported(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderTarget")]
        public abstract unsafe int SetRenderTarget(Renderer* renderer, Texture* texture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderTarget")]
        public abstract int SetRenderTarget(Span<Renderer> renderer, Span<Texture> texture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 529, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderTarget")]
        public abstract unsafe Texture* GetRenderTarget(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 529, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderTarget")]
        public abstract unsafe Texture* GetRenderTarget(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 554, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetLogicalSize")]
        public abstract unsafe int RenderSetLogicalSize(Renderer* renderer, int w, int h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 554, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetLogicalSize")]
        public abstract int RenderSetLogicalSize(Span<Renderer> renderer, int w, int h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public abstract unsafe void RenderGetLogicalSize(Renderer* renderer, int* w, int* h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public abstract void RenderGetLogicalSize(Span<Renderer> renderer, Span<int> w, Span<int> h);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 579, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetIntegerScale")]
        public abstract unsafe int RenderSetIntegerScale(Renderer* renderer, SdlBool enable);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 579, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetIntegerScale")]
        public abstract int RenderSetIntegerScale(Span<Renderer> renderer, SdlBool enable);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 589, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetIntegerScale")]
        public abstract unsafe SdlBool RenderGetIntegerScale(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 589, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetIntegerScale")]
        public abstract SdlBool RenderGetIntegerScale(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetViewport")]
        public abstract unsafe int RenderSetViewport(Renderer* renderer, Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetViewport")]
        public abstract int RenderSetViewport(Span<Renderer> renderer, Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 614, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetViewport")]
        public abstract unsafe void RenderGetViewport(Renderer* renderer, Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 614, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetViewport")]
        public abstract void RenderGetViewport(Span<Renderer> renderer, Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 628, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetClipRect")]
        public abstract unsafe int RenderSetClipRect(Renderer* renderer, Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 628, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetClipRect")]
        public abstract int RenderSetClipRect(Span<Renderer> renderer, Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 640, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetClipRect")]
        public abstract unsafe void RenderGetClipRect(Renderer* renderer, Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 640, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetClipRect")]
        public abstract void RenderGetClipRect(Span<Renderer> renderer, Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 650, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderIsClipEnabled")]
        public abstract unsafe SdlBool RenderIsClipEnabled(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 650, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderIsClipEnabled")]
        public abstract SdlBool RenderIsClipEnabled(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 671, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetScale")]
        public abstract unsafe int RenderSetScale(Renderer* renderer, float scaleX, float scaleY);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 671, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetScale")]
        public abstract int RenderSetScale(Span<Renderer> renderer, float scaleX, float scaleY);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public abstract unsafe void RenderGetScale(Renderer* renderer, float* scaleX, float* scaleY);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public abstract void RenderGetScale(Span<Renderer> renderer, Span<float> scaleX, Span<float> scaleY);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 698, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderDrawColor")]
        public abstract unsafe int SetRenderDrawColor(Renderer* renderer, byte r, byte g, byte b, byte a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 698, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderDrawColor")]
        public abstract int SetRenderDrawColor(Span<Renderer> renderer, byte r, byte g, byte b, byte a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public abstract unsafe int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, byte* b, byte* a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public abstract int GetRenderDrawColor(Span<Renderer> renderer, Span<byte> r, Span<byte> g, Span<byte> b, Span<byte> a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 731, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderDrawBlendMode")]
        public abstract unsafe int SetRenderDrawBlendMode(Renderer* renderer, BlendMode blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 731, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderDrawBlendMode")]
        public abstract int SetRenderDrawBlendMode(Span<Renderer> renderer, BlendMode blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 744, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawBlendMode")]
        public abstract unsafe int GetRenderDrawBlendMode(Renderer* renderer, BlendMode* blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 744, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawBlendMode")]
        public abstract int GetRenderDrawBlendMode(Span<Renderer> renderer, Span<BlendMode> blendMode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 755, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderClear")]
        public abstract unsafe int RenderClear(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 755, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderClear")]
        public abstract int RenderClear(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 766, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoint")]
        public abstract unsafe int RenderDrawPoint(Renderer* renderer, int x, int y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 766, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoint")]
        public abstract int RenderDrawPoint(Span<Renderer> renderer, int x, int y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 778, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoints")]
        public abstract unsafe int RenderDrawPoints(Renderer* renderer, Point* points, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 778, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoints")]
        public abstract int RenderDrawPoints(Span<Renderer> renderer, Span<Point> points, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 793, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLine")]
        public abstract unsafe int RenderDrawLine(Renderer* renderer, int x1, int y1, int x2, int y2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 793, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLine")]
        public abstract int RenderDrawLine(Span<Renderer> renderer, int x1, int y1, int x2, int y2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 805, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLines")]
        public abstract unsafe int RenderDrawLines(Renderer* renderer, Point* points, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 805, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLines")]
        public abstract int RenderDrawLines(Span<Renderer> renderer, Span<Point> points, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 817, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRect")]
        public abstract unsafe int RenderDrawRect(Renderer* renderer, Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 817, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRect")]
        public abstract int RenderDrawRect(Span<Renderer> renderer, Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 829, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRects")]
        public abstract unsafe int RenderDrawRects(Renderer* renderer, Rect* rects, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 829, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRects")]
        public abstract int RenderDrawRects(Span<Renderer> renderer, Span<Rect> rects, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 842, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRect")]
        public abstract unsafe int RenderFillRect(Renderer* renderer, Rect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 842, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRect")]
        public abstract int RenderFillRect(Span<Renderer> renderer, Span<Rect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRects")]
        public abstract unsafe int RenderFillRects(Renderer* renderer, Rect* rects, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRects")]
        public abstract int RenderFillRects(Span<Renderer> renderer, Span<Rect> rects, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public abstract unsafe int RenderCopy(Renderer* renderer, Texture* texture, Rect* srcrect, Rect* dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public abstract int RenderCopy(Span<Renderer> renderer, Span<Texture> texture, Span<Rect> srcrect, Span<Rect> dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public abstract unsafe int RenderCopyEx(Renderer* renderer, Texture* texture, Rect* srcrect, Rect* dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public abstract int RenderCopyEx(Span<Renderer> renderer, Span<Texture> texture, Span<Rect> srcrect, Span<Rect> dstrect, double angle, Span<Point> center, RendererFlip flip);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointF")]
        public abstract unsafe int RenderDrawPointF(Renderer* renderer, float x, float y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointF")]
        public abstract int RenderDrawPointF(Span<Renderer> renderer, float x, float y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 920, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointsF")]
        public abstract unsafe int RenderDrawPointsF(Renderer* renderer, FPoint* points, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 920, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointsF")]
        public abstract int RenderDrawPointsF(Span<Renderer> renderer, Span<FPoint> points, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 935, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLineF")]
        public abstract unsafe int RenderDrawLineF(Renderer* renderer, float x1, float y1, float x2, float y2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 935, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLineF")]
        public abstract int RenderDrawLineF(Span<Renderer> renderer, float x1, float y1, float x2, float y2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 947, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLinesF")]
        public abstract unsafe int RenderDrawLinesF(Renderer* renderer, FPoint* points, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 947, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLinesF")]
        public abstract int RenderDrawLinesF(Span<Renderer> renderer, Span<FPoint> points, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 959, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectF")]
        public abstract unsafe int RenderDrawRectF(Renderer* renderer, FRect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 959, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectF")]
        public abstract int RenderDrawRectF(Span<Renderer> renderer, Span<FRect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 971, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectsF")]
        public abstract unsafe int RenderDrawRectsF(Renderer* renderer, FRect* rects, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 971, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectsF")]
        public abstract int RenderDrawRectsF(Span<Renderer> renderer, Span<FRect> rects, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 984, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectF")]
        public abstract unsafe int RenderFillRectF(Renderer* renderer, FRect* rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 984, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectF")]
        public abstract int RenderFillRectF(Span<Renderer> renderer, Span<FRect> rect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 996, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectsF")]
        public abstract unsafe int RenderFillRectsF(Renderer* renderer, FRect* rects, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 996, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectsF")]
        public abstract int RenderFillRectsF(Span<Renderer> renderer, Span<FRect> rects, int count);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public abstract unsafe int RenderCopyF(Renderer* renderer, Texture* texture, Rect* srcrect, FRect* dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public abstract int RenderCopyF(Span<Renderer> renderer, Span<Texture> texture, Span<Rect> srcrect, Span<FRect> dstrect);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public abstract unsafe int RenderCopyExF(Renderer* renderer, Texture* texture, Rect* srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public abstract int RenderCopyExF(Span<Renderer> renderer, Span<Texture> texture, Span<Rect> srcrect, Span<FRect> dstrect, double angle, Span<FPoint> center, RendererFlip flip);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public abstract unsafe int RenderReadPixels(Renderer* renderer, Rect* rect, uint format, void* pixels, int pitch);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public abstract int RenderReadPixels<T0>(Span<Renderer> renderer, Span<Rect> rect, uint format, Span<T0> pixels, int pitch) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1063, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderPresent")]
        public abstract unsafe void RenderPresent(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1063, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderPresent")]
        public abstract void RenderPresent(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1071, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_DestroyTexture")]
        public abstract unsafe void DestroyTexture(Texture* texture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1071, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_DestroyTexture")]
        public abstract void DestroyTexture(Span<Texture> texture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1079, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_DestroyRenderer")]
        public abstract unsafe void DestroyRenderer(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1079, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_DestroyRenderer")]
        public abstract void DestroyRenderer(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1104, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFlush")]
        public abstract unsafe int RenderFlush(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1104, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFlush")]
        public abstract int RenderFlush(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public abstract unsafe int GLBindTexture(Texture* texture, float* texw, float* texh);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public abstract int GLBindTexture(Span<Texture> texture, Span<float> texw, Span<float> texh);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1126, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_UnbindTexture")]
        public abstract unsafe int GLUnbindTexture(Texture* texture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1126, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_UnbindTexture")]
        public abstract int GLUnbindTexture(Span<Texture> texture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1137, Column 31 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetMetalLayer")]
        public abstract unsafe void* RenderGetMetalLayer(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1137, Column 31 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetMetalLayer")]
        public abstract unsafe void* RenderGetMetalLayer(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1148, Column 31 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetMetalCommandEncoder")]
        public abstract unsafe void* RenderGetMetalCommandEncoder(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1148, Column 31 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetMetalCommandEncoder")]
        public abstract unsafe void* RenderGetMetalCommandEncoder(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 127, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_NumSensors")]
        public abstract int NumSensors();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 136, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceName")]
        public abstract unsafe byte* SensorGetDeviceName(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 145, Column 40 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceType")]
        public abstract SensorType SensorGetDeviceType(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 154, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceNonPortableType")]
        public abstract int SensorGetDeviceNonPortableType(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 163, Column 38 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceInstanceID")]
        public abstract int SensorGetDeviceInstanceID(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 172, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorOpen")]
        public abstract unsafe SDLSensor* SensorOpen(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 177, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorFromInstanceID")]
        public abstract unsafe SDLSensor* SensorFromInstanceID(int instance_id);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 184, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetName")]
        public abstract unsafe byte* SensorGetName(SDLSensor* sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 184, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetName")]
        public abstract unsafe byte* SensorGetName(Span<SDLSensor> sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 193, Column 40 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetType")]
        public abstract unsafe SensorType SensorGetType(SDLSensor* sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 193, Column 40 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetType")]
        public abstract SensorType SensorGetType(Span<SDLSensor> sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 202, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetNonPortableType")]
        public abstract unsafe int SensorGetNonPortableType(SDLSensor* sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 202, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetNonPortableType")]
        public abstract int SensorGetNonPortableType(Span<SDLSensor> sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 211, Column 38 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetInstanceID")]
        public abstract unsafe int SensorGetInstanceID(SDLSensor* sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 211, Column 38 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetInstanceID")]
        public abstract int SensorGetInstanceID(Span<SDLSensor> sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetData")]
        public abstract unsafe int SensorGetData(SDLSensor* sensor, float* data, int num_values);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetData")]
        public abstract int SensorGetData(Span<SDLSensor> sensor, Span<float> data, int num_values);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 229, Column 30 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorClose")]
        public abstract unsafe void SensorClose(SDLSensor* sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 229, Column 30 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorClose")]
        public abstract void SensorClose(Span<SDLSensor> sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 238, Column 30 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorUpdate")]
        public abstract void SensorUpdate();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 66, Column 38 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_CreateShapedWindow")]
        public abstract unsafe Window* CreateShapedWindow(byte* title, uint x, uint y, uint w, uint h, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 66, Column 38 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_CreateShapedWindow")]
        public abstract unsafe Window* CreateShapedWindow(Span<byte> title, uint x, uint y, uint w, uint h, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 77, Column 34 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_IsShapedWindow")]
        public abstract unsafe SdlBool IsShapedWindow(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 77, Column 34 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_IsShapedWindow")]
        public abstract SdlBool IsShapedWindow(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public abstract unsafe int SetWindowShape(Window* window, Surface* shape, WindowShapeModeVal* shape_mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public abstract int SetWindowShape(Span<Window> window, Span<Surface> shape, Span<WindowShapeModeVal> shape_mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 136, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_GetShapedWindowMode")]
        public abstract unsafe int GetShapedWindowMode(Window* window, WindowShapeModeVal* shape_mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 136, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_GetShapedWindowMode")]
        public abstract int GetShapedWindowMode(Span<Window> window, Span<WindowShapeModeVal> shape_mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 50, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowsMessageHook")]
        public abstract unsafe void SetWindowsMessageHook(void* callback, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 50, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowsMessageHook")]
        public abstract void SetWindowsMessageHook<T0, T1>(Span<T0> callback, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 58, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_Direct3D9GetAdapterIndex")]
        public abstract int Direct3D9GetAdapterIndex(int displayIndex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 66, Column 43 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetD3D9Device")]
        public abstract unsafe IDirect3DDevice9* RenderGetD3D9Device(Renderer* renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 66, Column 43 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetD3D9Device")]
        public abstract unsafe IDirect3DDevice9* RenderGetD3D9Device(Span<Renderer> renderer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 74, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_DXGIGetOutputInfo")]
        public abstract unsafe SdlBool DXGIGetOutputInfo(int displayIndex, int* adapterIndex, int* outputIndex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 74, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_DXGIGetOutputInfo")]
        public abstract SdlBool DXGIGetOutputInfo(int displayIndex, Span<int> adapterIndex, Span<int> outputIndex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 295, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_IsTablet")]
        public abstract SdlBool IsTablet();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 298, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationWillTerminate")]
        public abstract void OnApplicationWillTerminate();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 299, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning")]
        public abstract void OnApplicationDidReceiveMemoryWarning();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 300, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationWillResignActive")]
        public abstract void OnApplicationWillResignActive();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 301, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidEnterBackground")]
        public abstract void OnApplicationDidEnterBackground();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 302, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationWillEnterForeground")]
        public abstract void OnApplicationWillEnterForeground();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 303, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidBecomeActive")]
        public abstract void OnApplicationDidBecomeActive();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 45, Column 32 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_GetTicks")]
        public abstract uint GetTicks();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 61, Column 32 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_GetPerformanceCounter")]
        public abstract ulong GetPerformanceCounter();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 66, Column 32 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_GetPerformanceFrequency")]
        public abstract ulong GetPerformanceFrequency();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 71, Column 30 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_Delay")]
        public abstract void Delay(uint ms);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 93, Column 37 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_AddTimer")]
        public abstract unsafe int AddTimer(uint interval, void* callback, void* param);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 93, Column 37 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_AddTimer")]
        public abstract int AddTimer<T0, T1>(uint interval, Span<T0> callback, Span<T1> param) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 104, Column 34 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_RemoveTimer")]
        public abstract SdlBool RemoveTimer(int id);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 133, Column 30 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetVersion")]
        public abstract unsafe void GetVersion(Version* ver);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 133, Column 30 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetVersion")]
        public abstract void GetVersion(Span<Version> ver);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 142, Column 37 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetRevision")]
        public abstract unsafe byte* GetRevision();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 151, Column 29 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetRevisionNumber")]
        public abstract int GetRevisionNumber();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 188, Column 38 in build/submodules/SDL-mirror/include/SDL_platform.h")]
        [NativeApi(EntryPoint = "SDL_GetPlatform")]
        public abstract string GetPlatformS();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 397, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_getenv")]
        public abstract string Getenv(string name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public abstract int Setenv(string name, string value, int overwrite);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 458, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslen")]
        public abstract uint Wcslen(string wstr);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public abstract uint Wcslcpy(string dst, string src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public abstract uint Wcslcat(string dst, string src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 461, Column 34 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsdup")]
        public abstract string Wcsdup(string wstr);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public abstract string Wcsstr(string haystack, string needle);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public abstract int Wcscmp(string str1, string str2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public abstract int Wcsncmp(string str1, string str2, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 467, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlen")]
        public abstract uint Strlen(string str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public abstract uint Strlcpy(string dst, string src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public abstract uint Utf8strlcpy(string dst, string src, uint dst_bytes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public abstract uint Strlcat(string dst, string src, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 471, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strdup")]
        public abstract string Strdup(string str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 472, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrev")]
        public abstract string Strrev(string str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 473, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strupr")]
        public abstract string Strupr(string str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 474, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlwr")]
        public abstract string Strlwr(string str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 475, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strchr")]
        public abstract string Strchr(string str, int c);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 476, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrchr")]
        public abstract string Strrchr(string str, int c);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public abstract string Strstr(string haystack, string needle);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public abstract unsafe string Strtokr(string s1, string s2, byte** saveptr);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 479, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlen")]
        public abstract uint Utf8strlen(string str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 481, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_itoa")]
        public abstract string Itoa(int value, string str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 482, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_uitoa")]
        public abstract string Uitoa(uint value, string str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 483, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ltoa")]
        public abstract string Ltoa(int value, string str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 484, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ultoa")]
        public abstract string Ultoa(uint value, string str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 485, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lltoa")]
        public abstract string Lltoa(long value, string str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 486, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ulltoa")]
        public abstract string Ulltoa(ulong value, string str, int radix);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 488, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atoi")]
        public abstract int Atoi(string str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 489, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atof")]
        public abstract double Atof(string str);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtol")]
        public abstract unsafe int Strtol(string str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoul")]
        public abstract unsafe uint Strtoul(string str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoll")]
        public abstract unsafe long Strtoll(string str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoull")]
        public abstract unsafe ulong Strtoull(string str, byte** endp, int @base);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtod")]
        public abstract unsafe double Strtod(string str, byte** endp);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public abstract int Strcmp(string str1, string str2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public abstract int Strncmp(string str1, string str2, uint maxlen);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public abstract int Strcasecmp(string str1, string str2);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public abstract int Strncasecmp(string str1, string str2, uint len);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public abstract int Sscanf(string text, string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public abstract int Vsscanf(string text, string fmt, string ap);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public abstract int Snprintf(string text, uint maxlen, string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public abstract int Vsnprintf(string text, uint maxlen, string fmt, string ap);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public abstract unsafe SDLIconvT* IconvOpen(string tocode, string fromcode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public abstract string IconvString(string tocode, string fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public abstract unsafe int RegisterApp(string name, uint style, void* hInst);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public abstract int RegisterApp<T0>(string name, uint style, Span<T0> hInst) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public abstract unsafe AssertState ReportAssertion(AssertData* arg0, string arg1, string arg2, int arg3);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public abstract AssertState ReportAssertion(Span<AssertData> arg0, string arg1, string arg2, int arg3);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 41, Column 29 in build/submodules/SDL-mirror/include\\SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_SetError")]
        public abstract int SetError(string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 42, Column 37 in build/submodules/SDL-mirror/include\\SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_GetError")]
        public abstract string GetErrorS();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public abstract unsafe Thread* CreateThread(void* fn, string name, void* data, void* pfnBeginThread, void* pfnEndThread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public abstract unsafe Thread* CreateThread<T0, T1, T2, T3>(Span<T0> fn, string name, Span<T1> data, Span<T2> pfnBeginThread, Span<T3> pfnEndThread) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public abstract unsafe Thread* CreateThreadWithStackSize(void* fn, string name, uint stacksize, void* data, void* pfnBeginThread, void* pfnEndThread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public abstract unsafe Thread* CreateThreadWithStackSize<T0, T1, T2, T3>(Span<T0> fn, string name, uint stacksize, Span<T1> data, Span<T2> pfnBeginThread, Span<T3> pfnEndThread) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 227, Column 37 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadName")]
        public abstract unsafe string GetThreadNameS(Thread* thread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 227, Column 37 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadName")]
        public abstract string GetThreadNameS(Span<Thread> thread);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 153, Column 36 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_RWFromFile")]
        public abstract unsafe RWops* RWFromFile(string file, string mode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 251, Column 31 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_LoadFile")]
        public abstract unsafe void* LoadFile(string file, uint* datasize);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 251, Column 31 in build/submodules/SDL-mirror/include\\SDL_rwops.h")]
        [NativeApi(EntryPoint = "SDL_LoadFile")]
        public abstract unsafe void* LoadFile(string file, Span<uint> datasize);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 252, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDriver")]
        public abstract string GetAudioDriverS(int index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 263, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioInit")]
        public abstract int AudioInit(string driver_name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 271, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentAudioDriver")]
        public abstract string GetCurrentAudioDriverS();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 359, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDeviceName")]
        public abstract string GetAudioDeviceNameS(int index, int iscapture);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public abstract unsafe uint OpenAudioDevice(string device, int iscapture, AudioSpec* desired, AudioSpec* obtained, int allowed_changes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public abstract uint OpenAudioDevice(string device, int iscapture, Span<AudioSpec> desired, Span<AudioSpec> obtained, int allowed_changes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeWAV")]
        public abstract void FreeWAV(string audio_buf);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public abstract void MixAudio(string dst, string src, uint len, int volume);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public abstract void MixAudioFormat(string dst, string src, ushort format, uint len, int volume);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 46, Column 29 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_SetClipboardText")]
        public abstract int SetClipboardText(string text);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 53, Column 32 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_GetClipboardText")]
        public abstract string GetClipboardTextS();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 344, Column 37 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetPixelFormatName")]
        public abstract string GetPixelFormatNameS(uint format);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public abstract unsafe void GetRGB(uint pixel, PixelFormat* format, string r, string g, string b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public abstract void GetRGB(uint pixel, Span<PixelFormat> format, string r, string g, string b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public abstract unsafe void GetRGBA(uint pixel, PixelFormat* format, string r, string g, string b, string a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public abstract void GetRGBA(uint pixel, Span<PixelFormat> format, string r, string g, string b, string a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public abstract unsafe int GetSurfaceColorMod(Surface* surface, string r, string g, string b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public abstract int GetSurfaceColorMod(Span<Surface> surface, string r, string g, string b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public abstract unsafe int GetSurfaceAlphaMod(Surface* surface, string alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public abstract int GetSurfaceAlphaMod(Span<Surface> surface, string alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 272, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetVideoDriver")]
        public abstract string GetVideoDriverS(int index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 288, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_VideoInit")]
        public abstract int VideoInit(string driver_name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 308, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentVideoDriver")]
        public abstract string GetCurrentVideoDriverS();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 324, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayName")]
        public abstract string GetDisplayNameS(int displayIndex);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 514, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindow")]
        public abstract unsafe Window* CreateWindow(string title, int x, int y, int w, int h, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public abstract unsafe void SetWindowTitle(Window* window, string title);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public abstract void SetWindowTitle(Span<Window> window, string title);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowTitle")]
        public abstract unsafe string GetWindowTitleS(Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowTitle")]
        public abstract string GetWindowTitleS(Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public abstract unsafe void* SetWindowData(Window* window, string name, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public abstract unsafe void* SetWindowData<T0>(Span<Window> window, string name, Span<T0> userdata) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public abstract unsafe void* GetWindowData(Window* window, string name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public abstract unsafe void* GetWindowData(Span<Window> window, string name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1137, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_LoadLibrary")]
        public abstract int GLLoadLibrary(string path);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1142, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetProcAddress")]
        public abstract unsafe void* GLGetProcAddress(string proc);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1155, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_ExtensionSupported")]
        public abstract SdlBool GLExtensionSupported(string extension);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardState")]
        public abstract unsafe string GetKeyboardStateS(int* numkeys);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardState")]
        public abstract string GetKeyboardStateS(Span<int> numkeys);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 120, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeName")]
        public abstract string GetScancodeNameS(Scancode scancode);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 129, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeFromName")]
        public abstract Scancode GetScancodeFromName(string name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 141, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyName")]
        public abstract string GetKeyNameS(int key);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 150, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyFromName")]
        public abstract int GetKeyFromName(string name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public abstract unsafe Cursor* CreateCursor(string data, string mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 133, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNameForIndex")]
        public abstract string JoystickNameForIndexS(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 206, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickName")]
        public abstract unsafe string JoystickNameS(SDLJoystick* joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 206, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickName")]
        public abstract string JoystickNameS(Span<SDLJoystick> joystick);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 252, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDString")]
        public abstract void JoystickGetGUIDString(JoystickGUID guid, string pszGUID, int cbGUID);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 257, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDFromString")]
        public abstract JoystickGUID JoystickGetGUIDFromString(string pchGUID);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 145, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMapping")]
        public abstract int GameControllerAddMapping(string mappingString);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 159, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForIndex")]
        public abstract string GameControllerMappingForIndexS(int mapping_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 166, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForGUID")]
        public abstract string GameControllerMappingForGUIDS(JoystickGUID guid);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 173, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMapping")]
        public abstract unsafe string GameControllerMappingS(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 173, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMapping")]
        public abstract string GameControllerMappingS(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 185, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerNameForIndex")]
        public abstract string GameControllerNameForIndexS(int joystick_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 199, Column 31 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForDeviceIndex")]
        public abstract string GameControllerMappingForDeviceIndexS(int joystick_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 225, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerName")]
        public abstract unsafe string GameControllerNameS(SDLGameController* gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 225, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerName")]
        public abstract string GameControllerNameS(Span<SDLGameController> gamecontroller);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 317, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxisFromString")]
        public abstract GameControllerAxis GameControllerGetAxisFromString(string pchString);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 322, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetStringForAxis")]
        public abstract string GameControllerGetStringForAxisS(GameControllerAxis axis);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 370, Column 50 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButtonFromString")]
        public abstract GameControllerButton GameControllerGetButtonFromString(string pchString);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 375, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetStringForButton")]
        public abstract string GameControllerGetStringForButtonS(GameControllerButton button);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 63, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetBasePath")]
        public abstract string GetBasePathS();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public abstract string GetPrefPath(string org, string app);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 832, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticName")]
        public abstract string HapticNameS(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public abstract SdlBool SetHintWithPriority(string name, string value, HintPriority priority);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public abstract SdlBool SetHint(string name, string value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1312, Column 38 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHint")]
        public abstract string GetHint(string name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1319, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHintBoolean")]
        public abstract SdlBool GetHintBoolean(string name, SdlBool default_value);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public abstract unsafe void AddHintCallback(string name, void* callback, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public abstract void AddHintCallback<T0, T1>(string name, Span<T0> callback, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public abstract unsafe void DelHintCallback(string name, void* callback, void* userdata);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public abstract void DelHintCallback<T0, T1>(string name, Span<T0> callback, Span<T1> userdata) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 58, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadObject")]
        public abstract unsafe void* LoadObject(string sofile);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public abstract unsafe void* LoadFunction(void* handle, string name);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public abstract unsafe void* LoadFunction<T0>(Span<T0> handle, string name) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 140, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_Log")]
        public abstract void Log(string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 145, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogVerbose")]
        public abstract void LogVerbose(int category, string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 150, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogDebug")]
        public abstract void LogDebug(int category, string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 155, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogInfo")]
        public abstract void LogInfo(int category, string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 160, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogWarn")]
        public abstract void LogWarn(int category, string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 165, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogError")]
        public abstract void LogError(int category, string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 170, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogCritical")]
        public abstract void LogCritical(int category, string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 175, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessage")]
        public abstract void LogMessage(int category, LogPriority priority, string fmt);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public abstract void LogMessageV(int category, LogPriority priority, string fmt, string ap);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public abstract unsafe int ShowSimpleMessageBox(uint flags, string title, string message, Window* window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public abstract int ShowSimpleMessageBox(uint flags, string title, string message, Span<Window> window);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public abstract unsafe int GetTextureColorMod(Texture* texture, string r, string g, string b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public abstract int GetTextureColorMod(Span<Texture> texture, string r, string g, string b);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public abstract unsafe int GetTextureAlphaMod(Texture* texture, string alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public abstract int GetTextureAlphaMod(Span<Texture> texture, string alpha);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public abstract unsafe int UpdateYUVTexture(Texture* texture, Rect* rect, string Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public abstract int UpdateYUVTexture(Span<Texture> texture, Span<Rect> rect, string Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public abstract unsafe int GetRenderDrawColor(Renderer* renderer, string r, string g, string b, string a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public abstract int GetRenderDrawColor(Span<Renderer> renderer, string r, string g, string b, string a);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 136, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceName")]
        public abstract string SensorGetDeviceNameS(int device_index);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 184, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetName")]
        public abstract unsafe string SensorGetNameS(SDLSensor* sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 184, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetName")]
        public abstract string SensorGetNameS(Span<SDLSensor> sensor);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 66, Column 38 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_CreateShapedWindow")]
        public abstract unsafe Window* CreateShapedWindow(string title, uint x, uint y, uint w, uint h, uint flags);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 142, Column 37 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetRevision")]
        public abstract string GetRevisionS();

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe byte* Strtokr(byte* s1, byte* s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.MarshalStringArrayToPtr(saveptrSa);
            var ret = Strtokr(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((IntPtr) saveptr, saveptrSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe byte* Strtokr(Span<byte> s1, Span<byte> s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.MarshalStringArrayToPtr(saveptrSa);
            var ret = Strtokr(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((IntPtr) saveptr, saveptrSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe int Strtol(byte* str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtol(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe int Strtol(Span<byte> str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtol(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe uint Strtoul(byte* str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtoul(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe uint Strtoul(Span<byte> str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtoul(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe long Strtoll(byte* str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtoll(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe long Strtoll(Span<byte> str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtoll(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe ulong Strtoull(byte* str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtoull(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe ulong Strtoull(Span<byte> str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtoull(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe double Strtod(byte* str, string[] endpSa)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtod(str, endp);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe double Strtod(Span<byte> str, string[] endpSa)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtod(str, endp);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe uint Iconv(SDLIconvT* cd, string[] inbufSa, uint* inbytesleft, string[] outbufSa, uint* outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.MarshalStringArrayToPtr(inbufSa);
            var outbuf = (byte**) SilkMarshal.MarshalStringArrayToPtr(outbufSa);
            var ret = Iconv(cd, inbuf, inbytesleft, outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((IntPtr) inbuf, inbufSa);
            SilkMarshal.CopyPtrToStringArray((IntPtr) outbuf, outbufSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe uint Iconv(Span<SDLIconvT> cd, string[] inbufSa, Span<uint> inbytesleft, string[] outbufSa, Span<uint> outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.MarshalStringArrayToPtr(inbufSa);
            var outbuf = (byte**) SilkMarshal.MarshalStringArrayToPtr(outbufSa);
            var ret = Iconv(cd, inbuf, inbytesleft, outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((IntPtr) inbuf, inbufSa);
            SilkMarshal.CopyPtrToStringArray((IntPtr) outbuf, outbufSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        public unsafe int Main(int argc, string[] argvSa)
        {
            // StringArrayOverloader
            var argv = (byte**) SilkMarshal.MarshalStringArrayToPtr(argvSa);
            var ret = Main(argc, argv);
            SilkMarshal.CopyPtrToStringArray((IntPtr) argv, argvSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public unsafe AudioSpec* LoadWAVRW(RWops* src, int freesrc, AudioSpec* spec, string[] audio_bufSa, uint* audio_len)
        {
            // StringArrayOverloader
            var audio_buf = (byte**) SilkMarshal.MarshalStringArrayToPtr(audio_bufSa);
            var ret = LoadWAVRW(src, freesrc, spec, audio_buf, audio_len);
            SilkMarshal.CopyPtrToStringArray((IntPtr) audio_buf, audio_bufSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public unsafe AudioSpec* LoadWAVRW(Span<RWops> src, int freesrc, Span<AudioSpec> spec, string[] audio_bufSa, Span<uint> audio_len)
        {
            // StringArrayOverloader
            var audio_buf = (byte**) SilkMarshal.MarshalStringArrayToPtr(audio_bufSa);
            var ret = LoadWAVRW(src, freesrc, spec, audio_buf, audio_len);
            SilkMarshal.CopyPtrToStringArray((IntPtr) audio_buf, audio_bufSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe string Strtokr(string s1, string s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.MarshalStringArrayToPtr(saveptrSa);
            var ret = Strtokr(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((IntPtr) saveptr, saveptrSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe int Strtol(string str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtol(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe uint Strtoul(string str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtoul(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe long Strtoll(string str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtoll(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe ulong Strtoull(string str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtoull(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include\\SDL_stdinc.h")]
        public unsafe double Strtod(string str, string[] endpSa)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.MarshalStringArrayToPtr(endpSa);
            var ret = Strtod(str, endp);
            SilkMarshal.CopyPtrToStringArray((IntPtr) endp, endpSa);
            return ret;
        }

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new SDLLibraryNameContainer();

        public SDL(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

