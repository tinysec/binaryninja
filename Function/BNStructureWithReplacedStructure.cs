using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructure* BNStructureWithReplacedStructure(BNStructure* s, BNStructure* from, BNStructure* to)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNStructureWithReplacedStructure"
        )]
		internal static extern IntPtr BNStructureWithReplacedStructure(
			
			// BNStructure* s
		    IntPtr s  , 
			
			// BNStructure* _from
		    IntPtr _from  , 
			
			// BNStructure* to
		    IntPtr to  
			
		);
	}
}