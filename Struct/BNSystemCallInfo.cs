using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNSystemCallInfo 
	{
		/// <summary>
		/// uint32_t number
		/// </summary>
		internal uint number;
		
		/// <summary>
		/// BNQualifiedName name
		/// </summary>
		internal BNQualifiedName name;
		
		/// <summary>
		/// BNType* type
		/// </summary>
		internal IntPtr type;
	}

    public sealed class SystemCallInfo : INativeWrapperEx<BNSystemCallInfo>
    {
		public uint Number { get; set; } = 0;
		
		public QualifiedName Name { get; set; } = new QualifiedName();
		
		public BinaryNinja.Type? Type { get; set; } = null;
		
		public SystemCallInfo() 
		{
		    
		}

		internal static SystemCallInfo FromNative(BNSystemCallInfo native)
		{
			return new SystemCallInfo()
			{
				Number = native.number ,
				Name = QualifiedName.FromNative(native.name) ,
				Type = BinaryNinja.Type.NewFromHandle(native.type) ,
			};
		}

		public BNSystemCallInfo ToNativeEx(ScopedAllocator allocator)
		{
			return new BNSystemCallInfo()
			{
				number = this.Number ,
				name = this.Name.ToNativeEx(allocator) ,
				type = ( null == this.Type ? IntPtr.Zero : this.Type.DangerousGetHandle() )
			};
		}
    }
}