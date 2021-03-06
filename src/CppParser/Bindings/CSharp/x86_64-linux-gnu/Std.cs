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
    public unsafe partial class basic_string : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr _M_p;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSsD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNKSs5c_strEv")]
            internal static extern global::System.IntPtr c_str_0(global::System.IntPtr instance);
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
                    EntryPoint="_ZNSs12_Alloc_hiderD2Ev")]
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

            public sbyte* _M_p
            {
                get
                {
                    return ((Internal*) __Instance)->_M_p;
                }

                set
                {
                    ((Internal*) __Instance)->_M_p = (global::System.IntPtr) value;
                }
            }
        }

        public unsafe partial class _Rep_base : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public ulong _M_length;

                [FieldOffset(8)]
                public ulong _M_capacity;

                [FieldOffset(16)]
                public int _M_refcount;
            }

            public global::System.IntPtr __Instance { get; protected set; }

            protected int __PointerAdjustment;
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, _Rep_base> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, _Rep_base>();
            protected void*[] __OriginalVTables;

            protected bool __ownsNativeInstance;

            public static _Rep_base __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
            {
                return new _Rep_base(native.ToPointer(), skipVTables);
            }

            public static _Rep_base __CreateInstance(_Rep_base.Internal native, bool skipVTables = false)
            {
                return new _Rep_base(native, skipVTables);
            }

            private static void* __CopyValue(_Rep_base.Internal native)
            {
                var ret = Marshal.AllocHGlobal(24);
                *(_Rep_base.Internal*) ret = native;
                return ret.ToPointer();
            }

            private _Rep_base(_Rep_base.Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected _Rep_base(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new global::System.IntPtr(native);
            }

            public _Rep_base()
            {
                __Instance = Marshal.AllocHGlobal(24);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public void Dispose()
            {
                Dispose(disposing: true);
            }

            protected virtual void Dispose(bool disposing)
            {
                global::std.basic_string._Rep_base __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public int _M_refcount
            {
                get
                {
                    return ((Internal*) __Instance)->_M_refcount;
                }

                set
                {
                    ((Internal*) __Instance)->_M_refcount = value;
                }
            }
        }

        public unsafe partial class _Rep : global::std.basic_string._Rep_base, IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public new partial struct Internal
            {
                [FieldOffset(0)]
                public ulong _M_length;

                [FieldOffset(8)]
                public ulong _M_capacity;

                [FieldOffset(16)]
                public int _M_refcount;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSs4_Rep12_S_empty_repEv")]
                internal static extern global::System.IntPtr _S_empty_rep_0();

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNKSs4_Rep12_M_is_leakedEv")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool _M_is_leaked_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNKSs4_Rep12_M_is_sharedEv")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool _M_is_shared_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSs4_Rep13_M_set_leakedEv")]
                internal static extern void _M_set_leaked_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSs4_Rep15_M_set_sharableEv")]
                internal static extern void _M_set_sharable_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSs4_Rep10_M_refdataEv")]
                internal static extern sbyte* _M_refdata_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSs4_Rep10_M_refcopyEv")]
                internal static extern sbyte* _M_refcopy_0(global::System.IntPtr instance);
            }

            public static new _Rep __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
            {
                return new _Rep(native.ToPointer(), skipVTables);
            }

            public static _Rep __CreateInstance(_Rep.Internal native, bool skipVTables = false)
            {
                return new _Rep(native, skipVTables);
            }

            private static void* __CopyValue(_Rep.Internal native)
            {
                var ret = Marshal.AllocHGlobal(24);
                *(_Rep.Internal*) ret = native;
                return ret.ToPointer();
            }

            private _Rep(_Rep.Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected _Rep(void* native, bool skipVTables = false)
                : base((void*) null)
            {
                __PointerAdjustment = 0;
                if (native == null)
                    return;
                __Instance = new global::System.IntPtr(native);
            }

            public _Rep()
                : this((void*) null)
            {
                __Instance = Marshal.AllocHGlobal(24);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public bool _M_is_leaked()
            {
                var __ret = Internal._M_is_leaked_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            public bool _M_is_shared()
            {
                var __ret = Internal._M_is_shared_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            public void _M_set_leaked()
            {
                Internal._M_set_leaked_0((__Instance + __PointerAdjustment));
            }

            public void _M_set_sharable()
            {
                Internal._M_set_sharable_0((__Instance + __PointerAdjustment));
            }

            public sbyte* _M_refdata()
            {
                var __ret = Internal._M_refdata_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            public sbyte* _M_refcopy()
            {
                var __ret = Internal._M_refcopy_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            public static global::std.basic_string._Rep _S_empty_rep()
            {
                var __ret = Internal._S_empty_rep_0();
                global::std.basic_string._Rep __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::std.basic_string._Rep.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::std.basic_string._Rep) global::std.basic_string._Rep.NativeToManagedMap[__ret];
                else __result0 = global::std.basic_string._Rep.__CreateInstance(__ret);
                return __result0;
            }

            public static ulong _S_max_size
            {
                get
                {
                    var __ptr = (ulong*)CppSharp.SymbolResolver.ResolveSymbol("Std-templates", "_ZNSs4_Rep11_S_max_sizeE");
                    return *__ptr;
                }
            }

            public static sbyte _S_terminal
            {
                get
                {
                    var __ptr = (sbyte*)CppSharp.SymbolResolver.ResolveSymbol("Std-templates", "_ZNSs4_Rep11_S_terminalE");
                    return *__ptr;
                }
            }

            public static ulong[] _S_empty_rep_storage
            {
                get
                {
                    var __ptr = (byte*)CppSharp.SymbolResolver.ResolveSymbol("Std-templates", "_ZNSs4_Rep20_S_empty_rep_storageE");
                    return null;
                }
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
            var ret = Marshal.AllocHGlobal(8);
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
            global::std.basic_string __dummy;
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
                var __ptr = (ulong*)CppSharp.SymbolResolver.ResolveSymbol("Std-templates", "_ZNSs4nposE");
                return *__ptr;
            }
        }
    }
}
