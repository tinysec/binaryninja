namespace BinaryNinja
{
	public abstract class AbstractHighLevelILConstInstruction : HighLevelILInstruction
	{
		internal AbstractHighLevelILConstInstruction(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public ulong Constant
		{
			get
			{
				return this.RawOperands[0];
			}
		}
	}
}
