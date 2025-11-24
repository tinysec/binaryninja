using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNUpdateVersion 
	{
		/// <summary>
		/// const char* version
		/// </summary>
		public IntPtr version;
		
		/// <summary>
		/// const char* notes
		/// </summary>
		public IntPtr notes;
		
		/// <summary>
		/// uint64_t time
		/// </summary>
		public ulong time;
	}

    public sealed class UpdateVersion 
    {
		public string Version { get; set; } = string.Empty;
		
		public string Notes { get; set; } = string.Empty;
		
		public ulong Time { get; set; } = 0;
		
		public UpdateVersion() 
		{
		    
		}
    }
}