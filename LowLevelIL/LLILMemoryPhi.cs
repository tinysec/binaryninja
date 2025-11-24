namespace BinaryNinja
{
	public sealed class LLILMemoryPhi : LowLevelILInstruction
	{
		internal LLILMemoryPhi(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public ulong DestionationMemory
		{
			get
			{
				return this.RawOperands[0];
			}
		}
		
		public ulong[] SourceMemory
		{
			get
			{
				return this.GetOperandAsIntegerArray<ulong>(0);
			}
		}
	}
}
