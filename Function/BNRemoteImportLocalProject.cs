using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteProject* BNRemoteImportLocalProject(BNRemote* remote, BNProject* localProject, void** progress, void* progressCtxt)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteImportLocalProject"
        )]
		internal static extern IntPtr BNRemoteImportLocalProject(
			
			// BNRemote* remote
		    IntPtr remote  , 
			
			// BNProject* localProject
		    IntPtr localProject  , 
			
			// void** progress
		    IntPtr progress  , 
			
			// void* progressCtxt
		    IntPtr progressCtxt  
			
		);
	}
}