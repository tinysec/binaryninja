using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNVersionInfo 
	{
		/// <summary>
		/// uint32_t major
		/// </summary>
		public uint major;
		
		/// <summary>
		/// uint32_t minor
		/// </summary>
		public uint minor;
		
		/// <summary>
		/// uint32_t build
		/// </summary>
		public uint build;
		
		/// <summary>
		/// const char* channel
		/// </summary>
		public IntPtr channel;
	}

    public sealed class VersionInfo 
    {
		public uint Major { get; set; } = 0;
		
		public uint Minor { get; set; } = 0;
		
		public uint Build { get; set; } = 0;
		
		public string Channel { get; set; } = string.Empty;
		
		public VersionInfo() 
		{
		    
		}
		
		internal static VersionInfo FromNative(BNVersionInfo raw)
		{
			return new VersionInfo()
			{
				Major = raw.major ,
				Minor = raw.minor , 
				Build = raw.build , 
				Channel = UnsafeUtils.ReadAnsiString(raw.channel)
			};
		}

		public override string ToString()
		{
			return $"{Major}.{Minor}.{Build}.{Channel}";
		}
		
		public static VersionInfo GetVersionInfo()
		{
			return VersionInfo.FromNative(
				NativeMethods.BNGetVersionInfo()
			);
		}

		public static uint GetBuildId()
		{
			return NativeMethods.BNGetBuildId();
		}
		
		public static uint GetCurrentCoreABIVersion()
		{
			return NativeMethods.BNGetCurrentCoreABIVersion();
		}
		
		public static uint GetMinimumCoreABIVersion()
		{
			return NativeMethods.BNGetMinimumCoreABIVersion();
		}
    }
}