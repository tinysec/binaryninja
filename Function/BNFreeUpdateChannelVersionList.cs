using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeUpdateChannelVersionList(BNUpdateVersion* list, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeUpdateChannelVersionList"
        )]
		internal static extern void BNFreeUpdateChannelVersionList(
			
			// BNUpdateVersion* list
		    IntPtr list  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}