namespace BinaryNinja
{
	public sealed class HLILCase : HighLevelILInstruction
	{
		internal HLILCase(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction[] Values
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)0);
			}
		}
		
		public HighLevelILInstruction Body
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
		
	}
}
