using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveStructureBuilderMember(BNStructureBuilder* s, uint64_t idx)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRemoveStructureBuilderMember"
        )]
		internal static extern void BNRemoveStructureBuilderMember(
			
			// BNStructureBuilder* s
		    IntPtr s  , 
			
			// uint64_t idx
		    ulong idx  
		);
	}
}