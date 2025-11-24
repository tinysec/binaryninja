using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNTransformParameter 
	{
		/// <summary>
		/// char* name
		/// </summary>
		internal IntPtr name;
		
		/// <summary>
		/// BNDataBuffer* value
		/// </summary>
		internal IntPtr value;
	}

    public sealed class TransformParameter : INativeWrapperEx<BNTransformParameter>
    {
		public string Name { get; set; } = string.Empty;

		public DataBuffer Value { get; set; }
		
		public TransformParameter(string name , DataBuffer value) 
		{
		    this.Name = name;
		    this.Value = value;
		}

		public TransformParameter(string name , byte[] value) 
		{
			this.Name = name;
			this.Value = DataBuffer.FromBytes(value);
		}
		
		internal static TransformParameter FromNative(BNTransformParameter native)
		{
			return new TransformParameter(
				UnsafeUtils.ReadAnsiString(native.name) ,
				DataBuffer.MustNewFromHandle(native.value)
			);
		}

		public BNTransformParameter ToNativeEx(ScopedAllocator allocator)
		{
			return new BNTransformParameter()
			{
				name = allocator.AllocAnsiString(this.Name) , 
				value = this.Value.DangerousGetHandle()
			};
		}
    }
}