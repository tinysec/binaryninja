using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNTypeWithReplacedStructure(BNType* type, BNStructure* from, BNStructure* to)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeWithReplacedStructure"
        )]
		internal static extern IntPtr BNTypeWithReplacedStructure(
			
			// BNType* type
		    IntPtr type  , 
			
			// BNStructure* _from
		    IntPtr _from  , 
			
			// BNStructure* to
		    IntPtr to  
			
		);
	}
}