using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNTransformParameterInfo 
	{
		/// <summary>
		/// char* name
		/// </summary>
		internal IntPtr name;
		
		/// <summary>
		/// char* longName
		/// </summary>
		internal IntPtr longName;
		
		/// <summary>
		/// uint64_t fixedLength
		/// </summary>
		internal ulong fixedLength;
	}

    public sealed class TransformParameterInfo : INativeWrapperEx<BNTransformParameterInfo>
    {
		public string Name { get; set; } = string.Empty;
		
		public string LongName { get; set; } = string.Empty;
		
		public ulong FixedLength { get; set; } = 0;
		
		public TransformParameterInfo() 
		{
		    
		}

		internal static TransformParameterInfo FromNative(BNTransformParameterInfo native)
		{
			return new TransformParameterInfo()
			{
				Name = UnsafeUtils.ReadAnsiString(native.name) ,
				LongName = UnsafeUtils.ReadAnsiString(native.longName) ,
				FixedLength = native.fixedLength
			};
		}

		public BNTransformParameterInfo ToNativeEx(ScopedAllocator allocator)
		{
			return new BNTransformParameterInfo()
			{
				name = allocator.AllocAnsiString(this.Name) ,
				longName = allocator.AllocAnsiString(this.LongName) ,
				fixedLength = this.FixedLength
			};
		}
		
		internal BNTransformParameterInfo UnsafeToNative()
		{
			return new BNTransformParameterInfo()
			{
				name = UnsafeUtils.AllocAnsiString(this.Name) ,
				longName = UnsafeUtils.AllocAnsiString(this.LongName) ,
				fixedLength = this.FixedLength
			};
		}
		
		internal static BNTransformParameterInfo[] UnsafeToNativeArray(TransformParameterInfo[] parameters)
		{
			List<BNTransformParameterInfo> targets = new List<BNTransformParameterInfo>();

			foreach (TransformParameterInfo source in parameters)
			{
				targets.Add( source.UnsafeToNative() );
			}

			return targets.ToArray();
		}
    }
}