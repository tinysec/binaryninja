using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNCreateNamedTypeReferenceFromType(BNBinaryView* view, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateNamedTypeReferenceFromType"
        )]
		internal static extern IntPtr BNCreateNamedTypeReferenceFromType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* name
		    IntPtr name  
		);
	}
}