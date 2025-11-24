namespace BinaryNinja
{
	public sealed class LLILTailCall : LowLevelILInstruction
	{
		internal LLILTailCall(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
	}
}
