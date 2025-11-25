using System;

namespace BinaryNinja
{
	public class LowLevelILFlowGraphNode : FlowGraphNode
	{
		internal LowLevelILFunction ILFunction { get; set; }
		
		internal LowLevelILFlowGraphNode(
			LowLevelILFunction  ilFunction,
			IntPtr handle , 
			bool owner)
			: base(handle , owner)
		{
			this.ILFunction = ilFunction;
		}
		
		internal static LowLevelILFlowGraphNode? NewFromHandleEx(
			LowLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new LowLevelILFlowGraphNode(
				ilFunction,
				NativeMethods.BNNewFlowGraphNodeReference(handle) ,
				true
			);
		}
	    
		internal static LowLevelILFlowGraphNode MustNewFromHandleEx(
			LowLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new LowLevelILFlowGraphNode(
				ilFunction,
				NativeMethods.BNNewFlowGraphNodeReference(handle) ,
				true
			);
		}
	    
		internal static LowLevelILFlowGraphNode? TakeHandleEx(
			LowLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new LowLevelILFlowGraphNode(
				ilFunction,
				handle, 
				true);
		}
	    
		internal static LowLevelILFlowGraphNode MustTakeHandleEx(
			LowLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new LowLevelILFlowGraphNode(
				ilFunction,
				handle, 
				true);
		}
	    
		internal static LowLevelILFlowGraphNode? BorrowHandleEx(
			LowLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new LowLevelILFlowGraphNode(
				ilFunction,
				handle, 
				false);
		}
	    
		internal static LowLevelILFlowGraphNode MustBorrowHandleEx(
			LowLevelILFunction  ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new LowLevelILFlowGraphNode(
				ilFunction,
				handle, 
				false);
		}
		
		
		public LowLevelILBasicBlock? BasicBlock
		{
			get
			{
				return LowLevelILBasicBlock.TakeHandleEx(
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
		
		public LowLevelILFlowGraphEdge[] IncomingEdges
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetFlowGraphNodeIncomingEdges(
					this.handle,
					out ulong arrayLength 
				);
		    
				return UnsafeUtils.TakeStructArrayEx<BNFlowGraphEdge,LowLevelILFlowGraphEdge>(
					arrayPointer,
					arrayLength,
					(_native) => LowLevelILFlowGraphEdge.FromNativeEx(
						_native,
						this,
						false
					),
					NativeMethods.BNFreeFlowGraphNodeEdgeList
				);
			}
		}
	    
		public LowLevelILFlowGraphEdge[] OutgoingEdges
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetFlowGraphNodeOutgoingEdges(
					this.handle,
					out ulong arrayLength 
				);
		    
				return UnsafeUtils.TakeStructArrayEx<BNFlowGraphEdge,LowLevelILFlowGraphEdge>(
					arrayPointer,
					arrayLength,
					(_native) => LowLevelILFlowGraphEdge.FromNativeEx(
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
