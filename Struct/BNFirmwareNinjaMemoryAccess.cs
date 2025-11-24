using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNFirmwareNinjaMemoryAccess 
	{
		/// <summary>
		/// uint64_t instrAddress
		/// </summary>
		public ulong instrAddress;
		
		/// <summary>
		/// BNRegisterValue memAddress
		/// </summary>
		public BNRegisterValue memAddress;
		
		/// <summary>
		/// BNFirmwareNinjaMemoryHeuristic heuristic
		/// </summary>
		public FirmwareNinjaMemoryHeuristic heuristic;
		
		/// <summary>
		/// BNFirmwareNinjaMemoryAccessType type
		/// </summary>
		public FirmwareNinjaMemoryAccessType type;
		
		/// <summary>
		/// BNRegisterValue _value
		/// </summary>
		public BNRegisterValue _value;
	}

    public class FirmwareNinjaMemoryAccess 
    {
		public ulong InstrAddress { get; set; } = 0;
		
		public RegisterValue MemAddress { get; set; } = new RegisterValue();
		
		public FirmwareNinjaMemoryHeuristic Heuristic { get; set; } = new FirmwareNinjaMemoryHeuristic();
		
		public FirmwareNinjaMemoryAccessType Type { get; set; } = new FirmwareNinjaMemoryAccessType();
		
		public RegisterValue Value { get; set; } = new RegisterValue();
		
		public FirmwareNinjaMemoryAccess() 
		{
		    
		}
    }
}