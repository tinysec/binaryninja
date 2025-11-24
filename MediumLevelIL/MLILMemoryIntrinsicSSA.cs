using System;

namespace BinaryNinja
{
	public sealed class MLILMemoryIntrinsicSSA : MediumLevelILInstruction
	{
		internal MLILMemoryIntrinsicSSA(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILSSAVariable[] Output
		{
			get
			{
				MLILMemoryIntrinsicOutputSSA? intruction = this.GetOperandAsExpression(0) as  MLILMemoryIntrinsicOutputSSA;

				if (null == intruction)
				{
					throw new Exception("must MediumLevelILMemoryIntrinsicOutputSSA");
				}

				return intruction.Output;
			}
		}
		
		public ulong DestinationMemory
		{
			get
			{
				MLILMemoryIntrinsicOutputSSA? intruction = this.GetOperandAsExpression(0) as  MLILMemoryIntrinsicOutputSSA;

				if (null == intruction)
				{
					throw new Exception("must MediumLevelILMemoryIntrinsicOutputSSA");
				}

				return intruction.DestinationMemory;
			}
		}
		
		
		public Intrinsic Intrinsic
		{
			get
			{
				return this.GetOperandAsIntrinsic((OperandIndex)1);
			}
		}
		
		public MediumLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)2);
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return (ulong)this.RawOperands[4];
			}
		}
	}
}
