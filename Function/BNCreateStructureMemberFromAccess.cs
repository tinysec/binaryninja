using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeWithConfidence BNCreateStructureMemberFromAccess(BNBinaryView* view, BNQualifiedName* name, uint64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateStructureMemberFromAccess"
        )]
		internal static extern BNTypeWithConfidence BNCreateStructureMemberFromAccess(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  , 
			
			// uint64_t offset
		    ulong offset  
		);
	}
}