using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNILReferenceSource* BNGetMediumLevelILVariableReferencesIfAvailable(BNFunction* func, BNVariable* var, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetMediumLevelILVariableReferencesIfAvailable"
        )]
		internal static extern IntPtr BNGetMediumLevelILVariableReferencesIfAvailable(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    IntPtr _var  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}