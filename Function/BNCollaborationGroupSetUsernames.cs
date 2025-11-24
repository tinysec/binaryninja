using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNCollaborationGroupSetUsernames(BNCollaborationGroup* group, const char** names, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNCollaborationGroupSetUsernames"
        )]
		internal static extern bool BNCollaborationGroupSetUsernames(
			
			// BNCollaborationGroup* _group
		    IntPtr _group  , 
			
			// const char** names
		    string[] names  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}