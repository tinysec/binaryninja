using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNFirmwareNinjaQueryBoardNamesForArchitecture(BNFirmwareNinja* fn, BNArchitecture* arch, const char*** boards)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaQueryBoardNamesForArchitecture"
        )]
		internal static extern int BNFirmwareNinjaQueryBoardNamesForArchitecture(
			
			// BNFirmwareNinja* fn
		    IntPtr fn  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// const char*** boards
		    IntPtr boards  
			
		);
	}
}