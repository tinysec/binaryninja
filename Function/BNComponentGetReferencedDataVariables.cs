using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataVariable* BNComponentGetReferencedDataVariables(BNComponent* component, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNComponentGetReferencedDataVariables"
        )]
		internal static extern IntPtr BNComponentGetReferencedDataVariables(
			
			// BNComponent* component
		    IntPtr component  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}