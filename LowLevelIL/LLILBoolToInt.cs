namespace BinaryNinja
{
	public sealed class LLILBoolToInt : LowLevelILInstruction
	{
		internal LLILBoolToInt(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native 
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
	}
}
