namespace BinaryNinja
{
	public sealed class HLILBlock : HighLevelILInstruction
	{
		internal HLILBlock(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}

		public HighLevelILInstruction[] Body
		{
			get
			{
				return this.GetOperandAsExpressionList(0);
			}
		}
	}
}
