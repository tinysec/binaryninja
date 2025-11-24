using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNNameList 
	{
		/// <summary>
		/// const char** name
		/// </summary>
		public IntPtr name;
		
		/// <summary>
		/// const char* _join
		/// </summary>
		public IntPtr _join;
		
		/// <summary>
		/// uint64_t nameCount
		/// </summary>
		public ulong nameCount;
	}

    public sealed class NameList 
    {
		public string[] Name { get; set; } = Array.Empty<string>();
		
		public string Join { get; set; } = string.Empty;
		
		public NameList() 
		{
		    
		}
    }
}