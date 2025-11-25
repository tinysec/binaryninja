using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNEdgeStyle 
	{
		/// <summary>
		/// BNEdgePenStyle style
		/// </summary>
		internal EdgePenStyle style;
		
		/// <summary>
		/// uint64_t width
		/// </summary>
		internal ulong width;
		
		/// <summary>
		/// BNThemeColor color
		/// </summary>
		internal ThemeColor color;
	}

    public sealed class EdgeStyle : INativeWrapper<BNEdgeStyle>,
		 IEquatable<EdgeStyle>, 
	     IComparable<EdgeStyle>
    {
		public EdgePenStyle Style {get;} = EdgePenStyle.NoPen;
		
		public ulong Width {get;} = 0;
		
		public ThemeColor Color {get;} = ThemeColor.AddressColor;
		
		public EdgeStyle() 
		{
		    
		}
		
		public EdgeStyle(BNEdgeStyle native)
		{
			this.Style = native.style;
			this.Width = native.width;
			this.Color = native.color;
		}

		internal static EdgeStyle FromNative(BNEdgeStyle native)
		{
			return new EdgeStyle(native);
		}

		public BNEdgeStyle ToNative()
		{
			return new BNEdgeStyle
			{
				style = this.Style , 
				width = this.Width ,
				color = this.Color
			};
		}
		
		public override bool Equals(object? other)
		{
			if (other is null)
			{
				return false;
			}
			
			return this.Equals(other as EdgeStyle);
		}

		public bool Equals(EdgeStyle? other)
		{
			if (other is null)
			{
				return false;
			}

			if (ReferenceEquals(this , other))
			{
				return true;
			}

			if (this.Style != other.Style)
			{
				return false;
			}
			
			if (this.Width != other.Width)
			{
				return false;
			}
			
			if (this.Color != other.Color)
			{
				return false;
			}

			return true;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2218:OverrideGetHashCodeOnOverridingEquals")]
		public override int GetHashCode()
		{
			return HashCode.Combine<uint,ulong,uint>( 
				(uint)this.Style,
				this.Width,
				(uint)this.Color
			);
		}

		public static bool operator ==(EdgeStyle left, EdgeStyle right)
		{
			if (left is null)
			{
				return right is null;
			}
			
			return left.Equals(right);
		}

		public static bool operator !=(EdgeStyle left, EdgeStyle right)
		{
			return !(left == right);
		}

		public int CompareTo(EdgeStyle? other)
		{
			if (other is null)
			{
				return 1;
			}
			
			int result = this.Style.CompareTo(other.Style);

			if (0 == result)
			{
				result = this.Width.CompareTo(other.Width);
			}
			
			if (0 == result)
			{
				result = this.Color.CompareTo(other.Color);
			}
			
			return result;
		}
    }
}