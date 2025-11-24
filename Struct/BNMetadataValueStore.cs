using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNMetadataValueStore 
	{
		/// <summary>
		/// uint64_t size
		/// </summary>
		internal ulong size;
		
		/// <summary>
		/// const char** keys
		/// </summary>
		internal IntPtr keys;
		
		/// <summary>
		/// BNMetadata** values
		/// </summary>
		internal IntPtr values;
	}

    public sealed class MetadataValueStore 
    {
		public string[] Keys { get; set; } = Array.Empty<string>();
		
		public Metadata[] Values { get; set; } = Array.Empty<Metadata>();
		
		public MetadataValueStore() 
		{
		    
		}

		internal static MetadataValueStore MustFromNativePointer(IntPtr pointer)
		{
			if (IntPtr.Zero == pointer)
			{
				throw new ArgumentNullException(nameof(pointer));
			}
			
			return MetadataValueStore.FromNative(Marshal.PtrToStructure<BNMetadataValueStore>(pointer));
		}
		
		internal static MetadataValueStore FromNative(BNMetadataValueStore native)
		{
			return new MetadataValueStore()
			{
				Keys = UnsafeUtils.ReadAnsiStringArray(native.keys , (ulong)native.size) ,
				Values = UnsafeUtils.ReadHandleArray(
					native.values , 
					(ulong)native.size,
					Metadata.MustNewFromHandle
				) 
			};
		}

		public Dictionary<string , Metadata> ToDictionary()
		{
			Dictionary<string,Metadata> target = new Dictionary<string,Metadata>();

			if (0 == this.Keys.Length)
			{
				return target;
			}
			
			if (0 == this.Values.Length)
			{
				return target;
			}

			if (this.Keys.Length != this.Values.Length)
			{
				throw new ArgumentException("Keys and Values must have the same length.");
			}

			for (int i = 0; i < this.Keys.Length; i++)
			{
				target[ this.Keys[i]] = Metadata.MustNewFromHandle(
					this.Values[i].DangerousGetHandle()
				);
			}
			
			return target;
		}
    }
}