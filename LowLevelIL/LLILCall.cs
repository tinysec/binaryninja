namespace BinaryNinja
{
	public sealed class LLILCall : LowLevelILInstruction
	{
		internal LLILCall(
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
