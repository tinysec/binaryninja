using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeBuilder* BNCreateNamedTypeReferenceBuilderWithBuilder(BNNamedTypeReferenceBuilder* nt, uint64_t width, uint64_t align, BNBoolWithConfidence* cnst, BNBoolWithConfidence* vltl)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateNamedTypeReferenceBuilderWithBuilder"
        )]
		internal static extern IntPtr BNCreateNamedTypeReferenceBuilderWithBuilder(
			
			// BNNamedTypeReferenceBuilder* nt
		    IntPtr nt  , 
			
			// uint64_t width
		    ulong width  , 
			
			// uint64_t align
		    ulong align  , 
			
			// BNBoolWithConfidence* cnst
		    IntPtr cnst  , 
			
			// BNBoolWithConfidence* vltl
		    IntPtr vltl  
		);
	}
}