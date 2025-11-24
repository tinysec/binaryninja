namespace BinaryNinja
{
	public sealed class HLILCall : HighLevelILInstruction
	{
		internal HLILCall(
			HighLevelILFunction ilFunction ,
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex , native)
		{

		}

		public HighLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public HighLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)1);
			}
		}
	}
}
