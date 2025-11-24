using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLLILVariableVersionList(uint64_t* versions)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeLLILVariableVersionList"
        )]
		internal static extern void BNFreeLLILVariableVersionList(
			
			// uint64_t* versions
		    IntPtr versions  
			
		);
	}
}