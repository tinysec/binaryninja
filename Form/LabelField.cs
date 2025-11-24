namespace BinaryNinja
{
	public sealed class LabelField : AbstractFormInputField
	{
		public string Text { get; set; } = "";

		public LabelField()
		{
			
		}
		
		public LabelField(string text)
		{
			this.Text = text;
		}

		public override BNFormInputField ToNativeEx(ScopedAllocator allocator)
		{
			return new BNFormInputField()
			{
				type = FormInputFieldType.LabelFormField,
				hasDefault = false,
				prompt = allocator.AllocAnsiString(this.Text)
			};
		}
	}
}
