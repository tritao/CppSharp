//----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace std
{
    public unsafe partial class allocator : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSaIcEC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSaIcED2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, allocator> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, allocator>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static allocator __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new allocator(native.ToPointer(), skipVTables);
        }

        public static allocator __CreateInstance(allocator.Internal native, bool skipVTables = false)
        {
            return new allocator(native, skipVTables);
        }

        private static void* __CopyValue(allocator.Internal native)
        {
            var ret = Marshal.AllocHGlobal(0);
            *(allocator.Internal*) ret = native;
            return ret.ToPointer();
        }

        private allocator(allocator.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected allocator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public allocator()
        {
            __Instance = Marshal.AllocHGlobal(0);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            global::std.allocator __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment));
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }
    }
}

namespace std
{
    namespace __cxx11
    {
        public unsafe partial class basic_string : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 32)]
            public unsafe partial struct Internal
            {
                [FieldOffset(0)]
                public global::System.IntPtr _M_p;

                [FieldOffset(8)]
                public ulong _M_string_length;

                [FieldOffset(16)]
                public fixed sbyte _M_local_buf[16];

                [FieldOffset(17)]
                public sbyte __dummy__M_local_buf_1;

                [FieldOffset(18)]
                public sbyte __dummy__M_local_buf_2;

                [FieldOffset(19)]
                public sbyte __dummy__M_local_buf_3;

                [FieldOffset(20)]
                public sbyte __dummy__M_local_buf_4;

                [FieldOffset(21)]
                public sbyte __dummy__M_local_buf_5;

                [FieldOffset(22)]
                public sbyte __dummy__M_local_buf_6;

                [FieldOffset(23)]
                public sbyte __dummy__M_local_buf_7;

                [FieldOffset(24)]
                public sbyte __dummy__M_local_buf_8;

                [FieldOffset(25)]
                public sbyte __dummy__M_local_buf_9;

                [FieldOffset(26)]
                public sbyte __dummy__M_local_buf_10;

                [FieldOffset(27)]
                public sbyte __dummy__M_local_buf_11;

                [FieldOffset(28)]
                public sbyte __dummy__M_local_buf_12;

                [FieldOffset(29)]
                public sbyte __dummy__M_local_buf_13;

                [FieldOffset(30)]
                public sbyte __dummy__M_local_buf_14;

                [FieldOffset(31)]
                public sbyte __dummy__M_local_buf_15;

                [FieldOffset(16)]
                public ulong _M_allocated_capacity;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEED2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNKSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEE5c_strEv")]
                internal static extern global::System.IntPtr c_str_0(global::System.IntPtr instance);
            }

            internal enum S_local_capacity : uint
            {
                _S_local_capacity = 15
            }

            public unsafe partial class _Alloc_hider : global::std.allocator, IDisposable
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public new partial struct Internal
                {
                    [FieldOffset(0)]
                    public global::System.IntPtr _M_p;

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZNSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEE12_Alloc_hiderD2Ev")]
                    internal static extern void dtor_0(global::System.IntPtr instance);
                }

                public static new _Alloc_hider __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
                {
                    return new _Alloc_hider(native.ToPointer(), skipVTables);
                }

                public static _Alloc_hider __CreateInstance(_Alloc_hider.Internal native, bool skipVTables = false)
                {
                    return new _Alloc_hider(native, skipVTables);
                }

                private static void* __CopyValue(_Alloc_hider.Internal native)
                {
                    var ret = Marshal.AllocHGlobal(8);
                    *(_Alloc_hider.Internal*) ret = native;
                    return ret.ToPointer();
                }

                private _Alloc_hider(_Alloc_hider.Internal native, bool skipVTables = false)
                    : this(__CopyValue(native), skipVTables)
                {
                    __ownsNativeInstance = true;
                    NativeToManagedMap[__Instance] = this;
                }

                protected _Alloc_hider(void* native, bool skipVTables = false)
                    : base((void*) null)
                {
                    __PointerAdjustment = 0;
                    if (native == null)
                        return;
                    __Instance = new global::System.IntPtr(native);
                }

                protected override void Dispose(bool disposing)
                {
                    global::std.allocator __dummy;
                    NativeToManagedMap.TryRemove(__Instance, out __dummy);
                    Internal.dtor_0((__Instance + __PointerAdjustment));
                    if (__ownsNativeInstance)
                        Marshal.FreeHGlobal(__Instance);
                }
            }

            public unsafe partial struct _
            {
                [StructLayout(LayoutKind.Explicit, Size = 16)]
                public partial struct Internal
                {
                    [FieldOffset(0)]
                    public fixed sbyte _M_local_buf[16];

                    [FieldOffset(1)]
                    public sbyte __dummy__M_local_buf_1;

                    [FieldOffset(2)]
                    public sbyte __dummy__M_local_buf_2;

                    [FieldOffset(3)]
                    public sbyte __dummy__M_local_buf_3;

                    [FieldOffset(4)]
                    public sbyte __dummy__M_local_buf_4;

                    [FieldOffset(5)]
                    public sbyte __dummy__M_local_buf_5;

                    [FieldOffset(6)]
                    public sbyte __dummy__M_local_buf_6;

                    [FieldOffset(7)]
                    public sbyte __dummy__M_local_buf_7;

                    [FieldOffset(8)]
                    public sbyte __dummy__M_local_buf_8;

                    [FieldOffset(9)]
                    public sbyte __dummy__M_local_buf_9;

                    [FieldOffset(10)]
                    public sbyte __dummy__M_local_buf_10;

                    [FieldOffset(11)]
                    public sbyte __dummy__M_local_buf_11;

                    [FieldOffset(12)]
                    public sbyte __dummy__M_local_buf_12;

                    [FieldOffset(13)]
                    public sbyte __dummy__M_local_buf_13;

                    [FieldOffset(14)]
                    public sbyte __dummy__M_local_buf_14;

                    [FieldOffset(15)]
                    public sbyte __dummy__M_local_buf_15;

                    [FieldOffset(0)]
                    public ulong _M_allocated_capacity;
                }
            }

            public global::System.IntPtr __Instance { get; protected set; }

            protected int __PointerAdjustment;
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, basic_string> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, basic_string>();
            protected void*[] __OriginalVTables;

            protected bool __ownsNativeInstance;

            public static basic_string __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
            {
                return new basic_string(native.ToPointer(), skipVTables);
            }

            public static basic_string __CreateInstance(basic_string.Internal native, bool skipVTables = false)
            {
                return new basic_string(native, skipVTables);
            }

            private static void* __CopyValue(basic_string.Internal native)
            {
                var ret = Marshal.AllocHGlobal(32);
                *(basic_string.Internal*) ret = native;
                return ret.ToPointer();
            }

            private basic_string(basic_string.Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected basic_string(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new global::System.IntPtr(native);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
            }

            protected virtual void Dispose(bool disposing)
            {
                global::std.__cxx11.basic_string __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                Internal.dtor_0((__Instance + __PointerAdjustment));
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public string c_str()
            {
                var __ret = Internal.c_str_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            public static ulong npos
            {
                get
                {
                    var __ptr = (ulong*)CppSharp.SymbolResolver.ResolveSymbol("Std-templates", "_ZNSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEE4nposE");
                    return *__ptr;
                }
            }
        }
    }
}
