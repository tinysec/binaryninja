using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
    {
	    public static BasicBlock[] GetIteratedDominanceFrontier(BasicBlock[] blocks)
	    {
		    if (0 == blocks.Length)
		    {
			    return Array.Empty<BasicBlock>();
		    }
		   
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    ulong outputCount = 0;
			    
			    IntPtr arrayPointer = NativeMethods.BNGetBasicBlockIteratedDominanceFrontier(
				    allocator.AllocHandleArray<BasicBlock>(blocks),
				    (ulong)blocks.Length ,
				    out outputCount 
			    );

			    return UnsafeUtils.TakeHandleArrayEx<BasicBlock>(
				    arrayPointer ,
				    outputCount ,
				    BasicBlock.MustNewFromHandle ,
				    BinaryNinja.NativeMethods.BNFreeBasicBlockList
			    );
		    }
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// BNBasicBlock** BNGetBasicBlockIteratedDominanceFrontier(BNBasicBlock** blocks, uint64_t incomingCount, uint64_t* outputCount)
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetBasicBlockIteratedDominanceFrontier"
	    )]
	    internal static extern IntPtr BNGetBasicBlockIteratedDominanceFrontier(
			
		    // BNBasicBlock** blocks
		    IntPtr blocks  , 
			
		    // uint64_t incomingCount
		    ulong incomingCount  , 
			
		    // uint64_t* outputCount
		    out ulong outputCount  
	    );
    }
}