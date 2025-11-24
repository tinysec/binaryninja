using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNBaseStructure 
	{
		/// <summary>
		/// BNNamedTypeReference* type
		/// </summary>
		internal IntPtr type;
		
		/// <summary>
		/// uint64_t offset
		/// </summary>
		internal ulong offset;
		
		/// <summary>
		/// uint64_t width
		/// </summary>
		internal ulong width;
	}

    public sealed class BaseStructure : INativeWrapper<BNBaseStructure>
    {
		public NamedTypeReference Type { get; set; }
		
		public ulong Offset { get; set; } = 0;
		
		public ulong Width { get; set; } = 0;
		
		public BaseStructure(NamedTypeReference kind , ulong offset , ulong width) 
		{
		    this.Type = kind;
		    
		    this.Offset = offset;
		    
		    this.Width = width;
		}

		internal static BaseStructure FromNative(BNBaseStructure native)
		{
			return new BaseStructure(
				new NamedTypeReference(NativeMethods.BNNewNamedTypeReference(native.type) , true) ,
				native.offset ,
				native.width
			);
		}

		public BNBaseStructure ToNative()
		{
			return new BNBaseStructure()
			{
				type = this.Type.DangerousGetHandle(),
				offset = this.Offset,
				width = this.Width
			};
		}
    }
}