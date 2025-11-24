using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNRemoteProjectIsOpen(BNRemoteProject* project)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteProjectIsOpen"
        )]
		internal static extern bool BNRemoteProjectIsOpen(
			
			// BNRemoteProject* project
		    IntPtr project  
			
		);
	}
}