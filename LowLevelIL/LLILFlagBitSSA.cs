namespace BinaryNinja
{
	public sealed class LLILFlagBitSSA : LowLevelILInstruction
	{
		internal LLILFlagBitSSA(
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
				return this.GetOperandAsSSAFlag((OperandIndex)0 , (OperandIndex)1);
			}
		}
		
		public ulong Bit
		{
			get
			{
				return (ulong)this.RawOperands[2];
			}
		}
	}
}
