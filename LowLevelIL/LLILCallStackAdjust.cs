using System.Collections.Generic;

namespace BinaryNinja
{
	public sealed class LLILCallStackAdjust : LowLevelILInstruction
	{
		internal LLILCallStackAdjust(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILInstruction Dest
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)0);
			}
		}
		
		public ulong StackRdjustment
		{
			get
			{
				return this.RawOperands[1];
			}
		}
		
		public IDictionary<RegisterStackIndex,ulong> RegisterStackAdjustments
		{
			get
			{
				return this.GetOperandAsRegisterStackDict((OperandIndex)0);
			}
		}
	}
}
