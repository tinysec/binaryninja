namespace BinaryNinja
{
	public sealed class HLILVariableInit : HighLevelILInstruction
	{
		internal HLILVariableInit(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILVariable Destination
		{
			get
			{
				return this.GetOperandAsVariable((OperandIndex)0);
			}
		}
		
		public HighLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
	}
}
