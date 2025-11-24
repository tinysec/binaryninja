using System.Collections.Generic;

namespace BinaryNinja
{
	public sealed class MLILJumpTo : MediumLevelILInstruction
	{
		internal MLILJumpTo(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstruction Destination
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
				return this.GetOperandAsIntegerMap<ulong>((OperandIndex)1);
			}
		}
	}
}
