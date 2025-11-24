using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNQualifiedName 
	{
		/// <summary>
		/// const char** name
		/// </summary>
		internal IntPtr name;
		
		/// <summary>
		/// const char* join
		/// </summary>
		internal IntPtr join;
		
		/// <summary>
		/// uint64_t nameCount
		/// </summary>
		internal ulong nameCount;
	}

    public sealed class QualifiedName : INativeWrapperEx<BNQualifiedName>
    {
		public string[] Name { get; set; } = Array.Empty<string>();
		
		public string Join { get; set; } = "";
		
		public QualifiedName(string name = "")
		{
			this.Name = new string[1]
			{
				name
			};
			
			this.Join = "";
		}
		
		public QualifiedName(string[] name , string join = "") 
		{
		    this.Name = name;
		    
		    this.Join = join;
		}

		internal static QualifiedName FromNative(BNQualifiedName native)
		{
			return new QualifiedName(
				UnsafeUtils.ReadAnsiStringArray(native.name , native.nameCount) ,
				UnsafeUtils.ReadAnsiString(native.join)
			);
		}

		internal static QualifiedName TakeNative(BNQualifiedName native)
		{
			QualifiedName target = QualifiedName.FromNative(native);
			
			NativeMethods.BNFreeQualifiedName(native);

			return target;
		}

		public BNQualifiedName ToNativeEx(ScopedAllocator allocator)
		{
			return new BNQualifiedName()
			{
				name = allocator.AllocAnsiStringArray(this.Name) ,
				nameCount = (ulong)this.Name.Length,
				join = allocator.AllocAnsiString(this.Join)
			};
		}
		
		
		public static implicit operator QualifiedName(string value)
		{
			return new QualifiedName(value ?? string.Empty);
		}
		
		public static implicit operator string(QualifiedName? qn)
		{
			if (qn is null)
			{
				return string.Empty;
			}
			
			return qn.ToString();
		}

		public override string ToString()
		{
			if ( this.Name.Length == 0)
			{
				return string.Empty;
			}

			if ("::" == this.Join || string.IsNullOrEmpty(this.Join))
			{
				if (1 == this.Name.Length)
				{
					return this.Name[0];
				}
			}
			
			return string.Join(this.Join , this.Name);
		}
    }

    public class QualifiedNameAndId
    {
	    public QualifiedName Name { get; set; } = new QualifiedName();
	    
	    public string Id { get; set; } = string.Empty;

	    public QualifiedNameAndId(QualifiedName name , string id)
	    {
		    this.Name = name;
		    this.Id = id;
	    }
    }
}