using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNUpdateChannel* BNGetUpdateChannels(uint64_t* count, const char** errors)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetUpdateChannels"
        )]
		internal static extern IntPtr BNGetUpdateChannels(
			
			// uint64_t* count
		    IntPtr count  , 
			
			// const char** errors
		    string[] errors  
			
		);
	}
}