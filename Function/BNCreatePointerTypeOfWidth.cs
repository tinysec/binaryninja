using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNCreatePointerTypeOfWidth(uint64_t width, BNTypeWithConfidence* type, BNBoolWithConfidence* cnst, BNBoolWithConfidence* vltl, BNReferenceType refType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreatePointerTypeOfWidth"
        )]
		internal static extern IntPtr BNCreatePointerTypeOfWidth(
			
			// uint64_t width
		    ulong width  , 
			
			// BNTypeWithConfidence* type
			in BNTypeWithConfidence type  , 
			
			// BNBoolWithConfidence* cnst
			in BNBoolWithConfidence cnst  , 
			
			// BNBoolWithConfidence* vltl
		    // volatile
		    in BNBoolWithConfidence vltl  , 
			
			// BNReferenceType refType
		    ReferenceType refType  
		);
	}
}