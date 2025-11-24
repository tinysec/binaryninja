using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMediumLevelILFunction* BNNewMediumLevelILFunctionReference(BNMediumLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewMediumLevelILFunctionReference"
        )]
		internal static extern IntPtr BNNewMediumLevelILFunctionReference(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  
			
		);
	}
}