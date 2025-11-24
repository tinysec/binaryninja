namespace BinaryNinja
{
	public sealed class LLILSharedParamSlotSSA : LowLevelILInstruction
	{
		internal LLILSharedParamSlotSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILInstruction[] Source
		{
			get
			{
				return this.GetOperandAsExpressionList(0);
			}
		}
	}
}
