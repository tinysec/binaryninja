using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNCollaborationGroupGetUsers(BNCollaborationGroup* group, const char*** userIds, const char*** usernames, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNCollaborationGroupGetUsers"
        )]
		internal static extern bool BNCollaborationGroupGetUsers(
			
			// BNCollaborationGroup* _group
		    IntPtr _group  , 
			
			// const char*** userIds
		    IntPtr userIds  , 
			
			// const char*** usernames
		    IntPtr usernames  , 
			
			// uint64_t* count
		    IntPtr count  
		);
	}
}