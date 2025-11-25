using System;

namespace BinaryNinja
{
	public sealed class HighLevelILFlowGraphNode : FlowGraphNode
	{
		public HighLevelILFunction ILFunction { get; }
		
		internal HighLevelILFlowGraphNode(
			HighLevelILFunction  ilFunction,
			IntPtr handle , 
			bool owner)
			: base(handle , owner)
		{
			this.ILFunction = ilFunction;
		}
	    
		internal static HighLevelILFlowGraphNode? NewFromHandleEx(
			HighLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new HighLevelILFlowGraphNode(
				ilFunction,
				NativeMethods.BNNewFlowGraphNodeReference(handle) ,
				true
			);
		}
	    
		internal static HighLevelILFlowGraphNode MustNewFromHandleEx(
			HighLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new HighLevelILFlowGraphNode(
				ilFunction,
				NativeMethods.BNNewFlowGraphNodeReference(handle) ,
				true
			);
		}
	    
		internal static HighLevelILFlowGraphNode? TakeHandleEx(
			HighLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new HighLevelILFlowGraphNode(
				ilFunction,
				handle, 
				true);
		}
	    
		internal static HighLevelILFlowGraphNode MustTakeHandleEx(
			HighLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new HighLevelILFlowGraphNode(
				ilFunction,
				handle, 
				true);
		}
	    
		internal static HighLevelILFlowGraphNode? BorrowHandleEx(
			HighLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new HighLevelILFlowGraphNode(
				ilFunction,
				handle, 
				false);
		}
	    
		internal static HighLevelILFlowGraphNode MustBorrowHandleEx(
			HighLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new HighLevelILFlowGraphNode(
				ilFunction,
				handle, 
				false);
		}
		
		public HighLevelILBasicBlock? BasicBlock
		{
			get
			{
				return HighLevelILBasicBlock.TakeHandleEx(
					this.ILFunction,
					NativeMethods.BNGetFlowGraphBasicBlock(this.handle)
				);
			}

			set
			{
				NativeMethods.BNSetFlowGraphBasicBlock(
					this.handle, 
					null == value ? IntPtr.Zero : value.DangerousGetHandle()
				);
			}
		}
		
		public HighLevelILFlowGraphEdge[] IncomingEdges
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetFlowGraphNodeIncomingEdges(
					this.handle,
					out ulong arrayLength 
				);
		    
				return UnsafeUtils.TakeStructArrayEx<BNFlowGraphEdge,HighLevelILFlowGraphEdge>(
					arrayPointer,
					arrayLength,
					(_native) => HighLevelILFlowGraphEdge.FromNativeEx(
						_native,
						this,
						false
					),
					NativeMethods.BNFreeFlowGraphNodeEdgeList
				);
			}
		}
	    
		public HighLevelILFlowGraphEdge[] OutgoingEdges
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetFlowGraphNodeOutgoingEdges(
					this.handle,
					out ulong arrayLength 
				);
		    
				return UnsafeUtils.TakeStructArrayEx<BNFlowGraphEdge,HighLevelILFlowGraphEdge>(
					arrayPointer,
					arrayLength,
					(_native) => HighLevelILFlowGraphEdge.FromNativeEx(
						_native,
						this,
						true
					),
					NativeMethods.BNFreeFlowGraphNodeEdgeList
				);
			}
		}
	}
}
