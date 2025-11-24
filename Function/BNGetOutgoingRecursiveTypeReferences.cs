using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNQualifiedName* BNGetOutgoingRecursiveTypeReferences(BNBinaryView* view, BNQualifiedName* types, uint64_t typeCount, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetOutgoingRecursiveTypeReferences"
        )]
		internal static extern IntPtr BNGetOutgoingRecursiveTypeReferences(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* types
		    BNQualifiedName[] types  , 
			
			// uint64_t typeCount
		    ulong typeCount  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}