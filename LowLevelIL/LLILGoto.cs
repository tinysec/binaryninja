namespace BinaryNinja
{
	public sealed class LLILGoto : LowLevelILInstruction
	{
		internal LLILGoto(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public LowLevelILInstructionIndex Destination
		{
			get
			{
				return (LowLevelILInstructionIndex)this.RawOperands[0];
			}
		}
	}
}
