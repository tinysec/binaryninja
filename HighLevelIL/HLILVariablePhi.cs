namespace BinaryNinja
{
	public sealed class HLILVariablePhi : HighLevelILInstruction
	{
		internal HLILVariablePhi(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILSSAVariable Destination
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)0 , (OperandIndex)1);
			}
		}
		
		public HighLevelILSSAVariable[] Source
		{
			get
			{
				return this.GetOperandAsSSAVariableList((OperandIndex)2);
			}
		}
	}
}
