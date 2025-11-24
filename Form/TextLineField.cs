using System;
using Microsoft.VisualBasic;

namespace BinaryNinja
{
	public sealed class TextLineField : AbstractFormInputField
	{
		public string Prompt { get; set; } = "";

		public string Default { get; set; } = "";
		
		public string Result { get; set; } = "";
		
		public TextLineField()
		{
			
		}
		
		public override BNFormInputField ToNativeEx(ScopedAllocator allocator)
		{
			return new BNFormInputField()
			{
				type = FormInputFieldType.TextLineFormField,
				prompt = allocator.AllocAnsiString(this.Prompt),
				stringDefault = ( string.IsNullOrEmpty(this.Default) ? IntPtr.Zero : 
						allocator.AllocAnsiString(this.Default)
				),
				hasDefault = (!string.IsNullOrEmpty(this.Default)),
			};
		}
		
	}
}
