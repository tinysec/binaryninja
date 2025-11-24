using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial  class NativeMethods
    {
	    /// <summary>
	    /// BNHighlightColor BNGetBasicBlockHighlight(BNBasicBlock* block)
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetBasicBlockHighlight"
	    )]
	    internal static extern BNHighlightColor BNGetBasicBlockHighlight(
			
		    // BNBasicBlock* block
		    IntPtr block  
	    );
    }
}