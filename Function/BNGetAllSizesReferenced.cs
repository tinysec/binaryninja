using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeFieldReferenceSizeInfo* BNGetAllSizesReferenced(BNBinaryView* view, BNQualifiedName* type, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetAllSizesReferenced"
        )]
		internal static extern IntPtr BNGetAllSizesReferenced(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* type
		    in BNQualifiedName type  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}