using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSplitVariable(BNFunction* func, BNVariable* var)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSplitVariable"
        )]
		internal static extern void BNSplitVariable(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    IntPtr _var  
			
		);
	}
}