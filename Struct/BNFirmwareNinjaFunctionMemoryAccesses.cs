using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNFirmwareNinjaFunctionMemoryAccesses 
	{
		/// <summary>
		/// uint64_t start
		/// </summary>
		public ulong start;
		
		/// <summary>
		/// uint64_t count
		/// </summary>
		public ulong count;
		
		/// <summary>
		/// BNFirmwareNinjaMemoryAccess** accesses
		/// </summary>
		public IntPtr accesses;
	}

    public class FirmwareNinjaFunctionMemoryAccesses 
    {
		public ulong Start { get; set; } = 0;
		
		public ulong Count { get; set; } = 0;
	
		public IntPtr Accesses { get; set; } = IntPtr.Zero;
		
		public FirmwareNinjaFunctionMemoryAccesses() 
		{
		    
		}
    }
}