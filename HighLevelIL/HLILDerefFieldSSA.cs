namespace BinaryNinja
{
	public sealed class HLILDerefFieldSSA : HighLevelILInstruction
	{
		internal HLILDerefFieldSSA(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return (ulong)this.RawOperands[1];
			}
		}
		
		public long Offset
		{
			get
			{
				return (long)this.RawOperands[2];
			}
		}
		
		public ulong MemoryIndex
		{
			get
			{
				return this.RawOperands[3];
			}
		}
	}
}
