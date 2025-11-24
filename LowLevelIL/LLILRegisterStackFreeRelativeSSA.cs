namespace BinaryNinja
{
	public sealed class LLILRegisterStackFreeRelativeSSA : LowLevelILInstruction
	{
		internal LLILRegisterStackFreeRelativeSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILInstruction Stack
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public LowLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
		
		public LowLevelILInstruction Top
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
	}
}
