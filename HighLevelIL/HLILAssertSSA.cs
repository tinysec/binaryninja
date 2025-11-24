namespace BinaryNinja
{
	public sealed class HLILAssertSSA : HighLevelILInstruction
	{
		internal HLILAssertSSA(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILSSAVariable Source
		{
			get
			{
				return this.GetOperandAsSSAVariable(0 , (OperandIndex)1);
			}
		}
		
		public PossibleValueSet Constraint
		{
			get
			{
				return this.GetOperandAsPossibleValueSet((OperandIndex)2);
			}
		}
	}
}
