using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblyTextLine* BNFormatLines(BNLineFormatter* formatter, BNDisassemblyTextLine* inLines, uint64_t inCount, BNLineFormatterSettings* settings, uint64_t* outCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFormatLines"
        )]
		internal static extern IntPtr BNFormatLines(
			
			// BNLineFormatter* formatter
		    IntPtr formatter  , 
			
			// BNDisassemblyTextLine* inLines
		    IntPtr inLines  , 
			
			// uint64_t inCount
		    ulong inCount  , 
			
			// BNLineFormatterSettings* settings
		    IntPtr settings  , 
			
			// uint64_t* outCount
		    IntPtr outCount  
			
		);
	}
}