using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class RenderLayer : AbstractSafeHandle<RenderLayer>
	{
		internal RenderLayer(IntPtr handle)
			:base(handle, false)
		{
			
		}

		internal static RenderLayer FromHandle(IntPtr handle)
		{
			return new RenderLayer(handle);
		}
		
		public string Name
		{
			get
			{
				return UnsafeUtils.TakeAnsiString(
					NativeMethods.BNGetRenderLayerName(this.handle)
				);
			}
		}

		public void ApplyToFlowGraph(FlowGraph graph)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				NativeMethods.BNApplyRenderLayerToFlowGraph(
					this.handle, 
					graph.DangerousGetHandle()
				);
			}
		}
		
		
		public LinearDisassemblyLine[] ApplyToLinearViewObject(
			LinearViewObject linearView,
			LinearViewObject? prev,
			LinearViewObject? next,
			LinearDisassemblyLine[] lines
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				NativeMethods.BNApplyRenderLayerToLinearViewObject(
					this.handle, 
					linearView.DangerousGetHandle(),
					null == prev ? IntPtr.Zero : prev.DangerousGetHandle(),
					null == next ? IntPtr.Zero : next.DangerousGetHandle(),
					allocator.ConvertToNativeArrayEx<BNLinearDisassemblyLine,LinearDisassemblyLine>(lines),
					(ulong)lines.Length,
					out IntPtr outLines, 
					out ulong outLineCount
				);

				return UnsafeUtils.TakeStructArrayEx<BNLinearDisassemblyLine , LinearDisassemblyLine>(
					outLines ,
					outLineCount,
					LinearDisassemblyLine.FromNative,
					NativeMethods.BNFreeLinearDisassemblyLines
				);
			}
		}
	}
}