using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNQualifiedNameAndType 
	{
		/// <summary>
		/// BNQualifiedName name
		/// </summary>
		internal BNQualifiedName name;
		
		/// <summary>
		/// BNType* type
		/// </summary>
		internal IntPtr type;
	}

    public sealed class QualifiedNameAndType : INativeWrapperEx<BNQualifiedNameAndType>
    {
		public QualifiedName Name { get; set; } = new QualifiedName();
		
		public BinaryNinja.Type Type { get; set; }
		
		public QualifiedNameAndType(QualifiedName name , BinaryNinja.Type  type) 
		{
		    this.Name = name;
		    this.Type = type;
		}

		internal static QualifiedNameAndType FromNative(BNQualifiedNameAndType native)
		{
			return new QualifiedNameAndType(
				QualifiedName.FromNative(native.name) ,
				BinaryNinja.Type.MustNewFromHandle(native.type)
			);
		} 

		internal static QualifiedNameAndType TakeNative(BNQualifiedNameAndType native)
		{
			QualifiedNameAndType target = QualifiedNameAndType.FromNative(native);

			NativeMethods.BNFreeQualifiedNameAndType(native);
			
			return target;
		}

		public BNQualifiedNameAndType ToNativeEx(ScopedAllocator allocator)
		{
			return new BNQualifiedNameAndType()
			{
				name= this.Name.ToNativeEx(allocator) ,
				type = this.Type.DangerousGetHandle()
			};
		}

		internal static QualifiedName[] PickNames(QualifiedNameAndType[] nameAndTypes)
		{
			List<QualifiedName> targets = new List<QualifiedName>();
			
			foreach (QualifiedNameAndType item in nameAndTypes)
			{
				targets.Add(item.Name);
			}
			
			return targets.ToArray();
		}
		
		internal static BinaryNinja.Type[] PickTypes(QualifiedNameAndType[] nameAndTypes)
		{
			List<BinaryNinja.Type> targets = new List<BinaryNinja.Type>();
			
			foreach (QualifiedNameAndType item in nameAndTypes)
			{
				targets.Add(item.Type);
			}
			
			return targets.ToArray();
		}
		
    }
}