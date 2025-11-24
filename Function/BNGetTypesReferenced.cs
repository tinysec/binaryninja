using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeWithConfidence* BNGetTypesReferenced(BNBinaryView* view, BNQualifiedName* type, uint64_t offset, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypesReferenced"
        )]
		internal static extern IntPtr BNGetTypesReferenced(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* type
		    in BNQualifiedName type  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}