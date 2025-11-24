using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNTypeWithConfidence 
	{
		/// <summary>
		/// BNType* type
		/// </summary>
		internal IntPtr type;
		
		/// <summary>
		/// uint8_t confidence
		/// </summary>
		internal byte confidence;
	}

    public sealed class TypeWithConfidence : INativeWrapper<BNTypeWithConfidence>
    {
	    public BinaryNinja.Type Type { get;  }
	    
		public byte Confidence { get;  } = 0;
		
		public TypeWithConfidence(BinaryNinja.Type type , byte confidence = 0)
		{
			this.Type = type;
			this.Confidence = confidence;
		}
		
		internal static TypeWithConfidence FromNative(BNTypeWithConfidence native)
		{
			return new TypeWithConfidence(
				new BinaryNinja.Type( NativeMethods.BNNewTypeReference(native.type)  , true) ,
				native.confidence
			);
		}
		
		internal static TypeWithConfidence MustFromNativePointer(IntPtr pointer)
		{
			if (IntPtr.Zero == pointer)
			{
				throw new NullReferenceException(nameof(pointer));
			}
			
			return TypeWithConfidence.FromNative( Marshal.PtrToStructure<BNTypeWithConfidence>(pointer) );
		}
		
		public BNTypeWithConfidence ToNative()
		{
			return new BNTypeWithConfidence()
			{
				type = this.Type.DangerousGetHandle(),
				confidence = Confidence
			};
		}
    }
}