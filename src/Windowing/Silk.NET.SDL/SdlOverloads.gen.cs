// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    public static class SdlOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void* Realloc<T0>(this Sdl thisApi, Span<T0> mem, uint size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Realloc(ref mem.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 364, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void Free<T0>(this Sdl thisApi, Span<T0> mem) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Free(ref mem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, delegate* unmanaged[Cdecl]<uint, void*>* malloc_func, delegate* unmanaged[Cdecl]<uint, uint, void*>* calloc_func, delegate* unmanaged[Cdecl]<void*, uint, void*>* realloc_func, Span<PfnVvV> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, calloc_func, realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, delegate* unmanaged[Cdecl]<uint, void*>* malloc_func, delegate* unmanaged[Cdecl]<uint, uint, void*>* calloc_func, Span<PfnVvUiVv> realloc_func, delegate* unmanaged[Cdecl]<void*, void>* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, calloc_func, ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, delegate* unmanaged[Cdecl]<uint, void*>* malloc_func, delegate* unmanaged[Cdecl]<uint, uint, void*>* calloc_func, Span<PfnVvUiVv> realloc_func, Span<PfnVvV> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, calloc_func, ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, delegate* unmanaged[Cdecl]<uint, void*>* malloc_func, Span<PfnUiUiVv> calloc_func, delegate* unmanaged[Cdecl]<void*, uint, void*>* realloc_func, delegate* unmanaged[Cdecl]<void*, void>* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), realloc_func, free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, delegate* unmanaged[Cdecl]<uint, void*>* malloc_func, Span<PfnUiUiVv> calloc_func, delegate* unmanaged[Cdecl]<void*, uint, void*>* realloc_func, Span<PfnVvV> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, delegate* unmanaged[Cdecl]<uint, void*>* malloc_func, Span<PfnUiUiVv> calloc_func, Span<PfnVvUiVv> realloc_func, delegate* unmanaged[Cdecl]<void*, void>* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, delegate* unmanaged[Cdecl]<uint, void*>* malloc_func, Span<PfnUiUiVv> calloc_func, Span<PfnVvUiVv> realloc_func, Span<PfnVvV> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnUiVv> malloc_func, delegate* unmanaged[Cdecl]<uint, uint, void*>* calloc_func, delegate* unmanaged[Cdecl]<void*, uint, void*>* realloc_func, delegate* unmanaged[Cdecl]<void*, void>* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, realloc_func, free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnUiVv> malloc_func, delegate* unmanaged[Cdecl]<uint, uint, void*>* calloc_func, delegate* unmanaged[Cdecl]<void*, uint, void*>* realloc_func, Span<PfnVvV> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnUiVv> malloc_func, delegate* unmanaged[Cdecl]<uint, uint, void*>* calloc_func, Span<PfnVvUiVv> realloc_func, delegate* unmanaged[Cdecl]<void*, void>* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnUiVv> malloc_func, delegate* unmanaged[Cdecl]<uint, uint, void*>* calloc_func, Span<PfnVvUiVv> realloc_func, Span<PfnVvV> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnUiVv> malloc_func, Span<PfnUiUiVv> calloc_func, delegate* unmanaged[Cdecl]<void*, uint, void*>* realloc_func, delegate* unmanaged[Cdecl]<void*, void>* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), realloc_func, free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnUiVv> malloc_func, Span<PfnUiUiVv> calloc_func, delegate* unmanaged[Cdecl]<void*, uint, void*>* realloc_func, Span<PfnVvV> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnUiVv> malloc_func, Span<PfnUiUiVv> calloc_func, Span<PfnVvUiVv> realloc_func, delegate* unmanaged[Cdecl]<void*, void>* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnUiVv> malloc_func, Span<PfnUiUiVv> calloc_func, Span<PfnVvUiVv> realloc_func, Span<PfnVvV> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Getenv(this Sdl thisApi, Span<byte> name)
        {
            // SpanOverloader
            return thisApi.Getenv(ref name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Setenv(this Sdl thisApi, byte* name, Span<byte> value, int overwrite)
        {
            // SpanOverloader
            return thisApi.Setenv(name, ref value.GetPinnableReference(), overwrite);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Setenv(this Sdl thisApi, Span<byte> name, byte* value, int overwrite)
        {
            // SpanOverloader
            return thisApi.Setenv(ref name.GetPinnableReference(), value, overwrite);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Setenv(this Sdl thisApi, Span<byte> name, Span<byte> value, int overwrite)
        {
            // SpanOverloader
            return thisApi.Setenv(ref name.GetPinnableReference(), ref value.GetPinnableReference(), overwrite);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Setenv(this Sdl thisApi, Span<byte> name, string value, int overwrite)
        {
            // SpanOverloader
            return thisApi.Setenv(ref name.GetPinnableReference(), value, overwrite);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Setenv(this Sdl thisApi, string name, Span<byte> value, int overwrite)
        {
            // SpanOverloader
            return thisApi.Setenv(name, ref value.GetPinnableReference(), overwrite);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 400, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void Qsort<T0>(this Sdl thisApi, Span<T0> @base, uint nmemb, uint size, PfnVvVvI compare) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Qsort(ref @base.GetPinnableReference(), nmemb, size, compare);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 416, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void* Memset<T0>(this Sdl thisApi, Span<T0> dst, int c, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memset(ref dst.GetPinnableReference(), c, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void* Memcpy<T0>(this Sdl thisApi, void* dst, Span<T0> src, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcpy(dst, ref src.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void* Memcpy<T0>(this Sdl thisApi, Span<T0> dst, void* src, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcpy(ref dst.GetPinnableReference(), src, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void* Memcpy<T0, T1>(this Sdl thisApi, Span<T0> dst, Span<T1> src, uint len) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcpy(ref dst.GetPinnableReference(), ref src.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void* Memmove<T0>(this Sdl thisApi, void* dst, Span<T0> src, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memmove(dst, ref src.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void* Memmove<T0>(this Sdl thisApi, Span<T0> dst, void* src, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memmove(ref dst.GetPinnableReference(), src, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe void* Memmove<T0, T1>(this Sdl thisApi, Span<T0> dst, Span<T1> src, uint len) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memmove(ref dst.GetPinnableReference(), ref src.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 456, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Memcmp<T0>(this Sdl thisApi, void* s1, Span<T0> s2, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcmp(s1, ref s2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 456, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Memcmp<T0>(this Sdl thisApi, Span<T0> s1, void* s2, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcmp(ref s1.GetPinnableReference(), s2, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 456, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Memcmp<T0, T1>(this Sdl thisApi, Span<T0> s1, Span<T1> s2, uint len) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcmp(ref s1.GetPinnableReference(), ref s2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 458, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslen(this Sdl thisApi, Span<char> wstr)
        {
            // SpanOverloader
            return thisApi.Wcslen(ref wstr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslcpy(this Sdl thisApi, char* dst, Span<char> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcpy(dst, ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslcpy(this Sdl thisApi, Span<char> dst, char* src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcpy(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslcpy(this Sdl thisApi, Span<char> dst, Span<char> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcpy(ref dst.GetPinnableReference(), ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslcpy(this Sdl thisApi, Span<char> dst, string src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcpy(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslcpy(this Sdl thisApi, string dst, Span<char> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcpy(dst, ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslcat(this Sdl thisApi, char* dst, Span<char> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcat(dst, ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslcat(this Sdl thisApi, Span<char> dst, char* src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcat(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslcat(this Sdl thisApi, Span<char> dst, Span<char> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcat(ref dst.GetPinnableReference(), ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslcat(this Sdl thisApi, Span<char> dst, string src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcat(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Wcslcat(this Sdl thisApi, string dst, Span<char> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcat(dst, ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 461, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe char* Wcsdup(this Sdl thisApi, Span<char> wstr)
        {
            // SpanOverloader
            return thisApi.Wcsdup(ref wstr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe char* Wcsstr(this Sdl thisApi, char* haystack, Span<char> needle)
        {
            // SpanOverloader
            return thisApi.Wcsstr(haystack, ref needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe char* Wcsstr(this Sdl thisApi, Span<char> haystack, char* needle)
        {
            // SpanOverloader
            return thisApi.Wcsstr(ref haystack.GetPinnableReference(), needle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe char* Wcsstr(this Sdl thisApi, Span<char> haystack, Span<char> needle)
        {
            // SpanOverloader
            return thisApi.Wcsstr(ref haystack.GetPinnableReference(), ref needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe char* Wcsstr(this Sdl thisApi, Span<char> haystack, string needle)
        {
            // SpanOverloader
            return thisApi.Wcsstr(ref haystack.GetPinnableReference(), needle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe char* Wcsstr(this Sdl thisApi, string haystack, Span<char> needle)
        {
            // SpanOverloader
            return thisApi.Wcsstr(haystack, ref needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Wcscmp(this Sdl thisApi, char* str1, Span<char> str2)
        {
            // SpanOverloader
            return thisApi.Wcscmp(str1, ref str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Wcscmp(this Sdl thisApi, Span<char> str1, char* str2)
        {
            // SpanOverloader
            return thisApi.Wcscmp(ref str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Wcscmp(this Sdl thisApi, Span<char> str1, Span<char> str2)
        {
            // SpanOverloader
            return thisApi.Wcscmp(ref str1.GetPinnableReference(), ref str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Wcscmp(this Sdl thisApi, Span<char> str1, string str2)
        {
            // SpanOverloader
            return thisApi.Wcscmp(ref str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Wcscmp(this Sdl thisApi, string str1, Span<char> str2)
        {
            // SpanOverloader
            return thisApi.Wcscmp(str1, ref str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Wcsncmp(this Sdl thisApi, char* str1, Span<char> str2, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcsncmp(str1, ref str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Wcsncmp(this Sdl thisApi, Span<char> str1, char* str2, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcsncmp(ref str1.GetPinnableReference(), str2, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Wcsncmp(this Sdl thisApi, Span<char> str1, Span<char> str2, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcsncmp(ref str1.GetPinnableReference(), ref str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Wcsncmp(this Sdl thisApi, Span<char> str1, string str2, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcsncmp(ref str1.GetPinnableReference(), str2, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Wcsncmp(this Sdl thisApi, string str1, Span<char> str2, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcsncmp(str1, ref str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 467, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlen(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Strlen(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlcpy(this Sdl thisApi, byte* dst, Span<byte> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcpy(dst, ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlcpy(this Sdl thisApi, Span<byte> dst, byte* src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcpy(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlcpy(this Sdl thisApi, Span<byte> dst, Span<byte> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcpy(ref dst.GetPinnableReference(), ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlcpy(this Sdl thisApi, Span<byte> dst, string src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcpy(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlcpy(this Sdl thisApi, string dst, Span<byte> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcpy(dst, ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Utf8strlcpy(this Sdl thisApi, byte* dst, Span<byte> src, uint dst_bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strlcpy(dst, ref src.GetPinnableReference(), dst_bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Utf8strlcpy(this Sdl thisApi, Span<byte> dst, byte* src, uint dst_bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strlcpy(ref dst.GetPinnableReference(), src, dst_bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Utf8strlcpy(this Sdl thisApi, Span<byte> dst, Span<byte> src, uint dst_bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strlcpy(ref dst.GetPinnableReference(), ref src.GetPinnableReference(), dst_bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Utf8strlcpy(this Sdl thisApi, Span<byte> dst, string src, uint dst_bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strlcpy(ref dst.GetPinnableReference(), src, dst_bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Utf8strlcpy(this Sdl thisApi, string dst, Span<byte> src, uint dst_bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strlcpy(dst, ref src.GetPinnableReference(), dst_bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlcat(this Sdl thisApi, byte* dst, Span<byte> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcat(dst, ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlcat(this Sdl thisApi, Span<byte> dst, byte* src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcat(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlcat(this Sdl thisApi, Span<byte> dst, Span<byte> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcat(ref dst.GetPinnableReference(), ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlcat(this Sdl thisApi, Span<byte> dst, string src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcat(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strlcat(this Sdl thisApi, string dst, Span<byte> src, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcat(dst, ref src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 471, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strdup(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Strdup(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strrev(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Strrev(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strupr(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Strupr(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strlwr(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Strlwr(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 475, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strchr(this Sdl thisApi, Span<byte> str, int c)
        {
            // SpanOverloader
            return thisApi.Strchr(ref str.GetPinnableReference(), c);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 476, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strrchr(this Sdl thisApi, Span<byte> str, int c)
        {
            // SpanOverloader
            return thisApi.Strrchr(ref str.GetPinnableReference(), c);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strstr(this Sdl thisApi, byte* haystack, Span<byte> needle)
        {
            // SpanOverloader
            return thisApi.Strstr(haystack, ref needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strstr(this Sdl thisApi, Span<byte> haystack, byte* needle)
        {
            // SpanOverloader
            return thisApi.Strstr(ref haystack.GetPinnableReference(), needle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strstr(this Sdl thisApi, Span<byte> haystack, Span<byte> needle)
        {
            // SpanOverloader
            return thisApi.Strstr(ref haystack.GetPinnableReference(), ref needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strstr(this Sdl thisApi, Span<byte> haystack, string needle)
        {
            // SpanOverloader
            return thisApi.Strstr(ref haystack.GetPinnableReference(), needle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strstr(this Sdl thisApi, string haystack, Span<byte> needle)
        {
            // SpanOverloader
            return thisApi.Strstr(haystack, ref needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, byte* s1, Span<byte> s2, byte** saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(s1, ref s2.GetPinnableReference(), saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, byte* s1, Span<byte> s2, ref byte* saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(s1, ref s2.GetPinnableReference(), ref saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, byte* s2, byte** saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), s2, saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, byte* s2, ref byte* saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), s2, ref saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, Span<byte> s2, byte** saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), ref s2.GetPinnableReference(), saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, Span<byte> s2, ref byte* saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), ref s2.GetPinnableReference(), ref saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, string s2, byte** saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), s2, saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, string s2, ref byte* saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), s2, ref saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, string s1, Span<byte> s2, byte** saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(s1, ref s2.GetPinnableReference(), saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, string s1, Span<byte> s2, ref byte* saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(s1, ref s2.GetPinnableReference(), ref saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Utf8strlen(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Utf8strlen(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 481, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Itoa(this Sdl thisApi, int value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Itoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Uitoa(this Sdl thisApi, uint value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Uitoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 483, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Ltoa(this Sdl thisApi, int value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Ltoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Ultoa(this Sdl thisApi, uint value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Ultoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Lltoa(this Sdl thisApi, long value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Lltoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 486, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* Ulltoa(this Sdl thisApi, ulong value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Ulltoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 488, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Atoi(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Atoi(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe double Atof(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Atof(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strtol(this Sdl thisApi, Span<byte> str, byte** endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtol(ref str.GetPinnableReference(), endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strtol(this Sdl thisApi, Span<byte> str, ref byte* endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtol(ref str.GetPinnableReference(), ref endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strtoul(this Sdl thisApi, Span<byte> str, byte** endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoul(ref str.GetPinnableReference(), endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Strtoul(this Sdl thisApi, Span<byte> str, ref byte* endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoul(ref str.GetPinnableReference(), ref endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe long Strtoll(this Sdl thisApi, Span<byte> str, byte** endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoll(ref str.GetPinnableReference(), endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe long Strtoll(this Sdl thisApi, Span<byte> str, ref byte* endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoll(ref str.GetPinnableReference(), ref endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe ulong Strtoull(this Sdl thisApi, Span<byte> str, byte** endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoull(ref str.GetPinnableReference(), endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe ulong Strtoull(this Sdl thisApi, Span<byte> str, ref byte* endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoull(ref str.GetPinnableReference(), ref endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe double Strtod(this Sdl thisApi, Span<byte> str, byte** endp)
        {
            // SpanOverloader
            return thisApi.Strtod(ref str.GetPinnableReference(), endp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe double Strtod(this Sdl thisApi, Span<byte> str, ref byte* endp)
        {
            // SpanOverloader
            return thisApi.Strtod(ref str.GetPinnableReference(), ref endp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strcmp(this Sdl thisApi, byte* str1, Span<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcmp(str1, ref str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strcmp(this Sdl thisApi, Span<byte> str1, byte* str2)
        {
            // SpanOverloader
            return thisApi.Strcmp(ref str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strcmp(this Sdl thisApi, Span<byte> str1, Span<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcmp(ref str1.GetPinnableReference(), ref str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strcmp(this Sdl thisApi, Span<byte> str1, string str2)
        {
            // SpanOverloader
            return thisApi.Strcmp(ref str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strcmp(this Sdl thisApi, string str1, Span<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcmp(str1, ref str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strncmp(this Sdl thisApi, byte* str1, Span<byte> str2, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strncmp(str1, ref str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strncmp(this Sdl thisApi, Span<byte> str1, byte* str2, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strncmp(ref str1.GetPinnableReference(), str2, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strncmp(this Sdl thisApi, Span<byte> str1, Span<byte> str2, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strncmp(ref str1.GetPinnableReference(), ref str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strncmp(this Sdl thisApi, Span<byte> str1, string str2, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strncmp(ref str1.GetPinnableReference(), str2, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strncmp(this Sdl thisApi, string str1, Span<byte> str2, uint maxlen)
        {
            // SpanOverloader
            return thisApi.Strncmp(str1, ref str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strcasecmp(this Sdl thisApi, byte* str1, Span<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcasecmp(str1, ref str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strcasecmp(this Sdl thisApi, Span<byte> str1, byte* str2)
        {
            // SpanOverloader
            return thisApi.Strcasecmp(ref str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strcasecmp(this Sdl thisApi, Span<byte> str1, Span<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcasecmp(ref str1.GetPinnableReference(), ref str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strcasecmp(this Sdl thisApi, Span<byte> str1, string str2)
        {
            // SpanOverloader
            return thisApi.Strcasecmp(ref str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strcasecmp(this Sdl thisApi, string str1, Span<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcasecmp(str1, ref str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strncasecmp(this Sdl thisApi, byte* str1, Span<byte> str2, uint len)
        {
            // SpanOverloader
            return thisApi.Strncasecmp(str1, ref str2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strncasecmp(this Sdl thisApi, Span<byte> str1, byte* str2, uint len)
        {
            // SpanOverloader
            return thisApi.Strncasecmp(ref str1.GetPinnableReference(), str2, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strncasecmp(this Sdl thisApi, Span<byte> str1, Span<byte> str2, uint len)
        {
            // SpanOverloader
            return thisApi.Strncasecmp(ref str1.GetPinnableReference(), ref str2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strncasecmp(this Sdl thisApi, Span<byte> str1, string str2, uint len)
        {
            // SpanOverloader
            return thisApi.Strncasecmp(ref str1.GetPinnableReference(), str2, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Strncasecmp(this Sdl thisApi, string str1, Span<byte> str2, uint len)
        {
            // SpanOverloader
            return thisApi.Strncasecmp(str1, ref str2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Sscanf(this Sdl thisApi, byte* text, Span<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Sscanf(text, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Sscanf(this Sdl thisApi, Span<byte> text, byte* fmt)
        {
            // SpanOverloader
            return thisApi.Sscanf(ref text.GetPinnableReference(), fmt);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Sscanf(this Sdl thisApi, Span<byte> text, Span<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Sscanf(ref text.GetPinnableReference(), ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Sscanf(this Sdl thisApi, Span<byte> text, string fmt)
        {
            // SpanOverloader
            return thisApi.Sscanf(ref text.GetPinnableReference(), fmt);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Sscanf(this Sdl thisApi, string text, Span<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Sscanf(text, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, byte* text, byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, byte* text, Span<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, byte* text, Span<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, ref fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, byte* text, Span<byte> fmt, string ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, byte* text, string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, Span<byte> text, byte* fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(ref text.GetPinnableReference(), fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, Span<byte> text, byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(ref text.GetPinnableReference(), fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, Span<byte> text, byte* fmt, string ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(ref text.GetPinnableReference(), fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, Span<byte> text, Span<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(ref text.GetPinnableReference(), ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, Span<byte> text, Span<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(ref text.GetPinnableReference(), ref fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, Span<byte> text, Span<byte> fmt, string ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(ref text.GetPinnableReference(), ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, Span<byte> text, string fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(ref text.GetPinnableReference(), fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, Span<byte> text, string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(ref text.GetPinnableReference(), fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, Span<byte> text, string fmt, string ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(ref text.GetPinnableReference(), fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, string text, byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, string text, Span<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, string text, Span<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, ref fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, string text, Span<byte> fmt, string ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, string text, string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Snprintf(this Sdl thisApi, byte* text, uint maxlen, Span<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Snprintf(text, maxlen, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Snprintf(this Sdl thisApi, Span<byte> text, uint maxlen, byte* fmt)
        {
            // SpanOverloader
            return thisApi.Snprintf(ref text.GetPinnableReference(), maxlen, fmt);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Snprintf(this Sdl thisApi, Span<byte> text, uint maxlen, Span<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Snprintf(ref text.GetPinnableReference(), maxlen, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Snprintf(this Sdl thisApi, Span<byte> text, uint maxlen, string fmt)
        {
            // SpanOverloader
            return thisApi.Snprintf(ref text.GetPinnableReference(), maxlen, fmt);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Snprintf(this Sdl thisApi, string text, uint maxlen, Span<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Snprintf(text, maxlen, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, byte* text, uint maxlen, byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, byte* text, uint maxlen, Span<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, byte* text, uint maxlen, Span<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, ref fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, byte* text, uint maxlen, Span<byte> fmt, string ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, byte* text, uint maxlen, string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, uint maxlen, byte* fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, uint maxlen, byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, uint maxlen, byte* fmt, string ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, uint maxlen, Span<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, uint maxlen, Span<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, ref fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, uint maxlen, Span<byte> fmt, string ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, uint maxlen, string fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, uint maxlen, string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, uint maxlen, string fmt, string ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, string text, uint maxlen, byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, string text, uint maxlen, Span<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, string text, uint maxlen, Span<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, ref fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, string text, uint maxlen, Span<byte> fmt, string ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, string text, uint maxlen, string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe Icon* IconvOpen(this Sdl thisApi, byte* tocode, Span<byte> fromcode)
        {
            // SpanOverloader
            return thisApi.IconvOpen(tocode, ref fromcode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe Icon* IconvOpen(this Sdl thisApi, Span<byte> tocode, byte* fromcode)
        {
            // SpanOverloader
            return thisApi.IconvOpen(ref tocode.GetPinnableReference(), fromcode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe Icon* IconvOpen(this Sdl thisApi, Span<byte> tocode, Span<byte> fromcode)
        {
            // SpanOverloader
            return thisApi.IconvOpen(ref tocode.GetPinnableReference(), ref fromcode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe Icon* IconvOpen(this Sdl thisApi, Span<byte> tocode, string fromcode)
        {
            // SpanOverloader
            return thisApi.IconvOpen(ref tocode.GetPinnableReference(), fromcode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe Icon* IconvOpen(this Sdl thisApi, string tocode, Span<byte> fromcode)
        {
            // SpanOverloader
            return thisApi.IconvOpen(tocode, ref fromcode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 559, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe int IconvClose(this Sdl thisApi, Span<Icon> cd)
        {
            // SpanOverloader
            return thisApi.IconvClose(ref cd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, byte** inbuf, uint* inbytesleft, byte** outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, inbytesleft, outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, byte** inbuf, uint* inbytesleft, ref byte* outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, inbytesleft, ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, byte** inbuf, Span<uint> inbytesleft, byte** outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, ref inbytesleft.GetPinnableReference(), outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, byte** inbuf, Span<uint> inbytesleft, byte** outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, ref inbytesleft.GetPinnableReference(), outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, byte** inbuf, Span<uint> inbytesleft, ref byte* outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, byte** inbuf, Span<uint> inbytesleft, ref byte* outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, ref byte* inbuf, uint* inbytesleft, byte** outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, ref inbuf, inbytesleft, outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, ref byte* inbuf, uint* inbytesleft, ref byte* outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, ref inbuf, inbytesleft, ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, ref byte* inbuf, Span<uint> inbytesleft, byte** outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, ref inbuf, ref inbytesleft.GetPinnableReference(), outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, ref byte* inbuf, Span<uint> inbytesleft, byte** outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, ref inbuf, ref inbytesleft.GetPinnableReference(), outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, ref byte* inbuf, Span<uint> inbytesleft, ref byte* outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, ref inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Icon* cd, ref byte* inbuf, Span<uint> inbytesleft, ref byte* outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, ref inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, byte** inbuf, uint* inbytesleft, byte** outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), inbuf, inbytesleft, outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, byte** inbuf, uint* inbytesleft, byte** outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), inbuf, inbytesleft, outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, byte** inbuf, uint* inbytesleft, ref byte* outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), inbuf, inbytesleft, ref outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, byte** inbuf, uint* inbytesleft, ref byte* outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), inbuf, inbytesleft, ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, byte** inbuf, Span<uint> inbytesleft, byte** outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), inbuf, ref inbytesleft.GetPinnableReference(), outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, byte** inbuf, Span<uint> inbytesleft, byte** outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), inbuf, ref inbytesleft.GetPinnableReference(), outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, byte** inbuf, Span<uint> inbytesleft, ref byte* outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, byte** inbuf, Span<uint> inbytesleft, ref byte* outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, ref byte* inbuf, uint* inbytesleft, byte** outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), ref inbuf, inbytesleft, outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, ref byte* inbuf, uint* inbytesleft, byte** outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), ref inbuf, inbytesleft, outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, ref byte* inbuf, uint* inbytesleft, ref byte* outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), ref inbuf, inbytesleft, ref outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, ref byte* inbuf, uint* inbytesleft, ref byte* outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), ref inbuf, inbytesleft, ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, ref byte* inbuf, Span<uint> inbytesleft, byte** outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), ref inbuf, ref inbytesleft.GetPinnableReference(), outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, ref byte* inbuf, Span<uint> inbytesleft, byte** outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), ref inbuf, ref inbytesleft.GetPinnableReference(), outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, ref byte* inbuf, Span<uint> inbytesleft, ref byte* outbuf, uint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), ref inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe uint Iconv(this Sdl thisApi, Span<Icon> cd, ref byte* inbuf, Span<uint> inbytesleft, ref byte* outbuf, Span<uint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(ref cd.GetPinnableReference(), ref inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, byte* tocode, byte* fromcode, Span<byte> inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, fromcode, ref inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, byte* tocode, Span<byte> fromcode, byte* inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, ref fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, byte* tocode, Span<byte> fromcode, Span<byte> inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, ref fromcode.GetPinnableReference(), ref inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, byte* tocode, Span<byte> fromcode, string inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, ref fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, byte* tocode, string fromcode, Span<byte> inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, fromcode, ref inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, Span<byte> tocode, byte* fromcode, byte* inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(ref tocode.GetPinnableReference(), fromcode, inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, Span<byte> tocode, byte* fromcode, Span<byte> inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(ref tocode.GetPinnableReference(), fromcode, ref inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, Span<byte> tocode, byte* fromcode, string inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(ref tocode.GetPinnableReference(), fromcode, inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, Span<byte> tocode, Span<byte> fromcode, byte* inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(ref tocode.GetPinnableReference(), ref fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, Span<byte> tocode, Span<byte> fromcode, Span<byte> inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(ref tocode.GetPinnableReference(), ref fromcode.GetPinnableReference(), ref inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, Span<byte> tocode, Span<byte> fromcode, string inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(ref tocode.GetPinnableReference(), ref fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, Span<byte> tocode, string fromcode, byte* inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(ref tocode.GetPinnableReference(), fromcode, inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, Span<byte> tocode, string fromcode, Span<byte> inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(ref tocode.GetPinnableReference(), fromcode, ref inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, Span<byte> tocode, string fromcode, string inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(ref tocode.GetPinnableReference(), fromcode, inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, string tocode, byte* fromcode, Span<byte> inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, fromcode, ref inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, string tocode, Span<byte> fromcode, byte* inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, ref fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, string tocode, Span<byte> fromcode, Span<byte> inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, ref fromcode.GetPinnableReference(), ref inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, string tocode, Span<byte> fromcode, string inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, ref fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, string tocode, string fromcode, Span<byte> inbuf, uint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, fromcode, ref inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, uint* Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, Gmask, Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, uint* Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, Gmask, ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, uint* Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, Gmask, ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, Span<uint> Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, ref Gmask.GetPinnableReference(), Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, Span<uint> Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, ref Gmask.GetPinnableReference(), Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, Span<uint> Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, Span<uint> Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, uint* Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), Gmask, Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, uint* Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), Gmask, Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, uint* Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), Gmask, ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, uint* Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), Gmask, ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, Span<uint> Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, Span<uint> Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, Span<uint> Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, Span<uint> Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, uint* Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, Gmask, Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, uint* Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, Gmask, Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, uint* Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, Gmask, ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, uint* Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, Gmask, ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, Span<uint> Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, ref Gmask.GetPinnableReference(), Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, Span<uint> Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, ref Gmask.GetPinnableReference(), Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, Span<uint> Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, Span<uint> Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, uint* Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), Gmask, Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, uint* Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), Gmask, Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, uint* Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), Gmask, ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, uint* Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), Gmask, ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, Span<uint> Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, Span<uint> Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, Span<uint> Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, Span<uint> Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 382, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void FreeFormat(this Sdl thisApi, Span<PixelFormat> format)
        {
            // SpanOverloader
            thisApi.FreeFormat(ref format.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 399, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe int SetPixelFormatPalette(this Sdl thisApi, PixelFormat* format, Span<Palette> palette)
        {
            // SpanOverloader
            return thisApi.SetPixelFormatPalette(format, ref palette.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 399, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe int SetPixelFormatPalette(this Sdl thisApi, Span<PixelFormat> format, Palette* palette)
        {
            // SpanOverloader
            return thisApi.SetPixelFormatPalette(ref format.GetPinnableReference(), palette);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 399, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe int SetPixelFormatPalette(this Sdl thisApi, Span<PixelFormat> format, Span<Palette> palette)
        {
            // SpanOverloader
            return thisApi.SetPixelFormatPalette(ref format.GetPinnableReference(), ref palette.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe int SetPaletteColors(this Sdl thisApi, Palette* palette, Span<Color> colors, int firstcolor, int ncolors)
        {
            // SpanOverloader
            return thisApi.SetPaletteColors(palette, ref colors.GetPinnableReference(), firstcolor, ncolors);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe int SetPaletteColors(this Sdl thisApi, Span<Palette> palette, Color* colors, int firstcolor, int ncolors)
        {
            // SpanOverloader
            return thisApi.SetPaletteColors(ref palette.GetPinnableReference(), colors, firstcolor, ncolors);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe int SetPaletteColors(this Sdl thisApi, Span<Palette> palette, Span<Color> colors, int firstcolor, int ncolors)
        {
            // SpanOverloader
            return thisApi.SetPaletteColors(ref palette.GetPinnableReference(), ref colors.GetPinnableReference(), firstcolor, ncolors);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 421, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void FreePalette(this Sdl thisApi, Span<Palette> palette)
        {
            // SpanOverloader
            thisApi.FreePalette(ref palette.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe uint MapRGB(this Sdl thisApi, Span<PixelFormat> format, byte r, byte g, byte b)
        {
            // SpanOverloader
            return thisApi.MapRGB(ref format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe uint MapRGBA(this Sdl thisApi, Span<PixelFormat> format, byte r, byte g, byte b, byte a)
        {
            // SpanOverloader
            return thisApi.MapRGBA(ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, PixelFormat* format, string r, string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, ref format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, byte* r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, byte* g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, Span<byte> r, string g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, PixelFormat* format, string r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, byte* g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, byte* r, string g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, byte* g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, Span<byte> r, string g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, byte* g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, byte* b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, Span<PixelFormat> format, string r, string g, string b, string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, ref format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        public static unsafe void CalculateGammaRamp(this Sdl thisApi, float gamma, Span<ushort> ramp)
        {
            // SpanOverloader
            thisApi.CalculateGammaRamp(gamma, ref ramp.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 41, Column 29 in build/submodules/SDL-mirror/include/SDL_error.h")]
        public static unsafe int SetError(this Sdl thisApi, Span<byte> fmt)
        {
            // SpanOverloader
            return thisApi.SetError(ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool HasIntersection(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* A, Span<Silk.NET.Maths.Rectangle<int>> B)
        {
            // SpanOverloader
            return thisApi.HasIntersection(A, ref B.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool HasIntersection(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> A, Silk.NET.Maths.Rectangle<int>* B)
        {
            // SpanOverloader
            return thisApi.HasIntersection(ref A.GetPinnableReference(), B);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool HasIntersection(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> A, Span<Silk.NET.Maths.Rectangle<int>> B)
        {
            // SpanOverloader
            return thisApi.HasIntersection(ref A.GetPinnableReference(), ref B.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* A, Silk.NET.Maths.Rectangle<int>* B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(A, B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* A, Span<Silk.NET.Maths.Rectangle<int>> B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(A, ref B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* A, Span<Silk.NET.Maths.Rectangle<int>> B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(A, ref B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> A, Silk.NET.Maths.Rectangle<int>* B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(ref A.GetPinnableReference(), B, result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> A, Silk.NET.Maths.Rectangle<int>* B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(ref A.GetPinnableReference(), B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> A, Span<Silk.NET.Maths.Rectangle<int>> B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(ref A.GetPinnableReference(), ref B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> A, Span<Silk.NET.Maths.Rectangle<int>> B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(ref A.GetPinnableReference(), ref B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* A, Silk.NET.Maths.Rectangle<int>* B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            thisApi.UnionRect(A, B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* A, Span<Silk.NET.Maths.Rectangle<int>> B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            thisApi.UnionRect(A, ref B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* A, Span<Silk.NET.Maths.Rectangle<int>> B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            thisApi.UnionRect(A, ref B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> A, Silk.NET.Maths.Rectangle<int>* B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            thisApi.UnionRect(ref A.GetPinnableReference(), B, result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> A, Silk.NET.Maths.Rectangle<int>* B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            thisApi.UnionRect(ref A.GetPinnableReference(), B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> A, Span<Silk.NET.Maths.Rectangle<int>> B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            thisApi.UnionRect(ref A.GetPinnableReference(), ref B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> A, Span<Silk.NET.Maths.Rectangle<int>> B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            thisApi.UnionRect(ref A.GetPinnableReference(), ref B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, Point* points, int count, Silk.NET.Maths.Rectangle<int>* clip, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(points, count, clip, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, Point* points, int count, Span<Silk.NET.Maths.Rectangle<int>> clip, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(points, count, ref clip.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, Point* points, int count, Span<Silk.NET.Maths.Rectangle<int>> clip, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(points, count, ref clip.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, Span<Point> points, int count, Silk.NET.Maths.Rectangle<int>* clip, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(ref points.GetPinnableReference(), count, clip, result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, Span<Point> points, int count, Silk.NET.Maths.Rectangle<int>* clip, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(ref points.GetPinnableReference(), count, clip, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, Span<Point> points, int count, Span<Silk.NET.Maths.Rectangle<int>> clip, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(ref points.GetPinnableReference(), count, ref clip.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, Span<Point> points, int count, Span<Silk.NET.Maths.Rectangle<int>> clip, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(ref points.GetPinnableReference(), count, ref clip.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, int* X1, Span<int> Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, int* X1, Span<int> Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, int* X1, Span<int> Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, int* X1, Span<int> Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, int* Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), Y1, X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, int* Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, int* Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, int* Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, Span<int> Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, Span<int> Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, Span<int> Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, Span<int> Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, int* X1, int* Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), X1, Y1, X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, int* X1, int* Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), X1, Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, int* X1, int* Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), X1, Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, int* X1, int* Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), X1, Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, int* X1, Span<int> Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, int* X1, Span<int> Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, int* X1, Span<int> Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, int* X1, Span<int> Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, int* Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, int* Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, int* Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, int* Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, Span<int> Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, Span<int> Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, Span<int> Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, Span<int> Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(ref rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe Surface* CreateRGBSurfaceFrom<T0>(this Sdl thisApi, Span<T0> pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateRGBSurfaceFrom(ref pixels.GetPinnableReference(), width, height, depth, pitch, Rmask, Gmask, Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe Surface* CreateRGBSurfaceWithFormatFrom<T0>(this Sdl thisApi, Span<T0> pixels, int width, int height, int depth, int pitch, uint format) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateRGBSurfaceWithFormatFrom(ref pixels.GetPinnableReference(), width, height, depth, pitch, format);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 149, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe void FreeSurface(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            thisApi.FreeSurface(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SetSurfacePalette(this Sdl thisApi, Surface* surface, Span<Palette> palette)
        {
            // SpanOverloader
            return thisApi.SetSurfacePalette(surface, ref palette.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SetSurfacePalette(this Sdl thisApi, Span<Surface> surface, Palette* palette)
        {
            // SpanOverloader
            return thisApi.SetSurfacePalette(ref surface.GetPinnableReference(), palette);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SetSurfacePalette(this Sdl thisApi, Span<Surface> surface, Span<Palette> palette)
        {
            // SpanOverloader
            return thisApi.SetSurfacePalette(ref surface.GetPinnableReference(), ref palette.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 180, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LockSurface(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.LockSurface(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe void UnlockSurface(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            thisApi.UnlockSurface(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe Surface* LoadBMPRW(this Sdl thisApi, Span<RWops> src, int freesrc)
        {
            // SpanOverloader
            return thisApi.LoadBMPRW(ref src.GetPinnableReference(), freesrc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SaveBMPRW(this Sdl thisApi, Surface* surface, Span<RWops> dst, int freedst)
        {
            // SpanOverloader
            return thisApi.SaveBMPRW(surface, ref dst.GetPinnableReference(), freedst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SaveBMPRW(this Sdl thisApi, Span<Surface> surface, RWops* dst, int freedst)
        {
            // SpanOverloader
            return thisApi.SaveBMPRW(ref surface.GetPinnableReference(), dst, freedst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SaveBMPRW(this Sdl thisApi, Span<Surface> surface, Span<RWops> dst, int freedst)
        {
            // SpanOverloader
            return thisApi.SaveBMPRW(ref surface.GetPinnableReference(), ref dst.GetPinnableReference(), freedst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SetSurfaceRLE(this Sdl thisApi, Span<Surface> surface, int flag)
        {
            // SpanOverloader
            return thisApi.SetSurfaceRLE(ref surface.GetPinnableReference(), flag);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 249, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SetColorKey(this Sdl thisApi, Span<Surface> surface, int flag, uint key)
        {
            // SpanOverloader
            return thisApi.SetColorKey(ref surface.GetPinnableReference(), flag, key);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe SdlBool HasColorKey(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.HasColorKey(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetColorKey(this Sdl thisApi, Surface* surface, Span<uint> key)
        {
            // SpanOverloader
            return thisApi.GetColorKey(surface, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetColorKey(this Sdl thisApi, Span<Surface> surface, uint* key)
        {
            // SpanOverloader
            return thisApi.GetColorKey(ref surface.GetPinnableReference(), key);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetColorKey(this Sdl thisApi, Span<Surface> surface, Span<uint> key)
        {
            // SpanOverloader
            return thisApi.GetColorKey(ref surface.GetPinnableReference(), ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 284, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte r, byte g, byte b)
        {
            // SpanOverloader
            return thisApi.SetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, byte* r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, byte* r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, byte* g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, string g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, string r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, string r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, byte* g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, string g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, byte* g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, string g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, string r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, string r, byte* g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, string r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, string r, string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, string r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, string r, string g, string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 314, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SetSurfaceAlphaMod(this Sdl thisApi, Span<Surface> surface, byte alpha)
        {
            // SpanOverloader
            return thisApi.SetSurfaceAlphaMod(ref surface.GetPinnableReference(), alpha);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceAlphaMod(this Sdl thisApi, Surface* surface, Span<byte> alpha)
        {
            // SpanOverloader
            return thisApi.GetSurfaceAlphaMod(surface, ref alpha.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceAlphaMod(this Sdl thisApi, Span<Surface> surface, byte* alpha)
        {
            // SpanOverloader
            return thisApi.GetSurfaceAlphaMod(ref surface.GetPinnableReference(), alpha);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceAlphaMod(this Sdl thisApi, Span<Surface> surface, Span<byte> alpha)
        {
            // SpanOverloader
            return thisApi.GetSurfaceAlphaMod(ref surface.GetPinnableReference(), ref alpha.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceAlphaMod(this Sdl thisApi, Span<Surface> surface, string alpha)
        {
            // SpanOverloader
            return thisApi.GetSurfaceAlphaMod(ref surface.GetPinnableReference(), alpha);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SetSurfaceBlendMode(this Sdl thisApi, Span<Surface> surface, BlendMode blendMode)
        {
            // SpanOverloader
            return thisApi.SetSurfaceBlendMode(ref surface.GetPinnableReference(), blendMode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceBlendMode(this Sdl thisApi, Surface* surface, Span<BlendMode> blendMode)
        {
            // SpanOverloader
            return thisApi.GetSurfaceBlendMode(surface, ref blendMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceBlendMode(this Sdl thisApi, Span<Surface> surface, BlendMode* blendMode)
        {
            // SpanOverloader
            return thisApi.GetSurfaceBlendMode(ref surface.GetPinnableReference(), blendMode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int GetSurfaceBlendMode(this Sdl thisApi, Span<Surface> surface, Span<BlendMode> blendMode)
        {
            // SpanOverloader
            return thisApi.GetSurfaceBlendMode(ref surface.GetPinnableReference(), ref blendMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe SdlBool SetClipRect(this Sdl thisApi, Surface* surface, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.SetClipRect(surface, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe SdlBool SetClipRect(this Sdl thisApi, Span<Surface> surface, Silk.NET.Maths.Rectangle<int>* rect)
        {
            // SpanOverloader
            return thisApi.SetClipRect(ref surface.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe SdlBool SetClipRect(this Sdl thisApi, Span<Surface> surface, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.SetClipRect(ref surface.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 378, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe void GetClipRect(this Sdl thisApi, Surface* surface, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.GetClipRect(surface, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 378, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe void GetClipRect(this Sdl thisApi, Span<Surface> surface, Silk.NET.Maths.Rectangle<int>* rect)
        {
            // SpanOverloader
            thisApi.GetClipRect(ref surface.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 378, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe void GetClipRect(this Sdl thisApi, Span<Surface> surface, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.GetClipRect(ref surface.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 384, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe Surface* DuplicateSurface(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.DuplicateSurface(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe Surface* ConvertSurface(this Sdl thisApi, Surface* src, Span<PixelFormat> fmt, uint flags)
        {
            // SpanOverloader
            return thisApi.ConvertSurface(src, ref fmt.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe Surface* ConvertSurface(this Sdl thisApi, Span<Surface> src, PixelFormat* fmt, uint flags)
        {
            // SpanOverloader
            return thisApi.ConvertSurface(ref src.GetPinnableReference(), fmt, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe Surface* ConvertSurface(this Sdl thisApi, Span<Surface> src, Span<PixelFormat> fmt, uint flags)
        {
            // SpanOverloader
            return thisApi.ConvertSurface(ref src.GetPinnableReference(), ref fmt.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe Surface* ConvertSurfaceFormat(this Sdl thisApi, Span<Surface> src, uint pixel_format, uint flags)
        {
            // SpanOverloader
            return thisApi.ConvertSurfaceFormat(ref src.GetPinnableReference(), pixel_format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 406, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int ConvertPixels<T0>(this Sdl thisApi, int width, int height, uint src_format, void* src, int src_pitch, uint dst_format, Span<T0> dst, int dst_pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ConvertPixels(width, height, src_format, src, src_pitch, dst_format, ref dst.GetPinnableReference(), dst_pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 406, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int ConvertPixels<T0>(this Sdl thisApi, int width, int height, uint src_format, Span<T0> src, int src_pitch, uint dst_format, void* dst, int dst_pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ConvertPixels(width, height, src_format, ref src.GetPinnableReference(), src_pitch, dst_format, dst, dst_pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 406, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int ConvertPixels<T0, T1>(this Sdl thisApi, int width, int height, uint src_format, Span<T0> src, int src_pitch, uint dst_format, Span<T1> dst, int dst_pitch) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.ConvertPixels(width, height, src_format, ref src.GetPinnableReference(), src_pitch, dst_format, ref dst.GetPinnableReference(), dst_pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int FillRect(this Sdl thisApi, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> rect, uint color)
        {
            // SpanOverloader
            return thisApi.FillRect(dst, ref rect.GetPinnableReference(), color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int FillRect(this Sdl thisApi, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* rect, uint color)
        {
            // SpanOverloader
            return thisApi.FillRect(ref dst.GetPinnableReference(), rect, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int FillRect(this Sdl thisApi, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> rect, uint color)
        {
            // SpanOverloader
            return thisApi.FillRect(ref dst.GetPinnableReference(), ref rect.GetPinnableReference(), color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int FillRects(this Sdl thisApi, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> rects, int count, uint color)
        {
            // SpanOverloader
            return thisApi.FillRects(dst, ref rects.GetPinnableReference(), count, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int FillRects(this Sdl thisApi, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* rects, int count, uint color)
        {
            // SpanOverloader
            return thisApi.FillRects(ref dst.GetPinnableReference(), rects, count, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int FillRects(this Sdl thisApi, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> rects, int count, uint color)
        {
            // SpanOverloader
            return thisApi.FillRects(ref dst.GetPinnableReference(), ref rects.GetPinnableReference(), count, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int VideoInit(this Sdl thisApi, Span<byte> driver_name)
        {
            // SpanOverloader
            return thisApi.VideoInit(ref driver_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDisplayBounds(this Sdl thisApi, int displayIndex, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.GetDisplayBounds(displayIndex, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDisplayUsableBounds(this Sdl thisApi, int displayIndex, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.GetDisplayUsableBounds(displayIndex, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, float* ddpi, float* hdpi, Span<float> vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ddpi, hdpi, ref vdpi.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, float* ddpi, Span<float> hdpi, float* vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ddpi, ref hdpi.GetPinnableReference(), vdpi);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, float* ddpi, Span<float> hdpi, Span<float> vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ddpi, ref hdpi.GetPinnableReference(), ref vdpi.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, Span<float> ddpi, float* hdpi, float* vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ref ddpi.GetPinnableReference(), hdpi, vdpi);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, Span<float> ddpi, float* hdpi, Span<float> vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ref ddpi.GetPinnableReference(), hdpi, ref vdpi.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, Span<float> ddpi, Span<float> hdpi, float* vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ref ddpi.GetPinnableReference(), ref hdpi.GetPinnableReference(), vdpi);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, Span<float> ddpi, Span<float> hdpi, Span<float> vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ref ddpi.GetPinnableReference(), ref hdpi.GetPinnableReference(), ref vdpi.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 394, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDisplayMode(this Sdl thisApi, int displayIndex, int modeIndex, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.GetDisplayMode(displayIndex, modeIndex, ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 400, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetDesktopDisplayMode(this Sdl thisApi, int displayIndex, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.GetDesktopDisplayMode(displayIndex, ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetCurrentDisplayMode(this Sdl thisApi, int displayIndex, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.GetCurrentDisplayMode(displayIndex, ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 429, Column 43 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe DisplayMode* GetClosestDisplayMode(this Sdl thisApi, int displayIndex, DisplayMode* mode, Span<DisplayMode> closest)
        {
            // SpanOverloader
            return thisApi.GetClosestDisplayMode(displayIndex, mode, ref closest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 429, Column 43 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe DisplayMode* GetClosestDisplayMode(this Sdl thisApi, int displayIndex, Span<DisplayMode> mode, DisplayMode* closest)
        {
            // SpanOverloader
            return thisApi.GetClosestDisplayMode(displayIndex, ref mode.GetPinnableReference(), closest);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 429, Column 43 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe DisplayMode* GetClosestDisplayMode(this Sdl thisApi, int displayIndex, Span<DisplayMode> mode, Span<DisplayMode> closest)
        {
            // SpanOverloader
            return thisApi.GetClosestDisplayMode(displayIndex, ref mode.GetPinnableReference(), ref closest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 437, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowDisplayIndex(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.GetWindowDisplayIndex(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowDisplayMode(this Sdl thisApi, Window* window, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.SetWindowDisplayMode(window, ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowDisplayMode(this Sdl thisApi, Span<Window> window, DisplayMode* mode)
        {
            // SpanOverloader
            return thisApi.SetWindowDisplayMode(ref window.GetPinnableReference(), mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowDisplayMode(this Sdl thisApi, Span<Window> window, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.SetWindowDisplayMode(ref window.GetPinnableReference(), ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowDisplayMode(this Sdl thisApi, Window* window, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.GetWindowDisplayMode(window, ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowDisplayMode(this Sdl thisApi, Span<Window> window, DisplayMode* mode)
        {
            // SpanOverloader
            return thisApi.GetWindowDisplayMode(ref window.GetPinnableReference(), mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowDisplayMode(this Sdl thisApi, Span<Window> window, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.GetWindowDisplayMode(ref window.GetPinnableReference(), ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe uint GetWindowPixelFormat(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.GetWindowPixelFormat(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 514, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe Window* CreateWindow(this Sdl thisApi, Span<byte> title, int x, int y, int w, int h, uint flags)
        {
            // SpanOverloader
            return thisApi.CreateWindow(ref title.GetPinnableReference(), x, y, w, h, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe Window* CreateWindowFrom<T0>(this Sdl thisApi, Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateWindowFrom(ref data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe uint GetWindowID(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.GetWindowID(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe uint GetWindowFlags(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.GetWindowFlags(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowTitle(this Sdl thisApi, Window* window, Span<byte> title)
        {
            // SpanOverloader
            thisApi.SetWindowTitle(window, ref title.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowTitle(this Sdl thisApi, Span<Window> window, byte* title)
        {
            // SpanOverloader
            thisApi.SetWindowTitle(ref window.GetPinnableReference(), title);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowTitle(this Sdl thisApi, Span<Window> window, Span<byte> title)
        {
            // SpanOverloader
            thisApi.SetWindowTitle(ref window.GetPinnableReference(), ref title.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowTitle(this Sdl thisApi, Span<Window> window, string title)
        {
            // SpanOverloader
            thisApi.SetWindowTitle(ref window.GetPinnableReference(), title);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe byte* GetWindowTitle(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.GetWindowTitle(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowIcon(this Sdl thisApi, Window* window, Span<Surface> icon)
        {
            // SpanOverloader
            thisApi.SetWindowIcon(window, ref icon.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowIcon(this Sdl thisApi, Span<Window> window, Surface* icon)
        {
            // SpanOverloader
            thisApi.SetWindowIcon(ref window.GetPinnableReference(), icon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowIcon(this Sdl thisApi, Span<Window> window, Span<Surface> icon)
        {
            // SpanOverloader
            thisApi.SetWindowIcon(ref window.GetPinnableReference(), ref icon.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* SetWindowData<T0>(this Sdl thisApi, Window* window, byte* name, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowData(window, name, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* SetWindowData(this Sdl thisApi, Window* window, Span<byte> name, void* userdata)
        {
            // SpanOverloader
            return thisApi.SetWindowData(window, ref name.GetPinnableReference(), userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* SetWindowData<T0>(this Sdl thisApi, Window* window, Span<byte> name, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowData(window, ref name.GetPinnableReference(), ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* SetWindowData<T0>(this Sdl thisApi, Window* window, string name, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowData(window, name, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* SetWindowData(this Sdl thisApi, Span<Window> window, byte* name, void* userdata)
        {
            // SpanOverloader
            return thisApi.SetWindowData(ref window.GetPinnableReference(), name, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* SetWindowData<T0>(this Sdl thisApi, Span<Window> window, byte* name, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowData(ref window.GetPinnableReference(), name, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* SetWindowData(this Sdl thisApi, Span<Window> window, Span<byte> name, void* userdata)
        {
            // SpanOverloader
            return thisApi.SetWindowData(ref window.GetPinnableReference(), ref name.GetPinnableReference(), userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* SetWindowData<T0>(this Sdl thisApi, Span<Window> window, Span<byte> name, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowData(ref window.GetPinnableReference(), ref name.GetPinnableReference(), ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* SetWindowData(this Sdl thisApi, Span<Window> window, string name, void* userdata)
        {
            // SpanOverloader
            return thisApi.SetWindowData(ref window.GetPinnableReference(), name, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* SetWindowData<T0>(this Sdl thisApi, Span<Window> window, string name, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowData(ref window.GetPinnableReference(), name, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* GetWindowData(this Sdl thisApi, Window* window, Span<byte> name)
        {
            // SpanOverloader
            return thisApi.GetWindowData(window, ref name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* GetWindowData(this Sdl thisApi, Span<Window> window, byte* name)
        {
            // SpanOverloader
            return thisApi.GetWindowData(ref window.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* GetWindowData(this Sdl thisApi, Span<Window> window, Span<byte> name)
        {
            // SpanOverloader
            return thisApi.GetWindowData(ref window.GetPinnableReference(), ref name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* GetWindowData(this Sdl thisApi, Span<Window> window, string name)
        {
            // SpanOverloader
            return thisApi.GetWindowData(ref window.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowPosition(this Sdl thisApi, Span<Window> window, int x, int y)
        {
            // SpanOverloader
            thisApi.SetWindowPosition(ref window.GetPinnableReference(), x, y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowPosition(this Sdl thisApi, Window* window, int* x, Span<int> y)
        {
            // SpanOverloader
            thisApi.GetWindowPosition(window, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowPosition(this Sdl thisApi, Window* window, Span<int> x, int* y)
        {
            // SpanOverloader
            thisApi.GetWindowPosition(window, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowPosition(this Sdl thisApi, Window* window, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            thisApi.GetWindowPosition(window, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowPosition(this Sdl thisApi, Span<Window> window, int* x, int* y)
        {
            // SpanOverloader
            thisApi.GetWindowPosition(ref window.GetPinnableReference(), x, y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowPosition(this Sdl thisApi, Span<Window> window, int* x, Span<int> y)
        {
            // SpanOverloader
            thisApi.GetWindowPosition(ref window.GetPinnableReference(), x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowPosition(this Sdl thisApi, Span<Window> window, Span<int> x, int* y)
        {
            // SpanOverloader
            thisApi.GetWindowPosition(ref window.GetPinnableReference(), ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowPosition(this Sdl thisApi, Span<Window> window, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            thisApi.GetWindowPosition(ref window.GetPinnableReference(), ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 646, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowSize(this Sdl thisApi, Span<Window> window, int w, int h)
        {
            // SpanOverloader
            thisApi.SetWindowSize(ref window.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowSize(this Sdl thisApi, Span<Window> window, int* w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowSize(ref window.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowSize(this Sdl thisApi, Span<Window> window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowSize(ref window.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowSize(this Sdl thisApi, Span<Window> window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowSize(ref window.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowSize(this Sdl thisApi, Span<Window> window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowSize(ref window.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, int* left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, left, bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, int* left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, left, ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, int* left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, left, ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, Span<int> left, int* bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, ref left.GetPinnableReference(), bottom, right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, Span<int> left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, ref left.GetPinnableReference(), bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, Span<int> left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, Span<int> left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, int* left, int* bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), left, bottom, right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, int* left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), left, bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, int* left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), left, ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, int* left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), left, ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, Span<int> left, int* bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), ref left.GetPinnableReference(), bottom, right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, Span<int> left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), ref left.GetPinnableReference(), bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, Span<int> left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, Span<int> left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, int* top, int* left, int* bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), top, left, bottom, right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, int* top, int* left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), top, left, bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, int* top, int* left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), top, left, ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, int* top, int* left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), top, left, ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, int* top, Span<int> left, int* bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), top, ref left.GetPinnableReference(), bottom, right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, int* top, Span<int> left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), top, ref left.GetPinnableReference(), bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, int* top, Span<int> left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), top, ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, int* top, Span<int> left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), top, ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, Span<int> top, int* left, int* bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), ref top.GetPinnableReference(), left, bottom, right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, Span<int> top, int* left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), ref top.GetPinnableReference(), left, bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, Span<int> top, int* left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), ref top.GetPinnableReference(), left, ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, Span<int> top, int* left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), ref top.GetPinnableReference(), left, ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, Span<int> top, Span<int> left, int* bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), ref top.GetPinnableReference(), ref left.GetPinnableReference(), bottom, right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, Span<int> top, Span<int> left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), ref top.GetPinnableReference(), ref left.GetPinnableReference(), bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, Span<int> top, Span<int> left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), ref top.GetPinnableReference(), ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Span<Window> window, Span<int> top, Span<int> left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(ref window.GetPinnableReference(), ref top.GetPinnableReference(), ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowMinimumSize(this Sdl thisApi, Span<Window> window, int min_w, int min_h)
        {
            // SpanOverloader
            thisApi.SetWindowMinimumSize(ref window.GetPinnableReference(), min_w, min_h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMinimumSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMinimumSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMinimumSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowMinimumSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMinimumSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMinimumSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMinimumSize(this Sdl thisApi, Span<Window> window, int* w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowMinimumSize(ref window.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMinimumSize(this Sdl thisApi, Span<Window> window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMinimumSize(ref window.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMinimumSize(this Sdl thisApi, Span<Window> window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowMinimumSize(ref window.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMinimumSize(this Sdl thisApi, Span<Window> window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMinimumSize(ref window.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 729, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowMaximumSize(this Sdl thisApi, Span<Window> window, int max_w, int max_h)
        {
            // SpanOverloader
            thisApi.SetWindowMaximumSize(ref window.GetPinnableReference(), max_w, max_h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMaximumSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMaximumSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMaximumSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowMaximumSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMaximumSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMaximumSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMaximumSize(this Sdl thisApi, Span<Window> window, int* w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowMaximumSize(ref window.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMaximumSize(this Sdl thisApi, Span<Window> window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMaximumSize(ref window.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMaximumSize(this Sdl thisApi, Span<Window> window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowMaximumSize(ref window.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GetWindowMaximumSize(this Sdl thisApi, Span<Window> window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMaximumSize(ref window.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 759, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowBordered(this Sdl thisApi, Span<Window> window, SdlBool bordered)
        {
            // SpanOverloader
            thisApi.SetWindowBordered(ref window.GetPinnableReference(), bordered);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 776, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowResizable(this Sdl thisApi, Span<Window> window, SdlBool resizable)
        {
            // SpanOverloader
            thisApi.SetWindowResizable(ref window.GetPinnableReference(), resizable);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void ShowWindow(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            thisApi.ShowWindow(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void HideWindow(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            thisApi.HideWindow(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 796, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void RaiseWindow(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            thisApi.RaiseWindow(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 803, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void MaximizeWindow(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            thisApi.MaximizeWindow(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 810, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void MinimizeWindow(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            thisApi.MinimizeWindow(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 818, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void RestoreWindow(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            thisApi.RestoreWindow(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 828, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowFullscreen(this Sdl thisApi, Span<Window> window, uint flags)
        {
            // SpanOverloader
            return thisApi.SetWindowFullscreen(ref window.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe Surface* GetWindowSurface(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.GetWindowSurface(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int UpdateWindowSurface(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.UpdateWindowSurface(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int UpdateWindowSurfaceRects(this Sdl thisApi, Window* window, Span<Silk.NET.Maths.Rectangle<int>> rects, int numrects)
        {
            // SpanOverloader
            return thisApi.UpdateWindowSurfaceRects(window, ref rects.GetPinnableReference(), numrects);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int UpdateWindowSurfaceRects(this Sdl thisApi, Span<Window> window, Silk.NET.Maths.Rectangle<int>* rects, int numrects)
        {
            // SpanOverloader
            return thisApi.UpdateWindowSurfaceRects(ref window.GetPinnableReference(), rects, numrects);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int UpdateWindowSurfaceRects(this Sdl thisApi, Span<Window> window, Span<Silk.NET.Maths.Rectangle<int>> rects, int numrects)
        {
            // SpanOverloader
            return thisApi.UpdateWindowSurfaceRects(ref window.GetPinnableReference(), ref rects.GetPinnableReference(), numrects);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 879, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void SetWindowGrab(this Sdl thisApi, Span<Window> window, SdlBool grabbed)
        {
            // SpanOverloader
            thisApi.SetWindowGrab(ref window.GetPinnableReference(), grabbed);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 889, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe SdlBool GetWindowGrab(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.GetWindowGrab(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowBrightness(this Sdl thisApi, Span<Window> window, float brightness)
        {
            // SpanOverloader
            return thisApi.SetWindowBrightness(ref window.GetPinnableReference(), brightness);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 917, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe float GetWindowBrightness(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.GetWindowBrightness(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowOpacity(this Sdl thisApi, Span<Window> window, float opacity)
        {
            // SpanOverloader
            return thisApi.SetWindowOpacity(ref window.GetPinnableReference(), opacity);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowOpacity(this Sdl thisApi, Window* window, Span<float> out_opacity)
        {
            // SpanOverloader
            return thisApi.GetWindowOpacity(window, ref out_opacity.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowOpacity(this Sdl thisApi, Span<Window> window, float* out_opacity)
        {
            // SpanOverloader
            return thisApi.GetWindowOpacity(ref window.GetPinnableReference(), out_opacity);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowOpacity(this Sdl thisApi, Span<Window> window, Span<float> out_opacity)
        {
            // SpanOverloader
            return thisApi.GetWindowOpacity(ref window.GetPinnableReference(), ref out_opacity.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowModalFor(this Sdl thisApi, Window* modal_window, Span<Window> parent_window)
        {
            // SpanOverloader
            return thisApi.SetWindowModalFor(modal_window, ref parent_window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowModalFor(this Sdl thisApi, Span<Window> modal_window, Window* parent_window)
        {
            // SpanOverloader
            return thisApi.SetWindowModalFor(ref modal_window.GetPinnableReference(), parent_window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowModalFor(this Sdl thisApi, Span<Window> modal_window, Span<Window> parent_window)
        {
            // SpanOverloader
            return thisApi.SetWindowModalFor(ref modal_window.GetPinnableReference(), ref parent_window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 969, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowInputFocus(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.SetWindowInputFocus(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, ushort* red, ushort* green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, red, green, ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, ushort* red, Span<ushort> green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, red, ref green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, ushort* red, Span<ushort> green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, red, ref green.GetPinnableReference(), ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, ushort* green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, ref red.GetPinnableReference(), green, blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, ushort* green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, ref red.GetPinnableReference(), green, ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, Span<ushort> green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, ref red.GetPinnableReference(), ref green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, Span<ushort> green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, ref red.GetPinnableReference(), ref green.GetPinnableReference(), ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Span<Window> window, ushort* red, ushort* green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(ref window.GetPinnableReference(), red, green, blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Span<Window> window, ushort* red, ushort* green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(ref window.GetPinnableReference(), red, green, ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Span<Window> window, ushort* red, Span<ushort> green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(ref window.GetPinnableReference(), red, ref green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Span<Window> window, ushort* red, Span<ushort> green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(ref window.GetPinnableReference(), red, ref green.GetPinnableReference(), ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Span<Window> window, Span<ushort> red, ushort* green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(ref window.GetPinnableReference(), ref red.GetPinnableReference(), green, blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Span<Window> window, Span<ushort> red, ushort* green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(ref window.GetPinnableReference(), ref red.GetPinnableReference(), green, ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Span<Window> window, Span<ushort> red, Span<ushort> green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(ref window.GetPinnableReference(), ref red.GetPinnableReference(), ref green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Span<Window> window, Span<ushort> red, Span<ushort> green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(ref window.GetPinnableReference(), ref red.GetPinnableReference(), ref green.GetPinnableReference(), ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, ushort* red, ushort* green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, red, green, ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, ushort* red, Span<ushort> green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, red, ref green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, ushort* red, Span<ushort> green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, red, ref green.GetPinnableReference(), ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, ushort* green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, ref red.GetPinnableReference(), green, blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, ushort* green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, ref red.GetPinnableReference(), green, ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, Span<ushort> green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, ref red.GetPinnableReference(), ref green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, Span<ushort> green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, ref red.GetPinnableReference(), ref green.GetPinnableReference(), ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Span<Window> window, ushort* red, ushort* green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(ref window.GetPinnableReference(), red, green, blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Span<Window> window, ushort* red, ushort* green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(ref window.GetPinnableReference(), red, green, ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Span<Window> window, ushort* red, Span<ushort> green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(ref window.GetPinnableReference(), red, ref green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Span<Window> window, ushort* red, Span<ushort> green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(ref window.GetPinnableReference(), red, ref green.GetPinnableReference(), ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Span<Window> window, Span<ushort> red, ushort* green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(ref window.GetPinnableReference(), ref red.GetPinnableReference(), green, blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Span<Window> window, Span<ushort> red, ushort* green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(ref window.GetPinnableReference(), ref red.GetPinnableReference(), green, ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Span<Window> window, Span<ushort> red, Span<ushort> green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(ref window.GetPinnableReference(), ref red.GetPinnableReference(), ref green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Span<Window> window, Span<ushort> red, Span<ushort> green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(ref window.GetPinnableReference(), ref red.GetPinnableReference(), ref green.GetPinnableReference(), ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowHitTest<T0>(this Sdl thisApi, Window* window, PfnSDLWindowvSDLPointvVvSDLHitTestResult callback, Span<T0> callback_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowHitTest(window, callback, ref callback_data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowHitTest(this Sdl thisApi, Span<Window> window, PfnSDLWindowvSDLPointvVvSDLHitTestResult callback, void* callback_data)
        {
            // SpanOverloader
            return thisApi.SetWindowHitTest(ref window.GetPinnableReference(), callback, callback_data);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int SetWindowHitTest<T0>(this Sdl thisApi, Span<Window> window, PfnSDLWindowvSDLPointvVvSDLHitTestResult callback, Span<T0> callback_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowHitTest(ref window.GetPinnableReference(), callback, ref callback_data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1086, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void DestroyWindow(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            thisApi.DestroyWindow(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1137, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GLLoadLibrary(this Sdl thisApi, Span<byte> path)
        {
            // SpanOverloader
            return thisApi.GLLoadLibrary(ref path.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* GLGetProcAddress(this Sdl thisApi, Span<byte> proc)
        {
            // SpanOverloader
            return thisApi.GLGetProcAddress(ref proc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe SdlBool GLExtensionSupported(this Sdl thisApi, Span<byte> extension)
        {
            // SpanOverloader
            return thisApi.GLExtensionSupported(ref extension.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1176, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GLGetAttribute(this Sdl thisApi, GLattr attr, Span<int> value)
        {
            // SpanOverloader
            return thisApi.GLGetAttribute(attr, ref value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1184, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void* GLCreateContext(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.GLCreateContext(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1192, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GLMakeCurrent<T0>(this Sdl thisApi, Window* window, Span<T0> context) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GLMakeCurrent(window, ref context.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1192, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GLMakeCurrent(this Sdl thisApi, Span<Window> window, void* context)
        {
            // SpanOverloader
            return thisApi.GLMakeCurrent(ref window.GetPinnableReference(), context);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1192, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe int GLMakeCurrent<T0>(this Sdl thisApi, Span<Window> window, Span<T0> context) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GLMakeCurrent(ref window.GetPinnableReference(), ref context.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GLGetDrawableSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GLGetDrawableSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GLGetDrawableSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GLGetDrawableSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GLGetDrawableSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GLGetDrawableSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GLGetDrawableSize(this Sdl thisApi, Span<Window> window, int* w, int* h)
        {
            // SpanOverloader
            thisApi.GLGetDrawableSize(ref window.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GLGetDrawableSize(this Sdl thisApi, Span<Window> window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GLGetDrawableSize(ref window.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GLGetDrawableSize(this Sdl thisApi, Span<Window> window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GLGetDrawableSize(ref window.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GLGetDrawableSize(this Sdl thisApi, Span<Window> window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GLGetDrawableSize(ref window.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1255, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GLSwapWindow(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            thisApi.GLSwapWindow(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1262, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        public static unsafe void GLDeleteContext<T0>(this Sdl thisApi, Span<T0> context) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GLDeleteContext(ref context.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 29 in SDL_vulkan.h")]
        public static unsafe int VulkanLoadLibrary(this Sdl thisApi, Span<byte> path)
        {
            // SpanOverloader
            return thisApi.VulkanLoadLibrary(ref path.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanGetInstanceExtensions(this Sdl thisApi, Window* window, Span<uint> pCount, byte** pNames)
        {
            // SpanOverloader
            return thisApi.VulkanGetInstanceExtensions(window, ref pCount.GetPinnableReference(), pNames);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanGetInstanceExtensions(this Sdl thisApi, Window* window, Span<uint> pCount, ref byte* pNames)
        {
            // SpanOverloader
            return thisApi.VulkanGetInstanceExtensions(window, ref pCount.GetPinnableReference(), ref pNames);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanGetInstanceExtensions(this Sdl thisApi, Span<Window> window, uint* pCount, byte** pNames)
        {
            // SpanOverloader
            return thisApi.VulkanGetInstanceExtensions(ref window.GetPinnableReference(), pCount, pNames);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanGetInstanceExtensions(this Sdl thisApi, Span<Window> window, uint* pCount, ref byte* pNames)
        {
            // SpanOverloader
            return thisApi.VulkanGetInstanceExtensions(ref window.GetPinnableReference(), pCount, ref pNames);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanGetInstanceExtensions(this Sdl thisApi, Span<Window> window, Span<uint> pCount, byte** pNames)
        {
            // SpanOverloader
            return thisApi.VulkanGetInstanceExtensions(ref window.GetPinnableReference(), ref pCount.GetPinnableReference(), pNames);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanGetInstanceExtensions(this Sdl thisApi, Span<Window> window, Span<uint> pCount, ref byte* pNames)
        {
            // SpanOverloader
            return thisApi.VulkanGetInstanceExtensions(ref window.GetPinnableReference(), ref pCount.GetPinnableReference(), ref pNames);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanCreateSurface(this Sdl thisApi, Window* window, Silk.NET.Core.Native.VkHandle instance, Span<Silk.NET.Core.Native.VkNonDispatchableHandle> surface)
        {
            // SpanOverloader
            return thisApi.VulkanCreateSurface(window, instance, ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanCreateSurface(this Sdl thisApi, Span<Window> window, Silk.NET.Core.Native.VkHandle instance, Silk.NET.Core.Native.VkNonDispatchableHandle* surface)
        {
            // SpanOverloader
            return thisApi.VulkanCreateSurface(ref window.GetPinnableReference(), instance, surface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanCreateSurface(this Sdl thisApi, Span<Window> window, Silk.NET.Core.Native.VkHandle instance, Span<Silk.NET.Core.Native.VkNonDispatchableHandle> surface)
        {
            // SpanOverloader
            return thisApi.VulkanCreateSurface(ref window.GetPinnableReference(), instance, ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        public static unsafe void VulkanGetDrawableSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.VulkanGetDrawableSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        public static unsafe void VulkanGetDrawableSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.VulkanGetDrawableSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        public static unsafe void VulkanGetDrawableSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.VulkanGetDrawableSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        public static unsafe void VulkanGetDrawableSize(this Sdl thisApi, Span<Window> window, int* w, int* h)
        {
            // SpanOverloader
            thisApi.VulkanGetDrawableSize(ref window.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        public static unsafe void VulkanGetDrawableSize(this Sdl thisApi, Span<Window> window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.VulkanGetDrawableSize(ref window.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        public static unsafe void VulkanGetDrawableSize(this Sdl thisApi, Span<Window> window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.VulkanGetDrawableSize(ref window.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        public static unsafe void VulkanGetDrawableSize(this Sdl thisApi, Span<Window> window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.VulkanGetDrawableSize(ref window.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int RegisterApp<T0>(this Sdl thisApi, byte* name, uint style, Span<T0> hInst) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterApp(name, style, ref hInst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int RegisterApp(this Sdl thisApi, Span<byte> name, uint style, void* hInst)
        {
            // SpanOverloader
            return thisApi.RegisterApp(ref name.GetPinnableReference(), style, hInst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int RegisterApp<T0>(this Sdl thisApi, Span<byte> name, uint style, Span<T0> hInst) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterApp(ref name.GetPinnableReference(), style, ref hInst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int RegisterApp<T0>(this Sdl thisApi, string name, uint style, Span<T0> hInst) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterApp(name, style, ref hInst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 154, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int WinRTRunApp<T0>(this Sdl thisApi, PfnIBvvI mainFunction, Span<T0> reserved) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WinRTRunApp(mainFunction, ref reserved.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, AssertData* arg0, byte* arg1, Span<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(arg0, arg1, ref arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, AssertData* arg0, Span<byte> arg1, byte* arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(arg0, ref arg1.GetPinnableReference(), arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, AssertData* arg0, Span<byte> arg1, Span<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(arg0, ref arg1.GetPinnableReference(), ref arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, AssertData* arg0, Span<byte> arg1, string arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(arg0, ref arg1.GetPinnableReference(), arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, AssertData* arg0, string arg1, Span<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(arg0, arg1, ref arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, byte* arg1, byte* arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, byte* arg1, Span<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, ref arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, byte* arg1, string arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, Span<byte> arg1, byte* arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, Span<byte> arg1, Span<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, Span<byte> arg1, string arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, string arg1, byte* arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, string arg1, Span<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, ref arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, string arg1, string arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 30 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        public static unsafe void SetAssertionHandler<T0>(this Sdl thisApi, PfnSDLAssertDatavVvSDLAssertState handler, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetAssertionHandler(handler, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe SdlBool AtomicTryLock(this Sdl thisApi, Span<int> @lock)
        {
            // SpanOverloader
            return thisApi.AtomicTryLock(ref @lock.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe void AtomicLock(this Sdl thisApi, Span<int> @lock)
        {
            // SpanOverloader
            thisApi.AtomicLock(ref @lock.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe void AtomicUnlock(this Sdl thisApi, Span<int> @lock)
        {
            // SpanOverloader
            thisApi.AtomicUnlock(ref @lock.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe SdlBool AtomicCAS(this Sdl thisApi, Span<AtomicT> a, int oldval, int newval)
        {
            // SpanOverloader
            return thisApi.AtomicCAS(ref a.GetPinnableReference(), oldval, newval);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe int AtomicSet(this Sdl thisApi, Span<AtomicT> a, int v)
        {
            // SpanOverloader
            return thisApi.AtomicSet(ref a.GetPinnableReference(), v);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe int AtomicGet(this Sdl thisApi, Span<AtomicT> a)
        {
            // SpanOverloader
            return thisApi.AtomicGet(ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe int AtomicAdd(this Sdl thisApi, Span<AtomicT> a, int v)
        {
            // SpanOverloader
            return thisApi.AtomicAdd(ref a.GetPinnableReference(), v);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0>(this Sdl thisApi, void** a, void* oldval, Span<T0> newval) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(a, oldval, ref newval.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0>(this Sdl thisApi, void** a, Span<T0> oldval, void* newval) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(a, ref oldval.GetPinnableReference(), newval);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0, T1>(this Sdl thisApi, void** a, Span<T0> oldval, Span<T1> newval) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(a, ref oldval.GetPinnableReference(), ref newval.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0>(this Sdl thisApi, ref void* a, void* oldval, Span<T0> newval) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(ref a, oldval, ref newval.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0>(this Sdl thisApi, ref void* a, Span<T0> oldval, void* newval) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(ref a, ref oldval.GetPinnableReference(), newval);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0, T1>(this Sdl thisApi, ref void* a, Span<T0> oldval, Span<T1> newval) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(ref a, ref oldval.GetPinnableReference(), ref newval.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe void* AtomicSetPtr<T0>(this Sdl thisApi, void** a, Span<T0> v) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicSetPtr(a, ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        public static unsafe void* AtomicSetPtr<T0>(this Sdl thisApi, ref void* a, Span<T0> v) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicSetPtr(ref a, ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int LockMutex(this Sdl thisApi, Span<Mutex> mutex)
        {
            // SpanOverloader
            return thisApi.LockMutex(ref mutex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int TryLockMutex(this Sdl thisApi, Span<Mutex> mutex)
        {
            // SpanOverloader
            return thisApi.TryLockMutex(ref mutex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int UnlockMutex(this Sdl thisApi, Span<Mutex> mutex)
        {
            // SpanOverloader
            return thisApi.UnlockMutex(ref mutex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe void DestroyMutex(this Sdl thisApi, Span<Mutex> mutex)
        {
            // SpanOverloader
            thisApi.DestroyMutex(ref mutex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe void DestroySemaphore(this Sdl thisApi, Span<Semaphore> sem)
        {
            // SpanOverloader
            thisApi.DestroySemaphore(ref sem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 124, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int SemWait(this Sdl thisApi, Span<Semaphore> sem)
        {
            // SpanOverloader
            return thisApi.SemWait(ref sem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 132, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int SemTryWait(this Sdl thisApi, Span<Semaphore> sem)
        {
            // SpanOverloader
            return thisApi.SemTryWait(ref sem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 143, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int SemWaitTimeout(this Sdl thisApi, Span<Semaphore> sem, uint ms)
        {
            // SpanOverloader
            return thisApi.SemWaitTimeout(ref sem.GetPinnableReference(), ms);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int SemPost(this Sdl thisApi, Span<Semaphore> sem)
        {
            // SpanOverloader
            return thisApi.SemPost(ref sem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 32 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe uint SemValue(this Sdl thisApi, Span<Semaphore> sem)
        {
            // SpanOverloader
            return thisApi.SemValue(ref sem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe void DestroyCond(this Sdl thisApi, Span<Cond> cond)
        {
            // SpanOverloader
            thisApi.DestroyCond(ref cond.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 209, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int CondSignal(this Sdl thisApi, Span<Cond> cond)
        {
            // SpanOverloader
            return thisApi.CondSignal(ref cond.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int CondBroadcast(this Sdl thisApi, Span<Cond> cond)
        {
            // SpanOverloader
            return thisApi.CondBroadcast(ref cond.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int CondWait(this Sdl thisApi, Cond* cond, Span<Mutex> mutex)
        {
            // SpanOverloader
            return thisApi.CondWait(cond, ref mutex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int CondWait(this Sdl thisApi, Span<Cond> cond, Mutex* mutex)
        {
            // SpanOverloader
            return thisApi.CondWait(ref cond.GetPinnableReference(), mutex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int CondWait(this Sdl thisApi, Span<Cond> cond, Span<Mutex> mutex)
        {
            // SpanOverloader
            return thisApi.CondWait(ref cond.GetPinnableReference(), ref mutex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int CondWaitTimeout(this Sdl thisApi, Cond* cond, Span<Mutex> mutex, uint ms)
        {
            // SpanOverloader
            return thisApi.CondWaitTimeout(cond, ref mutex.GetPinnableReference(), ms);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int CondWaitTimeout(this Sdl thisApi, Span<Cond> cond, Mutex* mutex, uint ms)
        {
            // SpanOverloader
            return thisApi.CondWaitTimeout(ref cond.GetPinnableReference(), mutex, ms);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        public static unsafe int CondWaitTimeout(this Sdl thisApi, Span<Cond> cond, Span<Mutex> mutex, uint ms)
        {
            // SpanOverloader
            return thisApi.CondWaitTimeout(ref cond.GetPinnableReference(), ref mutex.GetPinnableReference(), ms);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe Thread* CreateThread<T0>(this Sdl thisApi, PfnVvI fn, byte* name, Span<T0> data, PfnVvUiPfnVvUiVvUiUivUi pfnBeginThread, PfnUiV pfnEndThread) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThread(fn, name, ref data.GetPinnableReference(), pfnBeginThread, pfnEndThread);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe Thread* CreateThread(this Sdl thisApi, PfnVvI fn, Span<byte> name, void* data, PfnVvUiPfnVvUiVvUiUivUi pfnBeginThread, PfnUiV pfnEndThread)
        {
            // SpanOverloader
            return thisApi.CreateThread(fn, ref name.GetPinnableReference(), data, pfnBeginThread, pfnEndThread);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe Thread* CreateThread<T0>(this Sdl thisApi, PfnVvI fn, Span<byte> name, Span<T0> data, PfnVvUiPfnVvUiVvUiUivUi pfnBeginThread, PfnUiV pfnEndThread) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThread(fn, ref name.GetPinnableReference(), ref data.GetPinnableReference(), pfnBeginThread, pfnEndThread);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe Thread* CreateThread<T0>(this Sdl thisApi, PfnVvI fn, string name, Span<T0> data, PfnVvUiPfnVvUiVvUiUivUi pfnBeginThread, PfnUiV pfnEndThread) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThread(fn, name, ref data.GetPinnableReference(), pfnBeginThread, pfnEndThread);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe Thread* CreateThreadWithStackSize<T0>(this Sdl thisApi, PfnThreadFunction fn, byte* name, uint stacksize, Span<T0> data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThreadWithStackSize(fn, name, stacksize, ref data.GetPinnableReference(), pfnBeginThread, pfnEndThread);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe Thread* CreateThreadWithStackSize(this Sdl thisApi, PfnThreadFunction fn, Span<byte> name, uint stacksize, void* data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread)
        {
            // SpanOverloader
            return thisApi.CreateThreadWithStackSize(fn, ref name.GetPinnableReference(), stacksize, data, pfnBeginThread, pfnEndThread);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe Thread* CreateThreadWithStackSize<T0>(this Sdl thisApi, PfnThreadFunction fn, Span<byte> name, uint stacksize, Span<T0> data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThreadWithStackSize(fn, ref name.GetPinnableReference(), stacksize, ref data.GetPinnableReference(), pfnBeginThread, pfnEndThread);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe Thread* CreateThreadWithStackSize<T0>(this Sdl thisApi, PfnThreadFunction fn, string name, uint stacksize, Span<T0> data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThreadWithStackSize(fn, name, stacksize, ref data.GetPinnableReference(), pfnBeginThread, pfnEndThread);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 37 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe byte* GetThreadName(this Sdl thisApi, Span<Thread> thread)
        {
            // SpanOverloader
            return thisApi.GetThreadName(ref thread.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 38 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe uint GetThreadID(this Sdl thisApi, Span<Thread> thread)
        {
            // SpanOverloader
            return thisApi.GetThreadID(ref thread.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe void WaitThread(this Sdl thisApi, Thread* thread, Span<int> status)
        {
            // SpanOverloader
            thisApi.WaitThread(thread, ref status.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe void WaitThread(this Sdl thisApi, Span<Thread> thread, int* status)
        {
            // SpanOverloader
            thisApi.WaitThread(ref thread.GetPinnableReference(), status);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe void WaitThread(this Sdl thisApi, Span<Thread> thread, Span<int> status)
        {
            // SpanOverloader
            thisApi.WaitThread(ref thread.GetPinnableReference(), ref status.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe void DetachThread(this Sdl thisApi, Span<Thread> thread)
        {
            // SpanOverloader
            thisApi.DetachThread(ref thread.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 350, Column 29 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        public static unsafe int TLSSet<T0>(this Sdl thisApi, uint id, Span<T0> value, PfnFreeFunc destructor) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TLSSet(id, ref value.GetPinnableReference(), destructor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int AudioInit(this Sdl thisApi, Span<byte> driver_name)
        {
            // SpanOverloader
            return thisApi.AudioInit(ref driver_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int OpenAudio(this Sdl thisApi, AudioSpec* desired, Span<AudioSpec> obtained)
        {
            // SpanOverloader
            return thisApi.OpenAudio(desired, ref obtained.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int OpenAudio(this Sdl thisApi, Span<AudioSpec> desired, AudioSpec* obtained)
        {
            // SpanOverloader
            return thisApi.OpenAudio(ref desired.GetPinnableReference(), obtained);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int OpenAudio(this Sdl thisApi, Span<AudioSpec> desired, Span<AudioSpec> obtained)
        {
            // SpanOverloader
            return thisApi.OpenAudio(ref desired.GetPinnableReference(), ref obtained.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, byte* device, int iscapture, AudioSpec* desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, desired, ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, byte* device, int iscapture, Span<AudioSpec> desired, AudioSpec* obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, ref desired.GetPinnableReference(), obtained, allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, byte* device, int iscapture, Span<AudioSpec> desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, ref desired.GetPinnableReference(), ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, Span<byte> device, int iscapture, AudioSpec* desired, AudioSpec* obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(ref device.GetPinnableReference(), iscapture, desired, obtained, allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, Span<byte> device, int iscapture, AudioSpec* desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(ref device.GetPinnableReference(), iscapture, desired, ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, Span<byte> device, int iscapture, Span<AudioSpec> desired, AudioSpec* obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(ref device.GetPinnableReference(), iscapture, ref desired.GetPinnableReference(), obtained, allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, Span<byte> device, int iscapture, Span<AudioSpec> desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(ref device.GetPinnableReference(), iscapture, ref desired.GetPinnableReference(), ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, string device, int iscapture, AudioSpec* desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, desired, ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, string device, int iscapture, Span<AudioSpec> desired, AudioSpec* obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, ref desired.GetPinnableReference(), obtained, allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, string device, int iscapture, Span<AudioSpec> desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, ref desired.GetPinnableReference(), ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, AudioSpec* spec, byte** audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, spec, audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, AudioSpec* spec, ref byte* audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, spec, ref audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, Span<AudioSpec> spec, byte** audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, ref spec.GetPinnableReference(), audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, Span<AudioSpec> spec, byte** audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, ref spec.GetPinnableReference(), audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, Span<AudioSpec> spec, ref byte* audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, ref spec.GetPinnableReference(), ref audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, Span<AudioSpec> spec, ref byte* audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, ref spec.GetPinnableReference(), ref audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, AudioSpec* spec, byte** audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, spec, audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, AudioSpec* spec, byte** audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, spec, audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, AudioSpec* spec, ref byte* audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, spec, ref audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, AudioSpec* spec, ref byte* audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, spec, ref audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, Span<AudioSpec> spec, byte** audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, ref spec.GetPinnableReference(), audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, Span<AudioSpec> spec, byte** audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, ref spec.GetPinnableReference(), audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, Span<AudioSpec> spec, ref byte* audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, ref spec.GetPinnableReference(), ref audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, Span<AudioSpec> spec, ref byte* audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, ref spec.GetPinnableReference(), ref audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void FreeWAV(this Sdl thisApi, Span<byte> audio_buf)
        {
            // SpanOverloader
            thisApi.FreeWAV(ref audio_buf.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int BuildAudioCVT(this Sdl thisApi, Span<AudioCVT> cvt, ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate)
        {
            // SpanOverloader
            return thisApi.BuildAudioCVT(ref cvt.GetPinnableReference(), src_format, src_channels, src_rate, dst_format, dst_channels, dst_rate);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int ConvertAudio(this Sdl thisApi, Span<AudioCVT> cvt)
        {
            // SpanOverloader
            return thisApi.ConvertAudio(ref cvt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int AudioStreamPut<T0>(this Sdl thisApi, AudioStream* stream, Span<T0> buf, int len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AudioStreamPut(stream, ref buf.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int AudioStreamPut(this Sdl thisApi, Span<AudioStream> stream, void* buf, int len)
        {
            // SpanOverloader
            return thisApi.AudioStreamPut(ref stream.GetPinnableReference(), buf, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int AudioStreamPut<T0>(this Sdl thisApi, Span<AudioStream> stream, Span<T0> buf, int len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AudioStreamPut(ref stream.GetPinnableReference(), ref buf.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int AudioStreamGet<T0>(this Sdl thisApi, AudioStream* stream, Span<T0> buf, int len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AudioStreamGet(stream, ref buf.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int AudioStreamGet(this Sdl thisApi, Span<AudioStream> stream, void* buf, int len)
        {
            // SpanOverloader
            return thisApi.AudioStreamGet(ref stream.GetPinnableReference(), buf, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int AudioStreamGet<T0>(this Sdl thisApi, Span<AudioStream> stream, Span<T0> buf, int len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AudioStreamGet(ref stream.GetPinnableReference(), ref buf.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int AudioStreamAvailable(this Sdl thisApi, Span<AudioStream> stream)
        {
            // SpanOverloader
            return thisApi.AudioStreamAvailable(ref stream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 623, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int AudioStreamFlush(this Sdl thisApi, Span<AudioStream> stream)
        {
            // SpanOverloader
            return thisApi.AudioStreamFlush(ref stream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 635, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void AudioStreamClear(this Sdl thisApi, Span<AudioStream> stream)
        {
            // SpanOverloader
            thisApi.AudioStreamClear(ref stream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void FreeAudioStream(this Sdl thisApi, Span<AudioStream> stream)
        {
            // SpanOverloader
            thisApi.FreeAudioStream(ref stream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void MixAudio(this Sdl thisApi, byte* dst, Span<byte> src, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudio(dst, ref src.GetPinnableReference(), len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void MixAudio(this Sdl thisApi, Span<byte> dst, byte* src, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudio(ref dst.GetPinnableReference(), src, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void MixAudio(this Sdl thisApi, Span<byte> dst, Span<byte> src, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudio(ref dst.GetPinnableReference(), ref src.GetPinnableReference(), len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void MixAudio(this Sdl thisApi, Span<byte> dst, string src, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudio(ref dst.GetPinnableReference(), src, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void MixAudio(this Sdl thisApi, string dst, Span<byte> src, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudio(dst, ref src.GetPinnableReference(), len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void MixAudioFormat(this Sdl thisApi, byte* dst, Span<byte> src, ushort format, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudioFormat(dst, ref src.GetPinnableReference(), format, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void MixAudioFormat(this Sdl thisApi, Span<byte> dst, byte* src, ushort format, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudioFormat(ref dst.GetPinnableReference(), src, format, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void MixAudioFormat(this Sdl thisApi, Span<byte> dst, Span<byte> src, ushort format, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudioFormat(ref dst.GetPinnableReference(), ref src.GetPinnableReference(), format, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void MixAudioFormat(this Sdl thisApi, Span<byte> dst, string src, ushort format, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudioFormat(ref dst.GetPinnableReference(), src, format, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe void MixAudioFormat(this Sdl thisApi, string dst, Span<byte> src, ushort format, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudioFormat(dst, ref src.GetPinnableReference(), format, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 709, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe int QueueAudio<T0>(this Sdl thisApi, uint dev, Span<T0> data, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueueAudio(dev, ref data.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 32 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public static unsafe uint DequeueAudio<T0>(this Sdl thisApi, uint dev, Span<T0> data, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DequeueAudio(dev, ref data.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 29 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        public static unsafe int SetClipboardText(this Sdl thisApi, Span<byte> text)
        {
            // SpanOverloader
            return thisApi.SetClipboardText(ref text.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        public static unsafe void SIMDFree<T0>(this Sdl thisApi, Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SIMDFree(ref ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        public static unsafe byte* GetKeyboardState(this Sdl thisApi, Span<int> numkeys)
        {
            // SpanOverloader
            return thisApi.GetKeyboardState(ref numkeys.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 129, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        public static unsafe Scancode GetScancodeFromName(this Sdl thisApi, Span<byte> name)
        {
            // SpanOverloader
            return thisApi.GetScancodeFromName(ref name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        public static unsafe int GetKeyFromName(this Sdl thisApi, Span<byte> name)
        {
            // SpanOverloader
            return thisApi.GetKeyFromName(ref name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        public static unsafe void SetTextInputRect(this Sdl thisApi, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.SetTextInputRect(ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        public static unsafe SdlBool IsScreenKeyboardShown(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.IsScreenKeyboardShown(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe uint GetMouseState(this Sdl thisApi, int* x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetMouseState(x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe uint GetMouseState(this Sdl thisApi, Span<int> x, int* y)
        {
            // SpanOverloader
            return thisApi.GetMouseState(ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe uint GetMouseState(this Sdl thisApi, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetMouseState(ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe uint GetGlobalMouseState(this Sdl thisApi, int* x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetGlobalMouseState(x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe uint GetGlobalMouseState(this Sdl thisApi, Span<int> x, int* y)
        {
            // SpanOverloader
            return thisApi.GetGlobalMouseState(ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe uint GetGlobalMouseState(this Sdl thisApi, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetGlobalMouseState(ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe uint GetRelativeMouseState(this Sdl thisApi, int* x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetRelativeMouseState(x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe uint GetRelativeMouseState(this Sdl thisApi, Span<int> x, int* y)
        {
            // SpanOverloader
            return thisApi.GetRelativeMouseState(ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe uint GetRelativeMouseState(this Sdl thisApi, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetRelativeMouseState(ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 132, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe void WarpMouseInWindow(this Sdl thisApi, Span<Window> window, int x, int y)
        {
            // SpanOverloader
            thisApi.WarpMouseInWindow(ref window.GetPinnableReference(), x, y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe Cursor* CreateCursor(this Sdl thisApi, byte* data, Span<byte> mask, int w, int h, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateCursor(data, ref mask.GetPinnableReference(), w, h, hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe Cursor* CreateCursor(this Sdl thisApi, Span<byte> data, byte* mask, int w, int h, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateCursor(ref data.GetPinnableReference(), mask, w, h, hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe Cursor* CreateCursor(this Sdl thisApi, Span<byte> data, Span<byte> mask, int w, int h, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateCursor(ref data.GetPinnableReference(), ref mask.GetPinnableReference(), w, h, hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe Cursor* CreateCursor(this Sdl thisApi, Span<byte> data, string mask, int w, int h, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateCursor(ref data.GetPinnableReference(), mask, w, h, hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe Cursor* CreateCursor(this Sdl thisApi, string data, Span<byte> mask, int w, int h, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateCursor(data, ref mask.GetPinnableReference(), w, h, hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe Cursor* CreateColorCursor(this Sdl thisApi, Span<Surface> surface, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateColorCursor(ref surface.GetPinnableReference(), hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 244, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe void SetCursor(this Sdl thisApi, Span<Cursor> cursor)
        {
            // SpanOverloader
            thisApi.SetCursor(ref cursor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        public static unsafe void FreeCursor(this Sdl thisApi, Span<Cursor> cursor)
        {
            // SpanOverloader
            thisApi.FreeCursor(ref cursor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe byte* JoystickName(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickName(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 213, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickGetPlayerIndex(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickGetPlayerIndex(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe void JoystickSetPlayerIndex(this Sdl thisApi, Span<Joystick> joystick, int player_index)
        {
            // SpanOverloader
            thisApi.JoystickSetPlayerIndex(ref joystick.GetPinnableReference(), player_index);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 223, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe JoystickGUID JoystickGetGUID(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickGetGUID(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe ushort JoystickGetVendor(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickGetVendor(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe ushort JoystickGetProduct(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickGetProduct(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe ushort JoystickGetProductVersion(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickGetProductVersion(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe JoystickType JoystickGetType(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickGetType(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 252, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe void JoystickGetGUIDString(this Sdl thisApi, JoystickGUID guid, Span<byte> pszGUID, int cbGUID)
        {
            // SpanOverloader
            thisApi.JoystickGetGUIDString(guid, ref pszGUID.GetPinnableReference(), cbGUID);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe JoystickGUID JoystickGetGUIDFromString(this Sdl thisApi, Span<byte> pchGUID)
        {
            // SpanOverloader
            return thisApi.JoystickGetGUIDFromString(ref pchGUID.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 262, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe SdlBool JoystickGetAttached(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickGetAttached(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 40 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickInstanceID(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickInstanceID(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickNumAxes(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickNumAxes(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 280, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickNumBalls(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickNumBalls(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickNumHats(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickNumHats(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickNumButtons(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickNumButtons(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe short JoystickGetAxis(this Sdl thisApi, Span<Joystick> joystick, int axis)
        {
            // SpanOverloader
            return thisApi.JoystickGetAxis(ref joystick.GetPinnableReference(), axis);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe SdlBool JoystickGetAxisInitialState(this Sdl thisApi, Joystick* joystick, int axis, Span<short> state)
        {
            // SpanOverloader
            return thisApi.JoystickGetAxisInitialState(joystick, axis, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe SdlBool JoystickGetAxisInitialState(this Sdl thisApi, Span<Joystick> joystick, int axis, short* state)
        {
            // SpanOverloader
            return thisApi.JoystickGetAxisInitialState(ref joystick.GetPinnableReference(), axis, state);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe SdlBool JoystickGetAxisInitialState(this Sdl thisApi, Span<Joystick> joystick, int axis, Span<short> state)
        {
            // SpanOverloader
            return thisApi.JoystickGetAxisInitialState(ref joystick.GetPinnableReference(), axis, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 366, Column 31 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe byte JoystickGetHat(this Sdl thisApi, Span<Joystick> joystick, int hat)
        {
            // SpanOverloader
            return thisApi.JoystickGetHat(ref joystick.GetPinnableReference(), hat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickGetBall(this Sdl thisApi, Joystick* joystick, int ball, int* dx, Span<int> dy)
        {
            // SpanOverloader
            return thisApi.JoystickGetBall(joystick, ball, dx, ref dy.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickGetBall(this Sdl thisApi, Joystick* joystick, int ball, Span<int> dx, int* dy)
        {
            // SpanOverloader
            return thisApi.JoystickGetBall(joystick, ball, ref dx.GetPinnableReference(), dy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickGetBall(this Sdl thisApi, Joystick* joystick, int ball, Span<int> dx, Span<int> dy)
        {
            // SpanOverloader
            return thisApi.JoystickGetBall(joystick, ball, ref dx.GetPinnableReference(), ref dy.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickGetBall(this Sdl thisApi, Span<Joystick> joystick, int ball, int* dx, int* dy)
        {
            // SpanOverloader
            return thisApi.JoystickGetBall(ref joystick.GetPinnableReference(), ball, dx, dy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickGetBall(this Sdl thisApi, Span<Joystick> joystick, int ball, int* dx, Span<int> dy)
        {
            // SpanOverloader
            return thisApi.JoystickGetBall(ref joystick.GetPinnableReference(), ball, dx, ref dy.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickGetBall(this Sdl thisApi, Span<Joystick> joystick, int ball, Span<int> dx, int* dy)
        {
            // SpanOverloader
            return thisApi.JoystickGetBall(ref joystick.GetPinnableReference(), ball, ref dx.GetPinnableReference(), dy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickGetBall(this Sdl thisApi, Span<Joystick> joystick, int ball, Span<int> dx, Span<int> dy)
        {
            // SpanOverloader
            return thisApi.JoystickGetBall(ref joystick.GetPinnableReference(), ball, ref dx.GetPinnableReference(), ref dy.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 384, Column 31 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe byte JoystickGetButton(this Sdl thisApi, Span<Joystick> joystick, int button)
        {
            // SpanOverloader
            return thisApi.JoystickGetButton(ref joystick.GetPinnableReference(), button);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe int JoystickRumble(this Sdl thisApi, Span<Joystick> joystick, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms)
        {
            // SpanOverloader
            return thisApi.JoystickRumble(ref joystick.GetPinnableReference(), low_frequency_rumble, high_frequency_rumble, duration_ms);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 403, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe void JoystickClose(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            thisApi.JoystickClose(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 408, Column 48 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        public static unsafe JoystickPowerLevel JoystickCurrentPowerLevel(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickCurrentPowerLevel(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe int GameControllerAddMappingsFromRW(this Sdl thisApi, Span<RWops> rw, int freerw)
        {
            // SpanOverloader
            return thisApi.GameControllerAddMappingsFromRW(ref rw.GetPinnableReference(), freerw);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe int GameControllerAddMapping(this Sdl thisApi, Span<byte> mappingString)
        {
            // SpanOverloader
            return thisApi.GameControllerAddMapping(ref mappingString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 173, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe byte* GameControllerMapping(this Sdl thisApi, Span<GameController> gamecontroller)
        {
            // SpanOverloader
            return thisApi.GameControllerMapping(ref gamecontroller.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe byte* GameControllerName(this Sdl thisApi, Span<GameController> gamecontroller)
        {
            // SpanOverloader
            return thisApi.GameControllerName(ref gamecontroller.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe GameControllerType GameControllerGetType(this Sdl thisApi, Span<GameController> gamecontroller)
        {
            // SpanOverloader
            return thisApi.GameControllerGetType(ref gamecontroller.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetPlayerIndex(this Sdl thisApi, Span<GameController> gamecontroller)
        {
            // SpanOverloader
            return thisApi.GameControllerGetPlayerIndex(ref gamecontroller.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe void GameControllerSetPlayerIndex(this Sdl thisApi, Span<GameController> gamecontroller, int player_index)
        {
            // SpanOverloader
            thisApi.GameControllerSetPlayerIndex(ref gamecontroller.GetPinnableReference(), player_index);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe ushort GameControllerGetVendor(this Sdl thisApi, Span<GameController> gamecontroller)
        {
            // SpanOverloader
            return thisApi.GameControllerGetVendor(ref gamecontroller.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe ushort GameControllerGetProduct(this Sdl thisApi, Span<GameController> gamecontroller)
        {
            // SpanOverloader
            return thisApi.GameControllerGetProduct(ref gamecontroller.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe ushort GameControllerGetProductVersion(this Sdl thisApi, Span<GameController> gamecontroller)
        {
            // SpanOverloader
            return thisApi.GameControllerGetProductVersion(ref gamecontroller.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 34 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe SdlBool GameControllerGetAttached(this Sdl thisApi, Span<GameController> gamecontroller)
        {
            // SpanOverloader
            return thisApi.GameControllerGetAttached(ref gamecontroller.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 271, Column 39 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe Joystick* GameControllerGetJoystick(this Sdl thisApi, Span<GameController> gamecontroller)
        {
            // SpanOverloader
            return thisApi.GameControllerGetJoystick(ref gamecontroller.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe GameControllerAxis GameControllerGetAxisFromString(this Sdl thisApi, Span<byte> pchString)
        {
            // SpanOverloader
            return thisApi.GameControllerGetAxisFromString(ref pchString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 328, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe GameControllerButtonBind GameControllerGetBindForAxis(this Sdl thisApi, Span<GameController> gamecontroller, GameControllerAxis axis)
        {
            // SpanOverloader
            return thisApi.GameControllerGetBindForAxis(ref gamecontroller.GetPinnableReference(), axis);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe short GameControllerGetAxis(this Sdl thisApi, Span<GameController> gamecontroller, GameControllerAxis axis)
        {
            // SpanOverloader
            return thisApi.GameControllerGetAxis(ref gamecontroller.GetPinnableReference(), axis);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 370, Column 50 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe GameControllerButton GameControllerGetButtonFromString(this Sdl thisApi, Span<byte> pchString)
        {
            // SpanOverloader
            return thisApi.GameControllerGetButtonFromString(ref pchString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 381, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe GameControllerButtonBind GameControllerGetBindForButton(this Sdl thisApi, Span<GameController> gamecontroller, GameControllerButton button)
        {
            // SpanOverloader
            return thisApi.GameControllerGetBindForButton(ref gamecontroller.GetPinnableReference(), button);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 390, Column 31 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe byte GameControllerGetButton(this Sdl thisApi, Span<GameController> gamecontroller, GameControllerButton button)
        {
            // SpanOverloader
            return thisApi.GameControllerGetButton(ref gamecontroller.GetPinnableReference(), button);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe int GameControllerRumble(this Sdl thisApi, Span<GameController> gamecontroller, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms)
        {
            // SpanOverloader
            return thisApi.GameControllerRumble(ref gamecontroller.GetPinnableReference(), low_frequency_rumble, high_frequency_rumble, duration_ms);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 409, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        public static unsafe void GameControllerClose(this Sdl thisApi, Span<GameController> gamecontroller)
        {
            // SpanOverloader
            thisApi.GameControllerClose(ref gamecontroller.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        public static unsafe int SaveAllDollarTemplates(this Sdl thisApi, Span<RWops> dst)
        {
            // SpanOverloader
            return thisApi.SaveAllDollarTemplates(ref dst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 68, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        public static unsafe int SaveDollarTemplate(this Sdl thisApi, long gestureId, Span<RWops> dst)
        {
            // SpanOverloader
            return thisApi.SaveDollarTemplate(gestureId, ref dst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        public static unsafe int LoadDollarTemplates(this Sdl thisApi, long touchId, Span<RWops> src)
        {
            // SpanOverloader
            return thisApi.LoadDollarTemplates(touchId, ref src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe int PeepEvents(this Sdl thisApi, Span<Event> events, int numevents, Eventaction action, uint minType, uint maxType)
        {
            // SpanOverloader
            return thisApi.PeepEvents(ref events.GetPinnableReference(), numevents, action, minType, maxType);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe int PollEvent(this Sdl thisApi, Span<Event> @event)
        {
            // SpanOverloader
            return thisApi.PollEvent(ref @event.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 677, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe int WaitEvent(this Sdl thisApi, Span<Event> @event)
        {
            // SpanOverloader
            return thisApi.WaitEvent(ref @event.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe int WaitEventTimeout(this Sdl thisApi, Span<Event> @event, int timeout)
        {
            // SpanOverloader
            return thisApi.WaitEventTimeout(ref @event.GetPinnableReference(), timeout);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe int PushEvent(this Sdl thisApi, Span<Event> @event)
        {
            // SpanOverloader
            return thisApi.PushEvent(ref @event.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe void SetEventFilter<T0>(this Sdl thisApi, PfnVvSDLEventvI filter, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetEventFilter(filter, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 734, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe SdlBool GetEventFilter(this Sdl thisApi, Span<PfnEventFilter> filter, void** userdata)
        {
            // SpanOverloader
            return thisApi.GetEventFilter(ref filter.GetPinnableReference(), userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 734, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe SdlBool GetEventFilter(this Sdl thisApi, Span<PfnEventFilter> filter, ref void* userdata)
        {
            // SpanOverloader
            return thisApi.GetEventFilter(ref filter.GetPinnableReference(), ref userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 740, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe void AddEventWatch<T0>(this Sdl thisApi, PfnEventFilter filter, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AddEventWatch(filter, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 746, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe void DelEventWatch<T0>(this Sdl thisApi, PfnEventFilter filter, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DelEventWatch(filter, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        public static unsafe void FilterEvents<T0>(this Sdl thisApi, PfnEventFilter filter, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FilterEvents(filter, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        public static unsafe byte* GetPrefPath(this Sdl thisApi, byte* org, Span<byte> app)
        {
            // SpanOverloader
            return thisApi.GetPrefPath(org, ref app.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        public static unsafe byte* GetPrefPath(this Sdl thisApi, Span<byte> org, byte* app)
        {
            // SpanOverloader
            return thisApi.GetPrefPath(ref org.GetPinnableReference(), app);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        public static unsafe byte* GetPrefPath(this Sdl thisApi, Span<byte> org, Span<byte> app)
        {
            // SpanOverloader
            return thisApi.GetPrefPath(ref org.GetPinnableReference(), ref app.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        public static unsafe byte* GetPrefPath(this Sdl thisApi, Span<byte> org, string app)
        {
            // SpanOverloader
            return thisApi.GetPrefPath(ref org.GetPinnableReference(), app);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        public static unsafe byte* GetPrefPath(this Sdl thisApi, string org, Span<byte> app)
        {
            // SpanOverloader
            return thisApi.GetPrefPath(org, ref app.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 878, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticIndex(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticIndex(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int JoystickIsHaptic(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.JoystickIsHaptic(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 927, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe Haptic* HapticOpenFromJoystick(this Sdl thisApi, Span<Joystick> joystick)
        {
            // SpanOverloader
            return thisApi.HapticOpenFromJoystick(ref joystick.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 935, Column 30 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe void HapticClose(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            thisApi.HapticClose(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticNumEffects(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticNumEffects(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 967, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticNumEffectsPlaying(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticNumEffectsPlaying(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 38 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe uint HapticQuery(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticQuery(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticNumAxes(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticNumAxes(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticEffectSupported(this Sdl thisApi, Haptic* haptic, Span<HapticEffect> effect)
        {
            // SpanOverloader
            return thisApi.HapticEffectSupported(haptic, ref effect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticEffectSupported(this Sdl thisApi, Span<Haptic> haptic, HapticEffect* effect)
        {
            // SpanOverloader
            return thisApi.HapticEffectSupported(ref haptic.GetPinnableReference(), effect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticEffectSupported(this Sdl thisApi, Span<Haptic> haptic, Span<HapticEffect> effect)
        {
            // SpanOverloader
            return thisApi.HapticEffectSupported(ref haptic.GetPinnableReference(), ref effect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticNewEffect(this Sdl thisApi, Haptic* haptic, Span<HapticEffect> effect)
        {
            // SpanOverloader
            return thisApi.HapticNewEffect(haptic, ref effect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticNewEffect(this Sdl thisApi, Span<Haptic> haptic, HapticEffect* effect)
        {
            // SpanOverloader
            return thisApi.HapticNewEffect(ref haptic.GetPinnableReference(), effect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticNewEffect(this Sdl thisApi, Span<Haptic> haptic, Span<HapticEffect> effect)
        {
            // SpanOverloader
            return thisApi.HapticNewEffect(ref haptic.GetPinnableReference(), ref effect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticUpdateEffect(this Sdl thisApi, Haptic* haptic, int effect, Span<HapticEffect> data)
        {
            // SpanOverloader
            return thisApi.HapticUpdateEffect(haptic, effect, ref data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticUpdateEffect(this Sdl thisApi, Span<Haptic> haptic, int effect, HapticEffect* data)
        {
            // SpanOverloader
            return thisApi.HapticUpdateEffect(ref haptic.GetPinnableReference(), effect, data);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticUpdateEffect(this Sdl thisApi, Span<Haptic> haptic, int effect, Span<HapticEffect> data)
        {
            // SpanOverloader
            return thisApi.HapticUpdateEffect(ref haptic.GetPinnableReference(), effect, ref data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1062, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticRunEffect(this Sdl thisApi, Span<Haptic> haptic, int effect, uint iterations)
        {
            // SpanOverloader
            return thisApi.HapticRunEffect(ref haptic.GetPinnableReference(), effect, iterations);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticStopEffect(this Sdl thisApi, Span<Haptic> haptic, int effect)
        {
            // SpanOverloader
            return thisApi.HapticStopEffect(ref haptic.GetPinnableReference(), effect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1090, Column 30 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe void HapticDestroyEffect(this Sdl thisApi, Span<Haptic> haptic, int effect)
        {
            // SpanOverloader
            thisApi.HapticDestroyEffect(ref haptic.GetPinnableReference(), effect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticGetEffectStatus(this Sdl thisApi, Span<Haptic> haptic, int effect)
        {
            // SpanOverloader
            return thisApi.HapticGetEffectStatus(ref haptic.GetPinnableReference(), effect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1124, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticSetGain(this Sdl thisApi, Span<Haptic> haptic, int gain)
        {
            // SpanOverloader
            return thisApi.HapticSetGain(ref haptic.GetPinnableReference(), gain);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1140, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticSetAutocenter(this Sdl thisApi, Span<Haptic> haptic, int autocenter)
        {
            // SpanOverloader
            return thisApi.HapticSetAutocenter(ref haptic.GetPinnableReference(), autocenter);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1157, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticPause(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticPause(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1169, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticUnpause(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticUnpause(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticStopAll(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticStopAll(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticRumbleSupported(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticRumbleSupported(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1202, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticRumbleInit(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticRumbleInit(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1216, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticRumblePlay(this Sdl thisApi, Span<Haptic> haptic, float strength, uint length)
        {
            // SpanOverloader
            return thisApi.HapticRumblePlay(ref haptic.GetPinnableReference(), strength, length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1228, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        public static unsafe int HapticRumbleStop(this Sdl thisApi, Span<Haptic> haptic)
        {
            // SpanOverloader
            return thisApi.HapticRumbleStop(ref haptic.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool SetHintWithPriority(this Sdl thisApi, byte* name, Span<byte> value, HintPriority priority)
        {
            // SpanOverloader
            return thisApi.SetHintWithPriority(name, ref value.GetPinnableReference(), priority);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool SetHintWithPriority(this Sdl thisApi, Span<byte> name, byte* value, HintPriority priority)
        {
            // SpanOverloader
            return thisApi.SetHintWithPriority(ref name.GetPinnableReference(), value, priority);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool SetHintWithPriority(this Sdl thisApi, Span<byte> name, Span<byte> value, HintPriority priority)
        {
            // SpanOverloader
            return thisApi.SetHintWithPriority(ref name.GetPinnableReference(), ref value.GetPinnableReference(), priority);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool SetHintWithPriority(this Sdl thisApi, Span<byte> name, string value, HintPriority priority)
        {
            // SpanOverloader
            return thisApi.SetHintWithPriority(ref name.GetPinnableReference(), value, priority);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool SetHintWithPriority(this Sdl thisApi, string name, Span<byte> value, HintPriority priority)
        {
            // SpanOverloader
            return thisApi.SetHintWithPriority(name, ref value.GetPinnableReference(), priority);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool SetHint(this Sdl thisApi, byte* name, Span<byte> value)
        {
            // SpanOverloader
            return thisApi.SetHint(name, ref value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool SetHint(this Sdl thisApi, Span<byte> name, byte* value)
        {
            // SpanOverloader
            return thisApi.SetHint(ref name.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool SetHint(this Sdl thisApi, Span<byte> name, Span<byte> value)
        {
            // SpanOverloader
            return thisApi.SetHint(ref name.GetPinnableReference(), ref value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool SetHint(this Sdl thisApi, Span<byte> name, string value)
        {
            // SpanOverloader
            return thisApi.SetHint(ref name.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool SetHint(this Sdl thisApi, string name, Span<byte> value)
        {
            // SpanOverloader
            return thisApi.SetHint(name, ref value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1312, Column 38 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe byte* GetHint(this Sdl thisApi, Span<byte> name)
        {
            // SpanOverloader
            return thisApi.GetHint(ref name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1319, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe SdlBool GetHintBoolean(this Sdl thisApi, Span<byte> name, SdlBool default_value)
        {
            // SpanOverloader
            return thisApi.GetHintBoolean(ref name.GetPinnableReference(), default_value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe void AddHintCallback<T0>(this Sdl thisApi, byte* name, PfnVvBvBvBvV callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AddHintCallback(name, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe void AddHintCallback(this Sdl thisApi, Span<byte> name, PfnVvBvBvBvV callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AddHintCallback(ref name.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe void AddHintCallback<T0>(this Sdl thisApi, Span<byte> name, PfnVvBvBvBvV callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AddHintCallback(ref name.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe void AddHintCallback<T0>(this Sdl thisApi, string name, PfnVvBvBvBvV callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AddHintCallback(name, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe void DelHintCallback<T0>(this Sdl thisApi, byte* name, PfnHintCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DelHintCallback(name, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe void DelHintCallback(this Sdl thisApi, Span<byte> name, PfnHintCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DelHintCallback(ref name.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe void DelHintCallback<T0>(this Sdl thisApi, Span<byte> name, PfnHintCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DelHintCallback(ref name.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        public static unsafe void DelHintCallback<T0>(this Sdl thisApi, string name, PfnHintCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DelHintCallback(name, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 58, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        public static unsafe void* LoadObject(this Sdl thisApi, Span<byte> sofile)
        {
            // SpanOverloader
            return thisApi.LoadObject(ref sofile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        public static unsafe void* LoadFunction(this Sdl thisApi, void* handle, Span<byte> name)
        {
            // SpanOverloader
            return thisApi.LoadFunction(handle, ref name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        public static unsafe void* LoadFunction<T0>(this Sdl thisApi, Span<T0> handle, byte* name) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoadFunction(ref handle.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        public static unsafe void* LoadFunction<T0>(this Sdl thisApi, Span<T0> handle, Span<byte> name) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoadFunction(ref handle.GetPinnableReference(), ref name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        public static unsafe void* LoadFunction<T0>(this Sdl thisApi, Span<T0> handle, string name) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoadFunction(ref handle.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 30 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        public static unsafe void UnloadObject<T0>(this Sdl thisApi, Span<T0> handle) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UnloadObject(ref handle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 140, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void Log(this Sdl thisApi, Span<byte> fmt)
        {
            // SpanOverloader
            thisApi.Log(ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogVerbose(this Sdl thisApi, int category, Span<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogVerbose(category, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogDebug(this Sdl thisApi, int category, Span<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogDebug(category, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogInfo(this Sdl thisApi, int category, Span<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogInfo(category, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogWarn(this Sdl thisApi, int category, Span<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogWarn(category, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogError(this Sdl thisApi, int category, Span<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogError(category, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogCritical(this Sdl thisApi, int category, Span<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogCritical(category, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogMessage(this Sdl thisApi, int category, LogPriority priority, Span<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogMessage(category, priority, ref fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogMessageV(this Sdl thisApi, int category, LogPriority priority, byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            thisApi.LogMessageV(category, priority, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogMessageV(this Sdl thisApi, int category, LogPriority priority, Span<byte> fmt, byte* ap)
        {
            // SpanOverloader
            thisApi.LogMessageV(category, priority, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogMessageV(this Sdl thisApi, int category, LogPriority priority, Span<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            thisApi.LogMessageV(category, priority, ref fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogMessageV(this Sdl thisApi, int category, LogPriority priority, Span<byte> fmt, string ap)
        {
            // SpanOverloader
            thisApi.LogMessageV(category, priority, ref fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogMessageV(this Sdl thisApi, int category, LogPriority priority, string fmt, Span<byte> ap)
        {
            // SpanOverloader
            thisApi.LogMessageV(category, priority, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogGetOutputFunction(this Sdl thisApi, Span<PfnVvISDLLogPriorityBvV> callback, void** userdata)
        {
            // SpanOverloader
            thisApi.LogGetOutputFunction(ref callback.GetPinnableReference(), userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogGetOutputFunction(this Sdl thisApi, Span<PfnVvISDLLogPriorityBvV> callback, ref void* userdata)
        {
            // SpanOverloader
            thisApi.LogGetOutputFunction(ref callback.GetPinnableReference(), ref userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        public static unsafe void LogSetOutputFunction<T0>(this Sdl thisApi, PfnLogOutputFunction callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogSetOutputFunction(callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowMessageBox(this Sdl thisApi, MessageBoxData* messageboxdata, Span<int> buttonid)
        {
            // SpanOverloader
            return thisApi.ShowMessageBox(messageboxdata, ref buttonid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowMessageBox(this Sdl thisApi, Span<MessageBoxData> messageboxdata, int* buttonid)
        {
            // SpanOverloader
            return thisApi.ShowMessageBox(ref messageboxdata.GetPinnableReference(), buttonid);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowMessageBox(this Sdl thisApi, Span<MessageBoxData> messageboxdata, Span<int> buttonid)
        {
            // SpanOverloader
            return thisApi.ShowMessageBox(ref messageboxdata.GetPinnableReference(), ref buttonid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, byte* title, byte* message, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, title, message, ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, byte* title, Span<byte> message, Window* window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, title, ref message.GetPinnableReference(), window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, byte* title, Span<byte> message, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, title, ref message.GetPinnableReference(), ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, byte* title, string message, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, title, message, ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, Span<byte> title, byte* message, Window* window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, ref title.GetPinnableReference(), message, window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, Span<byte> title, byte* message, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, ref title.GetPinnableReference(), message, ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, Span<byte> title, Span<byte> message, Window* window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, ref title.GetPinnableReference(), ref message.GetPinnableReference(), window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, Span<byte> title, Span<byte> message, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, ref title.GetPinnableReference(), ref message.GetPinnableReference(), ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, Span<byte> title, string message, Window* window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, ref title.GetPinnableReference(), message, window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, Span<byte> title, string message, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, ref title.GetPinnableReference(), message, ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, string title, byte* message, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, title, message, ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, string title, Span<byte> message, Window* window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, title, ref message.GetPinnableReference(), window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, string title, Span<byte> message, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, title, ref message.GetPinnableReference(), ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, string title, string message, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, title, message, ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 39 in build/submodules/SDL-mirror/include\\SDL_metal.h")]
        public static unsafe void* MetalCreateView(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.MetalCreateView(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 81, Column 30 in build/submodules/SDL-mirror/include\\SDL_metal.h")]
        public static unsafe void MetalDestroyView<T0>(this Sdl thisApi, Span<T0> view) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MetalDestroyView(ref view.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 40 in build/submodules/SDL-mirror/include\\SDL_power.h")]
        public static unsafe PowerState GetPowerInfo(this Sdl thisApi, int* secs, Span<int> pct)
        {
            // SpanOverloader
            return thisApi.GetPowerInfo(secs, ref pct.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 40 in build/submodules/SDL-mirror/include\\SDL_power.h")]
        public static unsafe PowerState GetPowerInfo(this Sdl thisApi, Span<int> secs, int* pct)
        {
            // SpanOverloader
            return thisApi.GetPowerInfo(ref secs.GetPinnableReference(), pct);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 40 in build/submodules/SDL-mirror/include\\SDL_power.h")]
        public static unsafe PowerState GetPowerInfo(this Sdl thisApi, Span<int> secs, Span<int> pct)
        {
            // SpanOverloader
            return thisApi.GetPowerInfo(ref secs.GetPinnableReference(), ref pct.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDriverInfo(this Sdl thisApi, int index, Span<RendererInfo> info)
        {
            // SpanOverloader
            return thisApi.GetRenderDriverInfo(index, ref info.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 201, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe Renderer* CreateRenderer(this Sdl thisApi, Span<Window> window, int index, uint flags)
        {
            // SpanOverloader
            return thisApi.CreateRenderer(ref window.GetPinnableReference(), index, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 214, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe Renderer* CreateSoftwareRenderer(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.CreateSoftwareRenderer(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe Renderer* GetRenderer(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.GetRenderer(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRendererInfo(this Sdl thisApi, Renderer* renderer, Span<RendererInfo> info)
        {
            // SpanOverloader
            return thisApi.GetRendererInfo(renderer, ref info.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRendererInfo(this Sdl thisApi, Span<Renderer> renderer, RendererInfo* info)
        {
            // SpanOverloader
            return thisApi.GetRendererInfo(ref renderer.GetPinnableReference(), info);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRendererInfo(this Sdl thisApi, Span<Renderer> renderer, Span<RendererInfo> info)
        {
            // SpanOverloader
            return thisApi.GetRendererInfo(ref renderer.GetPinnableReference(), ref info.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRendererOutputSize(this Sdl thisApi, Renderer* renderer, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.GetRendererOutputSize(renderer, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRendererOutputSize(this Sdl thisApi, Renderer* renderer, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.GetRendererOutputSize(renderer, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRendererOutputSize(this Sdl thisApi, Renderer* renderer, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.GetRendererOutputSize(renderer, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRendererOutputSize(this Sdl thisApi, Span<Renderer> renderer, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.GetRendererOutputSize(ref renderer.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRendererOutputSize(this Sdl thisApi, Span<Renderer> renderer, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.GetRendererOutputSize(ref renderer.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRendererOutputSize(this Sdl thisApi, Span<Renderer> renderer, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.GetRendererOutputSize(ref renderer.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRendererOutputSize(this Sdl thisApi, Span<Renderer> renderer, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.GetRendererOutputSize(ref renderer.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 252, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe Texture* CreateTexture(this Sdl thisApi, Span<Renderer> renderer, uint format, int access, int w, int h)
        {
            // SpanOverloader
            return thisApi.CreateTexture(ref renderer.GetPinnableReference(), format, access, w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe Texture* CreateTextureFromSurface(this Sdl thisApi, Renderer* renderer, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.CreateTextureFromSurface(renderer, ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe Texture* CreateTextureFromSurface(this Sdl thisApi, Span<Renderer> renderer, Surface* surface)
        {
            // SpanOverloader
            return thisApi.CreateTextureFromSurface(ref renderer.GetPinnableReference(), surface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe Texture* CreateTextureFromSurface(this Sdl thisApi, Span<Renderer> renderer, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.CreateTextureFromSurface(ref renderer.GetPinnableReference(), ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, int* access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, access, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, int* access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, access, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, int* access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, access, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, Span<int> access, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, ref access.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, Span<int> access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, ref access.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, Span<int> access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, ref access.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, Span<int> access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, ref access.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, int* access, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), access, w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, int* access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), access, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, int* access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), access, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, int* access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), access, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, Span<int> access, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), ref access.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, Span<int> access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), ref access.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, Span<int> access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), ref access.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, Span<int> access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), ref access.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, uint* format, int* access, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), format, access, w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, uint* format, int* access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), format, access, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, uint* format, int* access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), format, access, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, uint* format, int* access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), format, access, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, uint* format, Span<int> access, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), format, ref access.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, uint* format, Span<int> access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), format, ref access.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, uint* format, Span<int> access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), format, ref access.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, uint* format, Span<int> access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), format, ref access.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, Span<uint> format, int* access, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), ref format.GetPinnableReference(), access, w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, Span<uint> format, int* access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), ref format.GetPinnableReference(), access, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, Span<uint> format, int* access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), ref format.GetPinnableReference(), access, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, Span<uint> format, int* access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), ref format.GetPinnableReference(), access, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, Span<uint> format, Span<int> access, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), ref format.GetPinnableReference(), ref access.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, Span<uint> format, Span<int> access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), ref format.GetPinnableReference(), ref access.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, Span<uint> format, Span<int> access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), ref format.GetPinnableReference(), ref access.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Span<Texture> texture, Span<uint> format, Span<int> access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(ref texture.GetPinnableReference(), ref format.GetPinnableReference(), ref access.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 302, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int SetTextureColorMod(this Sdl thisApi, Span<Texture> texture, byte r, byte g, byte b)
        {
            // SpanOverloader
            return thisApi.SetTextureColorMod(ref texture.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, byte* r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, byte* r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, byte* g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, string g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, string r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, string r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, byte* r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, byte* r, byte* g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, byte* r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, byte* r, string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, byte* r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, byte* r, string g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, Span<byte> r, byte* g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, Span<byte> r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, Span<byte> r, string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, Span<byte> r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, Span<byte> r, string g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, string r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, string r, byte* g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, string r, Span<byte> g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, string r, string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, string r, string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Span<Texture> texture, string r, string g, string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(ref texture.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 333, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int SetTextureAlphaMod(this Sdl thisApi, Span<Texture> texture, byte alpha)
        {
            // SpanOverloader
            return thisApi.SetTextureAlphaMod(ref texture.GetPinnableReference(), alpha);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureAlphaMod(this Sdl thisApi, Texture* texture, Span<byte> alpha)
        {
            // SpanOverloader
            return thisApi.GetTextureAlphaMod(texture, ref alpha.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureAlphaMod(this Sdl thisApi, Span<Texture> texture, byte* alpha)
        {
            // SpanOverloader
            return thisApi.GetTextureAlphaMod(ref texture.GetPinnableReference(), alpha);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureAlphaMod(this Sdl thisApi, Span<Texture> texture, Span<byte> alpha)
        {
            // SpanOverloader
            return thisApi.GetTextureAlphaMod(ref texture.GetPinnableReference(), ref alpha.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureAlphaMod(this Sdl thisApi, Span<Texture> texture, string alpha)
        {
            // SpanOverloader
            return thisApi.GetTextureAlphaMod(ref texture.GetPinnableReference(), alpha);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int SetTextureBlendMode(this Sdl thisApi, Span<Texture> texture, BlendMode blendMode)
        {
            // SpanOverloader
            return thisApi.SetTextureBlendMode(ref texture.GetPinnableReference(), blendMode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureBlendMode(this Sdl thisApi, Texture* texture, Span<BlendMode> blendMode)
        {
            // SpanOverloader
            return thisApi.GetTextureBlendMode(texture, ref blendMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureBlendMode(this Sdl thisApi, Span<Texture> texture, BlendMode* blendMode)
        {
            // SpanOverloader
            return thisApi.GetTextureBlendMode(ref texture.GetPinnableReference(), blendMode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureBlendMode(this Sdl thisApi, Span<Texture> texture, Span<BlendMode> blendMode)
        {
            // SpanOverloader
            return thisApi.GetTextureBlendMode(ref texture.GetPinnableReference(), ref blendMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 392, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int SetTextureScaleMode(this Sdl thisApi, Span<Texture> texture, ScaleMode scaleMode)
        {
            // SpanOverloader
            return thisApi.SetTextureScaleMode(ref texture.GetPinnableReference(), scaleMode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureScaleMode(this Sdl thisApi, Texture* texture, Span<ScaleMode> scaleMode)
        {
            // SpanOverloader
            return thisApi.GetTextureScaleMode(texture, ref scaleMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureScaleMode(this Sdl thisApi, Span<Texture> texture, ScaleMode* scaleMode)
        {
            // SpanOverloader
            return thisApi.GetTextureScaleMode(ref texture.GetPinnableReference(), scaleMode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetTextureScaleMode(this Sdl thisApi, Span<Texture> texture, Span<ScaleMode> scaleMode)
        {
            // SpanOverloader
            return thisApi.GetTextureScaleMode(ref texture.GetPinnableReference(), ref scaleMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateTexture<T0>(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Span<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.UpdateTexture(texture, rect, ref pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, void* pixels, int pitch)
        {
            // SpanOverloader
            return thisApi.UpdateTexture(texture, ref rect.GetPinnableReference(), pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateTexture<T0>(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.UpdateTexture(texture, ref rect.GetPinnableReference(), ref pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, void* pixels, int pitch)
        {
            // SpanOverloader
            return thisApi.UpdateTexture(ref texture.GetPinnableReference(), rect, pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateTexture<T0>(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Span<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.UpdateTexture(ref texture.GetPinnableReference(), rect, ref pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, void* pixels, int pitch)
        {
            // SpanOverloader
            return thisApi.UpdateTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateTexture<T0>(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.UpdateTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), rect, Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Span<byte> Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, Span<byte> Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, ref Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, string Uplane, int Upitch, Span<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, ref Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, string Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, void** pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, rect, pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref void* pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, rect, ref pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, void** pixels, int* pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, ref rect.GetPinnableReference(), pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, void** pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, ref rect.GetPinnableReference(), pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, ref void* pixels, int* pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, ref rect.GetPinnableReference(), ref pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, ref void* pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, ref rect.GetPinnableReference(), ref pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, void** pixels, int* pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(ref texture.GetPinnableReference(), rect, pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, void** pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(ref texture.GetPinnableReference(), rect, pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, ref void* pixels, int* pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(ref texture.GetPinnableReference(), rect, ref pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, ref void* pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(ref texture.GetPinnableReference(), rect, ref pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, void** pixels, int* pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, void** pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, ref void* pixels, int* pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, ref void* pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTextureToSurface(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Surface** surface)
        {
            // SpanOverloader
            return thisApi.LockTextureToSurface(texture, ref rect.GetPinnableReference(), surface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTextureToSurface(this Sdl thisApi, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> rect, ref Surface* surface)
        {
            // SpanOverloader
            return thisApi.LockTextureToSurface(texture, ref rect.GetPinnableReference(), ref surface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTextureToSurface(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, Surface** surface)
        {
            // SpanOverloader
            return thisApi.LockTextureToSurface(ref texture.GetPinnableReference(), rect, surface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTextureToSurface(this Sdl thisApi, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* rect, ref Surface* surface)
        {
            // SpanOverloader
            return thisApi.LockTextureToSurface(ref texture.GetPinnableReference(), rect, ref surface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTextureToSurface(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, Surface** surface)
        {
            // SpanOverloader
            return thisApi.LockTextureToSurface(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), surface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int LockTextureToSurface(this Sdl thisApi, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> rect, ref Surface* surface)
        {
            // SpanOverloader
            return thisApi.LockTextureToSurface(ref texture.GetPinnableReference(), ref rect.GetPinnableReference(), ref surface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void UnlockTexture(this Sdl thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            thisApi.UnlockTexture(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 507, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe SdlBool RenderTargetSupported(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            return thisApi.RenderTargetSupported(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int SetRenderTarget(this Sdl thisApi, Renderer* renderer, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.SetRenderTarget(renderer, ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int SetRenderTarget(this Sdl thisApi, Span<Renderer> renderer, Texture* texture)
        {
            // SpanOverloader
            return thisApi.SetRenderTarget(ref renderer.GetPinnableReference(), texture);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int SetRenderTarget(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.SetRenderTarget(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe Texture* GetRenderTarget(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            return thisApi.GetRenderTarget(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 554, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderSetLogicalSize(this Sdl thisApi, Span<Renderer> renderer, int w, int h)
        {
            // SpanOverloader
            return thisApi.RenderSetLogicalSize(ref renderer.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetLogicalSize(this Sdl thisApi, Renderer* renderer, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.RenderGetLogicalSize(renderer, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetLogicalSize(this Sdl thisApi, Renderer* renderer, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.RenderGetLogicalSize(renderer, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetLogicalSize(this Sdl thisApi, Renderer* renderer, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.RenderGetLogicalSize(renderer, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetLogicalSize(this Sdl thisApi, Span<Renderer> renderer, int* w, int* h)
        {
            // SpanOverloader
            thisApi.RenderGetLogicalSize(ref renderer.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetLogicalSize(this Sdl thisApi, Span<Renderer> renderer, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.RenderGetLogicalSize(ref renderer.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetLogicalSize(this Sdl thisApi, Span<Renderer> renderer, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.RenderGetLogicalSize(ref renderer.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetLogicalSize(this Sdl thisApi, Span<Renderer> renderer, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.RenderGetLogicalSize(ref renderer.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderSetIntegerScale(this Sdl thisApi, Span<Renderer> renderer, SdlBool enable)
        {
            // SpanOverloader
            return thisApi.RenderSetIntegerScale(ref renderer.GetPinnableReference(), enable);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe SdlBool RenderGetIntegerScale(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            return thisApi.RenderGetIntegerScale(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderSetViewport(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderSetViewport(renderer, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderSetViewport(this Sdl thisApi, Span<Renderer> renderer, Silk.NET.Maths.Rectangle<int>* rect)
        {
            // SpanOverloader
            return thisApi.RenderSetViewport(ref renderer.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderSetViewport(this Sdl thisApi, Span<Renderer> renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderSetViewport(ref renderer.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetViewport(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.RenderGetViewport(renderer, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetViewport(this Sdl thisApi, Span<Renderer> renderer, Silk.NET.Maths.Rectangle<int>* rect)
        {
            // SpanOverloader
            thisApi.RenderGetViewport(ref renderer.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetViewport(this Sdl thisApi, Span<Renderer> renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.RenderGetViewport(ref renderer.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderSetClipRect(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderSetClipRect(renderer, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderSetClipRect(this Sdl thisApi, Span<Renderer> renderer, Silk.NET.Maths.Rectangle<int>* rect)
        {
            // SpanOverloader
            return thisApi.RenderSetClipRect(ref renderer.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderSetClipRect(this Sdl thisApi, Span<Renderer> renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderSetClipRect(ref renderer.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 640, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetClipRect(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.RenderGetClipRect(renderer, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 640, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetClipRect(this Sdl thisApi, Span<Renderer> renderer, Silk.NET.Maths.Rectangle<int>* rect)
        {
            // SpanOverloader
            thisApi.RenderGetClipRect(ref renderer.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 640, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetClipRect(this Sdl thisApi, Span<Renderer> renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.RenderGetClipRect(ref renderer.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 650, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe SdlBool RenderIsClipEnabled(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            return thisApi.RenderIsClipEnabled(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 671, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderSetScale(this Sdl thisApi, Span<Renderer> renderer, float scaleX, float scaleY)
        {
            // SpanOverloader
            return thisApi.RenderSetScale(ref renderer.GetPinnableReference(), scaleX, scaleY);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetScale(this Sdl thisApi, Renderer* renderer, float* scaleX, Span<float> scaleY)
        {
            // SpanOverloader
            thisApi.RenderGetScale(renderer, scaleX, ref scaleY.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetScale(this Sdl thisApi, Renderer* renderer, Span<float> scaleX, float* scaleY)
        {
            // SpanOverloader
            thisApi.RenderGetScale(renderer, ref scaleX.GetPinnableReference(), scaleY);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetScale(this Sdl thisApi, Renderer* renderer, Span<float> scaleX, Span<float> scaleY)
        {
            // SpanOverloader
            thisApi.RenderGetScale(renderer, ref scaleX.GetPinnableReference(), ref scaleY.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetScale(this Sdl thisApi, Span<Renderer> renderer, float* scaleX, float* scaleY)
        {
            // SpanOverloader
            thisApi.RenderGetScale(ref renderer.GetPinnableReference(), scaleX, scaleY);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetScale(this Sdl thisApi, Span<Renderer> renderer, float* scaleX, Span<float> scaleY)
        {
            // SpanOverloader
            thisApi.RenderGetScale(ref renderer.GetPinnableReference(), scaleX, ref scaleY.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetScale(this Sdl thisApi, Span<Renderer> renderer, Span<float> scaleX, float* scaleY)
        {
            // SpanOverloader
            thisApi.RenderGetScale(ref renderer.GetPinnableReference(), ref scaleX.GetPinnableReference(), scaleY);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderGetScale(this Sdl thisApi, Span<Renderer> renderer, Span<float> scaleX, Span<float> scaleY)
        {
            // SpanOverloader
            thisApi.RenderGetScale(ref renderer.GetPinnableReference(), ref scaleX.GetPinnableReference(), ref scaleY.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int SetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte r, byte g, byte b, byte a)
        {
            // SpanOverloader
            return thisApi.SetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, string g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, string g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, string g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, string g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, string r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, byte* g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, byte* g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, byte* g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, string g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, string g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, string g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, byte* r, string g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, byte* g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, byte* g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, byte* g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, string g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, string g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, string g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, Span<byte> r, string g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, byte* g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, byte* g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, byte* g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, byte* g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, byte* g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, Span<byte> g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, Span<byte> g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, Span<byte> g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, Span<byte> g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, Span<byte> g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, string g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, string g, byte* b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, string g, Span<byte> b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, string g, string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, string g, string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Span<Renderer> renderer, string r, string g, string b, string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(ref renderer.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int SetRenderDrawBlendMode(this Sdl thisApi, Span<Renderer> renderer, BlendMode blendMode)
        {
            // SpanOverloader
            return thisApi.SetRenderDrawBlendMode(ref renderer.GetPinnableReference(), blendMode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 744, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawBlendMode(this Sdl thisApi, Renderer* renderer, Span<BlendMode> blendMode)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawBlendMode(renderer, ref blendMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 744, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawBlendMode(this Sdl thisApi, Span<Renderer> renderer, BlendMode* blendMode)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawBlendMode(ref renderer.GetPinnableReference(), blendMode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 744, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GetRenderDrawBlendMode(this Sdl thisApi, Span<Renderer> renderer, Span<BlendMode> blendMode)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawBlendMode(ref renderer.GetPinnableReference(), ref blendMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderClear(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            return thisApi.RenderClear(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 766, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawPoint(this Sdl thisApi, Span<Renderer> renderer, int x, int y)
        {
            // SpanOverloader
            return thisApi.RenderDrawPoint(ref renderer.GetPinnableReference(), x, y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawPoints(this Sdl thisApi, Renderer* renderer, Span<Point> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawPoints(renderer, ref points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawPoints(this Sdl thisApi, Span<Renderer> renderer, Point* points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawPoints(ref renderer.GetPinnableReference(), points, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawPoints(this Sdl thisApi, Span<Renderer> renderer, Span<Point> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawPoints(ref renderer.GetPinnableReference(), ref points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 793, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawLine(this Sdl thisApi, Span<Renderer> renderer, int x1, int y1, int x2, int y2)
        {
            // SpanOverloader
            return thisApi.RenderDrawLine(ref renderer.GetPinnableReference(), x1, y1, x2, y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 805, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawLines(this Sdl thisApi, Renderer* renderer, Span<Point> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawLines(renderer, ref points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 805, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawLines(this Sdl thisApi, Span<Renderer> renderer, Point* points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawLines(ref renderer.GetPinnableReference(), points, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 805, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawLines(this Sdl thisApi, Span<Renderer> renderer, Span<Point> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawLines(ref renderer.GetPinnableReference(), ref points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 817, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRect(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderDrawRect(renderer, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 817, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRect(this Sdl thisApi, Span<Renderer> renderer, Silk.NET.Maths.Rectangle<int>* rect)
        {
            // SpanOverloader
            return thisApi.RenderDrawRect(ref renderer.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 817, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRect(this Sdl thisApi, Span<Renderer> renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderDrawRect(ref renderer.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRects(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawRects(renderer, ref rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRects(this Sdl thisApi, Span<Renderer> renderer, Silk.NET.Maths.Rectangle<int>* rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawRects(ref renderer.GetPinnableReference(), rects, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRects(this Sdl thisApi, Span<Renderer> renderer, Span<Silk.NET.Maths.Rectangle<int>> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawRects(ref renderer.GetPinnableReference(), ref rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRect(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderFillRect(renderer, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRect(this Sdl thisApi, Span<Renderer> renderer, Silk.NET.Maths.Rectangle<int>* rect)
        {
            // SpanOverloader
            return thisApi.RenderFillRect(ref renderer.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRect(this Sdl thisApi, Span<Renderer> renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderFillRect(ref renderer.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRects(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderFillRects(renderer, ref rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRects(this Sdl thisApi, Span<Renderer> renderer, Silk.NET.Maths.Rectangle<int>* rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderFillRects(ref renderer.GetPinnableReference(), rects, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRects(this Sdl thisApi, Span<Renderer> renderer, Span<Silk.NET.Maths.Rectangle<int>> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderFillRects(ref renderer.GetPinnableReference(), ref rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(renderer, texture, srcrect, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(renderer, texture, ref srcrect.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(renderer, texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(renderer, ref texture.GetPinnableReference(), srcrect, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(renderer, ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(ref renderer.GetPinnableReference(), texture, srcrect, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(ref renderer.GetPinnableReference(), texture, srcrect, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, srcrect, dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, srcrect, ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, srcrect, ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, ref srcrect.GetPinnableReference(), dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, ref srcrect.GetPinnableReference(), dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, ref texture.GetPinnableReference(), srcrect, dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, ref texture.GetPinnableReference(), srcrect, dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), texture, srcrect, dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), texture, srcrect, dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), texture, srcrect, ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), texture, srcrect, ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, Span<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawPointF(this Sdl thisApi, Span<Renderer> renderer, float x, float y)
        {
            // SpanOverloader
            return thisApi.RenderDrawPointF(ref renderer.GetPinnableReference(), x, y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawPointsF(this Sdl thisApi, Renderer* renderer, Span<FPoint> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawPointsF(renderer, ref points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawPointsF(this Sdl thisApi, Span<Renderer> renderer, FPoint* points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawPointsF(ref renderer.GetPinnableReference(), points, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawPointsF(this Sdl thisApi, Span<Renderer> renderer, Span<FPoint> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawPointsF(ref renderer.GetPinnableReference(), ref points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 935, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawLineF(this Sdl thisApi, Span<Renderer> renderer, float x1, float y1, float x2, float y2)
        {
            // SpanOverloader
            return thisApi.RenderDrawLineF(ref renderer.GetPinnableReference(), x1, y1, x2, y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawLinesF(this Sdl thisApi, Renderer* renderer, Span<FPoint> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawLinesF(renderer, ref points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawLinesF(this Sdl thisApi, Span<Renderer> renderer, FPoint* points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawLinesF(ref renderer.GetPinnableReference(), points, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawLinesF(this Sdl thisApi, Span<Renderer> renderer, Span<FPoint> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawLinesF(ref renderer.GetPinnableReference(), ref points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRectF(this Sdl thisApi, Renderer* renderer, Span<FRect> rect)
        {
            // SpanOverloader
            return thisApi.RenderDrawRectF(renderer, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRectF(this Sdl thisApi, Span<Renderer> renderer, FRect* rect)
        {
            // SpanOverloader
            return thisApi.RenderDrawRectF(ref renderer.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRectF(this Sdl thisApi, Span<Renderer> renderer, Span<FRect> rect)
        {
            // SpanOverloader
            return thisApi.RenderDrawRectF(ref renderer.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRectsF(this Sdl thisApi, Renderer* renderer, Span<FRect> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawRectsF(renderer, ref rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRectsF(this Sdl thisApi, Span<Renderer> renderer, FRect* rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawRectsF(ref renderer.GetPinnableReference(), rects, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderDrawRectsF(this Sdl thisApi, Span<Renderer> renderer, Span<FRect> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawRectsF(ref renderer.GetPinnableReference(), ref rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 984, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRectF(this Sdl thisApi, Renderer* renderer, Span<FRect> rect)
        {
            // SpanOverloader
            return thisApi.RenderFillRectF(renderer, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 984, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRectF(this Sdl thisApi, Span<Renderer> renderer, FRect* rect)
        {
            // SpanOverloader
            return thisApi.RenderFillRectF(ref renderer.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 984, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRectF(this Sdl thisApi, Span<Renderer> renderer, Span<FRect> rect)
        {
            // SpanOverloader
            return thisApi.RenderFillRectF(ref renderer.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRectsF(this Sdl thisApi, Renderer* renderer, Span<FRect> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderFillRectsF(renderer, ref rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRectsF(this Sdl thisApi, Span<Renderer> renderer, FRect* rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderFillRectsF(ref renderer.GetPinnableReference(), rects, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFillRectsF(this Sdl thisApi, Span<Renderer> renderer, Span<FRect> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderFillRectsF(ref renderer.GetPinnableReference(), ref rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(renderer, texture, srcrect, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(renderer, texture, ref srcrect.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(renderer, texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(renderer, ref texture.GetPinnableReference(), srcrect, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(renderer, ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(ref renderer.GetPinnableReference(), texture, srcrect, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(ref renderer.GetPinnableReference(), texture, srcrect, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, srcrect, dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, srcrect, ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, srcrect, ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, ref srcrect.GetPinnableReference(), dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, ref srcrect.GetPinnableReference(), dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, ref texture.GetPinnableReference(), srcrect, dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, ref texture.GetPinnableReference(), srcrect, dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), texture, srcrect, dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), texture, srcrect, dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), texture, srcrect, ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), texture, srcrect, ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Texture* texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), texture, ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Silk.NET.Maths.Rectangle<int>* srcrect, Span<FRect> dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), srcrect, ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, FRect* dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), dstrect, angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect, double angle, FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Span<Renderer> renderer, Span<Texture> texture, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<FRect> dstrect, double angle, Span<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(ref renderer.GetPinnableReference(), ref texture.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dstrect.GetPinnableReference(), angle, ref center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderReadPixels<T0>(this Sdl thisApi, Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect, uint format, Span<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderReadPixels(renderer, rect, format, ref pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderReadPixels(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rect, uint format, void* pixels, int pitch)
        {
            // SpanOverloader
            return thisApi.RenderReadPixels(renderer, ref rect.GetPinnableReference(), format, pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderReadPixels<T0>(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rect, uint format, Span<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderReadPixels(renderer, ref rect.GetPinnableReference(), format, ref pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderReadPixels(this Sdl thisApi, Span<Renderer> renderer, Silk.NET.Maths.Rectangle<int>* rect, uint format, void* pixels, int pitch)
        {
            // SpanOverloader
            return thisApi.RenderReadPixels(ref renderer.GetPinnableReference(), rect, format, pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderReadPixels<T0>(this Sdl thisApi, Span<Renderer> renderer, Silk.NET.Maths.Rectangle<int>* rect, uint format, Span<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderReadPixels(ref renderer.GetPinnableReference(), rect, format, ref pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderReadPixels(this Sdl thisApi, Span<Renderer> renderer, Span<Silk.NET.Maths.Rectangle<int>> rect, uint format, void* pixels, int pitch)
        {
            // SpanOverloader
            return thisApi.RenderReadPixels(ref renderer.GetPinnableReference(), ref rect.GetPinnableReference(), format, pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderReadPixels<T0>(this Sdl thisApi, Span<Renderer> renderer, Span<Silk.NET.Maths.Rectangle<int>> rect, uint format, Span<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderReadPixels(ref renderer.GetPinnableReference(), ref rect.GetPinnableReference(), format, ref pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void RenderPresent(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            thisApi.RenderPresent(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1071, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void DestroyTexture(this Sdl thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            thisApi.DestroyTexture(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void DestroyRenderer(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            thisApi.DestroyRenderer(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int RenderFlush(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            return thisApi.RenderFlush(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GLBindTexture(this Sdl thisApi, Texture* texture, float* texw, Span<float> texh)
        {
            // SpanOverloader
            return thisApi.GLBindTexture(texture, texw, ref texh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GLBindTexture(this Sdl thisApi, Texture* texture, Span<float> texw, float* texh)
        {
            // SpanOverloader
            return thisApi.GLBindTexture(texture, ref texw.GetPinnableReference(), texh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GLBindTexture(this Sdl thisApi, Texture* texture, Span<float> texw, Span<float> texh)
        {
            // SpanOverloader
            return thisApi.GLBindTexture(texture, ref texw.GetPinnableReference(), ref texh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GLBindTexture(this Sdl thisApi, Span<Texture> texture, float* texw, float* texh)
        {
            // SpanOverloader
            return thisApi.GLBindTexture(ref texture.GetPinnableReference(), texw, texh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GLBindTexture(this Sdl thisApi, Span<Texture> texture, float* texw, Span<float> texh)
        {
            // SpanOverloader
            return thisApi.GLBindTexture(ref texture.GetPinnableReference(), texw, ref texh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GLBindTexture(this Sdl thisApi, Span<Texture> texture, Span<float> texw, float* texh)
        {
            // SpanOverloader
            return thisApi.GLBindTexture(ref texture.GetPinnableReference(), ref texw.GetPinnableReference(), texh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GLBindTexture(this Sdl thisApi, Span<Texture> texture, Span<float> texw, Span<float> texh)
        {
            // SpanOverloader
            return thisApi.GLBindTexture(ref texture.GetPinnableReference(), ref texw.GetPinnableReference(), ref texh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1126, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe int GLUnbindTexture(this Sdl thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.GLUnbindTexture(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1137, Column 31 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void* RenderGetMetalLayer(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            return thisApi.RenderGetMetalLayer(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1148, Column 31 in build/submodules/SDL-mirror/include/SDL_render.h")]
        public static unsafe void* RenderGetMetalCommandEncoder(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            return thisApi.RenderGetMetalCommandEncoder(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        public static unsafe byte* SensorGetName(this Sdl thisApi, Span<Sensor> sensor)
        {
            // SpanOverloader
            return thisApi.SensorGetName(ref sensor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 40 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        public static unsafe SensorType SensorGetType(this Sdl thisApi, Span<Sensor> sensor)
        {
            // SpanOverloader
            return thisApi.SensorGetType(ref sensor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        public static unsafe int SensorGetNonPortableType(this Sdl thisApi, Span<Sensor> sensor)
        {
            // SpanOverloader
            return thisApi.SensorGetNonPortableType(ref sensor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 38 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        public static unsafe int SensorGetInstanceID(this Sdl thisApi, Span<Sensor> sensor)
        {
            // SpanOverloader
            return thisApi.SensorGetInstanceID(ref sensor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        public static unsafe int SensorGetData(this Sdl thisApi, Sensor* sensor, Span<float> data, int num_values)
        {
            // SpanOverloader
            return thisApi.SensorGetData(sensor, ref data.GetPinnableReference(), num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        public static unsafe int SensorGetData(this Sdl thisApi, Span<Sensor> sensor, float* data, int num_values)
        {
            // SpanOverloader
            return thisApi.SensorGetData(ref sensor.GetPinnableReference(), data, num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        public static unsafe int SensorGetData(this Sdl thisApi, Span<Sensor> sensor, Span<float> data, int num_values)
        {
            // SpanOverloader
            return thisApi.SensorGetData(ref sensor.GetPinnableReference(), ref data.GetPinnableReference(), num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 30 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        public static unsafe void SensorClose(this Sdl thisApi, Span<Sensor> sensor)
        {
            // SpanOverloader
            thisApi.SensorClose(ref sensor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 38 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe Window* CreateShapedWindow(this Sdl thisApi, Span<byte> title, uint x, uint y, uint w, uint h, uint flags)
        {
            // SpanOverloader
            return thisApi.CreateShapedWindow(ref title.GetPinnableReference(), x, y, w, h, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 34 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe SdlBool IsShapedWindow(this Sdl thisApi, Span<Window> window)
        {
            // SpanOverloader
            return thisApi.IsShapedWindow(ref window.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe int SetWindowShape(this Sdl thisApi, Window* window, Surface* shape, Span<WindowShapeModeVal> shape_mode)
        {
            // SpanOverloader
            return thisApi.SetWindowShape(window, shape, ref shape_mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe int SetWindowShape(this Sdl thisApi, Window* window, Span<Surface> shape, WindowShapeModeVal* shape_mode)
        {
            // SpanOverloader
            return thisApi.SetWindowShape(window, ref shape.GetPinnableReference(), shape_mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe int SetWindowShape(this Sdl thisApi, Window* window, Span<Surface> shape, Span<WindowShapeModeVal> shape_mode)
        {
            // SpanOverloader
            return thisApi.SetWindowShape(window, ref shape.GetPinnableReference(), ref shape_mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe int SetWindowShape(this Sdl thisApi, Span<Window> window, Surface* shape, WindowShapeModeVal* shape_mode)
        {
            // SpanOverloader
            return thisApi.SetWindowShape(ref window.GetPinnableReference(), shape, shape_mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe int SetWindowShape(this Sdl thisApi, Span<Window> window, Surface* shape, Span<WindowShapeModeVal> shape_mode)
        {
            // SpanOverloader
            return thisApi.SetWindowShape(ref window.GetPinnableReference(), shape, ref shape_mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe int SetWindowShape(this Sdl thisApi, Span<Window> window, Span<Surface> shape, WindowShapeModeVal* shape_mode)
        {
            // SpanOverloader
            return thisApi.SetWindowShape(ref window.GetPinnableReference(), ref shape.GetPinnableReference(), shape_mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe int SetWindowShape(this Sdl thisApi, Span<Window> window, Span<Surface> shape, Span<WindowShapeModeVal> shape_mode)
        {
            // SpanOverloader
            return thisApi.SetWindowShape(ref window.GetPinnableReference(), ref shape.GetPinnableReference(), ref shape_mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 136, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe int GetShapedWindowMode(this Sdl thisApi, Window* window, Span<WindowShapeModeVal> shape_mode)
        {
            // SpanOverloader
            return thisApi.GetShapedWindowMode(window, ref shape_mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 136, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe int GetShapedWindowMode(this Sdl thisApi, Span<Window> window, WindowShapeModeVal* shape_mode)
        {
            // SpanOverloader
            return thisApi.GetShapedWindowMode(ref window.GetPinnableReference(), shape_mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 136, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        public static unsafe int GetShapedWindowMode(this Sdl thisApi, Span<Window> window, Span<WindowShapeModeVal> shape_mode)
        {
            // SpanOverloader
            return thisApi.GetShapedWindowMode(ref window.GetPinnableReference(), ref shape_mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe void SetWindowsMessageHook<T0>(this Sdl thisApi, PfnVvVvUiUi64I64V callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetWindowsMessageHook(callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 43 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe IDirect3DDevice9* RenderGetD3D9Device(this Sdl thisApi, Span<Renderer> renderer)
        {
            // SpanOverloader
            return thisApi.RenderGetD3D9Device(ref renderer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe SdlBool DXGIGetOutputInfo(this Sdl thisApi, int displayIndex, int* adapterIndex, Span<int> outputIndex)
        {
            // SpanOverloader
            return thisApi.DXGIGetOutputInfo(displayIndex, adapterIndex, ref outputIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe SdlBool DXGIGetOutputInfo(this Sdl thisApi, int displayIndex, Span<int> adapterIndex, int* outputIndex)
        {
            // SpanOverloader
            return thisApi.DXGIGetOutputInfo(displayIndex, ref adapterIndex.GetPinnableReference(), outputIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe SdlBool DXGIGetOutputInfo(this Sdl thisApi, int displayIndex, Span<int> adapterIndex, Span<int> outputIndex)
        {
            // SpanOverloader
            return thisApi.DXGIGetOutputInfo(displayIndex, ref adapterIndex.GetPinnableReference(), ref outputIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        public static unsafe int IPhoneSetAnimationCallback<T0>(this Sdl thisApi, Window* window, int interval, PfnFreeFunc callback, Span<T0> callbackParam) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.IPhoneSetAnimationCallback(window, interval, callback, ref callbackParam.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        public static unsafe int IPhoneSetAnimationCallback(this Sdl thisApi, Span<Window> window, int interval, PfnFreeFunc callback, void* callbackParam)
        {
            // SpanOverloader
            return thisApi.IPhoneSetAnimationCallback(ref window.GetPinnableReference(), interval, callback, callbackParam);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        public static unsafe int IPhoneSetAnimationCallback<T0>(this Sdl thisApi, Span<Window> window, int interval, PfnFreeFunc callback, Span<T0> callbackParam) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.IPhoneSetAnimationCallback(ref window.GetPinnableReference(), interval, callback, ref callbackParam.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 93, Column 37 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        public static unsafe int AddTimer<T0>(this Sdl thisApi, uint interval, PfnUiVvUi callback, Span<T0> param) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AddTimer(interval, callback, ref param.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 30 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        public static unsafe void GetVersion(this Sdl thisApi, Span<Version> ver)
        {
            // SpanOverloader
            thisApi.GetVersion(ref ver.GetPinnableReference());
        }

    }
}

