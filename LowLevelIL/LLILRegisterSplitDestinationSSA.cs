namespace BinaryNinja
{
	public sealed class LLILRegisterSplitDestinationSSA : LowLevelILInstruction
	{
		internal LLILRegisterSplitDestinationSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILSSARegister Destination
		{
			get
			{
				return this.GetOperandAsSSARegister((OperandIndex)0,(OperandIndex)1);
			}
		}
	}
}
