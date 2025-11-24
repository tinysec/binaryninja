using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNParseTypesFromSource(BNPlatform* platform, const char* source, const char* fileName, BNTypeParserResult* result, const char** errors, const char** includeDirs, uint64_t includeDirCount, const char* autoTypeSource)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNParseTypesFromSource"
        )]
		internal static extern bool BNParseTypesFromSource(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// const char* source
		    string source  , 
			
			// const char* fileName
		    string fileName  , 
			
			// BNTypeParserResult* result
		    IntPtr result  , 
			
			// const char** errors
		    string[] errors  , 
			
			// const char** includeDirs
		    string[] includeDirs  , 
			
			// uint64_t includeDirCount
		    ulong includeDirCount  , 
			
			// const char* autoTypeSource
		    string autoTypeSource  
			
		);
	}
}