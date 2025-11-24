using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNFirmwareNinjaSection 
	{
		/// <summary>
		/// BNFirmwareNinjaSectionType type
		/// </summary>
		public FirmwareNinjaSectionType type;
		
		/// <summary>
		/// uint64_t start
		/// </summary>
		public ulong start;
		
		/// <summary>
		/// uint64_t end
		/// </summary>
		public ulong end;
		
		/// <summary>
		/// float entropy
		/// </summary>
		public float entropy;
	}

    public class FirmwareNinjaSection 
    {
		public FirmwareNinjaSectionType Type { get; set; } = new FirmwareNinjaSectionType();
		
		public ulong Start { get; set; } = 0;
		
		public ulong End { get; set; } = 0;
		
		public float Entropy { get; set; } = 0;
		
		public FirmwareNinjaSection() 
		{
		    
		}
    }
}