using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNMergedVariable 
	{
		/// <summary>
		/// BNVariable target
		/// </summary>
		public BNVariable target;
		
		/// <summary>
		/// BNVariable* sources
		/// </summary>
		public IntPtr sources;
		
		/// <summary>
		/// uint64_t sourceCount
		/// </summary>
		public ulong sourceCount;
	}

    public class MergedVariable 
    {
		public CoreVariable? Target { get; set; } = null;
		
		public CoreVariable[] Sources { get; set; } = Array.Empty<CoreVariable>();
		
		public MergedVariable() 
		{
		    
		}
    }
}