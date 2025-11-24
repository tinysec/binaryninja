using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class FileMetadata : AbstractSafeHandle<FileMetadata>
	{
		public FileMetadata()
			: this(NativeMethods.BNCreateFileMetadata() , true)
		{
			
		}

		public FileMetadata(string filename)
			: this(NativeMethods.BNCreateFileMetadata() , true)
		{
			this.Filename = filename;
		}

		internal FileMetadata(IntPtr handle , bool owner) 
			: base(handle , owner)
		{
			
		}
		
		internal static FileMetadata? TakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new FileMetadata(handle, true);
		}
	    
		internal static FileMetadata MustTakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new FileMetadata(handle, true);
		}
	    
		internal static FileMetadata? BorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new FileMetadata(handle, false);
		}
	    
		internal static FileMetadata MustBorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new FileMetadata(handle, false);
		}
		

		public static FileMetadata FromFile(string filename)
		{
			FileMetadata file = new FileMetadata();

			file.Filename = filename;

			return file;
		}

		protected override bool ReleaseHandle()
		{
			if (!this.IsInvalid)
			{
				NativeMethods.BNCloseFile(this.handle);
				NativeMethods.BNFreeFileMetadata(this.handle);
				this.SetHandleAsInvalid();
			}

			return true;
		}


		public ulong SessionId
		{
			get
			{
				return NativeMethods.BNFileMetadataGetSessionId(this.handle);
			}
		}

		public string Filename
		{
			get
			{
				return UnsafeUtils.TakeUtf8String(
					NativeMethods.BNGetFilename(this.handle)
				);
			}

			set
			{
				NativeMethods.BNSetFilename(this.handle , value);
			}
		}

		public string OriginalFilename
		{
			get
			{
				return UnsafeUtils.TakeUtf8String(
					NativeMethods.BNGetOriginalFilename(this.handle)
				);
			}

			set
			{
				NativeMethods.BNSetOriginalFilename(this.handle , value);
			}
		}

		public string GetVirtualPath()
		{
			return UnsafeUtils.TakeUtf8String(
				NativeMethods.BNGetVirtualPath(this.handle)
			);
		}

		public void SetVirtualPath(string value)
		{
			NativeMethods.BNSetVirtualPath(this.handle , value);
		}


		public bool Modified
		{
			get
			{
				return NativeMethods.BNIsFileModified(this.handle);
			}

			set
			{
				if (value)
				{
					NativeMethods.BNMarkFileModified(this.handle);
				}
				else
				{
					NativeMethods.BNMarkFileSaved(this.handle);
				}
			}
		}

		public bool AnalysisChanged
		{
			get
			{
				return NativeMethods.BNIsAnalysisChanged(this.handle);
			}
		}

		public bool IsBackedByDatabase(string binaryViewType = "")
		{
			return NativeMethods.BNIsBackedByDatabase(this.handle , binaryViewType);
		}

		public string View
		{
			get
			{
				return UnsafeUtils.TakeAnsiString(NativeMethods.BNGetCurrentView(this.handle));
			}

			set
			{
				this.Navigate(value , this.Offset);
			}
		}

		public ulong Offset
		{
			get
			{
				return NativeMethods.BNGetCurrentOffset(this.handle);
			}

			set
			{
				this.Navigate(this.View , value);
			}
		}

		public bool Navigate(string binaryViewType , ulong offset)
		{
			return NativeMethods.BNNavigate(
				this.handle ,
				binaryViewType ,
				offset
			);
		}

		public BinaryView? GetFileViewOfType(string binaryViewType)
		{
			return BinaryView.TakeHandle(
				NativeMethods.BNGetFileViewOfType(this.handle , binaryViewType)
			);
		}

		public BinaryView? RawBinaryView
		{
			get
			{
				return this.GetFileViewOfType("Raw");
			}
		}

		public Database? Database
		{
			get
			{
				return Database.TakeHandle(
					NativeMethods.BNGetFileMetadataDatabase(this.handle)
				);
			}
		}

		public bool SnapshotDataAppliedWithoutError
		{
			get
			{
				return NativeMethods.BNIsSnapshotDataAppliedWithoutError(this.handle);
			}
		}


		public ProjectFile? ProjectFile
		{
			get
			{
				return ProjectFile.TakeHandle(
					NativeMethods.BNGetProjectFile(this.handle)
				);
			}

			set
			{
				NativeMethods.BNSetProjectFile(
					this.handle ,
					null == value ? IntPtr.Zero : value.DangerousGetHandle()
				);
			}
		}

		public void CloseFile()
		{
			NativeMethods.BNCloseFile(this.handle);
		}

		public string BeginUndoActions(bool anonymousAllowed  )
	    {
		    return UnsafeUtils.TakeUtf8String(
			    NativeMethods.BNBeginUndoActions(this.handle , anonymousAllowed)
		    );
	    }

	    public void CommitUndoActions(string id)
	    {
		    NativeMethods.BNCommitUndoActions(this.handle , id);
	    }
	    
	    public void ForgetUndoActions(string id)
	    {
		    NativeMethods.BNForgetUndoActions(this.handle , id);
	    }
	    
	    public void RevertUndoActions(string id)
	    {
		    NativeMethods.BNRevertUndoActions(this.handle , id);
	    }

	    public bool CanUndo
	    {
		    get
		    {
			    return NativeMethods.BNCanUndo(this.handle);
		    }
	    }
	    
	    public bool Undo()
	    {
		    return NativeMethods.BNUndo(this.handle);
	    }
	    
	    public bool CanRedo
	    {
		    get
		    {
			    return NativeMethods.BNCanRedo(this.handle);
		    }
	    }
	    
	    public bool Redo()
	    {
		    return NativeMethods.BNRedo(this.handle);
	    }

	    public UndoEntry[] UndoEntries
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetUndoEntries(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeHandleArrayEx<UndoEntry>(
				    arrayPointer ,
				    arrayLength ,
				    UndoEntry.MustNewFromHandle ,
				    NativeMethods.BNFreeUndoEntryList
			    );
		    }
	    }
	    
	    public UndoEntry[] RedoEntrie
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetRedoEntries(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeHandleArrayEx<UndoEntry>(
				    arrayPointer ,
				    arrayLength ,
				    UndoEntry.MustNewFromHandle ,
				    NativeMethods.BNFreeUndoEntryList
			    );
		    }
	    }

	    public string[] ExistingViews
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetExistingViews(
				    this.handle ,
				    out ulong arrayLength
			    );
			    
			    return UnsafeUtils.TakeAnsiStringArray(
				    arrayPointer,
				    arrayLength ,
				    NativeMethods.BNFreeStringList
			    );
		    }
	    }


	    public void UnregisterViewOfType(string viewType , BinaryView view)
	    {
		    NativeMethods.BNUnregisterViewOfType(
			    this.handle , 
			    viewType , 
			    view.DangerousGetHandle()
			);
	    }
	    
	    public Logger? GetLogger(string name)
	    {
		    return Logger.GetLogger(name , this.SessionId);
	    }
	    
	    public Logger CreateLogger(string name)
	    {
		    return Logger.CreateLogger(name , this.SessionId);
	    }
	    
	    public Logger GetOrCreateLogger(string name)
	    {
		    return Logger.GetOrCreateLogger(name , this.SessionId);
	    }

	    public BinaryView? OpenExistingDatabase(string filename , ProgressDelegate? progress = null)
	    {
		    if (null == progress)
		    {
			    return BinaryView.TakeHandle(
				    NativeMethods.BNOpenExistingDatabase(this.handle , filename)
			    );
		    }
		    else
		    {
			    return BinaryView.TakeHandle(
				    NativeMethods.BNOpenExistingDatabaseWithProgress(
					    this.handle ,
					    filename,
					    IntPtr.Zero, 
					    Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
						    UnsafeUtils.WrapProgressDelegate(progress)
						    )
					)
			    );
		    }
	    }
	    
	    public BinaryView? OpenDatabaseForConfiguration(string filename )
	    {
		    return BinaryView.TakeHandle(
			    NativeMethods.BNOpenDatabaseForConfiguration(this.handle , filename)
		    );
	    }
	    
	}
}