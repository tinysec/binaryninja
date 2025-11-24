using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNTypeField 
	{
		/// <summary>
		/// BNQualifiedName name
		/// </summary>
		public BNQualifiedName name;
		
		/// <summary>
		/// uint64_t offset
		/// </summary>
		public ulong offset;
	}

    public sealed class TypeField 
    {
		public QualifiedName Name { get; set; } = new QualifiedName();
		
		public ulong Offset { get; set; } = 0;
		
		public TypeField() 
		{
		    
		}
    }
}