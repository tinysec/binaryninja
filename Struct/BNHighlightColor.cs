using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNHighlightColor 
	{
		/// <summary>
		/// BNHighlightColorStyle style
		/// </summary>
		internal HighlightColorStyle style;
		
		/// <summary>
		/// BNHighlightStandardColor color
		/// </summary>
		internal HighlightStandardColor color;
		
		/// <summary>
		/// BNHighlightStandardColor mixColor
		/// </summary>
		internal HighlightStandardColor mixColor;
		
		/// <summary>
		/// uint8_t mix
		/// </summary>
		internal byte mix;
		
		/// <summary>
		/// uint8_t r
		/// </summary>
		internal byte r;
		
		/// <summary>
		/// uint8_t g
		/// </summary>
		internal byte g;
		
		/// <summary>
		/// uint8_t b
		/// </summary>
		internal byte b;
		
		/// <summary>
		/// uint8_t alpha
		/// </summary>
		internal byte alpha;
	}

    public sealed class HighlightColor : INativeWrapper<BNHighlightColor>
    {
		public HighlightColorStyle Style { get; set; } = HighlightColorStyle.StandardHighlightColor;
		
		public HighlightStandardColor Color { get; set; } = HighlightStandardColor.NoHighlightColor;
	
		public HighlightStandardColor MixColor { get; set; } = HighlightStandardColor.NoHighlightColor;
	
		public byte Mix { get; set; } = 0;
		
		public byte R { get; set; } = 0;
		
		public byte G { get; set; } = 0;
		
		public byte B { get; set; } = 0;
	
		public byte Alpha { get; set; } = 0;
		
		public HighlightColor() 
		{
		    
		}
		
		internal static HighlightColor FromNative(BNHighlightColor native)
		{
			return new HighlightColor()
			{
				Style = native.style ,
				Color = native.color ,
				MixColor = native.mixColor ,
				Mix = native.mix ,
				R = native.r ,
				G = native.g ,
				B = native.b ,
				Alpha = native.alpha
			};
		}

		public BNHighlightColor ToNative()
		{
			return new BNHighlightColor
			{
				style = this.Style,
				color = this.Color,
				mixColor = this.MixColor,
				mix = this.Mix,
				r = this.R,
				g = this.G,
				b = this.B,
				alpha = this.Alpha
			};
		}
    }
}