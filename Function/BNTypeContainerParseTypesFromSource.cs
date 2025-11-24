using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNTypeContainerParseTypesFromSource(BNTypeContainer* container, const char* source, const char* fileName, const char** options, uint64_t optionCount, const char** includeDirs, uint64_t includeDirCount, const char* autoTypeSource, bool importDepencencies, BNTypeParserResult* result, BNTypeParserError** errors, uint64_t* errorCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeContainerParseTypesFromSource"
        )]
		internal static extern bool BNTypeContainerParseTypesFromSource(
			
			// BNTypeContainer* container
		    IntPtr container  , 
			
			// const char* source
		    string source  , 
			
			// const char* fileName
		    string fileName  , 
			
			// const char** options
		    string[] options  , 
			
			// uint64_t optionCount
		    ulong optionCount  , 
			
			// const char** includeDirs
		    string[] includeDirs  , 
			
			// uint64_t includeDirCount
		    ulong includeDirCount  , 
			
			// const char* autoTypeSource
		    string autoTypeSource  , 
			
			// bool importDepencencies
		    bool importDepencencies  , 
			
			// BNTypeParserResult* result
		    IntPtr result  , 
			
			// BNTypeParserError** errors
		    IntPtr errors  , 
			
			// uint64_t* errorCount
		    IntPtr errorCount  
			
		);
	}
}