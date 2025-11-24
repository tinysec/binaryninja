namespace BinaryNinja
{
	public sealed class HLILJump : HighLevelILInstruction
	{
		internal HLILJump(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)0);
			}
		}
	}
}
