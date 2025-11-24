namespace BinaryNinja
{
	public sealed class LLILTrap : LowLevelILInstruction
	{
		internal LLILTrap(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public ulong Vector
		{
			get
			{
				return this.RawOperands[0];
			}
		}
	}
}
