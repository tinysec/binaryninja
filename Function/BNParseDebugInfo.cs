using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDebugInfo* BNParseDebugInfo(BNDebugInfoParser* parser, BNBinaryView* view, BNBinaryView* debugFile, BNDebugInfo* existingDebugInfo, void** progress, void* progressCtxt)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNParseDebugInfo"
        )]
		internal static extern IntPtr BNParseDebugInfo(
			
			// BNDebugInfoParser* parser
		    IntPtr parser  , 
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNBinaryView* debugFile
		    IntPtr debugFile  , 
			
			// BNDebugInfo* existingDebugInfo
		    IntPtr existingDebugInfo  , 
			
			// void** progress
		    IntPtr progress  , 
			
			// void* progressCtxt
		    IntPtr progressCtxt  
			
		);
	}
}