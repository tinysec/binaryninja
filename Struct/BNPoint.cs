using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNPoint 
	{
		/// <summary>
		/// float x
		/// </summary>
		internal float x;
		
		/// <summary>
		/// float y
		/// </summary>
		internal float y;
	}

    public sealed class Point : INativeWrapper<BNPoint>
    {
		public float X { get; set; } = 0;
		
		public float Y { get; set; } = 0;
		
		public Point() 
		{
		    
		}

		internal static Point FromNative(BNPoint raw)
		{
			return new Point()
			{
				X = raw.x , 
				Y = raw.y
			};
		}

		public BNPoint ToNative()
		{
			return new BNPoint()
			{
				x = this.X ,
				y = this.Y
			};
		}
		
    }
}