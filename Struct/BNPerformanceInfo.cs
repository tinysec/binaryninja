using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNPerformanceInfo 
	{
		
		/// <summary>
		/// const char* name
		/// </summary>
		public IntPtr name;
		
		/// <summary>
		/// double seconds
		/// </summary>
		public double seconds;
		
	}

    public sealed class PerformanceInfo 
    {
		
		/// <summary>
		/// const char* name
		/// </summary>
		public string Name { get; set; } = string.Empty;
		
		/// <summary>
		/// double seconds
		/// </summary>
		public double Seconds { get; set; } = 0;
		
		
		public PerformanceInfo() 
		{
		    
		}
    }
}