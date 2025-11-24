namespace BinaryNinja
{
	public sealed class HLILCallSSA : HighLevelILInstruction
	{
		internal HLILCallSSA(
			HighLevelILFunction ilFunction ,
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex , native)
		{

		}

		public HighLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public HighLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)1);
			}
		}
		
		public ulong DestinationMemory
		{
			get
			{
				return this.RawOperands[3];
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return this.RawOperands[4];
			}
		}
	}
}
