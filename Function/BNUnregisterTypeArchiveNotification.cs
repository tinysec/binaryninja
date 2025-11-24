using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUnregisterTypeArchiveNotification(BNTypeArchive* archive, BNTypeArchiveNotification* notification)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUnregisterTypeArchiveNotification"
        )]
		internal static extern void BNUnregisterTypeArchiveNotification(
			
			// BNTypeArchive* archive
		    IntPtr archive  , 
			
			// BNTypeArchiveNotification* notification
		    IntPtr notification  
			
		);
	}
}