using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetMediumLevelILLiveInstructionsForVariable(BNMediumLevelILFunction* func, BNVariable* var, bool includeLastUse, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILLiveInstructionsForVariable"
        )]
		internal static extern IntPtr BNGetMediumLevelILLiveInstructionsForVariable(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    in BNVariable variable  , 
			
			// bool includeLastUse
		    bool includeLastUse  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}