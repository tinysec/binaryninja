namespace BinaryNinja
{
	public sealed class HLILSysCallSSA : HighLevelILInstruction
	{
		internal HLILSysCallSSA(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList(0);
			}
		}
		
		public ulong DestionationMemory
		{
			get
			{
				return this.RawOperands[2];
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return this.RawOperands[3];
			}
		}
	}
}
