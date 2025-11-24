using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterProjectNotification(BNProject* project, BNProjectNotification* notify)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRegisterProjectNotification"
        )]
		internal static extern void BNRegisterProjectNotification(
			
			// BNProject* project
		    IntPtr project  , 
			
			// BNProjectNotification* notify
		    IntPtr notify  
			
		);
	}
}