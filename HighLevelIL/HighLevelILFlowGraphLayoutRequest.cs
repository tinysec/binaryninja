using System;

namespace BinaryNinja
{
	public sealed class HighLevelILFlowGraphLayoutRequest : FlowGraphLayoutRequest
	{
		internal HighLevelILFunction ILFunction { get; set; }
		
		internal HighLevelILFlowGraphLayoutRequest(
			HighLevelILFunction ilFunction,
			IntPtr handle ,
			bool owner
		) : base(handle , owner)
		{
			this.ILFunction = ilFunction;
		}

		internal static HighLevelILFlowGraphLayoutRequest? NewFromHandleEx(
			HighLevelILFunction ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new HighLevelILFlowGraphLayoutRequest(
				ilFunction,
				NativeMethods.BNNewFlowGraphLayoutRequestReference(handle) ,
				true
			);
		}
	    
		internal static HighLevelILFlowGraphLayoutRequest MustNewFromHandleEx(
			HighLevelILFunction ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new HighLevelILFlowGraphLayoutRequest(
				ilFunction,
				NativeMethods.BNNewFlowGraphLayoutRequestReference(handle) ,
				true
			);
		}
	    
		internal static HighLevelILFlowGraphLayoutRequest? TakeHandleEx(
			HighLevelILFunction ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new HighLevelILFlowGraphLayoutRequest(
				ilFunction,
				handle, true);
		}
	    
		internal static HighLevelILFlowGraphLayoutRequest MustTakeHandleEx(
			HighLevelILFunction ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new HighLevelILFlowGraphLayoutRequest(
				ilFunction,
				handle, true);
		}
	    
		internal static HighLevelILFlowGraphLayoutRequest? BorrowHandleEx(
			HighLevelILFunction ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new HighLevelILFlowGraphLayoutRequest(
				ilFunction,
				handle, false);
		}
	    
		internal static HighLevelILFlowGraphLayoutRequest MustBorrowHandleEx(
			HighLevelILFunction ilFunction,
			IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new HighLevelILFlowGraphLayoutRequest(
				ilFunction,
				handle, false);
		}

		
		public HighLevelILFlowGraph? FlowGraph
		{
			get
			{
				return HighLevelILFlowGraph.TakeHandleEx(
					this.ILFunction,
					NativeMethods.BNGetGraphForFlowGraphLayoutRequest(this.handle)
				);
			}
		}

	}
}
