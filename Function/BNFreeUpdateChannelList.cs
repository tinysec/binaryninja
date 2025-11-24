using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeUpdateChannelList(BNUpdateChannel* list, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeUpdateChannelList"
        )]
		internal static extern void BNFreeUpdateChannelList(
			
			// BNUpdateChannel* list
		    IntPtr list  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}