namespace BinaryNinja
{
	public sealed class LLILSeparateParamListSSA : LowLevelILInstruction
	{
		internal LLILSeparateParamListSSA(
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
