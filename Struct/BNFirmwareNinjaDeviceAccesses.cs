using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNFirmwareNinjaDeviceAccesses 
	{
		/// <summary>
		/// const char* name
		/// </summary>
		public IntPtr name;
		
		/// <summary>
		/// uint64_t total
		/// </summary>
		public ulong total;
		
		/// <summary>
		/// uint64_t unique
		/// </summary>
		public ulong unique;
	}

    public class FirmwareNinjaDeviceAccesses 
    {
		public string Name { get; set; } = string.Empty;
		
		public ulong Total { get; set; } = 0;
	
		public ulong Unique { get; set; } = 0;
		
		public FirmwareNinjaDeviceAccesses() 
		{
		    
		}
    }
}