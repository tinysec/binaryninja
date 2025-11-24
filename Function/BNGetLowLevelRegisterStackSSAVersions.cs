using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetLowLevelRegisterStackSSAVersions(BNLowLevelILFunction* func, uint32_t var, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelRegisterStackSSAVersions"
        )]
		internal static extern IntPtr BNGetLowLevelRegisterStackSSAVersions(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t _var
			RegisterStackIndex _var  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}