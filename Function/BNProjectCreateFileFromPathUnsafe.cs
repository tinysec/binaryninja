using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProjectFile* BNProjectCreateFileFromPathUnsafe(BNProject* project, const char* path, BNProjectFolder* folder, const char* name, const char* description, const char* id, int64_t creationTimestamp, void* ctxt, void** progress)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProjectCreateFileFromPathUnsafe"
        )]
		internal static extern IntPtr BNProjectCreateFileFromPathUnsafe(
			
			// BNProject* project
		    IntPtr project  , 
			
			// const char* path
		    string path  , 
			
			// BNProjectFolder* folder
		    IntPtr folder  , 
			
			// const char* name
		    string name  , 
			
			// const char* description
		    string description  , 
			
			// const char* id
		    string id  , 
			
			// int64_t creationTimestamp
		    long creationTimestamp  , 
			
			// void* ctxt
		    IntPtr ctxt  , 
			
			// void** progress
		    IntPtr progress  
			
		);
	}
}