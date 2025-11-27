using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class NamedTypeReference : AbstractSafeHandle
	{
		public NamedTypeReference(NamedTypeReferenceClass cls , string id , QualifiedName name) 
			: this( NamedTypeReference.rawCreate(cls , id , name) , true )
		{
			
		}

	    internal NamedTypeReference(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	       
	    }

	    private static IntPtr rawCreate(NamedTypeReferenceClass cls , string id , QualifiedName name)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    return NativeMethods.BNCreateNamedType(
				    cls,
				    id,
				    name.ToNativeEx(allocator)
			    );
		    }
	    }
	    
	    internal static NamedTypeReference? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new NamedTypeReference(
			    NativeMethods.BNNewNamedTypeReference(handle) ,
			    true
		    );
	    }
	    
	    internal static NamedTypeReference MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new NamedTypeReference(
			    NativeMethods.BNNewNamedTypeReference(handle) ,
			    true
		    );
	    }
	    
	    internal static NamedTypeReference? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new NamedTypeReference(handle, true);
	    }
	    
	    internal static NamedTypeReference MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new NamedTypeReference(handle, true);
	    }
	    
	    internal static NamedTypeReference? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new NamedTypeReference(handle, false);
	    }
	    
	    internal static NamedTypeReference MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new NamedTypeReference(handle, false);
	    }

	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeNamedTypeReference(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }

	    public QualifiedName Name
	    {
		    get
		    {
			    return QualifiedName.TakeNative(
				    NativeMethods.BNGetTypeReferenceName(this.handle)
				);
		    }
	    }
	}
}