using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNPreprocessSource(const char* source, const char* fileName, const char** output, const char** errors, const char** includeDirs, uint64_t includeDirCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNPreprocessSource"
        )]
		internal static extern bool BNPreprocessSource(
			
			// const char* source
		    string source  , 
			
			// const char* fileName
		    string fileName  , 
			
			// const char** output
		    string[] output  , 
			
			// const char** errors
		    string[] errors  , 
			
			// const char** includeDirs
		    string[] includeDirs  , 
			
			// uint64_t includeDirCount
		    ulong includeDirCount  
			
		);
	}
}