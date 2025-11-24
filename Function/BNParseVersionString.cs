using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNParseVersionString(BNVersionInfo @return, const char* v)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNParseVersionString"
        )]
		internal static extern void BNParseVersionString(
			
			// BNVersionInfo _return
		    VersionInfo _return  , 
			
			// const char* v
		    string v  
			
		);
	}
}