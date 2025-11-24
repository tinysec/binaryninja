namespace BinaryNinja
{
	public sealed class MLILVariableSplit : MediumLevelILInstruction
	{
		internal MLILVariableSplit(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILVariable High
		{
			get
			{
				return this.GetOperandAsVariable(0);
			}
		}
		
		public MediumLevelILVariable Low
		{
			get
			{
				return this.GetOperandAsVariable((OperandIndex)1);
			}
		}
	}
}
