using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaFreeBoardNames(const char** boards, int32_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaFreeBoardNames"
        )]
		internal static extern void BNFirmwareNinjaFreeBoardNames(
			
			// const char** boards
		    string[] boards  , 
			
			// int32_t size
		    int size  
			
		);
	}
}