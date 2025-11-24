namespace BinaryNinja
{
	public sealed class HLILSplit : HighLevelILInstruction
	{
		internal HLILSplit(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction High
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
	
		public HighLevelILInstruction Low
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
	}
}
