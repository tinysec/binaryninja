using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSnapshot* BNCollaborationMergeSnapshots(BNSnapshot* first, BNSnapshot* second, void** conflictHandler, void* conflictHandlerCtxt, void** progress, void* progressContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationMergeSnapshots"
        )]
		internal static extern IntPtr BNCollaborationMergeSnapshots(
			
			// BNSnapshot* first
		    IntPtr first  , 
			
			// BNSnapshot* second
		    IntPtr second  , 
			
			// void** conflictHandler
		    IntPtr conflictHandler  , 
			
			// void* conflictHandlerCtxt
		    IntPtr conflictHandlerCtxt  , 
			
			// void** progress
		    IntPtr progress  , 
			
			// void* progressContext
		    IntPtr progressContext  
		);
	}
}