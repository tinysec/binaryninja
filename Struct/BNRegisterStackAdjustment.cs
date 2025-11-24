using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNRegisterStackAdjustment 
	{
		/// <summary>
		/// uint32_t regStack
		/// </summary>
		public uint regStack;
		
		/// <summary>
		/// int32_t adjustment
		/// </summary>
		public int adjustment;
		
		/// <summary>
		/// uint8_t confidence
		/// </summary>
		public byte confidence;
		
	}

    public sealed class RegisterStackAdjustment 
    {
		public uint RegStack { get; set; } = 0;
		
		public int Adjustment { get; set; } = 0;

		public byte Confidence { get; set; } = 0;
		
		public RegisterStackAdjustment() 
		{
		    
		}
    }
}