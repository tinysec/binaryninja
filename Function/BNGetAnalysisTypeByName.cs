using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNGetAnalysisTypeByName(BNBinaryView* view, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetAnalysisTypeByName"
        )]
		internal static extern IntPtr BNGetAnalysisTypeByName(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  
		);
	}
}