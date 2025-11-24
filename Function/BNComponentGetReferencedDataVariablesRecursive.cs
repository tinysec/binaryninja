using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataVariable* BNComponentGetReferencedDataVariablesRecursive(BNComponent* component, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNComponentGetReferencedDataVariablesRecursive"
        )]
		internal static extern IntPtr BNComponentGetReferencedDataVariablesRecursive(
			
			// BNComponent* component
		    IntPtr component  , 
			
			// uint64_t* count
		    IntPtr count  
		);
	}
}