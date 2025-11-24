using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterEnterpriseServerNotification(BNEnterpriseServerCallbacks* notify)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRegisterEnterpriseServerNotification"
        )]
		internal static extern void BNRegisterEnterpriseServerNotification(
			
			// BNEnterpriseServerCallbacks* notify
		    IntPtr notify  
			
		);
	}
}