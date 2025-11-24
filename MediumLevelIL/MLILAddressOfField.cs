namespace BinaryNinja
{
	public sealed class MLILAddressOfField : MediumLevelILInstruction
	{
		internal MLILAddressOfField(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILVariable Source
		{
			get
			{
				return this.GetOperandAsVariable(0);
			}
		}
		
		public ulong Offset
		{
			get
			{
				return this.RawOperands[1];
			}
		}
	}
}
