using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMainThreadAction* BNNewMainThreadActionReference(BNMainThreadAction* action)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewMainThreadActionReference"
        )]
		internal static extern IntPtr BNNewMainThreadActionReference(
			
			// BNMainThreadAction* action
		    IntPtr action  
			
		);
	}
}