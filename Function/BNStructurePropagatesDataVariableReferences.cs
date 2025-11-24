using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNStructurePropagatesDataVariableReferences(BNStructure* s)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNStructurePropagatesDataVariableReferences"
        )]
		internal static extern bool BNStructurePropagatesDataVariableReferences(
			
			// BNStructure* s
		    IntPtr s  
		);
	}
}