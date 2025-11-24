namespace BinaryNinja
{
	public sealed class MLILAssert : MediumLevelILInstruction
	{
		internal MLILAssert(
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
	
		public PossibleValueSet Constraint
		{
			get
			{
				return this.GetOperandAsPossibleValueSet((OperandIndex)1);
			}
		}
	}
}
