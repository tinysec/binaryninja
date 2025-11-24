using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeBuilder* BNCreateNamedTypeReferenceBuilder(BNNamedTypeReference* nt, uint64_t width, uint64_t align, BNBoolWithConfidence* cnst, BNBoolWithConfidence* vltl)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateNamedTypeReferenceBuilder"
        )]
		internal static extern IntPtr BNCreateNamedTypeReferenceBuilder(
			
			// BNNamedTypeReference* nt
		    IntPtr nt  , 
			
			// uint64_t width
		    ulong width  , 
			
			// uint64_t align
		    ulong align  , 
			
			// BNBoolWithConfidence* cnst
		    in BNBoolWithConfidence cnst  , 
			
			// BNBoolWithConfidence* vltl
		    in BNBoolWithConfidence vltl  
		);
	}
}