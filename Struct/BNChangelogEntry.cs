using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNChangelogEntry 
	{
		/// <summary>
		/// BNVersionInfo version
		/// </summary>
		public BNVersionInfo version;
		
		/// <summary>
		/// const char* notes
		/// </summary>
		public IntPtr notes;
		
		/// <summary>
		/// uint64_t time
		/// </summary>
		public ulong time;
	}

    public sealed class ChangelogEntry 
    {
		public VersionInfo Version { get; set; } = new VersionInfo();

		public string Notes { get; set; } = string.Empty;
		
		public ulong Time { get; set; } = 0;
		
		public ChangelogEntry() 
		{
		    
		}
    }
}