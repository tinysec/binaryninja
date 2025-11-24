using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMediumLevelILFunction* BNGetMediumLevelILForHighLevelILFunction(BNHighLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILForHighLevelILFunction"
        )]
		internal static extern IntPtr BNGetMediumLevelILForHighLevelILFunction(
			
			// BNHighLevelILFunction* func
		    IntPtr func  
		);
	}
}