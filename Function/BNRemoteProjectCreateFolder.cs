using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteFolder* BNRemoteProjectCreateFolder(BNRemoteProject* project, const char* name, const char* description, BNRemoteFolder* parent, void** progress, void* progressContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteProjectCreateFolder"
        )]
		internal static extern IntPtr BNRemoteProjectCreateFolder(
			
			// BNRemoteProject* project
		    IntPtr project  , 
			
			// const char* name
		    string name  , 
			
			// const char* description
		    string description  , 
			
			// BNRemoteFolder* parent
		    IntPtr parent  , 
			
			// void** progress
		    IntPtr progress  , 
			
			// void* progressContext
		    IntPtr progressContext  
			
		);
	}
}