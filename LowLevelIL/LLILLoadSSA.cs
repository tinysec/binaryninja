namespace BinaryNinja
{
	public sealed class LLILLoadSSA : LowLevelILInstruction
	{
		internal LLILLoadSSA(
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
				return this.GetOperandAsExpression((OperandIndex)0 );
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return this.RawOperands[1];
			}
		}
	}
}
