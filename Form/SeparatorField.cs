namespace BinaryNinja
{
	public sealed class SeparatorField : AbstractFormInputField
	{
		public SeparatorField()
		{
			
		}
		
		public override BNFormInputField ToNativeEx(ScopedAllocator allocator)
		{
			return new BNFormInputField()
			{
				type = FormInputFieldType.SeparatorFormField,
				hasDefault = false
			};
		}
	}
}
