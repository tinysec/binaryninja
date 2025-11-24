using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNFirmwareNinjaDevice 
	{
		/// <summary>
		/// const char* name
		/// </summary>
		public IntPtr name;
		
		/// <summary>
		/// uint64_t start
		/// </summary>
		public ulong start;
		
		/// <summary>
		/// uint64_t end
		/// </summary>
		public ulong end;
		
		/// <summary>
		/// const char* info
		/// </summary>
		public IntPtr info;
	}

    public class FirmwareNinjaDevice 
    {
		public string Name { get; set; } = string.Empty;
		
		public ulong Start { get; set; } = 0;
	
		public ulong End { get; set; } = 0;
		
		public string Info { get; set; } = string.Empty;
		
		public FirmwareNinjaDevice() 
		{
		    
		}
    }
}