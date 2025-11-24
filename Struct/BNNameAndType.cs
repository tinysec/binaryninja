using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNNameAndType 
	{
		/// <summary>
		/// const char* name
		/// </summary>
		internal IntPtr name;
		
		/// <summary>
		/// BNType* type
		/// </summary>
		internal IntPtr type;
		
		/// <summary>
		/// uint8_t typeConfidence
		/// </summary>
		internal byte typeConfidence;
	}

    public sealed class NameAndType 
    {
		public string Name { get; } = string.Empty;
		
		public BinaryNinja.Type Type { get;  }
		
		public byte TypeConfidence { get;  } = 0;
		
		public NameAndType(
			string name,
			BinaryNinja.Type type,
			byte typeConfidence
		)
		{
			this.Name = name;
			this.Type = type;
			this.TypeConfidence = typeConfidence;
		}
		
		internal NameAndType(BNNameAndType native)
		{
			this.Name = UnsafeUtils.ReadAnsiString(native.name);

			this.Type = BinaryNinja.Type.MustNewFromHandle(native.type);
			
			this.TypeConfidence = native.typeConfidence;
		}

		internal static NameAndType FromNative(BNNameAndType native)
		{
			return new NameAndType(native);
		}
    }
}