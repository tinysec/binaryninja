namespace BinaryNinja
{
	public sealed class HLILForceVersionSSA : HighLevelILInstruction
	{
		internal HLILForceVersionSSA(
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
				return this.GetOperandAsSSAVariable(0 , (OperandIndex)1);
			}
		}
		
		public HighLevelILSSAVariable Source
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)2 , (OperandIndex)3);
			}
		}
	}
}
