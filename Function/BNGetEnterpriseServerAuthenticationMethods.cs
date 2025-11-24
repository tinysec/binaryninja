using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetEnterpriseServerAuthenticationMethods(const char*** methods, const char*** names)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetEnterpriseServerAuthenticationMethods"
        )]
		internal static extern ulong BNGetEnterpriseServerAuthenticationMethods(
			
			// const char*** methods
		    IntPtr methods  , 
			
			// const char*** names
		    IntPtr names  
			
		);
	}
}