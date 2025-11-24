using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeNameSpaceList(BNNameSpace* nameSpace, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeNameSpaceList"
        )]
		internal static extern void BNFreeNameSpaceList(
			
			// BNNameSpace* _nameSpace
		    IntPtr _nameSpace  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}