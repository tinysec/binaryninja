using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPluginCommand* BNGetValidPluginCommandsForProject(BNProject* project, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetValidPluginCommandsForProject"
        )]
		internal static extern IntPtr BNGetValidPluginCommandsForProject(
			
			// BNProject* project
		    IntPtr project  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}