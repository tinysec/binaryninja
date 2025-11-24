namespace BinaryNinja
{
	public sealed class LLILUnimplementedMemory : LowLevelILInstruction
	{
		internal LLILUnimplementedMemory(
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
