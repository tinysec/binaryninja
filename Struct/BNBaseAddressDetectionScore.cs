using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNBaseAddressDetectionScore 
	{
		/// <summary>
		/// uint64_t Score
		/// </summary>
		public ulong Score;
		
		/// <summary>
		/// uint64_t BaseAddress
		/// </summary>
		public ulong BaseAddress;
	}

    public sealed class BaseAddressDetectionScore 
    {
		public ulong Score { get; set; } = 0;
		
		public ulong BaseAddress { get; set; } = 0;
		
		public BaseAddressDetectionScore() 
		{
		    
		}
    }
}