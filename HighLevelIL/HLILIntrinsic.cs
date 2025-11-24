namespace BinaryNinja
{
	public sealed class HLILIntrinsic : HighLevelILInstruction
	{
		internal HLILIntrinsic(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public Intrinsic Intrinsic
		{
			get
			{
				return this.GetOperandAsIntrinsic(0);
			}
		}
		
		public HighLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)1);
			}
		}
	}
}
