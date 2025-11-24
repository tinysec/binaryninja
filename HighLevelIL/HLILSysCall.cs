namespace BinaryNinja
{
	public sealed class HLILSysCall : HighLevelILInstruction
	{
		internal HLILSysCall(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList(0);
			}
		}
	}
}
