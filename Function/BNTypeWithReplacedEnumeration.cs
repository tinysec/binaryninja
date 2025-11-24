using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNTypeWithReplacedEnumeration(BNType* type, BNEnumeration* from, BNEnumeration* to)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeWithReplacedEnumeration"
        )]
		internal static extern IntPtr BNTypeWithReplacedEnumeration(
			
			// BNType* type
		    IntPtr type  , 
			
			// BNEnumeration* _from
		    IntPtr _from  , 
			
			// BNEnumeration* to
		    IntPtr to  
			
		);
	}
}