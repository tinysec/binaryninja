using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNTypeWithReplacedNamedTypeReference(BNType* type, BNNamedTypeReference* from, BNNamedTypeReference* to)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeWithReplacedNamedTypeReference"
        )]
		internal static extern IntPtr BNTypeWithReplacedNamedTypeReference(
			
			// BNType* type
		    IntPtr type  , 
			
			// BNNamedTypeReference* _from
		    IntPtr _from  , 
			
			// BNNamedTypeReference* to
		    IntPtr to  
			
		);
	}
}