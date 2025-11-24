using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDemanglerList(BNDemangler** demanglers)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeDemanglerList"
        )]
		internal static extern void BNFreeDemanglerList(
			
			// BNDemangler** demanglers
		    IntPtr demanglers  
			
		);
	}
}