using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNQualifiedName* BNGetOutgoingDirectTypeReferences(BNBinaryView* view, BNQualifiedName* type, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetOutgoingDirectTypeReferences"
        )]
		internal static extern IntPtr BNGetOutgoingDirectTypeReferences(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* type
		    in BNQualifiedName type  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}