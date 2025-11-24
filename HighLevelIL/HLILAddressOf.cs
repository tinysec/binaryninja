namespace BinaryNinja
{
	public sealed class HLILAddressOf : HighLevelILInstruction
	{
		internal HLILAddressOf(
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
	}
}
