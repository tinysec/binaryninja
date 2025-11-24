namespace BinaryNinja
{
	public sealed class HLILVariableSSA : HighLevelILInstruction
	{
		internal HLILVariableSSA(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILSSAVariable Variable
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)0 , (OperandIndex)1);
			}
		}
	}
}
