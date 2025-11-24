using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProjectFolder* BNProjectCreateFolderUnsafe(BNProject* project, BNProjectFolder* parent, const char* name, const char* description, const char* id)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProjectCreateFolderUnsafe"
        )]
		internal static extern IntPtr BNProjectCreateFolderUnsafe(
			
			// BNProject* project
		    IntPtr project  , 
			
			// BNProjectFolder* parent
		    IntPtr parent  , 
			
			// const char* name
		    string name  , 
			
			// const char* description
		    string description  , 
			
			// const char* id
		    string id  
			
		);
	}
}