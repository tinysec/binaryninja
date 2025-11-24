namespace BinaryNinja
{
	public sealed class HLILAssignMemorySSA : HighLevelILInstruction
	{
		internal HLILAssignMemorySSA(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction Destination
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
				return (ulong)this.RawOperands[1];
			}
		}
		
		public HighLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return (ulong)this.RawOperands[3];
			}
		}

	}
}
