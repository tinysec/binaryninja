using System;

namespace BinaryNinja
{
	public class CharType : IntegerType
	{
		public CharType(ulong width , string altName) 
			: base( width , true, altName ) 
		{
			
		}
		
		public CharType(BinaryNinja.Type type) 
			: base( type.DangerousGetHandle() , true)
		{
			
		}
		
		internal CharType(IntPtr handle , bool owner) : base(handle , owner)
		{
			
		}
	}
}
