using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNUpdateChannel 
	{
		/// <summary>
		/// const char* name
		/// </summary>
		public IntPtr name;
		
		/// <summary>
		/// const char* description
		/// </summary>
		public IntPtr description;
		
		/// <summary>
		/// const char* latestVersion
		/// </summary>
		public IntPtr latestVersion;
	}

    public sealed class UpdateChannel 
    {
		public string Name { get; set; } = string.Empty;
		
		public string Description { get; set; } = string.Empty;
		
		public string LatestVersion { get; set; } = string.Empty;
		
		public UpdateChannel() 
		{
		    
		}
    }
}