namespace BinaryNinja
{
	public sealed class HLILAssert : HighLevelILInstruction
	{
		internal HLILAssert(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILVariable Source
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
