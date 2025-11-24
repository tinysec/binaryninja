using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataBuffer* BNGetConstantData(BNFunction* func, BNRegisterValueType state, uint64_t value, uint64_t size, BNBuiltinType* builtin)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetConstantData"
        )]
		internal static extern IntPtr BNGetConstantData(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNRegisterValueType state
		    RegisterValueType state  , 
			
			// uint64_t value
		    ulong value  , 
			
			// uint64_t size
		    ulong size  , 
			
			// BNBuiltinType* builtin
			out BuiltinType builtin  
		);
	}
}