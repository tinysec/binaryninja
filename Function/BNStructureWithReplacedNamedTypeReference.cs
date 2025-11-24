using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructure* BNStructureWithReplacedNamedTypeReference(BNStructure* s, BNNamedTypeReference* from, BNNamedTypeReference* to)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNStructureWithReplacedNamedTypeReference"
        )]
		internal static extern IntPtr BNStructureWithReplacedNamedTypeReference(
			
			// BNStructure* s
		    IntPtr s  , 
			
			// BNNamedTypeReference* _from
		    IntPtr _from  , 
			
			// BNNamedTypeReference* to
		    IntPtr to  
			
		);
	}
}