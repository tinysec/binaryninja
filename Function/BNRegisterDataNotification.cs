using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterDataNotification(BNBinaryView* view, BNBinaryDataNotification* notify)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRegisterDataNotification"
        )]
		internal static extern void BNRegisterDataNotification(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNBinaryDataNotification* notify
		    IntPtr notify  
			
		);
	}
}