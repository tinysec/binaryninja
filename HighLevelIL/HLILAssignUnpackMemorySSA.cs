namespace BinaryNinja
{
	public sealed class HLILAssignUnpackMemorySSA : HighLevelILInstruction
	{
		internal HLILAssignUnpackMemorySSA(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction[] Destination
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)0);
			}
		}
		
		public ulong DestinationMemory
		{
			get
			{
				return (ulong)this.RawOperands[2];
			}
		}
		
		public HighLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)3);
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return (ulong)this.RawOperands[4];
			}
		}

	}
}
