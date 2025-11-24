using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNUpdateVersionNew 
	{
		/// <summary>
		/// BNVersionInfo version
		/// </summary>
		public BNVersionInfo version;
		
		/// <summary>
		/// const char* name
		/// </summary>
		public IntPtr name;
		
		/// <summary>
		/// uint64_t time
		/// </summary>
		public ulong time;
	}

    public sealed class UpdateVersionNew 
    {
		public VersionInfo Version { get; set; } = new VersionInfo();
		
		public string Name { get; set; } = string.Empty;
		
		public ulong Time { get; set; } = 0;
		
		public UpdateVersionNew() 
		{
		    
		}
    }
}