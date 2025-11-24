using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteFile* BNCollaborationUploadDatabase(BNFileMetadata* metadata, BNRemoteProject* project, BNRemoteFolder* folder, void** progress, void* progressContext, void** nameChangeset, void* nameChangesetContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationUploadDatabase"
        )]
		internal static extern IntPtr BNCollaborationUploadDatabase(
			
			// BNFileMetadata* metadata
		    IntPtr metadata  , 
			
			// BNRemoteProject* project
		    IntPtr project  , 
			
			// BNRemoteFolder* folder
		    IntPtr folder  , 
			
			// void** progress
		    IntPtr progress  , 
			
			// void* progressContext
		    IntPtr progressContext  , 
			
			// void** nameChangeset
		    IntPtr nameChangeset  , 
			
			// void* nameChangesetContext
		    IntPtr nameChangesetContext  
		);
	}
}