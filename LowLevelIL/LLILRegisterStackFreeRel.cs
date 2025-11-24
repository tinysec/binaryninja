namespace BinaryNinja
{
	public sealed class LLILRegisterStackFreeRel : LowLevelILInstruction
	{
		internal LLILRegisterStackFreeRel(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public RegisterStack Stack
		{
			get
			{
				return this.GetOperandAsRegisterStack(0);
			}
		}
		
		public LowLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
	}
}
