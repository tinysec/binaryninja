using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNQualifiedNameTypeAndId 
	{
		/// <summary>
		/// BNQualifiedName name
		/// </summary>
		internal BNQualifiedName name;
		
		/// <summary>
		/// const char* id
		/// </summary>
		internal IntPtr id;
		
		/// <summary>
		/// BNType* type
		/// </summary>
		internal IntPtr type;
	}

    public sealed class QualifiedNameTypeAndId : INativeWrapperEx<BNQualifiedNameTypeAndId>
    {
		public QualifiedName Name { get; set; } = new QualifiedName();
		
		public BinaryNinja.Type Type { get; set; }
		
		public string Id { get; set; } = string.Empty;
	
		public QualifiedNameTypeAndId(QualifiedName name ,  BinaryNinja.Type type , string id ) 
		{
		    this.Name = name;
		    this.Type = type;
		    this.Id = id;
		}

		internal static QualifiedNameTypeAndId FromNative(BNQualifiedNameTypeAndId native)
		{
			return new QualifiedNameTypeAndId(
				QualifiedName.FromNative(native.name) ,
				BinaryNinja.Type.MustNewFromHandle(native.type),
				UnsafeUtils.ReadAnsiString(native.id) 
			);
		}

		public BNQualifiedNameTypeAndId ToNativeEx(ScopedAllocator allocator)
		{
			return new BNQualifiedNameTypeAndId()
			{
				name = this.Name.ToNativeEx(allocator) ,
				id = allocator.AllocAnsiString(this.Id) ,
				type = this.Type.DangerousGetHandle()
			};
		}
    }
}