using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructureMember* BNGetStructureBuilderMembers(BNStructureBuilder* s, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetStructureBuilderMembers"
        )]
		internal static extern IntPtr BNGetStructureBuilderMembers(
			
			// BNStructureBuilder* s
		    IntPtr s  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}