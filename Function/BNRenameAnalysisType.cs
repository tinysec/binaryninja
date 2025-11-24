using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRenameAnalysisType(BNBinaryView* view, BNQualifiedName* oldName, BNQualifiedName* newName)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRenameAnalysisType"
        )]
		internal static extern void BNRenameAnalysisType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* oldName
		    in BNQualifiedName oldName  , 
			
			// BNQualifiedName* newName
		    in BNQualifiedName newName  
		);
	}
}