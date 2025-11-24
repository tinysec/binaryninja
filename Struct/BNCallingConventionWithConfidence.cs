using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCallingConventionWithConfidence 
	{
		/// <summary>
		/// BNCallingConvention* convention
		/// </summary>
		public IntPtr convention;
		
		/// <summary>
		/// uint8_t confidence
		/// </summary>
		public byte confidence;
	}

    public sealed class CallingConventionWithConfidence
    {
	    public BinaryNinja.CallingConvention? Convention { get; set; } = null;
	    
		public byte Confidence { get; set; } = 0;
		
		public CallingConventionWithConfidence() 
		{
			
		}
		
		public CallingConventionWithConfidence(BinaryNinja.CallingConvention? convention, byte confidence) 
		{
		    this.Convention = convention;
		    
		    this.Confidence = confidence;
		}

		internal static CallingConventionWithConfidence FromNative(BNCallingConventionWithConfidence native)
		{
			return new CallingConventionWithConfidence(
				
				new BinaryNinja.CallingConvention(
					NativeMethods.BNNewCallingConventionReference(native.convention) , 
					true
				) ,
				native.confidence
			);
		}
		
		internal BNCallingConventionWithConfidence ToNative()
		{
			return new BNCallingConventionWithConfidence()
			{
				convention = null == this.Convention ? IntPtr.Zero : this.Convention.DangerousGetHandle(),
				confidence = Confidence
			};
		}
    }
}