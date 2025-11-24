using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeInheritedStructureMember(BNInheritedStructureMember* members)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeInheritedStructureMember"
        )]
		internal static extern void BNFreeInheritedStructureMember(
			
			// BNInheritedStructureMember* members
		    IntPtr members  
			
		);
	}
}