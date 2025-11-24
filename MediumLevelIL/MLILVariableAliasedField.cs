namespace BinaryNinja
{
	public sealed class MLILVariableAliasedField : MediumLevelILInstruction
	{
		internal MLILVariableAliasedField(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILSSAVariable Source
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)0,(OperandIndex)1);
			}
		}
		
		public ulong Offset
		{
			get
			{
				return (ulong)this.RawOperands[2];
			}
		}
	}
}
