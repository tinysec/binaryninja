using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNDataVariable 
	{
		/// <summary>
		/// uint64_t address
		/// </summary>
		internal ulong address;
		
		/// <summary>
		/// BNType* type
		/// </summary>
		internal IntPtr type;
		
		/// <summary>
		/// bool autoDiscovered
		/// </summary>
		internal bool autoDiscovered;
		
		/// <summary>
		/// uint8_t typeConfidence
		/// </summary>
		internal byte typeConfidence;
	}

    public sealed class DataVariable 
    {
		public ulong Address { get;  } = 0;
		
		public BinaryNinja.Type Type { get;  }
		
		public bool AutoDiscovered { get;  } = false;
		
		public byte TypeConfidence { get;  } = 0;
		
		public DataVariable(BNDataVariable native) 
		{
			this.Address = native.address;
			this.Type = BinaryNinja.Type.MustNewFromHandle(native.type);
			this.AutoDiscovered = native.autoDiscovered;
			this.TypeConfidence = native.typeConfidence;
		}

		internal static DataVariable FromNative(BNDataVariable native)
		{
			return new DataVariable(native);
		}

		internal static DataVariable TakeNative(BNDataVariable native)
		{
			DataVariable target = DataVariable.FromNative(native);
			
			NativeMethods.BNFreeDataVariable(native);

			return target;
		}

		internal BNDataVariable ToNative()
		{
			return new BNDataVariable()
			{
				address = this.Address ,
				type = this.Type.DangerousGetHandle() ,
				autoDiscovered = this.AutoDiscovered ,
				typeConfidence = this.TypeConfidence
			};
		}
    }
}