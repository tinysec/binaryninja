using System;

namespace BinaryNinja
{
	public sealed class NamedTypeReferenceType : BinaryNinja.Type
	{
		public NamedTypeReferenceType(
			NamedTypeReference namedType ,
			ulong width ,
			ulong align ,
			BoolWithConfidence cnst ,
			BoolWithConfidence vltl
		)
			: base(
				NamedTypeReferenceType.create(
					namedType ,
					width ,
					align ,
					cnst ,
					vltl
				) ,
				true
			)
		{

		}
		
		public NamedTypeReferenceType(BinaryNinja.Type type) 
			: base( type.DangerousGetHandle() , true)
		{
			
		}

		internal NamedTypeReferenceType(IntPtr handle , bool owner) : base(handle , owner)
		{

		}

		private static IntPtr create(
			NamedTypeReference namedType ,
			ulong width ,
			ulong align ,
			BoolWithConfidence cnst ,
			BoolWithConfidence vltl
		)
		{
			return NativeMethods.BNCreateNamedTypeReference(
				namedType.DangerousGetHandle() ,
				width ,
				align ,
				cnst.ToNative() ,
				vltl.ToNative()
			);
		}

		public NamedTypeReferenceClass NamedTypeReferenceClass
		{
			get
			{
				return NativeMethods.BNGetTypeReferenceClass(this.handle);
			}
		}
		
		public string TypeReferenceId
		{
			get
			{
				return UnsafeUtils.TakeAnsiString(NativeMethods.BNGetTypeReferenceId(this.handle));
			}
		}
		
	}
}
