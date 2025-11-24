namespace BinaryNinja
{
	public sealed class HLILAssignUnpack : HighLevelILInstruction
	{
		internal HLILAssignUnpack(
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
		
		public HighLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
	}
}
