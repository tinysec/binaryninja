using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNUpdateChannelFullInfo 
	{
		/// <summary>
		/// BNUpdateVersionNew* versions
		/// </summary>
		public IntPtr versions;
		
		/// <summary>
		/// uint64_t versionCount
		/// </summary>
		public ulong versionCount;
		
		/// <summary>
		/// BNChangelogEntry* changelogEntries
		/// </summary>
		public IntPtr changelogEntries;
		
		/// <summary>
		/// uint64_t changelogEntryCount
		/// </summary>
		public ulong changelogEntryCount;
		
		/// <summary>
		/// const char* name
		/// </summary>
		public IntPtr name;
		
		/// <summary>
		/// const char* desc
		/// </summary>
		public IntPtr desc;
		
		/// <summary>
		/// const char* latestVersion
		/// </summary>
		public IntPtr latestVersion;
	}

    public sealed class UpdateChannelFullInfo 
    {
		public UpdateVersionNew[] Versions { get; set; } = Array.Empty<UpdateVersionNew>();
		
		public ChangelogEntry[] ChangelogEntries { get; set; } = Array.Empty<ChangelogEntry>();
		
		public string Name { get; set; } = string.Empty;
	
		public string Desc { get; set; } = string.Empty;
	
		public string LatestVersion { get; set; } = string.Empty;
		
		public UpdateChannelFullInfo() 
		{
		    
		}
    }
}