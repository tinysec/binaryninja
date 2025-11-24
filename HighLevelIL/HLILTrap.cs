namespace BinaryNinja
{
	public sealed class HLILTrap : HighLevelILInstruction
	{
		internal HLILTrap(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public ulong Vector
		{
			get
			{
				return this.RawOperands[0];
			}
		}
	}
}
