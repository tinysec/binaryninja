namespace BinaryNinja
{
	public sealed class LLILFlagSSA : LowLevelILInstruction
	{
		internal LLILFlagSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILSSAFlag Source
		{
			get
			{
				return this.GetOperandAsSSAFlag((OperandIndex)0,(OperandIndex)1);
			}
		}
	}
}
