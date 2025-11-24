using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetMediumLevelILVariableSSAVersions(BNMediumLevelILFunction* func, BNVariable* var, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILVariableSSAVersions"
        )]
		internal static extern IntPtr BNGetMediumLevelILVariableSSAVersions(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    in BNVariable variable  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}