namespace BinaryNinja
{
	public sealed class LLILStoreSSA : LowLevelILInstruction
	{
		internal LLILStoreSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public LowLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)0);
			}
		}
		
		public ulong DestinationMemory
		{
			get
			{
				return this.RawOperands[1];
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return this.RawOperands[2];
			}
		}
		
		public LowLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)3);
			}
		}
	}
}
