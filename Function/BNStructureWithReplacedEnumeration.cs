using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructure* BNStructureWithReplacedEnumeration(BNStructure* s, BNEnumeration* from, BNEnumeration* to)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNStructureWithReplacedEnumeration"
        )]
		internal static extern IntPtr BNStructureWithReplacedEnumeration(
			
			// BNStructure* s
		    IntPtr s  , 
			
			// BNEnumeration* _from
		    IntPtr _from  , 
			
			// BNEnumeration* to
		    IntPtr to  
			
		);
	}
}