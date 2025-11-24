using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeBuilder* BNCreatePointerTypeBuilder(BNArchitecture* arch, BNTypeWithConfidence* type, BNBoolWithConfidence* cnst, BNBoolWithConfidence* vltl, BNReferenceType refType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreatePointerTypeBuilder"
        )]
		internal static extern IntPtr BNCreatePointerTypeBuilder(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNTypeWithConfidence* type
		    IntPtr type  , 
			
			// BNBoolWithConfidence* cnst
		    IntPtr cnst  , 
			
			// BNBoolWithConfidence* vltl
		    IntPtr vltl  , 
			
			// BNReferenceType refType
		    ReferenceType refType  
		);
	}
}