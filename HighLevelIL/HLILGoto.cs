namespace BinaryNinja
{
	public sealed class HLILGoto : HighLevelILInstruction
	{
		internal HLILGoto(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILLabel Destination
		{
			get
			{
				return this.GetOperandAsLabel((OperandIndex)0);
			}
		}
	}
}
