using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNTypeFieldReferenceTypeInfo 
	{
		/// <summary>
		/// uint64_t offset
		/// </summary>
		internal ulong offset;
		
		/// <summary>
		/// BNTypeWithConfidence* types
		/// </summary>
		internal IntPtr types;
		
		/// <summary>
		/// uint64_t count
		/// </summary>
		internal ulong count;
	}

    public sealed class TypeFieldReferenceTypeInfo 
    {
		public ulong Offset { get; set; } = 0;
		
		public TypeWithConfidence[] Types { get; set; } = Array.Empty<TypeWithConfidence>();

		public TypeFieldReferenceTypeInfo() 
		{
		    
		}

		internal static TypeFieldReferenceTypeInfo FromNative(BNTypeFieldReferenceTypeInfo native)
		{
			return new TypeFieldReferenceTypeInfo()
			{
				Offset = native.offset , 
				Types = UnsafeUtils.ReadStructArray<BNTypeWithConfidence,TypeWithConfidence>(
					native.types ,
					native.count,
					TypeWithConfidence.FromNative
				)
			};
		}
    }
}