using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNStackVariableReference 
	{
		/// <summary>
		/// uint32_t sourceOperand
		/// </summary>
		public uint sourceOperand;
		
		/// <summary>
		/// uint8_t typeConfidence
		/// </summary>
		public byte typeConfidence;
		
		/// <summary>
		/// BNType* type
		/// </summary>
		public IntPtr type;
		
		/// <summary>
		/// const char* name
		/// </summary>
		public IntPtr name;
		
		/// <summary>
		/// uint64_t varIdentifier
		/// </summary>
		public ulong varIdentifier;
		
		/// <summary>
		/// int64_t referencedOffset
		/// </summary>
		public long referencedOffset;
		
		/// <summary>
		/// uint64_t size
		/// </summary>
		public ulong size;
	}

    public sealed class StackVariableReference 
    {
		public uint SourceOperand { get; set; } = 0;
		
		public byte TypeConfidence { get; set; } = 0;
		
		public BinaryNinja.Type? Type { get; set; } = null;
	
		public string Name { get; set; } = string.Empty;
		
		public ulong VarIdentifier { get; set; } = 0;
		
		public long ReferencedOffset { get; set; } = 0;
		
		public ulong Size { get; set; } = 0;
		
		public StackVariableReference() 
		{
		    
		}
    }
}