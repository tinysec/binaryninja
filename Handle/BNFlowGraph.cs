using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public abstract class AbstractFlowGraph : AbstractSafeHandle
	{
		internal AbstractFlowGraph(IntPtr handle , bool owner) 
			: base(handle , owner)
	    {
	       
	    }
		
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeFlowGraph(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	    
	   
	    public Function? Function
	    {
		    get
		    {
			    return Function.TakeHandle(NativeMethods.BNGetFunctionForFlowGraph(this.handle));
		    }

		    set
		    {
			    NativeMethods.BNSetFunctionForFlowGraph(
				    this.handle,
				    null == value ? IntPtr.Zero : value.DangerousGetHandle()
				);
		    }
	    }
	    
	    public BinaryView? BinaryView
	    {
		    get
		    {
			    return BinaryView.TakeHandle(NativeMethods.BNGetViewForFlowGraph(this.handle));
		    }

		    set
		    {
			    NativeMethods.BNSetViewForFlowGraph(
				    this.handle,
				    null == value ? IntPtr.Zero : value.DangerousGetHandle()
			    );
		    }
	    }

	    public bool LayoutComplete
	    {
		    get
		    {
			    return NativeMethods.BNIsFlowGraphLayoutComplete(this.handle);
		    }
	    }

	    
	    public ulong NodeCount
	    {
		    get
		    {
			    return NativeMethods.BNGetFlowGraphNodeCount(this.handle);
		    }
	    }

	    public bool HasNodes
	    {
		    get
		    {
			    return NativeMethods.BNFlowGraphHasNodes(this.handle);
		    }
	    }

	    public int Width
	    {
		    get
		    {
			    return NativeMethods.BNGetFlowGraphWidth(this.handle);
		    }

		    set
		    {
			    NativeMethods.BNFlowGraphSetWidth(this.handle, value);
		    }
	    }
	    
	    public int Height
	    {
		    get
		    {
			    return NativeMethods.BNGetFlowGraphHeight(this.handle);
		    }

		    set
		    {
			    NativeMethods.BNFlowGraphSetHeight(this.handle, value);
		    }
	    }
	    
	    
	    public int HorizontalMargin
	    {
		    get
		    {
			    return NativeMethods.BNGetHorizontalFlowGraphNodeMargin(this.handle);
		    }

		    set
		    {
			    NativeMethods.BNSetFlowGraphNodeMargins(
				    this.handle,
				    value,
				    this.VerticalMargin
				);
		    }
	    }
	    
	    
	    public int VerticalMargin
	    {
		    get
		    {
			    return NativeMethods.BNGetVerticalFlowGraphNodeMargin(this.handle);
		    }

		    set
		    {
			    NativeMethods.BNSetFlowGraphNodeMargins(
				    this.handle, 
				    this.HorizontalMargin,
				    value
				);
		    }
	    }
	    
	    public bool IsIL
	    {
		    get
		    {
			    return NativeMethods.BNIsILFlowGraph(this.handle);
		    }
	    }
	  
	    public bool IsLowLevelIL
	    {
		    get
		    {
			    return NativeMethods.BNIsLowLevelILFlowGraph(this.handle);
		    }
	    }

	    public bool IsMediumLevelIL
	    {
		    get
		    {
			    return NativeMethods.BNIsMediumLevelILFlowGraph(this.handle);
		    }
	    }
	    
	    public bool IsHighLevelIL
	    {
		    get
		    {
			    return NativeMethods.BNIsHighLevelILFlowGraph(this.handle);
		    }
	    }

	    public LowLevelILFunction? LowLevelILFunction
	    {
		    get
		    {
			    return LowLevelILFunction.TakeHandle(
				    NativeMethods.BNGetFlowGraphLowLevelILFunction(this.handle)
			    );
		    }

		    set
		    {
			    NativeMethods.BNSetFlowGraphLowLevelILFunction(
				    this.handle ,
				    null == value ? IntPtr.Zero : value.DangerousGetHandle()
			    );
		    }
	    }
	    
	    public MediumLevelILFunction? MediumLevelILFunction
	    {
		    get
		    {
			    return MediumLevelILFunction.TakeHandle(
				    NativeMethods.BNGetFlowGraphMediumLevelILFunction(this.handle)
			    );
		    }
		    
		    set
		    {
			    NativeMethods.BNSetFlowGraphMediumLevelILFunction(
				    this.handle ,
				    null == value ? IntPtr.Zero : value.DangerousGetHandle()
			    );
		    }
	    }
	    
	    public HighLevelILFunction? HighLevelILFunction
	    {
		    get
		    {
			    return HighLevelILFunction.TakeHandle(
				    NativeMethods.BNGetFlowGraphHighLevelILFunction(this.handle)
			    );
		    }
		    
		    set
		    {
			    NativeMethods.BNSetFlowGraphHighLevelILFunction(
				    this.handle ,
				    null == value ? IntPtr.Zero : value.DangerousGetHandle()
			    );
		    }
	    }

	    public bool IsOptionSet(FlowGraphOption option )
	    {
		    return NativeMethods.BNIsFlowGraphOptionSet(this.handle , option );
	    }

	    public void SetOption(FlowGraphOption option , bool value)
	    {
		    NativeMethods.BNSetFlowGraphOption(this.handle , option , value);
	    }

	    public bool UsesBlockHighlights
	    {
		    get
		    {
			    return this.IsOptionSet(FlowGraphOption.FlowGraphUsesBlockHighlights);
		    }

		    set
		    {
			    this.SetOption(FlowGraphOption.FlowGraphUsesBlockHighlights, value);
		    }
	    }
	    
	    public bool UsesInstructionHighlights
	    {
		    get
		    {
			    return this.IsOptionSet(FlowGraphOption.FlowGraphUsesInstructionHighlights);
		    }

		    set
		    {
			    this.SetOption(FlowGraphOption.FlowGraphUsesInstructionHighlights, value);
		    }
	    }
	    
	    public bool IncludesUserComments
	    {
		    get
		    {
			    return this.IsOptionSet(FlowGraphOption.FlowGraphIncludesUserComments);
		    }

		    set
		    {
			    this.SetOption(FlowGraphOption.FlowGraphIncludesUserComments, value);
		    }
	    }
	    
	    public bool AllowsPatching
	    {
		    get
		    {
			    return this.IsOptionSet(FlowGraphOption.FlowGraphAllowsPatching);
		    }

		    set
		    {
			    this.SetOption(FlowGraphOption.FlowGraphAllowsPatching, value);
		    }
	    }
	    
	    public bool AllowsInlineInstructionEditing
	    {
		    get
		    {
			    return this.IsOptionSet(FlowGraphOption.FlowGraphAllowsInlineInstructionEditing);
		    }

		    set
		    {
			    this.SetOption(FlowGraphOption.FlowGraphAllowsInlineInstructionEditing, value);
		    }
	    }
	    
	    public bool ShowsSecondaryRegisterHighlighting
	    {
		    get
		    {
			    return this.IsOptionSet(FlowGraphOption.FlowGraphShowsSecondaryRegisterHighlighting);
		    }

		    set
		    {
			    this.SetOption(FlowGraphOption.FlowGraphShowsSecondaryRegisterHighlighting, value);
		    }
	    }
	    
	    public bool Addressable
	    {
		    get
		    {
			    return this.IsOptionSet(FlowGraphOption.FlowGraphIsAddressable);
		    }

		    set
		    {
			    this.SetOption(FlowGraphOption.FlowGraphIsAddressable, value);
		    }
	    }
	    
	    public bool WorkflowGraph
	    {
		    get
		    {
			    return this.IsOptionSet(FlowGraphOption.FlowGraphIsWorkflowGraph);
		    }

		    set
		    {
			    this.SetOption(FlowGraphOption.FlowGraphIsWorkflowGraph, value);
		    }
	    }

	    

	    public ulong AddNode(FlowGraphNode node)
	    {
		    return NativeMethods.BNAddFlowGraphNode(this.handle, node.DangerousGetHandle());
	    }
	    
	    public void ReplaceNode(ulong index , FlowGraphNode node)
	    {
		    NativeMethods.BNReplaceFlowGraphNode(this.handle, index ,node.DangerousGetHandle());
	    }
	    
	    public void ClearNodes()
	    {
		    NativeMethods.BNClearFlowGraphNodes(this.handle);
	    }

	    public void ShowReport(string title , BinaryView? view = null)
	    {
		    NativeMethods.BNShowGraphReport(
			    null == view ? IntPtr.Zero  : view.DangerousGetHandle(),  
			    title , 
			    this.handle
			);
	    }
	    
	    public RenderLayer[] RenderLayers
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetFlowGraphRenderLayers(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeHandleArray<RenderLayer>(
				    arrayPointer ,
				    arrayLength ,
				    RenderLayer.FromHandle ,
				    NativeMethods.BNFreeRenderLayerList
			    );
		    }

		    set
		    {
			    foreach (RenderLayer layer in this.RenderLayers)
			    {
				    this.RemoveRenderLayer(layer);
			    }
			    
			    foreach (RenderLayer layer in value)
			    {
				    this.AddRenderLayer(layer);
			    }
		    }
	    }

	    public void AddRenderLayer(RenderLayer layer)
	    {
		    NativeMethods.BNAddFlowGraphRenderLayer(this.handle , layer.DangerousGetHandle());
	    }
	    
	    public void RemoveRenderLayer(RenderLayer layer)
	    {
		    NativeMethods.BNRemoveFlowGraphRenderLayer(this.handle , layer.DangerousGetHandle());
	    }
	    
	    
	    public FlowGraphLayoutRequest StartLayout(Action? callback)
	    {
		    IntPtr argCallback = IntPtr.Zero;

		    if (null != callback)
		    {
			    Action<IntPtr> callbackAdapter = ( _ctx => { callback(); } );
			    
			    argCallback = Marshal.GetFunctionPointerForDelegate<Action<IntPtr>>(
				    callbackAdapter
				);
		    }
		    
		    return new FlowGraphLayoutRequest(
			    NativeMethods.BNStartFlowGraphLayout(
				    this.handle , 
				    IntPtr.Zero ,
				    argCallback
				) ,
			    true
		    );
	    }

	    public bool IsNodeValid(FlowGraphNode node)
	    {
		    return NativeMethods.BNIsNodeValidForFlowGraph(this.handle, node.DangerousGetHandle());
	    }
	}
	
	// x
	public sealed class FlowGraph : AbstractFlowGraph
	{
		public FlowGraph()
			:this( NativeMethods.BNCreateFlowGraph() , true)
		{
			
		}

		internal FlowGraph(IntPtr handle , bool owner) 
			: base(handle , owner)
	    {
	       
	    }
		
	    
	    internal static FlowGraph? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new FlowGraph(handle, true);
	    }
	    
	    internal static FlowGraph MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new FlowGraph(handle, true);
	    }
	    
	    internal static FlowGraph? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new FlowGraph(handle, false);
	    }
	    
	    internal static FlowGraph MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new FlowGraph(handle, false);
	    }
	}
}