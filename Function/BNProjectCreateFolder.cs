using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProjectFolder* BNProjectCreateFolder(BNProject* project, BNProjectFolder* parent, const char* name, const char* description)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProjectCreateFolder"
        )]
		internal static extern IntPtr BNProjectCreateFolder(
			
			// BNProject* project
		    IntPtr project  , 
			
			// BNProjectFolder* parent
		    IntPtr parent  , 
			
			// const char* name
		    string name  , 
			
			// const char* description
		    string description  
			
		);
	}
}