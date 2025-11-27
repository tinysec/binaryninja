using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class TransformContext : AbstractSafeHandle
	{
	    internal TransformContext(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	       
	    }

	    internal static TransformContext? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new TransformContext(
			    NativeMethods.BNNewTransformContextReference(handle) ,
			    true
		    );
	    }
	    
	    internal static TransformContext MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new TransformContext(
			    NativeMethods.BNNewTransformContextReference(handle) ,
			    true
		    );
	    }
	    
	    internal static TransformContext? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new TransformContext(handle, true);
	    }
	    
	    internal static TransformContext MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new TransformContext(handle, true);
	    }
	    
	    internal static TransformContext? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new TransformContext(handle, false);
	    }
	    
	    internal static TransformContext MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new TransformContext(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeTransformContext(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }

	    public BinaryView? Input
	    {
		    get
		    {
			    return BinaryView.TakeHandle( 
				    NativeMethods.BNTransformContextGetInput(this.handle)
				);
		    }
	    }

	    public string FileName
	    {
		    get
		    {
			    return UnsafeUtils.TakeUtf8String(
				    NativeMethods.BNTransformContextGetFileName(this.handle)
			    );
		    }
	    }

	    public string TransformName
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNTransformContextGetTransformName(this.handle)
			    );
		    }

	    }

	    public TransformParameter[] Parameters
	    {
		    set
		    {
			    using (ScopedAllocator allocator = new ScopedAllocator())
			    {
				    NativeMethods.BNTransformContextSetTransformParameters(
					    this.handle, 
					    allocator.ConvertToNativeArrayEx<BNTransformParameter,TransformParameter>(
						    value
						),
					    (ulong)value.Length
				    );
			    }
		    }
	    }

	    public void SetParameter(string name , byte[] value)
	    {
		    NativeMethods.BNTransformContextSetTransformParameter(
			    this.handle ,
			    name ,
			    DataBuffer.FromBytes(value).DangerousGetHandle()
		    );
	    }

	    public bool HasParameter(string name)
	    {
		    return NativeMethods.BNTransformContextHasTransformParameter(this.handle, name);
	    }
	    
	    public void ClearParameter(string name)
	    {
		    NativeMethods.BNTransformContextClearTransformParameter(this.handle, name);
	    }
	    
	    public string ExtractionMessage
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNTransformContextGetExtractionMessage(this.handle)
			    );
		    }
	    }
	    
	    public TransformResult ExtractionResult
	    {
		    get
		    {
			    return NativeMethods.BNTransformContextGetExtractionResult(this.handle);
		    }
	    }
	    
	    public TransformResult TransformResult
	    {
		    get
		    {
			    return NativeMethods.BNTransformContextGetTransformResult(this.handle);
		    }
	    }

	    public Metadata? Metadata
	    {
		    get
		    {
			    return Metadata.TakeHandle(
				    NativeMethods.BNTransformContextGetMetadata(this.handle)
			    );
		    }
	    }
	    
	    public TransformContext? Parent
	    {
		    get
		    {
			    return TransformContext.TakeHandle(
				    NativeMethods.BNTransformContextGetParent(this.handle)
			    );
		    }
	    }
	    
	    public ulong ChildCount
	    {
		    get
		    {
			    return NativeMethods.BNTransformContextGetChildCount(this.handle);
		    }
	    }
	    
	    public TransformContext[] Children
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNTransformContextGetChildren(
				    this.handle ,
				    out ulong arrayLength
				);

			    return UnsafeUtils.TakeHandleArrayEx<TransformContext>(
				    arrayPointer ,
				    arrayLength ,
				    TransformContext.MustBorrowHandle,
				    NativeMethods.BNFreeTransformContextList
			    );
		    }
	    }

	    public bool IsLeaf
	    {
		    get
		    {
			    return NativeMethods.BNTransformContextIsLeaf(this.handle);
		    }
	    }
	    
	    public bool IsRoot
	    {
		    get
		    {
			    return NativeMethods.BNTransformContextIsRoot(this.handle);
		    }
	    }
	    
	    public bool IsDatabase
	    {
		    get
		    {
			    return NativeMethods.BNTransformContextIsDatabase(this.handle);
		    }
	    }
	}
}