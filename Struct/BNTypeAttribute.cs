using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNTypeAttribute 
	{
		/// <summary>
		/// const char* name
		/// </summary>
		public IntPtr name;
		
		/// <summary>
		/// const char* _value
		/// </summary>
		public IntPtr _value;
	}

    public sealed class TypeAttribute 
    {
		public string Name { get; set; } = string.Empty;
		
		public string Value { get; set; } = string.Empty;
		
		public TypeAttribute() 
		{
		    
		}
    }
}