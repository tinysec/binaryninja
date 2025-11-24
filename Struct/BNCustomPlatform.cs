using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCustomPlatform 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** _init
		/// </summary>
		public IntPtr _init;
		
		/// <summary>
		/// void** viewInit
		/// </summary>
		public IntPtr viewInit;
		
		/// <summary>
		/// void** getGlobalRegisters
		/// </summary>
		public IntPtr getGlobalRegisters;
		
		/// <summary>
		/// void** freeRegisterList
		/// </summary>
		public IntPtr freeRegisterList;
		
		/// <summary>
		/// void** getGlobalRegisterType
		/// </summary>
		public IntPtr getGlobalRegisterType;
		
		/// <summary>
		/// void** getAddressSize
		/// </summary>
		public IntPtr getAddressSize;
		
		/// <summary>
		/// void** adjustTypeParserInput
		/// </summary>
		public IntPtr adjustTypeParserInput;
		
		/// <summary>
		/// void** freeTypeParserInput
		/// </summary>
		public IntPtr freeTypeParserInput;
		
		/// <summary>
		/// void** getFallbackEnabled
		/// </summary>
		public IntPtr getFallbackEnabled;
	}

    public class CustomPlatform 
    {
		public CustomPlatform() 
		{
		    
		}
    }
}