namespace BinaryNinja
{
	public sealed class LLILConst : LowLevelILInstruction
	{
		internal LLILConst(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public ulong Constant
		{
			get
			{
				return this.RawOperands[0];
			}
		}
	}
}
