using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighLevelILFunction* BNNewHighLevelILFunctionReference(BNHighLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewHighLevelILFunctionReference"
        )]
		internal static extern IntPtr BNNewHighLevelILFunctionReference(
			
			// BNHighLevelILFunction* func
		    IntPtr func  
			
		);
	}
}