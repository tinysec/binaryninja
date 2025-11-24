using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveTagReference(BNBinaryView* view, BNTagReference @ref)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoveTagReference"
        )]
		internal static extern void BNRemoveTagReference(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTagReference _ref
		    TagReference _ref  
			
		);
	}
}