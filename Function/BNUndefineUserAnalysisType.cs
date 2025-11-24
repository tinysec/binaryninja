using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUndefineUserAnalysisType(BNBinaryView* view, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNUndefineUserAnalysisType"
        )]
		internal static extern void BNUndefineUserAnalysisType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  
		);
	}
}