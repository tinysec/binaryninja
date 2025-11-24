using System;
using System.Collections.Generic;

namespace BinaryNinja
{
	public sealed class HighLevelILLabel : AbstractLabel<HighLevelILLabel>
	{
		internal HighLevelILFunction ILFunction { get; }
		
		internal HighLevelILLabel(HighLevelILFunction ilfunction , ulong id) 
			: base( id)
		{
			this.ILFunction = ilfunction;
		}

		public override string Name
		{
			get
			{
				return UnsafeUtils.TakeAnsiString(
					NativeMethods.BNGetGotoLabelName(
						this.ILFunction.OwnerFunction.DangerousGetHandle() ,
						this.Id
					)
				);
			}

			set
			{
				NativeMethods.BNSetUserGotoLabelName(
					this.ILFunction.OwnerFunction.DangerousGetHandle(),
					this.Id, 
					value
				);
			}
		}
		
		public HighLevelILInstruction? Definition
		{
			get
			{
				HighLevelILExpressionIndex index = NativeMethods.BNGetHighLevelILExprIndexForLabel(
					this.ILFunction.DangerousGetHandle() ,
					this.Id
				);

				return this.ILFunction.GetExpression(index);
			}
		}
		
		public HighLevelILInstruction[] Uses
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetHighLevelILUsesForLabel(
					this.ILFunction.DangerousGetHandle() ,
					this.Id ,
					out ulong arrayLength
				);

				ulong[] indexes = UnsafeUtils.TakeNumberArray<ulong>(
					arrayPointer ,
					arrayLength ,
					NativeMethods.BNFreeILInstructionList
				);
				
				List<HighLevelILInstruction>  instructions = new List<HighLevelILInstruction>();

				foreach (HighLevelILExpressionIndex index in indexes)
				{
					instructions.Add(
						this.ILFunction.MustGetExpression(index)
					);
				}

				return instructions.ToArray();
			}
		}
	}
}
