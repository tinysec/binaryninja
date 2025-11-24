using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class Project : AbstractSafeHandle<Project>
	{
		internal Project(IntPtr handle , bool owner) 
			: base(handle , owner)
	    {
	       
	    }
		
		internal static Project? NewFromHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new Project(
				NativeMethods.BNNewProjectReference(handle) ,
				true
			);
		}
	    
		internal static Project MustNewFromHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new Project(
				NativeMethods.BNNewProjectReference(handle) ,
				true
			);
		}
	    
		internal static Project? TakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new Project(handle, true);
		}
	    
		internal static Project MustTakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new Project(handle, true);
		}
	    
		internal static Project? BorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new Project(handle, false);
		}
	    
		internal static Project MustBorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new Project(handle, false);
		}

	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeProject(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	    
	    public PluginCommand[] ValidPluginCommands
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForProject(
				    this.handle,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeStructArray<BNPluginCommand , PluginCommand>(
				    arrayPointer ,
				    arrayLength ,
				    PluginCommand.FromNative ,
				    NativeMethods.BNFreePluginCommandList
			    );
		    }
	    }
	}
}