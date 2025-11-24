using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class TypeArchive : AbstractSafeHandle<TypeArchive>
	{
		internal TypeArchive(IntPtr handle , bool owner) 
			: base(handle , owner)
		{
			
		}
	  
		internal static TypeArchive? NewFromHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new TypeArchive(
				NativeMethods.BNNewTypeArchiveReference(handle) ,
				true
			);
		}
	    
		internal static TypeArchive MustNewFromHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new TypeArchive(
				NativeMethods.BNNewTypeArchiveReference(handle) ,
				true
			);
		}
	    
		internal static TypeArchive? TakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new TypeArchive(handle, true);
		}
	    
		internal static TypeArchive MustTakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new TypeArchive(handle, true);
		}
	    
		internal static TypeArchive? BorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new TypeArchive(handle, false);
		}
	    
		internal static TypeArchive MustBorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new TypeArchive(handle, false);
		}
		
		protected override bool ReleaseHandle()
		{
			if ( !this.IsInvalid )
			{
				NativeMethods.BNFreeTypeArchiveReference(this.handle);
				this.SetHandleAsInvalid();
			}
	        
			return true;
		}

	}
}