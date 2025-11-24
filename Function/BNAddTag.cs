using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddTag(BNBinaryView* view, BNTag* tag, bool user)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddTag"
        )]
		internal static extern void BNAddTag(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTag* tag
		    IntPtr tag  , 
			
			// bool user
		    bool user  
		);
	}
}