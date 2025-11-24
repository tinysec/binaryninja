using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNQualifiedNameList 
	{
		/// <summary>
		/// BNQualifiedName* names
		/// </summary>
		internal IntPtr names;
		
		/// <summary>
		/// uint64_t count
		/// </summary>
		internal ulong count;
	}

    public sealed class QualifiedNameList : INativeWrapperEx<BNQualifiedNameList>
    {
		public QualifiedName[] Names { get; set; } = Array.Empty<QualifiedName>();
		
		public QualifiedNameList() 
		{
		    
		}
		
		public QualifiedNameList(QualifiedName[]? names) 
		{
			if (null != names)
			{
				this.Names = names;
			}
		}

		public BNQualifiedNameList ToNativeEx(ScopedAllocator allocator)
		{
			return new BNQualifiedNameList()
			{
				names = allocator.AllocStructArray<BNQualifiedName>(
					allocator.ConvertToNativeArrayEx<BNQualifiedName , QualifiedName>(
						this.Names
					)
				) ,
				count = (ulong)this.Names.Length
			};
		}
    }
}