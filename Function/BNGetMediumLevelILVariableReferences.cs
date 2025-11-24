using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNILReferenceSource* BNGetMediumLevelILVariableReferences(BNFunction* func, BNVariable* var, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILVariableReferences"
        )]
		internal static extern IntPtr BNGetMediumLevelILVariableReferences(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    in BNVariable _var  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}