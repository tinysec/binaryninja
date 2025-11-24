namespace BinaryNinja
{
	public sealed class MLILVariableAliased : MediumLevelILInstruction
	{
		internal MLILVariableAliased(
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
	}
}
