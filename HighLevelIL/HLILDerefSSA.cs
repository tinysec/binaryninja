namespace BinaryNinja
{
	public sealed class HLILDerefSSA : HighLevelILInstruction
	{
		internal HLILDerefSSA(
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
				return this.RawOperands[1];
			}
		}
	}
}
