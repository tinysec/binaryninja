using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNActivity* BNNewActivityReference(BNActivity* activity)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNNewActivityReference"
        )]
		internal static extern IntPtr BNNewActivityReference(
			
			// BNActivity* activity
		    IntPtr activity  
		);
	}
}