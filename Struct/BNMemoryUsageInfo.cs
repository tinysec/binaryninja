using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNMemoryUsageInfo 
	{
		/// <summary>
		/// const char* name
		/// </summary>
		public IntPtr name;
		
		/// <summary>
		/// uint64_t _value
		/// </summary>
		public ulong _value;
	}

    public sealed class MemoryUsageInfo 
    {
		public string Name { get; set; } = string.Empty;
		
		public ulong Value { get; set; } = 0;
		
		public MemoryUsageInfo() 
		{
		    
		}
    }
}