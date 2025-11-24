using System;

namespace BinaryNinja
{
	public sealed class EnumerationType : BinaryNinja.Type
	{
		public EnumerationType(BinaryNinja.Type type) 
			: base( type.DangerousGetHandle() , true)
		{
			
		}
		
		internal EnumerationType(IntPtr handle , bool owner) : base(handle , owner)
		{

		}
		
		public Enumeration Enumeration
		{
			get
			{
				return Enumeration.MustTakeHandle(
					NativeMethods.BNGetTypeEnumeration(this.handle)
				);
			}
		}
	}
}
