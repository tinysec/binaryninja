using System;

namespace BinaryNinja
{
	public sealed class StructureType : BinaryNinja.Type
	{
		internal StructureType(IntPtr handle , bool owner) : base(handle , owner)
		{
			
		}
		
		public StructureType(BinaryNinja.Type type) 
			: base( type.DangerousGetHandle() , true)
		{
			
		}
		
		internal new static StructureType MustNewFromHandle(IntPtr handle)
		{
			if (IntPtr.Zero == handle)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new StructureType(
				NativeMethods.BNNewTypeReference(handle) ,
				true
			);
		}
		
		public QualifiedName StructureName
		{
			get
			{
				return QualifiedName.TakeNative(
					NativeMethods.BNTypeGetStructureName(this.handle)
				);
			}
		}

		public Structure Structure
		{
			get
			{
				return Structure.MustTakeHandle(
					NativeMethods.BNGetTypeStructure(this.handle)
				);
			}
		}
	}
}
