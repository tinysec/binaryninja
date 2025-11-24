namespace BinaryNinja
{
	public sealed class HLILReturn : HighLevelILInstruction
	{
		internal HLILReturn(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction[] Source
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)0);
			}
		}
	}
}
