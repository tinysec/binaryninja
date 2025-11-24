using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProjectFile* BNProjectCreateFileFromPath(BNProject* project, const char* path, BNProjectFolder* folder, const char* name, const char* description, void* ctxt, void** progress)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProjectCreateFileFromPath"
        )]
		internal static extern IntPtr BNProjectCreateFileFromPath(
			
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
			
			// void* ctxt
		    IntPtr ctxt  , 
			
			// void** progress
		    IntPtr progress  
			
		);
	}
}