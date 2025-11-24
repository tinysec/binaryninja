namespace BinaryNinja
{
	public sealed class LLILExternPointer : LowLevelILInstruction
	{
		internal LLILExternPointer(
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
		
		public ulong Offset
		{
			get
			{
				return this.RawOperands[1];
			}
		}
	}
}
