using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNDownloadInstanceResponse 
	{
		/// <summary>
		/// uint16_t statusCode
		/// </summary>
		public ushort statusCode;
		
		/// <summary>
		/// uint64_t headerCount
		/// </summary>
		public ulong headerCount;
		
		/// <summary>
		/// const char** headerKeys
		/// </summary>
		public IntPtr headerKeys;
		
		/// <summary>
		/// const char** headerValues
		/// </summary>
		public IntPtr headerValues;
	}

    public class DownloadInstanceResponse 
    {
		public ushort StatusCode { get; set; } = 0;
		
		public ulong HeaderCount { get; set; } = 0;
		
		public string[] HeaderKeys { get; set; } = Array.Empty<string>();
		
		public string[] HeaderValues { get; set; } = Array.Empty<string>();
		
		public DownloadInstanceResponse() 
		{
		    
		}
    }
}