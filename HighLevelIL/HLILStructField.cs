namespace BinaryNinja
{
	public sealed class HLILStructField : HighLevelILInstruction
	{
		internal HLILStructField(
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
		
		public long Offset
		{
			get
			{
				return (long)this.RawOperands[1];
			}
		}
		
		public ulong MemberIndex
		{
			get
			{
				return this.RawOperands[2];
			}
		}
	}
}
