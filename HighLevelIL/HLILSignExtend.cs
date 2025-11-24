namespace BinaryNinja
{
	public sealed class HLILSignExtend : HighLevelILInstruction
	{
		internal HLILSignExtend(
			HighLevelILFunction ilFunction ,
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex , native)
		{

		}

		public HighLevelILInstruction Left
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
	}
}
