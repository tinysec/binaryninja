using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNTypeReferenceSource 
	{
		/// <summary>
		/// BNQualifiedName name
		/// </summary>
		internal BNQualifiedName name;
		
		/// <summary>
		/// uint64_t offset
		/// </summary>
		internal ulong offset;
		
		/// <summary>
		/// BNTypeReferenceType type
		/// </summary>
		internal TypeReferenceType type;
	}

    public sealed class TypeReferenceSource : INativeWrapperEx<BNTypeReferenceSource>
    {
		public QualifiedName Name { get; set; } = new QualifiedName();
		
		public ulong Offset { get; set; } = 0;
		
		public TypeReferenceType Type { get; set; } = TypeReferenceType.DirectTypeReferenceType;
		
		public TypeReferenceSource() 
		{
		    
		}

		internal static TypeReferenceSource FromNative(BNTypeReferenceSource native)
		{
			return new TypeReferenceSource()
			{
				Name = QualifiedName.FromNative(native.name) , 
				Offset = native.offset , 
				Type = native.type
			};
		}

		public BNTypeReferenceSource ToNativeEx(ScopedAllocator allocator)
		{
			return new BNTypeReferenceSource()
			{
				name = this.Name.ToNativeEx(allocator) , 
				offset = this.Offset , 
				type = this.Type
			};
		}
    }
}