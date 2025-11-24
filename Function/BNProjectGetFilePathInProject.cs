using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNProjectGetFilePathInProject(BNProject* project, BNProjectFile* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProjectGetFilePathInProject"
        )]
		internal static extern IntPtr BNProjectGetFilePathInProject(
			
			// BNProject* project
		    IntPtr project  , 
			
			// BNProjectFile* file
		    IntPtr file  
			
		);
	}
}