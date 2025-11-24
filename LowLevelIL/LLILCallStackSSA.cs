namespace BinaryNinja
{
	public sealed class LLILCallStackSSA : LowLevelILInstruction
	{
		internal LLILCallStackSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILSSARegister Source
		{
			get
			{
				return this.GetOperandAsSSARegister((OperandIndex)0 , (OperandIndex)1);
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return this.RawOperands[2];
			}
		}
	}
}
