using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInheritedStructureMember* BNGetStructureMembersIncludingInherited(BNStructure* s, BNTypeContainer* types, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetStructureMembersIncludingInherited"
        )]
		internal static extern IntPtr BNGetStructureMembersIncludingInherited(
			
			// BNStructure* s
		    IntPtr s  , 
			
			// BNTypeContainer* types
		    IntPtr types  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}