using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBinaryView* BNTransformSessionGetCurrentView(BNTransformSession* session)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTransformSessionGetCurrentView"
        )]
		internal static extern IntPtr BNTransformSessionGetCurrentView(
			
			// BNTransformSession* session
		    IntPtr session  
			
		);
	}
}