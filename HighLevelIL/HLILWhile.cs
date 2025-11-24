namespace BinaryNinja
{
	public sealed class HLILWhile : HighLevelILInstruction
	{
		internal HLILWhile(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction Condition
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public HighLevelILInstruction Body
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
	}
}
