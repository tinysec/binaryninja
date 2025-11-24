using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeBuilder* BNCreateNamedTypeReferenceBuilderFromType(BNBinaryView* view, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateNamedTypeReferenceBuilderFromType"
        )]
		internal static extern IntPtr BNCreateNamedTypeReferenceBuilderFromType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* name
		    IntPtr name  
		);
	}
}