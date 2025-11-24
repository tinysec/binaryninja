using System.Collections.Generic;

namespace BinaryNinja
{
	public sealed class LLILJumpTo : LowLevelILInstruction
	{
		internal LLILJumpTo(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public LowLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public IDictionary<ulong,ulong> Targets
		{
			get
			{
				return this.GetOperandAsIntegerDict<ulong>((OperandIndex)1);
			}
		}
	}
}
