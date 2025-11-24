using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public class FlowGraphNode : AbstractSafeHandle<FlowGraphNode>
	{
	    internal FlowGraphNode(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeFlowGraphNode(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        return true;
	    }

	    public int X
	    {
		    get
		    {
			    return NativeMethods.BNGetFlowGraphNodeX(this.handle);
		    }

		    set
		    {
			    NativeMethods.BNFlowGraphNodeSetX(this.handle, value);
		    }
	    }
	    
	    public int Y
	    {
		    get
		    {
			    return NativeMethods.BNGetFlowGraphNodeY(this.handle);
		    }

		    set
		    {
			    NativeMethods.BNFlowGraphNodeSetY(this.handle, value);
		    }
	    }
	    
	    public int Width
	    {
		    get
		    {
			    return NativeMethods.BNGetFlowGraphNodeWidth(this.handle);
		    }
	    }
	    
	    public int Height
	    {
		    get
		    {
			    return NativeMethods.BNGetFlowGraphNodeHeight(this.handle);
		    }
	    }
	    
	    public DisassemblyTextLine[] Lines
	    {
		    get
		    {
			    ulong arrayLength = 0;
		    
			    IntPtr arrayPointer = NativeMethods.BNGetFlowGraphNodeLines(
				    this.handle,
				    out arrayLength 
			    );
		    
			    return UnsafeUtils.TakeStructArrayEx<BNDisassemblyTextLine,DisassemblyTextLine>(
				    arrayPointer,
				    arrayLength,
				    DisassemblyTextLine.FromNative,
				    NativeMethods.BNFreeDisassemblyTextLines
			    );
		    }

		    set
		    {
			    using (ScopedAllocator allocator = new ScopedAllocator())
			    {
				    NativeMethods.BNSetFlowGraphNodeLines(
					    this.handle ,
					    allocator.ConvertToNativeArrayEx<BNDisassemblyTextLine , DisassemblyTextLine>(
						    value
					    ) ,
					    (ulong)value.Length
				    );
			    }
		    }
	    }
	    
	    
	    public void AddOutgoingEdge(
		    BranchType kind ,
		    FlowGraphNode target ,
		    EdgeStyle  style 
		)
	    {
		    NativeMethods.BNAddFlowGraphNodeOutgoingEdge(
			    this.handle ,
			    kind ,
			    target.DangerousGetHandle() ,
			    style
		    );
	    }

	    public HighlightColor Highlight
	    {
		    get
		    {
			    return HighlightColor.FromNative(
				    NativeMethods.BNGetFlowGraphNodeHighlight(this.handle)
			    );
		    }

		    set
		    {
			    NativeMethods.BNSetFlowGraphNodeHighlight(this.handle, value);
		    }
	    }


	    public void SetVisibilityRegion(
		    int x  , 
		    int y  , 
		    int width  , 
		    int height 
		)
	    {
		    NativeMethods.BNFlowGraphNodeSetVisibilityRegion(
			    this.handle,
			    x,
			    y,
			    width,
			    height
			);
	    }
	    
	    public void SetOutgoingEdgePoints(ulong edgeNum, Point[] points)
	    {
		    NativeMethods.BNFlowGraphNodeSetOutgoingEdgePoints(
			    this.handle,
			    edgeNum,
			    UnsafeUtils.ConvertToNativeArray<BNPoint,Point>(points),
			    (ulong)points.Length
		    );
	    }
	    
	   

	}
}