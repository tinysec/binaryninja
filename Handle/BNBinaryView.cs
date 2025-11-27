using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class BinaryView : AbstractSafeHandle
	{
		internal BinaryView(IntPtr handle , bool owner) 
			: base(handle , owner)
		{
			
		}
		
		internal static BinaryView? TakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new BinaryView(handle, true);
		}
	    
		internal static BinaryView MustTakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new BinaryView(handle, true);
		}
	    
		internal static BinaryView? BorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new BinaryView(handle, false);
		}
	    
		internal static BinaryView MustBorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new BinaryView(handle, false);
		}

		protected override bool ReleaseHandle()
		{
			if (!this.IsInvalid)
			{
				NativeMethods.BNFreeBinaryView(this.handle);
				this.SetHandleAsInvalid();
			}

			return true;
		}

		public ulong Length
		{
			get
			{
				return NativeMethods.BNGetViewLength(this.handle);
			}
		}
		
		public static BinaryView? FromFile(
			string filename ,
			FileMetadata? file = null
		)
		{
			FileMetadata? autoFile = file;

			if (null == autoFile)
			{
				autoFile = new FileMetadata(filename);
			}

			return BinaryView.TakeHandle(
				NativeMethods.BNCreateBinaryDataViewFromFilename(
					autoFile.DangerousGetHandle() ,
					filename
				)
			);
		}

		public static BinaryView? Create(FileMetadata file)
		{
			return BinaryView.TakeHandle(
				NativeMethods.BNCreateBinaryDataView(file.DangerousGetHandle())
			);
		}

		public static BinaryView? FromBuffer( DataBuffer buffer , FileMetadata? file = null )
		{
			if (null == file)
			{
				file = new FileMetadata();
			}
			
			return BinaryView.TakeHandle(
				NativeMethods.BNCreateBinaryDataViewFromBuffer(
					file.DangerousGetHandle() ,
					buffer.DangerousGetHandle()
				)
			);
		}

		public static BinaryView? FromBytes(byte[] data , FileMetadata? file = null )
		{
			if (null == file)
			{
				file = new FileMetadata();
			}
		
			return BinaryView.TakeHandle(
				NativeMethods.BNCreateBinaryDataViewFromData(
					file.DangerousGetHandle() ,
					data,
					(ulong)data.Length
				)
			);
		}

		public BinaryView? Load(
			bool updateAnalysis = false ,
			string options = "",
			ProgressDelegate? progress = null
		)
		{
			return BinaryView.TakeHandle(
				NativeMethods.BNLoadBinaryView(
					this.handle ,
					updateAnalysis ,
					options ,
					null == progress
						? IntPtr.Zero
						: Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
							UnsafeUtils.WrapProgressDelegate(progress)
							) ,
					IntPtr.Zero
				)
			);
		}
		
		public Task<BinaryView?> LoadAsync(
			bool updateAnalysis = false,
			string options = "" ,
			CancellationToken? cancellationToken = null
		)
		{
			return Task.Run(() =>
				{
					bool cancelled = false;

					ProgressDelegate progress = (param2 , param3) =>
					{
						if (null != cancellationToken)
						{
							if (cancellationToken.GetValueOrDefault().IsCancellationRequested)
							{
								cancelled = true;

								return false;
							}
						}

						return true;
					};

					if (cancelled)
					{
						return null;
					}
					
					BinaryView? view =  BinaryView.TakeHandle(
						NativeMethods.BNLoadBinaryView(
							this.handle ,
							updateAnalysis ,
							options ,
							Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
								UnsafeUtils.WrapProgressDelegate(progress)
							),
							IntPtr.Zero
						)
					);

					if (null == view)
					{
						return null;
					}
					
					if (cancelled && ( null != cancellationToken) )
					{
						cancellationToken.GetValueOrDefault().ThrowIfCancellationRequested();
					}

					return view;
				}
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filename">like afd.sys.bndb</param>
		/// <param name="updateAnalysis"></param>
		/// <param name="options"></param>
		/// <param name="progress"></param>
		/// <returns></returns>
		public static BinaryView? LoadFile(
			string filename ,
			bool updateAnalysis = false ,
			string options = "",
			ProgressDelegate? progress = null
		)
		{
			return BinaryView.TakeHandle(
				NativeMethods.BNLoadFilename(
					filename ,
					updateAnalysis ,
					options ,
					null == progress
						? IntPtr.Zero
						: Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
							UnsafeUtils.WrapProgressDelegate(progress)) ,
					IntPtr.Zero
				)
			);
		}

		public static Task<BinaryView?> LoadFileAsync(
			string filename ,
			bool updateAnalysis = false ,
			string options = "",
			CancellationToken? cancellationToken = null
		)
		{
			return Task.Run(() =>
				{
					bool cancelled = false;

					ProgressDelegate progress = (param2 , param3) =>
					{
						if (null != cancellationToken)
						{
							if (cancellationToken.GetValueOrDefault().IsCancellationRequested)
							{
								cancelled = true;

								return false;
							}
						}

						return true;
					};

					if (cancelled)
					{
						return null;
					}
					
					BinaryView? view =  BinaryView.TakeHandle(
						NativeMethods.BNLoadFilename(
							filename ,
							updateAnalysis ,
							options ,
							Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
									UnsafeUtils.WrapProgressDelegate(progress)) ,
							IntPtr.Zero
						)
					);

					if (null == view)
					{
						return null;
					}
					
					if (cancelled && ( null != cancellationToken) )
					{
						cancellationToken.GetValueOrDefault().ThrowIfCancellationRequested();
					}

					return view;
				}
			);
		}

		public static BinaryView? OpenExistingDatabase(string filename , ProgressDelegate? progress = null)
		{
			FileMetadata file = new FileMetadata(filename);
			
			if (null == progress)
			{
				return BinaryView.TakeHandle(
					NativeMethods.BNOpenExistingDatabase(
						file.DangerousGetHandle() ,
						filename
					)
				);
			}
			else
			{
				return BinaryView.TakeHandle(
					NativeMethods.BNOpenExistingDatabaseWithProgress(
						file.DangerousGetHandle() ,
						filename,
						IntPtr.Zero, 
						Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
							UnsafeUtils.WrapProgressDelegate(progress)
						)
					)
				);
			}
		}
		
		public static Task<BinaryView?> OpenExistingDatabaseAsync(
			string filename ,
			CancellationToken? cancellationToken = null
		)
		{
			return Task.Run(() =>
				{
					bool cancelled = false;

					ProgressDelegate progress = (param2 , param3) =>
					{
						if (null != cancellationToken)
						{
							if (cancellationToken.GetValueOrDefault().IsCancellationRequested)
							{
								cancelled = true;

								return false;
							}
						}

						return true;
					};

					if (cancelled)
					{
						return null;
					}
					
					FileMetadata file = new FileMetadata(filename);
					
					BinaryView? view =  BinaryView.TakeHandle(
						NativeMethods.BNOpenExistingDatabaseWithProgress(
							file.DangerousGetHandle() ,
							filename ,
							Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
								UnsafeUtils.WrapProgressDelegate(progress)) ,
							IntPtr.Zero
						)
					);

					if (null == view)
					{
						return null;
					}
					
					if (cancelled && ( null != cancellationToken) )
					{
						cancellationToken.GetValueOrDefault().ThrowIfCancellationRequested();
					}

					return view;
				}
			);
		}
		
		public BinaryView? Parent
		{
			get
			{
				return BinaryView.TakeHandle(
					NativeMethods.BNGetParentView(this.handle)
				);
			}
		}

		public FileMetadata File
		{
			get
			{
				return FileMetadata.MustTakeHandle(
					NativeMethods.BNGetFileForView(this.handle)
				);
			}
		}

		public ulong ImageBase
		{
			get
			{
				return NativeMethods.BNGetImageBase(this.handle);
			}
		}

		public ulong OriginalImageBase
		{
			get
			{
				return NativeMethods.BNGetOriginalImageBase(this.handle);
			}

			set
			{
				NativeMethods.BNSetOriginalImageBase(this.handle , value);
			}
		}

		public ulong Start
		{
			get
			{
				return NativeMethods.BNGetStartOffset(this.handle);
			}
		}

		public ulong End
		{
			get
			{
				return NativeMethods.BNGetEndOffset(this.handle);
			}
		}

		public ulong EntryPoint
		{
			get
			{
				return NativeMethods.BNGetEntryPoint(this.handle);
			}
		}

		public Architecture? DefaultArchitecture
		{
			get
			{
				return Architecture.FromHandle(
					NativeMethods.BNGetDefaultArchitecture(this.handle)
				);
			}

			set
			{
				NativeMethods.BNSetDefaultArchitecture(
					this.handle ,
					null == value ? IntPtr.Zero : value.DangerousGetHandle()
				);
			}
		}

		public Platform? DefaultPlatform
		{
			get
			{
				IntPtr raw = NativeMethods.BNGetDefaultPlatform(this.handle);

				if (IntPtr.Zero == raw)
				{
					return null;
				}

				return new Platform(raw , true);
			}

			set
			{
				NativeMethods.BNSetDefaultPlatform(
					this.handle ,
					null == value ? IntPtr.Zero : value.DangerousGetHandle()
				);
			}
		}

		public Endianness DefaultEndiannes
		{
			get
			{
				return NativeMethods.BNGetDefaultEndianness(this.handle);
			}
		}

		public bool Relocatable
		{
			get
			{
				return NativeMethods.BNIsRelocatable(this.handle);
			}
		}

		public ulong AddressSize
		{
			get
			{
				return NativeMethods.BNGetViewAddressSize(this.handle);
			}
		}

		public bool Modified
		{
			get
			{
				return NativeMethods.BNIsViewModified(this.handle);
			}
		}
		
		public bool Executable
		{
			get
			{
				return NativeMethods.BNIsExecutableView(this.handle);
			}
		}

		public Function[] Functions
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetAnalysisFunctionList(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeHandleArrayEx<Function>(
					arrayPointer ,
					arrayLength ,
					Function.MustNewFromHandle ,
					NativeMethods.BNFreeFunctionList
				);
			}
		}
		
		public IEnumerable<BasicBlock> BasicBlocks
		{
			get
			{
				foreach (Function function in this.Functions)
				{
					foreach (BasicBlock basicBlock in function.BasicBlocks)
					{
						yield return basicBlock;
					}
				}
			}
		}

		public IEnumerable<LowLevelILFunction> LowLevelILFunctions
		{
			get
			{
				foreach (Function function in this.Functions)
				{
					yield return function.LowLevelIL;
				}
			}
		}
		
		public IEnumerable<LowLevelILBasicBlock> LowLevelILBasicBlocks
		{
			get
			{
				foreach (LowLevelILFunction function in this.LowLevelILFunctions)
				{
					foreach (LowLevelILBasicBlock basicBlock in function.BasicBlocks)
					{
						yield return basicBlock;
					}
				}
			}
		}
		
		public IEnumerable<LowLevelILFunction> LiftedILFunctions
		{
			get
			{
				foreach (Function function in this.Functions)
				{
					yield return function.LiftedIL;
				}
			}
		}
		
		public IEnumerable<LowLevelILBasicBlock> LiftedILBasicBlocks
		{
			get
			{
				foreach (LowLevelILFunction function in this.LiftedILFunctions)
				{
					foreach (LowLevelILBasicBlock basicBlock in function.BasicBlocks)
					{
						yield return basicBlock;
					}
				}
			}
		}
		
		public IEnumerable<MediumLevelILFunction> MediumLevelILFunctions
		{
			get
			{
				foreach (Function function in this.Functions)
				{
					yield return function.MediumLevelIL;
				}
			}
		}
		
		public IEnumerable<MediumLevelILBasicBlock> MediumLevelILBasicBlocks
		{
			get
			{
				foreach (MediumLevelILFunction function in this.MediumLevelILFunctions)
				{
					foreach (MediumLevelILBasicBlock basicBlock in function.BasicBlocks)
					{
						yield return basicBlock;
					}
				}
			}
		}
		
		public IEnumerable<MediumLevelILFunction> MappedMediumLevelILFunctions
		{
			get
			{
				foreach (Function function in this.Functions)
				{
					yield return function.MappedMediumLevelIL;
				}
			}
		}

		public IEnumerable<MediumLevelILBasicBlock> MappedMediumLevelILBasicBlocks
		{
			get
			{
				foreach (MediumLevelILFunction function in this.MappedMediumLevelILFunctions)
				{
					foreach (MediumLevelILBasicBlock basicBlock in function.BasicBlocks)
					{
						yield return basicBlock;
					}
				}
			}
		}
		
		public IEnumerable<HighLevelILFunction> HighLevelILFunctions
		{
			get
			{
				foreach (Function function in this.Functions)
				{
					yield return function.HighLevelIL;
				}
			}
		}
		
		public IEnumerable<HighLevelILBasicBlock> HighLevelILBasicBlocks
		{
			get
			{
				foreach (HighLevelILFunction function in this.HighLevelILFunctions)
				{
					foreach (HighLevelILBasicBlock basicBlock in function.BasicBlocks)
					{
						yield return basicBlock;
					}
				}
			}
		}
	
		
		public bool HasFunctions
		{
			get
			{
				return NativeMethods.BNHasFunctions(this.handle);
			}
		}

		public bool HasSymbols
		{
			get
			{
				return NativeMethods.BNHasSymbols(this.handle);
			}
		}

		public bool HasDataVariables
		{
			get
			{
				return NativeMethods.BNHasDataVariables(this.handle);
			}
		}

		public Function? EntryFunction
		{
			get
			{
				IntPtr raw = NativeMethods.BNGetAnalysisEntryPoint(this.handle);

				if (IntPtr.Zero == raw)
				{
					return null;
				}

				return new Function(raw , true);
			}
		}

		public Function[] EntryFunctions
		{
			get
			{
				ulong arrayLength = 0;

				IntPtr arrayPointer = NativeMethods.BNGetAllEntryFunctions(this.handle , out arrayLength);

				return UnsafeUtils.TakeHandleArrayEx<Function>(
					arrayPointer ,
					arrayLength ,
					Function.MustNewFromHandle ,
					NativeMethods.BNFreeFunctionList
				);
			}
		}

		public NameSpace[] NameSpaces
		{
			get
			{
				ulong arrayLength = 0;

				IntPtr arrayPointer = NativeMethods.BNGetNameSpaces(this.handle , out arrayLength);

				return UnsafeUtils.TakeStructArrayEx<BNNameSpace , NameSpace>(
					arrayPointer ,
					arrayLength ,
					NameSpace.FromNative ,
					NativeMethods.BNFreeNameSpaceList
				);
			}
		}

		public string ViewType
		{
			get
			{
				return UnsafeUtils.TakeAnsiString(
					NativeMethods.BNGetViewType(this.handle)
				);
			}
		}

		public BinaryViewType[] ViewTypes
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetBinaryViewTypesForData(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeHandleArray<BinaryViewType>(
					arrayPointer ,
					arrayLength ,
					BinaryViewType.MustFromHandle ,
					NativeMethods.BNFreeBinaryViewTypeList
				);
			}
		}

		public StringReference[] Strings
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetStrings(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArray<BNStringReference , StringReference>(
					arrayPointer ,
					arrayLength ,
					StringReference.FromNative ,
					NativeMethods.BNFreeStringReferenceList
				);
			}
		}

		public AnalysisInfo GetAnalysisInfo()
		{
			return AnalysisInfo.MustTakeNativePointer(
				NativeMethods.BNGetAnalysisInfo(this.handle)
			);
		}

		public AnalysisProgress AnalysisProgress
		{
			get
			{
				return AnalysisProgress.FromNative(NativeMethods.BNGetAnalysisProgress(this.handle));
			}
		}

		public AnalysisState AnalysisState
		{
			get
			{
				return NativeMethods.BNGetAnalysisState(this.handle);
			}
		}

		public LinearViewObject CreateLinearViewDisassembly(
			DisassemblySettings? settings = null
		)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}

			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewDisassembly(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}
		
		public LinearViewObject CreateLinearViewLiftedIL(
			DisassemblySettings? settings = null
		)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewLiftedIL(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}

		public LinearViewObject CreateLinearViewLowLevelIL(
			DisassemblySettings? settings = null
		)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewLowLevelIL(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}

		public LinearViewObject CreateLinearViewLowLevelILSSAForm(
			DisassemblySettings? settings = null
		)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewLowLevelILSSAForm(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}

		public LinearViewObject CreateLinearViewMediumLevelIL(
			DisassemblySettings? settings = null
		)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewMediumLevelIL(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}

		public LinearViewObject CreateLinearViewMediumLevelILSSAForm(
			DisassemblySettings? settings = null
		)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewMediumLevelILSSAForm(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}

		public LinearViewObject CreateLinearViewMappedMediumLevelIL(
			DisassemblySettings? settings = null
		)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewMappedMediumLevelIL(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}

		public LinearViewObject CreateLinearViewMappedMediumLevelILSSAForm(
			DisassemblySettings? settings = null
		)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewMappedMediumLevelILSSAForm(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}

		public LinearViewObject CreateLinearViewHighLevelIL(DisassemblySettings? settings = null)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewHighLevelIL(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}

		public LinearViewObject CreateLinearViewHighLevelILSSAForm(DisassemblySettings? settings = null)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewHighLevelILSSAForm(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}

		public LinearViewObject CreateLinearViewLanguageRepresentation(
			DisassemblySettings? settings = null ,
			string language = "Pseudo C"
		)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.DefaultLinear();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewLanguageRepresentation(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle() ,
					language
				)
			);
		}

		public LinearViewObject CreateLinearViewDataOnly(DisassemblySettings? settings = null)
		{
			if (null == settings)
			{
				settings = DisassemblySettings.Default();
			}
			
			return LinearViewObject.MustTakeHandle(
				NativeMethods.BNCreateLinearViewDataOnly(
					this.handle ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				)
			);
		}

		public DataVariable[] DataVariables
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetDataVariables(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNDataVariable , DataVariable>(
					arrayPointer ,
					arrayLength ,
					DataVariable.FromNative ,
					NativeMethods.BNFreeDataVariables
				);
			}
		}

		public QualifiedNameAndType[] Types
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetAnalysisTypeList(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNQualifiedNameAndType , QualifiedNameAndType>(
					arrayPointer ,
					arrayLength ,
					QualifiedNameAndType.FromNative ,
					NativeMethods.BNFreeTypeAndNameList
				);
			}
		}

		public QualifiedNameAndType[] DependencySortedTypes
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetAnalysisDependencySortedTypeList(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNQualifiedNameAndType , QualifiedNameAndType>(
					arrayPointer ,
					arrayLength ,
					QualifiedNameAndType.FromNative ,
					NativeMethods.BNFreeTypeAndNameList
				);
			}
		}

		public QualifiedName[] GetTypeNames(string match)
		{
			IntPtr arrayPointer = NativeMethods.BNGetAnalysisTypeNames(
				this.handle ,
				out ulong arrayLength ,
				match
			);

			return UnsafeUtils.TakeStructArrayEx<BNQualifiedName , QualifiedName>(
				arrayPointer ,
				arrayLength ,
				QualifiedName.FromNative ,
				NativeMethods.BNFreeTypeNameList
			);
		}

		public TypeLibrary[] TypeLibraries
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetBinaryViewTypeLibraries(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeHandleArrayEx<TypeLibrary>(
					arrayPointer ,
					arrayLength ,
					TypeLibrary.MustNewFromHandle ,
					NativeMethods.BNFreeTypeLibraryList
				);
			}
		}

		public IDictionary<string , string> TypeArchives
		{
			get
			{
				ulong arrayLength = NativeMethods.BNBinaryViewGetTypeArchives(
					this.handle ,
					out IntPtr idArrayPointer ,
					out IntPtr pathArrayPointer
				);

				string[] ids = UnsafeUtils.TakeAnsiStringArray(
					idArrayPointer ,
					arrayLength,
					NativeMethods.BNFreeStringList
				);

				string[] paths = UnsafeUtils.TakeAnsiStringArray(
					pathArrayPointer ,
					arrayLength,
					NativeMethods.BNFreeStringList
				);

				Dictionary<string , string> targets = new Dictionary<string , string>();

				for (ulong i = 0; i < arrayLength; i++)
				{
					targets[ids[i]] = paths[i];
				}

				return targets;
			}
		}

		public TypeArchive? GetTypeArchive(string id)
		{
			return TypeArchive.TakeHandle(
				NativeMethods.BNBinaryViewGetTypeArchive(this.handle , id)
			);
		}

		public TypeArchive[] ConnectedTypeArchives
		{
			get
			{
				List<TypeArchive> targets = new List<TypeArchive>();

				foreach (string id in this.TypeArchives.Keys)
				{
					TypeArchive? archive = this.GetTypeArchive(id);

					if (null != archive)
					{
						targets.Add(archive);
					}
				}

				return targets.ToArray();
			}
		}

		public Segment[] Segments
		{
			get
			{
				ulong arrayLength = 0;

				IntPtr arrayPointer = NativeMethods.BNGetSegments(this.handle , out arrayLength);

				return UnsafeUtils.TakeHandleArrayEx<Segment>(
					arrayPointer ,
					arrayLength ,
					Segment.MustNewFromHandle ,
					NativeMethods.BNFreeSegmentList
				);
			}
		}

		public Section[] Sections
		{
			get
			{
				ulong arrayLength = 0;

				IntPtr arrayPointer = NativeMethods.BNGetSections(this.handle , out arrayLength);

				return UnsafeUtils.TakeHandleArrayEx<Section>(
					arrayPointer ,
					arrayLength ,
					Section.MustNewFromHandle ,
					NativeMethods.BNFreeSectionList
				);
			}
		}

		public AddressRange[] AllocatedRanges
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetAllocatedRanges(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArray<BNAddressRange , AddressRange>(
					arrayPointer ,
					arrayLength ,
					AddressRange.FromNative ,
					NativeMethods.BNFreeAddressRanges
				);
			}
		}

		public AddressRange[] MappedAddressRange
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetMappedAddressRanges(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArray<BNAddressRange , AddressRange>(
					arrayPointer ,
					arrayLength ,
					AddressRange.FromNative ,
					NativeMethods.BNFreeAddressRanges
				);
			}
		}

		public AddressRange[] BackedAddressRanges
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetBackedAddressRanges(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArray<BNAddressRange , AddressRange>(
					arrayPointer ,
					arrayLength ,
					AddressRange.FromNative ,
					NativeMethods.BNFreeAddressRanges
				);
			}
		}

		public RegisterValueWithConfidence GlobalPointerValue
		{
			get
			{
				return RegisterValueWithConfidence.FromNative(
					NativeMethods.BNGetGlobalPointerValue(this.handle)
				);
			}

			set
			{
				NativeMethods.BNSetUserGlobalPointerValue(
					this.handle ,
					value.ToNative()
				);
			}
		}

		public bool UserGlobalPointerValueSet
		{
			get
			{
				return NativeMethods.BNUserGlobalPointerValueSet(this.handle);
			}
		}

		public void ClearUserGlobalPointerValue()
		{
			NativeMethods.BNClearUserGlobalPointerValue(this.handle);
		}


		public AnalysisParameters ParametersForAnalysis
		{
			get
			{
				return AnalysisParameters.FromNative(
					NativeMethods.BNGetParametersForAnalysis(this.handle)
				);
			}

			set
			{
				NativeMethods.BNSetParametersForAnalysis(this.handle , value.ToNative());
			}
		}

		public ulong MaxFunctionSizeForAnalysis
		{
			get
			{
				return NativeMethods.BNGetMaxFunctionSizeForAnalysis(this.handle);
			}

			set
			{
				NativeMethods.BNSetMaxFunctionSizeForAnalysis(this.handle , value);
			}
		}

		public Relocation[] GetRelocationsAt(ulong address)
		{
			IntPtr arrayPointer = NativeMethods.BNGetRelocationsAt(
				this.handle ,
				address ,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArrayEx<Relocation>(
				arrayPointer ,
				arrayLength ,
				Relocation.MustNewFromHandle ,
				NativeMethods.BNFreeRelocationList
			);
		}

		public Range[] RelocationRanges
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetRelocationRanges(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArray<BNRange , Range>(
					arrayPointer ,
					arrayLength ,
					Range.FromNative ,
					NativeMethods.BNFreeRelocationRanges
				);
			}
		}

		public Range[] GetRelocationRangesAtAddress(ulong address)
		{
			IntPtr arrayPointer = NativeMethods.BNGetRelocationRangesAtAddress(
				this.handle ,
				address ,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeStructArray<BNRange , Range>(
				arrayPointer ,
				arrayLength ,
				Range.FromNative ,
				NativeMethods.BNFreeRelocationRanges
			);
		}

		public Range[] GetRelocationRangesInRange(ulong address , ulong length)
		{
			IntPtr arrayPointer = NativeMethods.BNGetRelocationRangesInRange(
				this.handle ,
				address ,
				length ,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeStructArray<BNRange , Range>(
				arrayPointer ,
				arrayLength ,
				Range.FromNative ,
				NativeMethods.BNFreeRelocationRanges
			);
		}

		public bool FinalizeNewSegments()
		{
			return NativeMethods.BNBinaryViewFinalizeNewSegments(this.handle);
		}

		public bool RangeContainsRelocation(ulong address , ulong length)
		{
			return NativeMethods.BNRangeContainsRelocation(this.handle , address , length);
		}

		public bool NewAutoFunctionAnalysisSuppressed
		{
			get
			{
				return NativeMethods.BNGetNewAutoFunctionAnalysisSuppressed(this.handle);
			}

			set
			{
				NativeMethods.BNSetNewAutoFunctionAnalysisSuppressed(this.handle , value);
			}
		}

		public DataBuffer ReadBuffer(ulong offset , ulong length)
		{
			return DataBuffer.MustTakeHandle(
				NativeMethods.BNReadViewBuffer(this.handle , offset , length)
			);
		}

		public byte[] ReadData(ulong offset , ulong length)
		{
			if (0 == length)
			{
				return Array.Empty<byte>();
			}
			
			byte[] buffer = new byte[length];


			ulong readed = NativeMethods.BNReadViewData(
				this.handle ,
				buffer ,
				offset ,
				length
			);

			if (readed < length)
			{
				if (0 == readed)
				{
					return Array.Empty<byte>();
				}
				
				byte[] part = new byte[readed];
				
				Array.Copy(
					buffer,
					0,
					part,
					0,
					(int)readed
				);
				
				return part;
			}
		
			return buffer;
		}

		
		public ulong? ReadPointer(ulong offset)
		{
			BinaryReader reader = new BinaryReader(this);

			reader.Position = offset;
			
			bool ok = NativeMethods.BNReadPointer(
				this.handle ,
				reader.DangerousGetHandle(),
				out ulong value
			);
			
			return ok ? value : null;
		}
		
		public ulong WriteBuffer(ulong offset , DataBuffer buffer)
		{
			return NativeMethods.BNWriteViewBuffer(
				this.handle ,
				offset ,
				buffer.DangerousGetHandle()
			);
		}

		public ulong WriteData(ulong offset , byte[] data)
		{
			return NativeMethods.BNWriteViewData(
				this.handle ,
				offset ,
				data,
				(ulong)data.Length
			);
		}
		
		public ulong InsertBuffer(ulong offset , DataBuffer buffer)
		{
			return NativeMethods.BNInsertViewBuffer(
				this.handle ,
				offset ,
				buffer.DangerousGetHandle()
			);
		}

		public ulong InsertData(ulong offset , byte[] data)
		{
			return NativeMethods.BNInsertViewData(
				this.handle ,
				offset ,
				data,
				(ulong)data.Length
			);
		}

		
		public ulong RemoveData(ulong offset , ulong length)
		{
			return NativeMethods.BNRemoveViewData(this.handle , offset , length);
		}

		public float[] GetEntropy(ulong offset , ulong length , ulong blockSize)
		{
			if (0 == length)
			{
				return Array.Empty<float>();
			}
				
			if (0 == blockSize)
			{
				blockSize = this.Length;
			}
			
			float[] entropy= new float[ ( length / blockSize) + 1];
			
			ulong arrayLength = NativeMethods.BNGetEntropy(
				this.handle , 
				offset , 
				length ,
				blockSize,
				ref entropy
			);

			return entropy;
		}

		public ModificationStatus GetModification(ulong offset)
		{
			return NativeMethods.BNGetModification(
				this.handle , 
				offset 
			);
		}
		
		public ModificationStatus[] GetModificationStatus(ulong offset , ulong length )
		{
			ModificationStatus[] buffer = new ModificationStatus[length];
			
			ulong written = NativeMethods.BNGetModificationArray(
				this.handle , 
				offset ,
				buffer,
				length
			);

			if (0 == written)
			{
				return Array.Empty<ModificationStatus>();
			}
			
			if (written == length)
			{
				return buffer;
			}

			ModificationStatus[] status = new ModificationStatus[written];
			
			Array.Copy(buffer, status, (long)written);
			
			return status;
		}

		public ulong GetNextValidOffset(ulong offset)
		{
			return NativeMethods.BNGetNextValidOffset(this.handle , offset);
		}

		public bool IsValidOffset(ulong offset)
		{
			return NativeMethods.BNIsValidOffset(this.handle , offset);
		}

		public bool IsOffsetReadable(ulong offset)
		{
			return NativeMethods.BNIsOffsetReadable(this.handle , offset);
		}
		
		public bool IsOffsetWritable(ulong offset)
		{
			return NativeMethods.BNIsOffsetWritable(this.handle , offset);
		}

		public bool IsOffsetExecutable(ulong offset)
		{
			return NativeMethods.BNIsOffsetExecutable(this.handle , offset);
		}
		
		public bool IsOffsetBackedByFile(ulong offset)
		{
			return NativeMethods.BNIsOffsetBackedByFile(this.handle , offset);
		}
		
		public bool IsOffsetCodeSemantics(ulong offset)
		{
			return NativeMethods.BNIsOffsetCodeSemantics(this.handle , offset);
		}
		
		public bool IsOffsetExternSemantics(ulong offset)
		{
			return NativeMethods.BNIsOffsetExternSemantics(this.handle , offset);
		}

		public bool IsOffsetWritableSemantics(ulong offset)
		{
			return NativeMethods.BNIsOffsetWritableSemantics(this.handle , offset);
		}

		public bool SaveToFile(FileAccessor accessor)
		{
			return NativeMethods.BNSaveToFile(this.handle , accessor.ToNative());
		}

		public bool SaveToFilename(string filename)
		{
			if (!Path.IsPathRooted(filename))
			{
				filename = Path.GetFullPath(filename);
			}
		
			string? dirname = Path.GetDirectoryName(filename);
			if (!string.IsNullOrEmpty(dirname) && !Directory.Exists(dirname))
			{
				Directory.CreateDirectory(dirname);
			}
			
			return NativeMethods.BNSaveToFilename(
				this.handle , 
				filename
			);
		}

		public Function? AddFunctionForAnalysis(
			ulong address ,
			Platform? platform = null,
			bool autoDiscovered = false,
			BinaryNinja.Type? functionType = null
		)
		{
			if (null == platform)
			{
				platform = this.DefaultPlatform;
			}

			return Function.TakeHandle(

				NativeMethods.BNAddFunctionForAnalysis(
					this.handle ,
					null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
					address ,
					autoDiscovered ,
					null == functionType ? IntPtr.Zero : functionType.DangerousGetHandle()
				)
			);
		}
		
		public void AddEntryPointForAnalysis(ulong address , Platform? platform = null )
		{
			if (null == platform)
			{
				platform = this.DefaultPlatform;
			}

			NativeMethods.BNAddEntryPointForAnalysis(
				this.handle ,
				null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
				address 
			);
		}

		public void AddToEntryFunctions(Function function)
		{
			NativeMethods.BNAddToEntryFunctions(
				this.handle ,
				function.DangerousGetHandle()
			);
		}

		public void RemoveAnalysisFunction(Function function , bool updateRefs = false  )
		{
			NativeMethods.BNRemoveAnalysisFunction(
				this.handle , 
				function.DangerousGetHandle(),
				updateRefs
			);
		}

		public Function? CreateUserFunction(ulong address , Platform? platform = null)
		{
			if (null == platform)
			{
				platform = this.DefaultPlatform;
			}

			return Function.TakeHandle(

				NativeMethods.BNCreateUserFunction(
					this.handle ,
					null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
					address
				)
			);
		}
		
		public void RemoveUserFunction(Function function  )
		{
			NativeMethods.BNRemoveUserFunction(
				this.handle , 
				function.DangerousGetHandle()
			);
		}

		public void AddAnalysisOption(string option)
		{
			NativeMethods.BNAddAnalysisOption(this.handle , option);
		}

		public bool HasInitialAnalysis
		{
			get
			{
				return NativeMethods.BNHasInitialAnalysis(this.handle);
			}
		}

		public void SetAnalysisHold(bool enable  )
		{
			NativeMethods.BNSetAnalysisHold(this.handle , enable);
		}

		public bool FunctionAnalysisUpdateDisabled
		{
			get
			{
				return NativeMethods.BNGetFunctionAnalysisUpdateDisabled(this.handle);
			}

			set
			{
				NativeMethods.BNSetFunctionAnalysisUpdateDisabled(this.handle ,value);
			}
		}

		public void UpdateAnalysis()
		{
			NativeMethods.BNUpdateAnalysis(this.handle);
		}
		
		public void UpdateAnalysisAndWait()
		{
			NativeMethods.BNUpdateAnalysisAndWait(this.handle);
		}
		
		public void AbortAnalysis()
		{
			NativeMethods.BNAbortAnalysis(this.handle);
		}

		public bool AnalysisIsAborted
		{
			get
			{
				return NativeMethods.BNAnalysisIsAborted(this.handle);
			}
		}

		public bool ShouldSkipTargetAnalysis(
			ArchitectureAndAddress source ,
			Function sourceFunction,
			ulong sourceEnd,
			ArchitectureAndAddress target
			)
		{
			return NativeMethods.BNShouldSkipTargetAnalysis(
				this.handle,
				source.ToNative(),
				sourceFunction.DangerousGetHandle(),
				sourceEnd,
				target.ToNative()
			);
		}

		public void DefineDataVariable(ulong address , TypeWithConfidence type)
		{
			NativeMethods.BNDefineDataVariable(
				this.handle,
				address ,
				type.ToNative()
			);
		}
		
		public void DefineUserDataVariable(ulong address , TypeWithConfidence type)
		{
			NativeMethods.BNDefineUserDataVariable(
				this.handle,
				address ,
				type.ToNative()
			);
		}

		public void UndefineDataVariable(ulong address , bool blacklist = false)
		{
			NativeMethods.BNUndefineDataVariable(this.handle , address , blacklist);
		}
		
		public void UndefineUserDataVariable(ulong address )
		{
			NativeMethods.BNUndefineUserDataVariable(this.handle , address);
		}

		public DataVariable? GetDataVariableAtAddress(ulong address)
		{
			bool ok = NativeMethods.BNGetDataVariableAtAddress(
				this.handle ,
				address ,
				out BNDataVariable native
			);

			if (!ok)
			{
				return null;
			}

			return DataVariable.TakeNative(native);
		}

		public Function[] GetFunctionsContainingAddress(ulong address)
		{
			IntPtr arrayPointer = NativeMethods.BNGetAnalysisFunctionsContainingAddress(
				this.handle ,
				address ,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArrayEx<Function>(
				arrayPointer ,
				arrayLength ,
				Function.MustNewFromHandle,
				NativeMethods.BNFreeFunctionList
			);
		}

		public Function[] GetFunctionsByName(string name)
		{
			Symbol[] symbols = this.GetSymbolsByName(name);
			
			List<Function> functions = new List<Function>();

			foreach (Symbol symbol in symbols)
			{
				Function? function = this.GetFunctionByAddress(
					symbol.Address
				);

				if (null != function)
				{
					functions.Add(function);
				}
			}

			return functions.ToArray();
		}

		public Function? GetFunctionByRawName(string name , Platform? platform = null)
		{
			Symbol? symbol = this.GetSymbolByRawName(name);

			if (null == symbol)
			{
				return null;
			}
			
			return this.GetFunctionByAddress(symbol.Address);
		}
		
		public LowLevelILFunction? GetLowLevelILFunctionByRawName(
			string name , 
			Platform? platform = null)
		{
			Function? function = this.GetFunctionByRawName(name);

			if (null == function)
			{
				return null;
			}
			
			return function.GetLowLevelIL();
		}
		
		public MediumLevelILFunction? GetMediumLevelILFunctionByRawName(
			string name , 
			Platform? platform = null)
		{
			Function? function = this.GetFunctionByRawName(name);

			if (null == function)
			{
				return null;
			}
			
			return function.GetMediumLevelIL();
		}
		
		public HighLevelILFunction? GetHighLevelILFunctionByRawName(
			string name , 
			Platform? platform = null)
		{
			Function? function = this.GetFunctionByRawName(name);

			if (null == function)
			{
				return null;
			}
			
			return function.GetHighLevelIL();
		}
		
		public LanguageRepresentationFunction? GetLanguageRepresentationFunctionByRawName(
			string name , 
			string language = "Pseudo C",
			Platform? platform = null)
		{
			Function? function = this.GetFunctionByRawName(name);

			if (null == function)
			{
				return null;
			}
			
			return function.GetLanguageRepresentation(language);
		}
		
		public Function? GetFunctionByAddress(ulong address , Platform? platform = null)
		{
			if (null == platform)
			{
				platform = this.DefaultPlatform;
			}
			
			return Function.TakeHandle(
				NativeMethods.BNGetAnalysisFunction(
					this.handle ,
					null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
					address
				)
			);
		}
		
		public Function[] GetFunctionsForAddress(ulong address)
		{
			IntPtr arrayPointer = NativeMethods.BNGetAnalysisFunctionsForAddress(
				this.handle ,
				address ,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArrayEx<Function>(
				arrayPointer ,
				arrayLength ,
				Function.MustNewFromHandle,
				NativeMethods.BNFreeFunctionList
			);
		}
		
		public Function? GetRecentFunctionForAddress(ulong address )
		{
			return Function.TakeHandle(
				NativeMethods.BNGetRecentAnalysisFunctionForAddress(
					this.handle ,
					address
				)
			);
		}
		
		public BasicBlock[] GetBasicBlocksForAddress(ulong address)
		{
			IntPtr arrayPointer = NativeMethods.BNGetBasicBlocksForAddress(
				this.handle ,
				address ,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArrayEx<BasicBlock>(
				arrayPointer ,
				arrayLength ,
				BasicBlock.MustNewFromHandle,
				NativeMethods.BNFreeBasicBlockList
			);
		}

		public BasicBlock[] GetBasicBlocksStartingAtAddress(ulong address)
		{
			IntPtr arrayPointer = NativeMethods.BNGetBasicBlocksStartingAtAddress(
				this.handle ,
				address ,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArrayEx<BasicBlock>(
				arrayPointer ,
				arrayLength ,
				BasicBlock.MustNewFromHandle ,
				NativeMethods.BNFreeBasicBlockList
			);
		}
		
		public BasicBlock? GetRecentBasicBlockForAddress(ulong address )
		{
			return BasicBlock.TakeHandle(
				NativeMethods.BNGetRecentBasicBlockForAddress(
					this.handle ,
					address
				)
			);
		}

		public ReferenceSource[] GetCodeReferences(
			ulong address,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			IntPtr arrayPointer = NativeMethods.BNGetCodeReferences(
				this.handle ,
				address ,
				out ulong arrayLength ,
				limit ,
				maxItems
			);

			return UnsafeUtils.TakeStructArrayEx<BNReferenceSource , ReferenceSource>(
				arrayPointer ,
				arrayLength ,
				ReferenceSource.FromNative ,
				NativeMethods.BNFreeCodeReferences
			);
		}
		
		public ReferenceSource[] GetCodeReferencesInRange(
			ulong address,
			ulong length,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			IntPtr arrayPointer = NativeMethods.BNGetCodeReferencesInRange(
				this.handle ,
				address ,
				length,
				out ulong arrayLength ,
				limit ,
				maxItems
			);

			return UnsafeUtils.TakeStructArrayEx<BNReferenceSource , ReferenceSource>(
				arrayPointer ,
				arrayLength ,
				ReferenceSource.FromNative ,
				NativeMethods.BNFreeCodeReferences
			);
		}
		
		public ulong[] GetCodeReferencesFrom(ReferenceSource source)
		{
			IntPtr arrayPointer = NativeMethods.BNGetCodeReferencesFrom(
				this.handle ,
				source.ToNative() ,
				out ulong arrayLength 
			);

			return UnsafeUtils.TakeNumberArray<ulong>(
				arrayPointer ,
				arrayLength ,
				NativeMethods.BNFreeAddressList
			);
		}
		
		public ulong[] GetCodeReferencesFromInRange(ReferenceSource source , ulong length)
		{
			IntPtr arrayPointer = NativeMethods.BNGetCodeReferencesFromInRange(
				this.handle ,
				source.ToNative() ,
				length,
				out ulong arrayLength 
			);

			return UnsafeUtils.TakeNumberArray<ulong>(
				arrayPointer ,
				arrayLength ,
				NativeMethods.BNFreeAddressList
			);
		}
		
		public ulong[] GetDataReferences(
			ulong address,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			IntPtr arrayPointer = NativeMethods.BNGetDataReferences(
				this.handle ,
				address ,
				out ulong arrayLength ,
				limit,
				maxItems
			);

			return UnsafeUtils.TakeNumberArray<ulong>(
				arrayPointer ,
				arrayLength ,
				NativeMethods.BNFreeDataReferences
			);
		}
		
		public ulong[] GetDataReferencesInRange(
			ulong address,
			ulong length,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			IntPtr arrayPointer = NativeMethods.BNGetDataReferencesInRange(
				this.handle ,
				address ,
				length,
				out ulong arrayLength ,
				limit,
				maxItems
			);

			return UnsafeUtils.TakeNumberArray<ulong>(
				arrayPointer ,
				arrayLength ,
				NativeMethods.BNFreeDataReferences
			);
		}
		
		public ulong[] GetDataReferencesFrom(ulong address)
		{
			IntPtr arrayPointer = NativeMethods.BNGetDataReferencesFrom(
				this.handle ,
				address ,
				out ulong arrayLength 
			);

			return UnsafeUtils.TakeNumberArray<ulong>(
				arrayPointer ,
				arrayLength ,
				NativeMethods.BNFreeDataReferences
			);
		}
		
		public ulong[] GetDataReferencesFromInRange(ulong address , ulong length)
		{
			IntPtr arrayPointer = NativeMethods.BNGetDataReferencesFromInRange(
				this.handle ,
				address ,
				length,
				out ulong arrayLength 
			);

			return UnsafeUtils.TakeNumberArray<ulong>(
				arrayPointer ,
				arrayLength ,
				NativeMethods.BNFreeDataReferences
			);
		}
		
		public ReferenceSource[] GetCodeReferencesForType(
			QualifiedName type,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetCodeReferencesForType(
					this.handle ,
					type.ToNativeEx(allocator) ,
					out ulong arrayLength ,
					limit ,
					maxItems
				);

				return UnsafeUtils.TakeStructArrayEx<BNReferenceSource , ReferenceSource>(
					arrayPointer ,
					arrayLength ,
					ReferenceSource.FromNative ,
					NativeMethods.BNFreeCodeReferences
				);
			}
		}

		public ReferenceSource[] GetCodeReferencesForTypeField(
			QualifiedName type,
			ulong offset,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetCodeReferencesForTypeField(
					this.handle ,
					type.ToNativeEx(allocator) ,
					offset,
					out ulong arrayLength ,
					limit ,
					maxItems
				);

				return UnsafeUtils.TakeStructArrayEx<BNReferenceSource , ReferenceSource>(
					arrayPointer ,
					arrayLength ,
					ReferenceSource.FromNative ,
					NativeMethods.BNFreeCodeReferences
				);
			}
		}
		
		public ulong[] GetDataReferencesForType(
			QualifiedName type,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetDataReferencesForType(
					this.handle ,
					type.ToNativeEx(allocator) ,
					out ulong arrayLength ,
					limit ,
					maxItems
				);

				return UnsafeUtils.TakeNumberArray<ulong>(
					arrayPointer ,
					arrayLength ,
					NativeMethods.BNFreeDataReferences
				);
			}
		}
		
		public ulong[] GetDataReferencesForTypeField(
			QualifiedName type,
			ulong offset,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetDataReferencesForTypeField(
					this.handle ,
					type.ToNativeEx(allocator) ,
					offset,
					out ulong arrayLength ,
					limit ,
					maxItems
				);

				return UnsafeUtils.TakeNumberArray<ulong>(
					arrayPointer ,
					arrayLength ,
					NativeMethods.BNFreeDataReferences
				);
			}
		}
		
		public ulong[] GetDataReferencesFromForTypeField(
			QualifiedName type,
			ulong offset,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetDataReferencesFromForTypeField(
					this.handle ,
					type.ToNativeEx(allocator) ,
					offset,
					out ulong arrayLength ,
					limit ,
					maxItems
				);

				return UnsafeUtils.TakeNumberArray<ulong>(
					arrayPointer ,
					arrayLength ,
					NativeMethods.BNFreeDataReferences
				);
			}
		}
		
		public TypeReferenceSource[] GetTypeReferencesForType(
			QualifiedName type,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetTypeReferencesForType(
					this.handle ,
					type.ToNativeEx(allocator) ,
					out ulong arrayLength ,
					limit ,
					maxItems
				);

				return UnsafeUtils.TakeStructArrayEx<BNTypeReferenceSource , TypeReferenceSource>(
					arrayPointer ,
					arrayLength ,
					TypeReferenceSource.FromNative ,
					NativeMethods.BNFreeTypeReferences
				);
			}
		}
		
		public TypeReferenceSource[] GetTypeReferencesForTypeField(
			QualifiedName type,
			ulong offset ,
			bool limit = false,
			ulong maxItems = 0
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetTypeReferencesForTypeField(
					this.handle ,
					type.ToNativeEx(allocator) ,
					offset,
					out ulong arrayLength ,
					limit ,
					maxItems
				);

				return UnsafeUtils.TakeStructArrayEx<BNTypeReferenceSource , TypeReferenceSource>(
					arrayPointer ,
					arrayLength ,
					TypeReferenceSource.FromNative ,
					NativeMethods.BNFreeTypeReferences
				);
			}
		}

		public TypeReferenceSource[] GetCodeReferencesForTypeFrom(ReferenceSource source)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetCodeReferencesForTypeFrom(
					this.handle ,
					source.ToNative(),
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeStructArrayEx<BNTypeReferenceSource , TypeReferenceSource>(
					arrayPointer ,
					arrayLength ,
					TypeReferenceSource.FromNative ,
					NativeMethods.BNFreeTypeReferences
				);
			}
		}

		public TypeReferenceSource[] GetCodeReferencesForTypeFromInRange(
			ReferenceSource source,
			ulong length
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetCodeReferencesForTypeFromInRange(
					this.handle ,
					source.ToNative(),
					length,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeStructArrayEx<BNTypeReferenceSource , TypeReferenceSource>(
					arrayPointer ,
					arrayLength ,
					TypeReferenceSource.FromNative ,
					NativeMethods.BNFreeTypeReferences
				);
			}
		}
		
		public TypeReferenceSource[] GetCodeReferencesForTypeFieldsFrom(ReferenceSource source)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetCodeReferencesForTypeFieldsFrom(
					this.handle ,
					source.ToNative(),
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeStructArrayEx<BNTypeReferenceSource , TypeReferenceSource>(
					arrayPointer ,
					arrayLength ,
					TypeReferenceSource.FromNative ,
					NativeMethods.BNFreeTypeReferences
				);
			}
		}
		
		public TypeReferenceSource[] GetCodeReferencesForTypeFieldsFromInRange(
			ReferenceSource source,
			ulong length
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetCodeReferencesForTypeFieldsFromInRange(
					this.handle ,
					source.ToNative(),
					length,
					out ulong arrayLength 
				);
				
				return UnsafeUtils.TakeStructArrayEx<BNTypeReferenceSource , TypeReferenceSource>(
					arrayPointer ,
					arrayLength ,
					TypeReferenceSource.FromNative ,
					NativeMethods.BNFreeTypeReferences
				);
			}
		}

	
		public void AddUserDataReference(ulong from  , ulong to)
		{
			NativeMethods.BNAddUserDataReference(this.handle ,from ,to);
		}
		
		public void RemoveDataReference(ulong from  , ulong to)
		{
			NativeMethods.BNRemoveDataReference(this.handle ,from ,to);
		}
		
		public void RemoveUserDataReference(ulong from  , ulong to)
		{
			NativeMethods.BNRemoveUserDataReference(this.handle ,from ,to);
		}
		
		public ulong[] GetAllFieldsReferenced(QualifiedName type)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetAllFieldsReferenced(
					this.handle ,
					type.ToNativeEx(allocator) ,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeNumberArray<ulong>(
					arrayPointer ,
					arrayLength ,
					NativeMethods.BNFreeDataReferences
				);
			}
		}
		
		public TypeFieldReferenceSizeInfo[] GetAllSizesReferenced(QualifiedName type)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetAllSizesReferenced(
					this.handle ,
					type.ToNativeEx(allocator) ,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeStructArrayEx<BNTypeFieldReferenceSizeInfo,TypeFieldReferenceSizeInfo>(
					arrayPointer ,
					arrayLength ,
					TypeFieldReferenceSizeInfo.FromNative,
					NativeMethods.BNFreeTypeFieldReferenceSizeInfo
				);
			}
		}
		
		public TypeFieldReferenceTypeInfo[] GetAllTypesReferenced(QualifiedName type)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetAllTypesReferenced(
					this.handle ,
					type.ToNativeEx(allocator) ,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeStructArrayEx<BNTypeFieldReferenceTypeInfo,TypeFieldReferenceTypeInfo>(
					arrayPointer ,
					arrayLength ,
					TypeFieldReferenceTypeInfo.FromNative,
					NativeMethods.BNFreeTypeFieldReferenceTypeInfo
				);
			}
		}
		
		public ulong[] GetSizesReferenced(QualifiedName type , ulong offset)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetSizesReferenced(
					this.handle ,
					type.ToNativeEx(allocator) ,
					offset,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeNumberArrayEx<ulong>(
					arrayPointer ,
					arrayLength ,
					NativeMethods.BNFreeTypeFieldReferenceSizes
				);
			}
		}
		
		public TypeWithConfidence[] GetTypesReferenced(QualifiedName type , ulong offset)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetTypesReferenced(
					this.handle ,
					type.ToNativeEx(allocator) ,
					offset,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeStructArrayEx<BNTypeWithConfidence,TypeWithConfidence>(
					arrayPointer ,
					arrayLength ,
					TypeWithConfidence.FromNative,
					NativeMethods.BNFreeTypeFieldReferenceTypes
				);
			}
		}
		
		public QualifiedName[] GetOutgoingDirectTypeReferences(QualifiedName type)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetOutgoingDirectTypeReferences(
					this.handle ,
					type.ToNativeEx(allocator) ,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeStructArrayEx<BNQualifiedName,QualifiedName>(
					arrayPointer ,
					arrayLength ,
					QualifiedName.FromNative,
					NativeMethods.BNFreeTypeNameList
				);
			}
		}
		
		public QualifiedName[] GetOutgoingRecursiveTypeReferences(QualifiedName[] types)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetOutgoingRecursiveTypeReferences(
					this.handle ,
					allocator.ConvertToNativeArrayEx<BNQualifiedName,QualifiedName>(
						types),
					(ulong)types.Length,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeStructArrayEx<BNQualifiedName,QualifiedName>(
					arrayPointer ,
					arrayLength ,
					QualifiedName.FromNative,
					NativeMethods.BNFreeTypeNameList
				);
			}
		}
		
		public QualifiedName[] GetIncomingDirectTypeReferences(QualifiedName type)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetIncomingDirectTypeReferences(
					this.handle ,
					type.ToNativeEx(allocator) ,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeStructArrayEx<BNQualifiedName,QualifiedName>(
					arrayPointer ,
					arrayLength ,
					QualifiedName.FromNative,
					NativeMethods.BNFreeTypeNameList
				);
			}
		}
		
		public QualifiedName[] GetIncomingRecursiveTypeReferences(QualifiedName[] types)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetIncomingRecursiveTypeReferences(
					this.handle ,
					allocator.ConvertToNativeArrayEx<BNQualifiedName,QualifiedName>(
						types),
					(ulong)types.Length,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeStructArrayEx<BNQualifiedName,QualifiedName>(
					arrayPointer ,
					arrayLength ,
					QualifiedName.FromNative,
					NativeMethods.BNFreeTypeNameList
				);
			}
		}

		public Structure CreateStructureFromOffsetAccess(QualifiedName name , out bool newMember)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return Structure.MustTakeHandle(
					NativeMethods.BNCreateStructureFromOffsetAccess(
						this.handle,
						name.ToNativeEx(allocator) ,
						out newMember
					)
				);
			}
		}
		
		public TypeWithConfidence CreateStructureMemberFromAccess(QualifiedName name , ulong offset)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return TypeWithConfidence.FromNative(
					NativeMethods.BNCreateStructureMemberFromAccess(
						this.handle,
						name.ToNativeEx(allocator) ,
						offset
					)
				);
			}
		}

		public void AddExpressionParserMagicValue(string name , ulong value)
		{
			NativeMethods.BNAddExpressionParserMagicValue(this.handle , name , value);
		}
		
		public void RemoveExpressionParserMagicValue(string name )
		{
			NativeMethods.BNRemoveExpressionParserMagicValue(this.handle , name );
		}
		
		public void AddExpressionParserMagicValues(IDictionary<string,ulong> items)
		{
			NativeMethods.BNAddExpressionParserMagicValues(
				this.handle ,
				items.Keys.ToArray() , 
				items.Values.ToArray(),
				(ulong)items.Count
			);
		}
		
		public void RemoveExpressionParserMagicValues(string[] names)
		{
			NativeMethods.BNRemoveExpressionParserMagicValues(
				this.handle ,
				names,
				(ulong)names.Length
			);
		}

		public bool GetExpressionParserMagicValue(string name , out ulong value)
		{
			return NativeMethods.BNGetExpressionParserMagicValue(
				this.handle ,
				name ,
				out value
			);
		}
		
		
		public ReferenceSource[] GetCallers(ulong callee)
		{
			IntPtr arrayPointer = NativeMethods.BNGetCallers(
				this.handle ,
				callee ,
				out ulong arrayLength 
			);

			return UnsafeUtils.TakeStructArrayEx<BNReferenceSource , ReferenceSource>(
				arrayPointer ,
				arrayLength ,
				ReferenceSource.FromNative ,
				NativeMethods.BNFreeCodeReferences
			);
		}
		
		public ulong[] GetCallees(ReferenceSource callSite)
		{
			IntPtr arrayPointer = NativeMethods.BNGetCallees(
				this.handle ,
				callSite.ToNative() ,
				out ulong arrayLength 
			);

			return UnsafeUtils.TakeNumberArray<ulong>(
				arrayPointer ,
				arrayLength ,
				NativeMethods.BNFreeAddressList
			);
		}

		public Symbol? GetSymbolByAddress(ulong address , NameSpace? ns = null)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return Symbol.TakeHandle(
					NativeMethods.BNGetSymbolByAddress(
						this.handle ,
						address ,
						null == ns
							? IntPtr.Zero
							: allocator.AllocStruct<BNNameSpace>(
								ns.ToNativeEx(allocator)
							)
					)
				);
			}
		}
		
		public Symbol[] GetSymbolsByRawName(string name, NameSpace? ns = null)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetSymbolsByRawName(
					this.handle ,
					name ,
					out ulong arrayLength ,
					null == ns
						? IntPtr.Zero
						: allocator.AllocStruct<BNNameSpace>(
							ns.ToNativeEx(allocator)
						)
				);

				return UnsafeUtils.TakeHandleArrayEx<Symbol>(
					arrayPointer ,
					arrayLength ,
					Symbol.MustNewFromHandle ,
					NativeMethods.BNFreeSymbolList
				);
			}
		}
		
		public Symbol? GetSymbolByRawName(string name, NameSpace? ns = null)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return Symbol.TakeHandle(
					NativeMethods.BNGetSymbolByRawName(
						this.handle ,
						name ,
						null == ns
							? IntPtr.Zero
							: allocator.AllocStruct<BNNameSpace>(
								ns.ToNativeEx(allocator)
							)
					)
				);
			}
		}
		
		public Symbol[] GetSymbolsByName(string name, NameSpace? ns = null)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetSymbolsByName(
					this.handle ,
					name ,
					out ulong arrayLength ,
					null == ns
						? IntPtr.Zero
						: allocator.AllocStruct<BNNameSpace>(
							ns.ToNativeEx(allocator)
						)
				);

				return UnsafeUtils.TakeHandleArrayEx<Symbol>(
					arrayPointer ,
					arrayLength ,
					Symbol.MustNewFromHandle ,
					NativeMethods.BNFreeSymbolList
				);
			}
		}

		public Symbol[] GetSymbols(NameSpace? ns = null)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetSymbols(
					this.handle ,
					out ulong arrayLength ,
					null == ns
						? IntPtr.Zero
						: allocator.AllocStruct<BNNameSpace>(
							ns.ToNativeEx(allocator)
						)
				);

				return UnsafeUtils.TakeHandleArrayEx<Symbol>(
					arrayPointer ,
					arrayLength ,
					Symbol.MustNewFromHandle ,
					NativeMethods.BNFreeSymbolList
				);
			}
		}

		
		public Symbol[] Symbols
		{
			get
			{
				return this.GetSymbols(null);
			}
		}
		
		public string[] SymbolNames
		{
			get
			{
				List<string> items = new List<string>();

				foreach (Symbol symbol in this.Symbols)
				{
					if (!items.Contains(symbol.RawName))
					{
						items.Add(symbol.RawName);
					}
				}

				return items.ToArray();
			}
		}
		
		public string[] SymbolFullNames
		{
			get
			{
				List<string> items = new List<string>();

				foreach (Symbol symbol in this.Symbols)
				{
					if (!items.Contains(symbol.FullName))
					{
						items.Add(symbol.FullName);
					}
				}

				return items.ToArray();
			}
		}
		
		public Symbol[] GetSymbolsInRange(
			ulong start ,
			ulong length,
			NameSpace? ns = null)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetSymbolsInRange(
					this.handle ,
					start,
					length,
					out ulong arrayLength ,
					null == ns
						? IntPtr.Zero
						: allocator.AllocStruct<BNNameSpace>(
							ns.ToNativeEx(allocator)
						)
				);

				return UnsafeUtils.TakeHandleArrayEx<Symbol>(
					arrayPointer ,
					arrayLength ,
					Symbol.MustNewFromHandle ,
					NativeMethods.BNFreeSymbolList
				);
			}
		}
		
		
		public Symbol[] GetSymbolsOfType(
			SymbolType type,
			NameSpace? ns = null)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetSymbolsOfType(
					this.handle ,
					type,
					out ulong arrayLength ,
					null == ns
						? IntPtr.Zero
						: allocator.AllocStruct<BNNameSpace>(
							ns.ToNativeEx(allocator)
						)
				);

				return UnsafeUtils.TakeHandleArrayEx<Symbol>(
					arrayPointer ,
					arrayLength ,
					Symbol.MustNewFromHandle ,
					NativeMethods.BNFreeSymbolList
				);
			}
		}
		
		public Symbol[] GetSymbolsOfTypeInRange(
			SymbolType type,
			ulong start ,
			ulong length,
			NameSpace? ns = null)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr arrayPointer = NativeMethods.BNGetSymbolsOfTypeInRange(
					this.handle ,
					type,
					start,
					length,
					out ulong arrayLength ,
					null == ns
						? IntPtr.Zero
						: allocator.AllocStruct<BNNameSpace>(
							ns.ToNativeEx(allocator)
						)
				);

				return UnsafeUtils.TakeHandleArrayEx<Symbol>(
					arrayPointer ,
					arrayLength ,
					Symbol.MustNewFromHandle ,
					NativeMethods.BNFreeSymbolList
				);
			}
		}

		public void DefineAutoSymbol(Symbol symbol)
		{
			NativeMethods.BNDefineAutoSymbol(this.handle , symbol.DangerousGetHandle());
		}
		
		public Symbol? DefineAutoSymbolAndVariableOrFunction(
			Symbol symbol,
			Platform? platform = null,
			TypeWithConfidence? type = null
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return Symbol.TakeHandle(
					NativeMethods.BNDefineAutoSymbolAndVariableOrFunction(
						this.handle ,
						symbol.DangerousGetHandle(),
						symbol.DangerousGetHandle(),
						null == type ? IntPtr.Zero : 
							allocator.AllocStruct<BNTypeWithConfidence>( type.ToNative() )
					)
				);
			}
		}
		
		public void UndefineAutoSymbol(Symbol symbol)
		{
			NativeMethods.BNUndefineAutoSymbol(this.handle , symbol.DangerousGetHandle());
		}
		
		public void DefineUserSymbol(Symbol symbol)
		{
			NativeMethods.BNDefineUserSymbol(this.handle , symbol.DangerousGetHandle());
		}
		
		public void UndefineUserSymbol(Symbol symbol)
		{
			NativeMethods.BNUndefineUserSymbol(this.handle , symbol.DangerousGetHandle());
		}
		
		public void DefineImportedFunction(
			Symbol symbol,
			Function function,
			BinaryNinja.Type? type
	    )
		{
			NativeMethods.BNDefineImportedFunction(
				this.handle , 
				symbol.DangerousGetHandle(),
				function.DangerousGetHandle(),
				null == type ? IntPtr.Zero :  type.DangerousGetHandle()
			);
		}

		public void BeginBulkModifySymbols()
		{
			NativeMethods.BNBeginBulkModifySymbols(this.handle );
		}
		
		public void EndBulkModifySymbols()
		{
			NativeMethods.BNEndBulkModifySymbols(this.handle );
		}

		public TagType CreateTagType()
		{
			return TagType.MustTakeHandle(
				NativeMethods.BNCreateTagType(this.handle)
			);
		}

		public void AddTagType(TagType tagType)
		{
			NativeMethods.BNAddTagType(this.handle , tagType.DangerousGetHandle());
		}

		public void RemoveTag(Tag tag , bool user)
		{
			NativeMethods.BNRemoveTag(this.handle , tag.DangerousGetHandle() , user);
		}
		
		public void RemoveTagType(TagType tagType)
		{
			NativeMethods.BNRemoveTagType(this.handle , tagType.DangerousGetHandle());
		}

		public TagType[] TagTypes
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetTagTypes(
					this.handle,
					out ulong arrayLength 
				);

				return UnsafeUtils.TakeHandleArrayEx<TagType>(
					arrayPointer , 
					arrayLength,
					TagType.MustNewFromHandle,
					NativeMethods.BNFreeTagTypeList
				);
			}
		}

		public TagType? GetTagType(string name)
		{
			return TagType.TakeHandle(
				NativeMethods.BNGetTagType(this.handle , name )
			);
		}
		
		public TagType? GetTagTypeById(string name)
		{
			return TagType.TakeHandle(
				NativeMethods.BNGetTagTypeById(this.handle , name )
			);
		}
		
		public void AddTag(Tag tag , bool user)
		{
			NativeMethods.BNAddTag(this.handle , tag.DangerousGetHandle() , user);
		}

		public void AddUserDataTag(ulong address ,  Tag tag )
		{
			NativeMethods.BNAddUserDataTag(
				this.handle ,
				address , tag.DangerousGetHandle());
		}

		public TagReference[] TagReferences
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetAllTagReferences(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNTagReference , TagReference>(
					arrayPointer ,
					arrayLength ,
					TagReference.FromNative ,
					NativeMethods.BNFreeTagReferences
				);
			}
		}

		public TagReference[] AddressTagReferences
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetAllAddressTagReferences(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNTagReference , TagReference>(
					arrayPointer ,
					arrayLength ,
					TagReference.FromNative ,
					NativeMethods.BNFreeTagReferences
				);
			}
		}
		
		public TagReference[] FunctionTagReferences
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetAllFunctionTagReferences(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNTagReference , TagReference>(
					arrayPointer ,
					arrayLength ,
					TagReference.FromNative ,
					NativeMethods.BNFreeTagReferences
				);
			}
		}
		
		public TagReference[] DataTagReferences
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetDataTagReferences(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNTagReference , TagReference>(
					arrayPointer ,
					arrayLength ,
					TagReference.FromNative ,
					NativeMethods.BNFreeTagReferences
				);
			}
		}
		
		public TagReference[] AutoDataTagReferences
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetAutoDataTagReferences(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNTagReference , TagReference>(
					arrayPointer ,
					arrayLength ,
					TagReference.FromNative ,
					NativeMethods.BNFreeTagReferences
				);
			}
		}
		
		public TagReference[] UserDataTagReferences
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetUserDataTagReferences(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNTagReference , TagReference>(
					arrayPointer ,
					arrayLength ,
					TagReference.FromNative ,
					NativeMethods.BNFreeTagReferences
				);
			}
		}
		
		
		
		public Tag[] GetDataTags(ulong address)
		{
			IntPtr arrayPointer = NativeMethods.BNGetDataTags(
				this.handle ,
				address,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArrayEx<Tag>(
				arrayPointer ,
				arrayLength ,
				Tag.MustNewFromHandle ,
				NativeMethods.BNFreeTagList
			);
		}
		
		public Tag[] GetAutoDataTags(ulong address)
		{
			IntPtr arrayPointer = NativeMethods.BNGetAutoDataTags(
				this.handle ,
				address,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArrayEx<Tag>(
				arrayPointer ,
				arrayLength ,
				Tag.MustNewFromHandle ,
				NativeMethods.BNFreeTagList
			);
		}
		
		public Tag[] GetUserDataTags(ulong address)
		{
			IntPtr arrayPointer = NativeMethods.BNGetUserDataTags(
				this.handle ,
				address,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArrayEx<Tag>(
				arrayPointer ,
				arrayLength ,
				Tag.MustNewFromHandle ,
				NativeMethods.BNFreeTagList
			);
		}
		
		
		public TagReference[] GetDataTagsInRange(ulong start , ulong end)
		{
			IntPtr arrayPointer = NativeMethods.BNGetDataTagsInRange(
				this.handle ,
				start,
				end,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeStructArrayEx<BNTagReference,TagReference>(
				arrayPointer ,
				arrayLength ,
				TagReference.FromNative ,
				NativeMethods.BNFreeTagReferences
			);
		}
		
		public TagReference[] GetAutoDataTagsInRange(ulong start , ulong end)
		{
			IntPtr arrayPointer = NativeMethods.BNGetAutoDataTagsInRange(
				this.handle ,
				start,
				end,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeStructArrayEx<BNTagReference,TagReference>(
				arrayPointer ,
				arrayLength ,
				TagReference.FromNative ,
				NativeMethods.BNFreeTagReferences
			);
		}
		
		public TagReference[] GetUserDataTagsInRange(ulong start , ulong end)
		{
			IntPtr arrayPointer = NativeMethods.BNGetUserDataTagsInRange(
				this.handle ,
				start,
				end,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeStructArrayEx<BNTagReference,TagReference>(
				arrayPointer ,
				arrayLength ,
				TagReference.FromNative ,
				NativeMethods.BNFreeTagReferences
			);
		}

		public void RemoveUserDataTag(ulong address , Tag tag)
		{
			NativeMethods.BNRemoveUserDataTag(
				this.handle , 
				address ,
				tag.DangerousGetHandle()
			);
		}
		
		public void RemoveUserDataTagsOfType(ulong address , TagType tagType)
		{
			NativeMethods.BNRemoveUserDataTagsOfType(
				this.handle , 
				address ,
				tagType.DangerousGetHandle()
			);
		}
		
		
		public void RemoveAutoDataTag(ulong address , Tag tag)
		{
			NativeMethods.BNRemoveAutoDataTag(
				this.handle , 
				address ,
				tag.DangerousGetHandle()
			);
		}

		public void RemoveAutoDataTagsOfType(ulong address , TagType tagType)
		{
			NativeMethods.BNRemoveAutoDataTagsOfType(
				this.handle , 
				address ,
				tagType.DangerousGetHandle()
			);
		}

		public string CheckForStringAnnotationType(
		
			ulong address  , 
			
			out StringType strType  , 
			
			bool allowShortStrings  , 
			
			bool allowLargeStrings  , 
			
			ulong childWidth  
		)
		{
			bool ok = NativeMethods.BNCheckForStringAnnotationType(
				this.handle ,
				address ,
				out IntPtr textPointer ,
				out strType ,
				allowShortStrings ,
				allowLargeStrings ,
				childWidth
			);

			if (!ok)
			{
				return string.Empty;
			}

			return UnsafeUtils.TakeUtf8String(textPointer);
		}

		public bool CanAssemble(Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			return NativeMethods.BNCanAssemble(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle()
			);
		}
		
		public bool IsNeverBranchPatchAvailable(ulong address , Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			return NativeMethods.BNIsNeverBranchPatchAvailable(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				address
			);
		} 
		
		public bool IsAlwaysBranchPatchAvailable(ulong address , Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			return NativeMethods.BNIsAlwaysBranchPatchAvailable(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				address
			);
		} 
		
		public bool IsInvertBranchPatchAvailable(ulong address , Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			return NativeMethods.BNIsInvertBranchPatchAvailable(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				address
			);
		} 
		
		public bool IsSkipAndReturnZeroPatchAvailable(ulong address , Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			return NativeMethods.BNIsSkipAndReturnZeroPatchAvailable(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				address
			);
		} 
		
		public bool IsSkipAndReturnValuePatchAvailable(ulong address , Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			return NativeMethods.BNIsSkipAndReturnValuePatchAvailable(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				address
			);
		} 
		
		public bool ConvertToNop(ulong address , Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			
			return NativeMethods.BNConvertToNop(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				address
			);
		} 
		
		public bool AlwaysBranch(ulong address , Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			
			return NativeMethods.BNAlwaysBranch(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				address
			);
		} 
		
		public bool InvertBranch(ulong address , Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			
			return NativeMethods.BNInvertBranch(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				address
			);
		} 
		
		public bool SkipAndReturnValue(
			ulong address ,
			ulong value = 0,
			Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			
			return NativeMethods.BNSkipAndReturnValue(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				address,
				value
			);
		}

		public ulong GetInstructionLength(ulong address , Architecture? arch = null)
		{
			if (null == arch)
			{
				arch = this.DefaultArchitecture;
			}

			return NativeMethods.BNGetInstructionLength(
				this.handle ,
				null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				address
			);
		}
		
		public void NotifyDataWritten(ulong offset , ulong length)
		{
			NativeMethods.BNNotifyDataWritten(
				this.handle ,
				offset,
				length
			);
		}
		
		public void NotifyDataInserted(ulong offset , ulong length)
		{
			NativeMethods.BNNotifyDataInserted(
				this.handle ,
				offset,
				length
			);
		}
		
		public void NotifyDataRemoved(ulong offset , ulong length)
		{
			NativeMethods.BNNotifyDataRemoved(
				this.handle ,
				offset,
				length
			);
		}

		public Component? GetComponentByGuid( string guid)
		{
			return Component.TakeHandle(
				NativeMethods.BNGetComponentByGuid(this.handle , guid)
			);
		}
		
		public Component? GetComponentByPath( string path)
		{
			return Component.TakeHandle(
				NativeMethods.BNGetComponentByPath(this.handle , path)
			);
		}

		public Component RootComponent
		{
			get
			{
				return Component.MustTakeHandle(
					NativeMethods.BNGetRootComponent(this.handle )
				);
			}
		}

		public Component CreateComponent()
		{
			return Component.MustTakeHandle(
				NativeMethods.BNCreateComponent(
					this.handle 
				)
			);
		}
		
		public Component CreateComponentWithParent(string parentGUID)
		{
			return Component.MustTakeHandle(
				NativeMethods.BNCreateComponentWithParent(
					this.handle ,
					parentGUID 
				)
			);
		}
		
		public Component CreateComponentWithName( string name)
		{
			return Component.MustTakeHandle(
				NativeMethods.BNCreateComponentWithName(
					this.handle ,
					name
				)
			);
		}
		
		public Component CreateComponentWithParentAndName(string parentGUID , string name)
		{
			return Component.MustTakeHandle(
				NativeMethods.BNCreateComponentWithParentAndName(
					this.handle ,
					parentGUID ,
					name
				)
			);
		}

		public bool RemoveComponent(Component component)
		{
			return NativeMethods.BNRemoveComponent(
				this.handle ,
				component.DangerousGetHandle()
			);
		}
		
		public bool RemoveComponentByGuid(string guid)
		{
			return NativeMethods.BNRemoveComponentByGuid(
				this.handle ,
				guid
			);
		}

		public Component[] GetFunctionParentComponents(Function function)
		{
			IntPtr arrayPointer = NativeMethods.BNGetFunctionParentComponents(
				this.handle ,
				function.DangerousGetHandle() ,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArrayEx<Component>(
				arrayPointer ,
				arrayLength,
				Component.MustNewFromHandle,
				NativeMethods.BNFreeComponents
			);
		}
		
		public Component[] GetDataVariableParentComponents(ulong dataVariable)
		{
			IntPtr arrayPointer = NativeMethods.BNGetDataVariableParentComponents(
				this.handle ,
				dataVariable,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArrayEx<Component>(
				arrayPointer ,
				arrayLength,
				Component.MustNewFromHandle,
				NativeMethods.BNFreeComponents
			);
		}

		public StringReference[] StringReferences
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetStrings(
					this.handle ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArray<BNStringReference , StringReference>(
					arrayPointer ,
					arrayLength ,
					StringReference.FromNative ,
					NativeMethods.BNFreeStringReferenceList
				);
			}
		}
		
		public StringReference[] GetStringsInRange(ulong start , ulong length)
		{
			IntPtr arrayPointer = NativeMethods.BNGetStringsInRange(
				this.handle ,
				start,
				length,
				out ulong arrayLength
			);

			return UnsafeUtils.TakeStructArray<BNStringReference , StringReference>(
				arrayPointer ,
				arrayLength ,
				StringReference.FromNative ,
				NativeMethods.BNFreeStringReferenceList
			);
		}
		
		public StringReference? GetStringAtAddress(ulong address)
		{
			bool ok = NativeMethods.BNGetStringAtAddress(
				this.handle ,
				address,
				out BNStringReference strRef
			);

			if (!ok)
			{
				return null;
			}
			
			return StringReference.FromNative(strRef);
		}

		public ulong GetNextFunctionStartAfterAddress(ulong address)
		{
			return NativeMethods.BNGetNextFunctionStartAfterAddress(this.handle , address);
		}
		
		public ulong GetNextBasicBlockStartAfterAddress(ulong address)
		{
			return NativeMethods.BNGetNextBasicBlockStartAfterAddress(this.handle , address);
		}
		
		public ulong GetNextDataAfterAddress(ulong address)
		{
			return NativeMethods.BNGetNextDataAfterAddress(this.handle , address);
		}
		
		public ulong GetNextDataVariableStartAfterAddress(ulong address)
		{
			return NativeMethods.BNGetNextDataVariableStartAfterAddress(this.handle , address);
		}
		
		public DataVariable? GetNextDataVariableAfterAddress(ulong address)
		{
			while (address < this.End)
			{
				ulong dataVariableStart = this.GetNextDataVariableStartAfterAddress(address);

				if (dataVariableStart == this.End)
				{
					return null;
				}

				DataVariable? variable = this.GetDataVariableAtAddress(dataVariableStart);

				if (null != variable)
				{
					if (variable.Address < dataVariableStart)
					{
						address = variable.Address + variable.Type.Width;
						continue;
					}
					
					return variable;
				}
				else
				{
					return null;
				}
			}

			return null;
		}
		
		public ulong GetPreviousFunctionStartBeforeAddress(ulong address)
		{
			return NativeMethods.BNGetPreviousFunctionStartBeforeAddress(this.handle , address);
		}
		
		public ulong GetPreviousBasicBlockStartBeforeAddress(ulong address)
		{
			return NativeMethods.BNGetPreviousBasicBlockStartBeforeAddress(this.handle , address);
		}
		
		public ulong GetPreviousBasicBlockEndBeforeAddress(ulong address)
		{
			return NativeMethods.BNGetPreviousBasicBlockEndBeforeAddress(this.handle , address);
		}
		
		public ulong GetPreviousDataBeforeAddress(ulong address)
		{
			return NativeMethods.BNGetPreviousDataBeforeAddress(this.handle , address);
		}

		
		public ulong GetPreviousDataVariableStartBeforeAddress(ulong address)
		{
			return NativeMethods.BNGetPreviousDataVariableStartBeforeAddress(this.handle , address);
		}
		
		public DataVariable? GetPreviousDataVariableBeforeAddress(ulong address)
		{
			ulong dataVariableStart = this.GetNextDataVariableStartAfterAddress(address);

			if (dataVariableStart == this.Start)
			{
				return null;
			}

			return this.GetDataVariableAtAddress(dataVariableStart);
		}

		public QualifiedNameAndType? ParseTypeString(
			string text ,
			QualifiedName[]? typesAllowRedefinition = null,
			bool importDepencencies = true
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				bool ok = NativeMethods.BNParseTypeString(
					this.handle , 
					text,
					out BNQualifiedNameAndType result,
					out IntPtr errorPointer,
					new QualifiedNameList(typesAllowRedefinition).ToNativeEx(allocator),
					importDepencencies
				);

				if (!ok)
				{
					string errors = UnsafeUtils.TakeAnsiString(errorPointer);

					if (!string.IsNullOrEmpty(errors))
					{
						throw new Exception(errors);
					}		
					
					return null;
				}
				
				return QualifiedNameAndType.TakeNative(result);
			}
		}
		
		public TypeParserResult? ParseTypesString(
			string text ,
			string[] options,
			string[] includeDirs,
			QualifiedName[]? typesAllowRedefinition = null,
			bool importDepencencies = true
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				bool ok = NativeMethods.BNParseTypesString(
					this.handle , 
					text,
					options,
					(ulong)options.Length,
					includeDirs,
					(ulong)includeDirs.Length,
					out BNTypeParserResult result,
					out IntPtr errorPointer,
					new QualifiedNameList(typesAllowRedefinition).ToNativeEx(allocator),
					importDepencencies
				);

				if (!ok)
				{
					string errors = UnsafeUtils.TakeAnsiString(errorPointer);

					if (!string.IsNullOrEmpty(errors))
					{
						throw new Exception(errors);
					}		
					
					return null;
				}
				
				return TypeParserResult.TakeNative(result);
			}
		}

		public PossibleValueSet? ParsePossibleValueSet(
			string text,
			RegisterValueType state,
			ulong here
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				bool ok = NativeMethods.BNParsePossibleValueSet(
					this.handle , 
					text,
					state,
					out BNPossibleValueSet result,
					here,
					out IntPtr errorPointer
				);

				if (!ok)
				{
					string errors = UnsafeUtils.TakeAnsiString(errorPointer);

					if (!string.IsNullOrEmpty(errors))
					{
						throw new Exception(errors);
					}		
					
					return null;
				}
				
				return PossibleValueSet.TakeNative(result);
			}
		}

		public TypeContainer TypeContainer
		{
			get
			{
				return TypeContainer.MustTakeHandle(
					NativeMethods.BNGetAnalysisTypeContainer(this.handle)
				);
			}
		}
		
		public TypeContainer AutoTypeContainer
		{
			get
			{
				return TypeContainer.MustTakeHandle(
					NativeMethods.BNGetAnalysisAutoTypeContainer(this.handle)
				);
			}
		}
		
		public TypeContainer UserTypeContainer
		{
			get
			{
				return TypeContainer.MustTakeHandle(
					NativeMethods.BNGetAnalysisUserTypeContainer(this.handle)
				);
			}
		}

		public BinaryNinja.Type? GetTypeByName(QualifiedName name)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return BinaryNinja.Type.TakeHandle(

					NativeMethods.BNGetAnalysisTypeByName(
						this.handle ,
						name.ToNativeEx(allocator)
					)
				);
			}
		}
		
		public BinaryNinja.Type? GetTypeById(string id)
		{
			return BinaryNinja.Type.TakeHandle(

				NativeMethods.BNGetAnalysisTypeById(
					this.handle ,
					id
				)
			);
		}
		
		public QualifiedName GetTypeNameById(string id)
		{
			return QualifiedName.TakeNative(

				NativeMethods.BNGetAnalysisTypeNameById(
					this.handle ,
					id
				)
			);
		}
		
		public string GetTypeId(QualifiedName name)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return UnsafeUtils.TakeAnsiString(

					NativeMethods.BNGetAnalysisTypeId(
						this.handle ,
						name.ToNativeEx(allocator)
					)
				);
			}
		}

		public void AddTypeLibrary(TypeLibrary library)
		{
			NativeMethods.BNAddBinaryViewTypeLibrary(
				this.handle, 
				library.DangerousGetHandle()
			);
		}

		public TypeLibrary? GetTypeLibrary(string name)
		{
			return TypeLibrary.TakeHandle(
				NativeMethods.BNGetBinaryViewTypeLibrary(
					this.handle ,
					name
				)
			);
		}
		
		public bool IsTypeAutoDefined(QualifiedName name)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return NativeMethods.BNIsAnalysisTypeAutoDefined(
					this.handle ,
					name.ToNativeEx(allocator)
				);
			}
		}

		public QualifiedName DefineType(
			string typeId ,
			QualifiedName defaultName,
			BinaryNinja.Type type
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return QualifiedName.TakeNative(

					NativeMethods.BNDefineAnalysisType(
						this.handle ,
						typeId,
						defaultName.ToNativeEx(allocator),
						type.DangerousGetHandle()
					)
				);
			}
		}
		
		public void DefineUserType(
			QualifiedName name ,
			BinaryNinja.Type type
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				NativeMethods.BNDefineUserAnalysisType(
					this.handle ,
					name.ToNativeEx(allocator),
					type.DangerousGetHandle()
				);
			}
		}
		
		public QualifiedNameAndId[] DefineTypes(
			QualifiedNameTypeAndId[] types,
			ProgressDelegate? progress = null
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				ulong arrayLength = NativeMethods.BNDefineAnalysisTypes(
					this.handle ,
					allocator.ConvertToNativeArrayEx<BNQualifiedNameTypeAndId,QualifiedNameTypeAndId>(types),
					(ulong)types.Length,
					null == progress ? IntPtr.Zero : 
						Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
							UnsafeUtils.WrapProgressDelegate(progress)
							) ,
					IntPtr.Zero, 
					out IntPtr idsPointer,
					out IntPtr namesPointer
				);

				string[] ids = UnsafeUtils.TakeStringArrayEx(
					idsPointer , 
					arrayLength);
				
				QualifiedName[] names = UnsafeUtils.TakeStructArrayEx<BNQualifiedName,QualifiedName>(
					namesPointer ,
					arrayLength,
					QualifiedName.FromNative,
					NativeMethods.BNFreeTypeNameList
				);
				
				List<QualifiedNameAndId> targets = new List<QualifiedNameAndId>();

				for (ulong i = 0; i < arrayLength; i++)
				{
					targets.Add(
						new QualifiedNameAndId(
							names[i],
							ids[i]
						)
					);
				}

				return targets.ToArray();
			}
		}
		
		public void DefineUserTypes(
			QualifiedNameAndType[] types,
			ProgressDelegate? progress = null
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				NativeMethods.BNDefineUserAnalysisTypes(
					this.handle ,
					allocator.ConvertToNativeArrayEx<BNQualifiedNameAndType,QualifiedNameAndType>(types),
					(ulong)types.Length,
					null == progress ? IntPtr.Zero : 
						Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
							UnsafeUtils.WrapProgressDelegate(progress)
							) ,
					IntPtr.Zero
				);
			}
		}

		public void UndefineType(string typeId)
		{
			NativeMethods.BNUndefineAnalysisType(this.handle , typeId);
		}
		
		public void UndefineUserType(QualifiedName name)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				NativeMethods.BNUndefineUserAnalysisType(
					this.handle , 
					name.ToNativeEx(allocator)
				);
			}
		}
		
		public void RenameType(QualifiedName oldName , QualifiedName newName)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				NativeMethods.BNRenameAnalysisType(
					this.handle , 
					oldName.ToNativeEx(allocator),
					newName.ToNativeEx(allocator)
				);
			}
		}

		public BinaryNinja.Type? GetSystemCallType(uint id , Platform? platform = null)
		{
			if (null == platform)
			{
				platform = this.DefaultPlatform;
			}

			return BinaryNinja.Type.TakeHandle(

				NativeMethods.BNGetAnalysisSystemCallType(
					this.handle ,
					null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
					id
				)
			);
		}
		
		public string GetSystemCallName(uint id , Platform? platform = null)
		{
			if (null == platform)
			{
				platform = this.DefaultPlatform;
			}

			return UnsafeUtils.TakeAnsiString(

				NativeMethods.BNGetAnalysisSystemCallName(
					this.handle ,
					null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
					id
				)
			);
		}

		public BinaryNinja.Type? ImportTypeLibraryType(QualifiedName name , TypeLibrary? library = null)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return BinaryNinja.Type.TakeHandle(

					NativeMethods.BNBinaryViewImportTypeLibraryType(
						this.handle ,
						null == library ? IntPtr.Zero : library.DangerousGetHandle() ,
						name.ToNativeEx(allocator)
					)
				);
			}
		}
		
		public BinaryNinja.Type? ImportTypeLibraryTypeByGuid(string guid )
		{
			return BinaryNinja.Type.TakeHandle(

				NativeMethods.BNBinaryViewImportTypeLibraryTypeByGuid(
					this.handle ,
					guid
				)
			);
		}
		
		public BinaryNinja.Type? ImportTypeLibraryObject(
			QualifiedName name , 
			TypeLibrary? library 
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				IntPtr libraryHandle = ( null == library ? IntPtr.Zero : library.DangerousGetHandle() );

				IntPtr typeHandle = NativeMethods.BNBinaryViewImportTypeLibraryObject(
					this.handle ,
					ref libraryHandle ,
					name.ToNativeEx(allocator)
				);

				return BinaryNinja.Type.TakeHandle(

					typeHandle
				);
			}
		}
		
		public void ExportTypeToTypeLibrary(
			TypeLibrary library ,
			QualifiedName name , 
			BinaryNinja.Type type
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				NativeMethods.BNBinaryViewExportTypeToTypeLibrary(
					this.handle ,
					library.DangerousGetHandle(), 
					name.ToNativeEx(allocator),
					type.DangerousGetHandle()
				);
			}
		}
		
		public void ExportObjectToTypeLibrar(
			TypeLibrary library ,
			QualifiedName name , 
			BinaryNinja.Type type
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				NativeMethods.BNBinaryViewExportObjectToTypeLibrary(
					this.handle ,
					library.DangerousGetHandle(), 
					name.ToNativeEx(allocator),
					type.DangerousGetHandle()
				);
			}
		}
	
		public void SetManualDependencies(
			TypeLibrary library ,
			QualifiedName[] viewTypeNames,
			QualifiedName[] libTypeNames,
			string[] libNames 
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				NativeMethods.BNBinaryViewSetManualDependencies(
					this.handle,
					allocator.ConvertToNativeArrayEx<BNQualifiedName,QualifiedName>(viewTypeNames),
					allocator.ConvertToNativeArrayEx<BNQualifiedName,QualifiedName>(libTypeNames),
					libNames,
					( ulong )libNames.Length
				);
			}
		}
		
		public void RecordImportedObjectLibrary(
			ulong address,
			TypeLibrary library ,
			QualifiedName name , 
			Platform? platform = null
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				NativeMethods.BNBinaryViewRecordImportedObjectLibrary(
					this.handle ,
					null == platform ? IntPtr.Zero : platform.DangerousGetHandle(),
					address,
					library.DangerousGetHandle(), 
					name.ToNativeEx(allocator)
				);
			}
		}
		
		
		public TypeLibrary? LookupImportedObjectLibrary(
			ulong address,
			out QualifiedName? name,
			Platform? platform = null
		)
		{
			bool ok = NativeMethods.BNBinaryViewLookupImportedObjectLibrary(
				this.handle ,
				null == platform ? IntPtr.Zero : platform.DangerousGetHandle(),
				address,
				out IntPtr libraryHandle,
				out BNQualifiedName rawName
			);

			if (!ok)
			{
				name = null;
				return null;
			}
			
			name = QualifiedName.TakeNative(rawName);
			
			return TypeLibrary.MustTakeHandle(libraryHandle);
		}
		
		public TypeLibrary? LookupImportedTypeLibrary(
			QualifiedName typeName,
			out QualifiedName? libraryName
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				bool ok = NativeMethods.BNBinaryViewLookupImportedTypeLibrary(
					this.handle ,
					typeName.ToNativeEx(allocator),
					out IntPtr libraryHandle,
					out BNQualifiedName rawLibraryName
				);

				if (!ok)
				{
					libraryName = null;
					return null;
				}
			
				libraryName = QualifiedName.TakeNative(rawLibraryName);
			
				return TypeLibrary.MustTakeHandle(libraryHandle);
			}
			
		}

		public TypeArchive? AttachTypeArchive(string id , string path)
		{
			return TypeArchive.TakeHandle(
				NativeMethods.BNBinaryViewAttachTypeArchive(this.handle , id , path)
			);
		}
		
		public bool DetachTypeArchive(string id)
		{
			return NativeMethods.BNBinaryViewDetachTypeArchive(this.handle , id);
		}
		
		public string GetTypeArchivePath(string id)
		{
			return UnsafeUtils.TakeAnsiString(
				NativeMethods.BNBinaryViewGetTypeArchivePath(this.handle , id)
			);
		}

		public void RegisterPlatformTypes(Platform platform)
		{
			NativeMethods.BNRegisterPlatformTypes(this.handle , platform.DangerousGetHandle());
		}

		public Platform? LookupImportedTypePlatform(
			QualifiedName typeName,
			out QualifiedName? resultName
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				bool ok = NativeMethods.BNLookupImportedTypePlatform(
					this.handle ,
					typeName.ToNativeEx(allocator) ,
					out IntPtr platformHandle ,
					out BNQualifiedName rawResultName
				);

				if (!ok)
				{
					resultName = null;
					return null;
				}
				
				resultName = QualifiedName.TakeNative(rawResultName);
				
				return Platform.MustTakeHandle(platformHandle);
			}
		}

		public ulong? FindNextData(
			byte[] data ,
			ulong start = 0 ,
			FindFlag flags = FindFlag.FindCaseSensitive
		)
		{
			bool ok = NativeMethods.BNFindNextData(
				this.handle ,
				start ,
				new DataBuffer(data).DangerousGetHandle() ,
				out ulong result ,
				flags
			);

			if (!ok)
			{
				return null;
			}

			return result;
		}

		public ulong? FindNextDataWithProgress(
			byte[] data ,
			ulong start ,
			ulong end ,
			ProgressDelegate progress ,
			FindFlag flags = FindFlag.FindCaseSensitive
		)
		{
			bool ok = NativeMethods.BNFindNextDataWithProgress(
				this.handle ,
				start ,
				end ,
				new DataBuffer(data).DangerousGetHandle() ,
				out ulong result ,
				flags ,
				IntPtr.Zero ,
				Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
					UnsafeUtils.WrapProgressDelegate(progress)
				)
			);

			if (!ok)
			{
				return null;
			}

			return result;
		}

		public ulong? FindNextText(
			string data ,
			ulong start ,
			FunctionViewType viewType ,
			DisassemblySettings? settings = null ,
			FindFlag flags = FindFlag.FindCaseSensitive
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				bool ok = NativeMethods.BNFindNextText(
					this.handle ,
					start ,
					data ,
					out ulong result ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle() ,
					flags ,
					viewType.ToNativeEx(allocator)
				);

				if (!ok)
				{
					return null;
				}

				return result;
			}
		}

		public ulong? FindNextTextWithProgress(
			string data ,
			ulong start ,
			ulong end ,
			ProgressDelegate progress ,
			FunctionViewType viewType ,
			DisassemblySettings? settings = null ,
			FindFlag flags = FindFlag.FindCaseSensitive
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				bool ok = NativeMethods.BNFindNextTextWithProgress(
					this.handle ,
					start ,
					end ,
					data ,
					out ulong result ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle() ,
					flags ,
					viewType.ToNativeEx(allocator) ,
					IntPtr.Zero ,
					Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
						UnsafeUtils.WrapProgressDelegate(progress)
					)
				);

				if (!ok)
				{
					return null;
				}

				return result;
			}
		}

		public ulong? FindNextConstant(
			ulong start ,
			ulong value ,
			FunctionViewType viewType ,
			DisassemblySettings? settings = null
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				bool ok = NativeMethods.BNFindNextConstant(
					this.handle ,
					start ,
					value ,
					out ulong result ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle() ,
					viewType.ToNativeEx(allocator)
				);

				if (!ok)
				{
					return null;
				}

				return result;
			}
		}

		public ulong? FindNextConstantWithProgress(
			ulong data,
			ulong start,
			ulong end,
			ProgressDelegate progress,
			FunctionViewType viewType,
			DisassemblySettings? settings = null
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				bool ok =  NativeMethods.BNFindNextConstantWithProgress(
					this.handle , 
					start, 
					end,
					data,
					out ulong result,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle(),
					viewType.ToNativeEx(allocator), 
					IntPtr.Zero,
					Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
						UnsafeUtils.WrapProgressDelegate(progress)
					)
				);
			
				if (!ok)
				{
					return null;
				}

				return result;
			}
		}

		public bool FindAllData(
			byte[] data ,
			ulong start ,
			ulong end ,
			MatchDataDelegate match ,
			ProgressDelegate? progress = null ,
			FindFlag flags = FindFlag.FindCaseSensitive
		)
		{
			return NativeMethods.BNFindAllDataWithProgress(
				this.handle ,
				start ,
				end ,
				new DataBuffer(data).DangerousGetHandle() ,
				flags ,
				IntPtr.Zero ,
				null == progress
					? IntPtr.Zero
					: Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
						UnsafeUtils.WrapProgressDelegate(progress)
					) ,
				IntPtr.Zero ,
				Marshal.GetFunctionPointerForDelegate<NativeDelegates.MatchDataDelegate>(
					UnsafeUtils.WrapMatchDataDelegate(match)
				)
			);
		}


		public bool FindAllText(
			string data ,
			ulong start ,
			ulong end ,
			MatchDataDelegate match ,
			FunctionViewType viewType ,
			ProgressDelegate? progress = null ,
			FindFlag flags = FindFlag.FindCaseSensitive ,
			DisassemblySettings? settings = null
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return NativeMethods.BNFindAllTextWithProgress(
					this.handle ,
					start ,
					end ,
					data ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle() ,
					flags ,
					viewType.ToNativeEx(allocator) ,
					IntPtr.Zero ,
					null == progress
						? IntPtr.Zero
						: Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
							UnsafeUtils.WrapProgressDelegate(progress)
						) ,
					IntPtr.Zero ,
					Marshal.GetFunctionPointerForDelegate<NativeDelegates.MatchDataDelegate>(
						UnsafeUtils.WrapMatchDataDelegate(match)
					)
				);
			}
		}

		public bool FindAllConstant(
			ulong data ,
			ulong start ,
			ulong end ,
			MatchDataDelegate match ,
			FunctionViewType viewType ,
			ProgressDelegate? progress = null ,
			DisassemblySettings? settings = null
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return NativeMethods.BNFindAllConstantWithProgress(
					this.handle ,
					start ,
					end ,
					data ,
					null == settings ? IntPtr.Zero : settings.DangerousGetHandle() ,
					viewType.ToNativeEx(allocator) ,
					IntPtr.Zero ,
					null == progress
						? IntPtr.Zero
						: Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
							UnsafeUtils.WrapProgressDelegate(progress)
						) ,
					IntPtr.Zero ,
					Marshal.GetFunctionPointerForDelegate<NativeDelegates.MatchDataDelegate>(
						UnsafeUtils.WrapMatchDataDelegate(match)
					)
				);
			}
		}
		
		public bool Search(
			string query ,
			MatchDataDelegate match ,
			ProgressDelegate? progress = null 
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return NativeMethods.BNSearch(
					this.handle ,
					query ,
					IntPtr.Zero ,
					null == progress
						? IntPtr.Zero
						: Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
							UnsafeUtils.WrapProgressDelegate(progress)
						) ,
					IntPtr.Zero ,
					Marshal.GetFunctionPointerForDelegate<NativeDelegates.MatchDataDelegate>(
						UnsafeUtils.WrapMatchDataDelegate(match)
					)
				);
			}
		}
		
		public void Reanalyze()
		{
			NativeMethods.BNReanalyzeAllFunctions(this.handle);
		}

		public Workflow? Workflow
		{
			get
			{
				return Workflow.TakeHandle(

					NativeMethods.BNGetWorkflowForBinaryView(this.handle)
				);
			}
		}

		public bool Rebase(ulong address , ProgressDelegate? progress)
		{
			if (null == progress)
			{
				 return NativeMethods.BNRebase(
					this.handle,
					address
				);
			}
			else
			{
				return NativeMethods.BNRebaseWithProgress(
					this.handle,
					address,
					IntPtr.Zero, 
					Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
						UnsafeUtils.WrapProgressDelegate(progress)
					)
				);
			}
			
		}

		public void ShowPlainTextReport(string title , string contents)
		{
			NativeMethods.BNShowPlainTextReport(this.handle , title , contents);
		}
		
		public void ShowMarkdownReport(string title , string contents , string plaintext)
		{
			NativeMethods.BNShowMarkdownReport(this.handle , title , contents , plaintext);
		}
		
		public void ShowHTMLReport(string title , string contents , string plaintext)
		{
			NativeMethods.BNShowHTMLReport(this.handle , title , contents , plaintext);
		}
		
		public void ShowGraphReport(string title , FlowGraph graph)
		{
			NativeMethods.BNShowGraphReport(
				this.handle ,
				title , 
				graph.DangerousGetHandle() 
			) ;
		}

		public bool GetAddressInput(
			out ulong result,
			string prompt,
			string title ,
			ulong? currentAddress = null
		)
		{
			if (null == currentAddress)
			{
				currentAddress = this.File.Offset;
			}
			
			return NativeMethods.BNGetAddressInput(
				out result,
				prompt,
				title,
				this.handle,
				currentAddress?? 0
			);
		}
		
		public void BeginBulkAddSegments()
		{
			NativeMethods.BNBeginBulkAddSegments(this.handle);
		}
		
		public void EndBulkAddSegments()
		{
			NativeMethods.BNEndBulkAddSegments(this.handle);
		}
		
		public void CancelBulkAddSegments()
		{
			NativeMethods.BNCancelBulkAddSegments(this.handle);
		}

		public void AddAutoSegment(
		    ulong start ,
		    ulong length , 
		    ulong dataOffset ,
		    ulong dataLength,
		    uint flags
	    )
	    {
		    NativeMethods.BNAddAutoSegment(
			    this.handle ,
			    start , 
			    length , 
			    dataOffset ,
			    dataLength , 
			    flags
		    );
	    }

		public void AddAutoSegments(SegmentInfo[] segments)
		{
			NativeMethods.BNAddAutoSegments(
				this.handle,
				UnsafeUtils.ConvertToNativeArray<BNSegmentInfo,SegmentInfo>(
					segments
					),
				(ulong)segments.Length
			);
		}
	    
	    public void RemoveAutoSegment(ulong start , ulong length)
	    {
		    NativeMethods.BNRemoveAutoSegment(
			    this.handle ,
			    start , 
			    length 
		    );
	    }
	    
	    public void AddUserSegment(
		    ulong start ,
		    ulong length , 
		    ulong dataOffset ,
		    ulong dataLength,
		    uint flags
	    )
	    {
		    NativeMethods.BNAddUserSegment(
			    this.handle ,
			    start , 
			    length , 
			    dataOffset ,
			    dataLength , 
			    flags
		    );
	    }
	    
	    public void AddUserSegments(SegmentInfo[] segments)
	    {
		    NativeMethods.BNAddUserSegments(
			    this.handle,
			    UnsafeUtils.ConvertToNativeArray<BNSegmentInfo,SegmentInfo>(
				    segments
			    ),
			    (ulong)segments.Length
		    );
	    }
	    
	    public void RemoveUserSegment(
		    ulong start ,
		    ulong length 
	    )
	    {
		    NativeMethods.BNRemoveUserSegment(
			    this.handle ,
			    start , 
			    length 
		    );
	    }

	   

	    public Segment? GetSegmentAt(ulong address)
	    {
		    return Segment.TakeHandle(
			    NativeMethods.BNGetSegmentAt(this.handle , address)
		    );
	    }
	    
	    public bool GetAddressForDataOffset(ulong offset , out ulong address)
	    {
		    return NativeMethods.BNGetAddressForDataOffset(this.handle , offset , out address);
	    }
	    
	    public bool GetDataOffsetForAddress(ulong address , out ulong offset)
	    {
		    offset = 0;
		    
		    Segment? segment = this.GetSegmentAt(address);

		    if (null == segment)
		    {
			    return false;
		    }

		    if (address >= segment.Start && address < segment.End)
		    {
			    offset = address - segment.Start;

			    if (offset >segment.DataLength)
			    {
				    return false;
			    }
			    
			    offset = segment.DataOffset + offset;

			    return true;
		    }

		    return false;
	    }

	    
	    public void AddAutoSection(
		    string name ,
		    ulong start,
		    ulong length , 
		    SectionSemantics semantics = SectionSemantics.DefaultSectionSemantics,
		    string type = "",
		    ulong align = 1,
		    ulong entrySize = 1 ,
		    string linkedSection = "",
		    string infoSection = "",
		    ulong infoData = 0
	    )
	    {
		    NativeMethods.BNAddAutoSection(
			    this.handle ,
			    name,
			    start , 
			    length , 
			    semantics,
			    type,
			    align ,
			    entrySize , 
			    linkedSection,
			    infoSection,
			    infoData
		    );
	    }
	    
	    public void RemoveAutoSection(string name)
	    {
		    NativeMethods.BNRemoveAutoSection(this.handle , name);
	    }
	    
	    public void AddUserSection(
		    string name ,
		    ulong start,
		    ulong length , 
		    SectionSemantics semantics = SectionSemantics.DefaultSectionSemantics,
		    string type = "",
		    ulong align = 1,
		    ulong entrySize = 1 ,
		    string linkedSection = "",
		    string infoSection = "",
		    ulong infoData = 0
	    )
	    {
		    NativeMethods.BNAddUserSection(
			    this.handle ,
			    name,
			    start , 
			    length , 
			    semantics,
			    type,
			    align ,
			    entrySize , 
			    linkedSection,
			    infoSection,
			    infoData
		    );
	    }
	    
	    public void RemoveUserSection(string name)
	    {
		    NativeMethods.BNRemoveUserSection(this.handle , name);
	    }
	    
	    public Section[] GetSectionsAt(ulong address)
	    {
		    IntPtr arrayPointer =  NativeMethods.BNGetSectionsAt(
			    this.handle ,
			    address,
			    out ulong arrayLength
			 );
		    
		    return UnsafeUtils.TakeHandleArrayEx<Section>(
			    arrayPointer,
			    arrayLength,
			    Section.MustNewFromHandle,
			    NativeMethods.BNFreeSectionList
			 );
	    }

	    public Section? GetSectionByName(string name)
	    {
		    return Section.TakeHandle(
			    NativeMethods.BNGetSectionByName(this.handle , name)
		    );
	    }

	 

	    public ulong[] GlobalCommentedAddresses
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetGlobalCommentedAddresses(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeNumberArray<ulong>(
				    arrayPointer ,
				    arrayLength ,
				    NativeMethods.BNFreeAddressList
			    );
		    }
	    }

	    public string GetGlobalCommentForAddress(ulong address)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetGlobalCommentForAddress(this.handle , address)
		    );
	    }

	    public void SetGlobalCommentForAddress(ulong address , string comment)
	    {
		    NativeMethods.BNSetGlobalCommentForAddress(this.handle , address, comment);
	    }

	    public DebugInfo DebugInfo
	    {
		    get
		    {
			    return DebugInfo.MustTakeHandle(
				    NativeMethods.BNGetDebugInfo(this.handle)
			    );
		    }

		    set
		    {
			    NativeMethods.BNSetDebugInfo(
				    this.handle, 
				    null == value ? IntPtr.Zero : value.DangerousGetHandle()
				);
		    }
	    }

	    public void ApplyDebugInfo(DebugInfo debugInfo)
	    {
		    NativeMethods.BNApplyDebugInfo(this.handle, debugInfo.DangerousGetHandle());
	    }

	    public Metadata? QueryMetadata(string key)
	    {
		    return Metadata.TakeHandle(
			    NativeMethods.BNBinaryViewQueryMetadata(this.handle , key)
		    );
	    }

	    public void StoreMetadata(string key , Metadata data , bool isAuto = false )
	    {
		    NativeMethods.BNBinaryViewStoreMetadata(
			    this.handle ,
			    key , 
			    data.DangerousGetHandle() ,
			    isAuto
			);
	    }

	    public void RemoveMetadata(string key)
	    {
		    NativeMethods.BNBinaryViewRemoveMetadata(this.handle , key);
	    }

	    public Metadata Metadata
	    {
		    get
		    {
			    return Metadata.MustTakeHandle(
				    NativeMethods.BNBinaryViewGetMetadata(this.handle)
			    );
		    }
	    }
	    
	    public Metadata AutoMetadata
	    {
		    get
		    {
			    return Metadata.MustTakeHandle(
				    NativeMethods.BNBinaryViewGetAutoMetadata(this.handle)
			    );
		    }
	    }

	    public string[] LoadSettingsTypeNames
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNBinaryViewGetLoadSettingsTypeNames(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeAnsiStringArray(
				    arrayPointer , 
				    arrayLength,
				    NativeMethods.BNFreeStringList
				    );
		    }
	    }

	    public Settings? GetLoadSettings(string typeName)
	    {
		    return Settings.TakeHandle(
			    NativeMethods.BNBinaryViewGetLoadSettings(this.handle , typeName)
		    );
	    }

	    public void SetLoadSettings(string typeName , Settings settings)
	    {
		    NativeMethods.BNBinaryViewSetLoadSettings(
			    this.handle ,
			    typeName ,
			    settings.DangerousGetHandle()
			);
	    }

	    public ulong ParseExpression(string expression, ulong here = 0)
	    {
		    bool ok = NativeMethods.BNParseExpression(
			    this.handle ,
			    expression ,
			    out ulong offset ,
			    here ,
			    out IntPtr errorPointer
		    );

		    if (!ok)
		    {
			    string errors = UnsafeUtils.TakeUtf8String(
				    errorPointer ,
				    NativeMethods.BNFreeParseError
				);
			    
			    throw new Exception(errors);
		    }
		    
		    return offset;
	    }

	    public BinaryReader CreateReader()
	    {
		    return new BinaryReader(this);
	    }
	    
	    public BinaryWriter CreateWriter()
	    {
		    return new BinaryWriter(this);
	    }
	    
	   
	    public ExternalLibrary AddExternalLibrary(
		    string name ,
		    ProjectFile? projectFile = null,
		    bool isAuto = false
		)
	    {
		    return ExternalLibrary.MustTakeHandle(
			    NativeMethods.BNBinaryViewAddExternalLibrary(
				    this.handle ,
				    name ,
				    null == projectFile ? IntPtr.Zero : projectFile.DangerousGetHandle() ,
				    isAuto
			    )
		    );
	    }

	    public void RemoveExternalLibrary(string name )
	    {
		    NativeMethods.BNBinaryViewRemoveExternalLibrary(this.handle , name);
	    }

	    public ExternalLibrary? GetExternalLibrary(string name)
	    {
		    return ExternalLibrary.TakeHandle(
			    NativeMethods.BNBinaryViewGetExternalLibrary(this.handle , name)
			);
	    }

	    public ExternalLibrary[] ExternalLibraries
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNBinaryViewGetExternalLibraries(
				    this.handle,
				    out ulong arrayLength
				);

			    return UnsafeUtils.TakeHandleArrayEx<ExternalLibrary>(
				    arrayPointer ,
				    arrayLength ,
				    ExternalLibrary.MustNewFromHandle,
				    NativeMethods.BNFreeExternalLibraryList
			    );
		    }
	    }

	    public string StringifyUnicodeData(
		    Architecture arch,
		    DataBuffer buffer,
		    bool nullTerminates,
		    bool allowShortStrings,
		    out StringType stringType
		)
	    {
		    string text = string.Empty;
		    
		    bool ok = NativeMethods.BNStringifyUnicodeData(
			    this.handle ,
			    arch.DangerousGetHandle() ,
			    buffer.DangerousGetHandle() ,
			    nullTerminates ,
			    allowShortStrings ,
			    out IntPtr textPointer ,
			    out stringType
		    );
		    
		    if (ok)
		    {
			    if (StringType.AsciiString == stringType)
			    {
					text = UnsafeUtils.TakeAnsiString(textPointer);
			    }
			    else if (StringType.Utf16String == stringType)
			    {
				    text = UnsafeUtils.TakeUtf16String(textPointer);
			    }
			    else if (StringType.Utf32String == stringType)
			    {
				    text = UnsafeUtils.TakeUtf32String(textPointer);
			    }
			    else if (StringType.Utf8String == stringType)
			    {
				    text = UnsafeUtils.TakeUtf8String(textPointer);
			    }
			    else
			    {
				    throw new Exception("unknown string type");
			    }
		    }
		    else
		    {
			    text = String.Empty;
			    stringType = StringType.AsciiString;
		    }

		    return text;
	    }

	    
	    public PluginCommand[] ValidPluginCommands
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommands(
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

	    public PluginCommand[] GetValidPluginCommandsForAddress(ulong address)
	    {
		    
		    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForAddress(
			    this.handle,
			    address,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArray<BNPluginCommand , PluginCommand>(
			    arrayPointer ,
			    arrayLength ,
			    PluginCommand.FromNative ,
			    NativeMethods.BNFreePluginCommandList
		    );
	    }
	    
	    public PluginCommand[] GetValidPluginCommandsForRange(
		    ulong address,
		    ulong length
		)
	    {
		    
		    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForRange(
			    this.handle,
			    address,
			    length,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArray<BNPluginCommand , PluginCommand>(
			    arrayPointer ,
			    arrayLength ,
			    PluginCommand.FromNative ,
			    NativeMethods.BNFreePluginCommandList
		    );
	    }
	    
	    public PluginCommand[] GetValidPluginCommandsForFunction(Function function)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForFunction(
			    this.handle,
			    function.DangerousGetHandle(),
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArray<BNPluginCommand , PluginCommand>(
			    arrayPointer ,
			    arrayLength ,
			    PluginCommand.FromNative ,
			    NativeMethods.BNFreePluginCommandList
		    );
	    }
	    
	    public PluginCommand[] GetValidPluginCommandsForLowLevelILFunction(LowLevelILFunction function)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForLowLevelILFunction(
			    this.handle,
			    function.DangerousGetHandle(),
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArray<BNPluginCommand , PluginCommand>(
			    arrayPointer ,
			    arrayLength ,
			    PluginCommand.FromNative ,
			    NativeMethods.BNFreePluginCommandList
		    );
	    }
	    
	    public PluginCommand[] GetValidPluginCommandsForLowLevelILInstruction(
		    LowLevelILFunction function,
		    ulong instruction
		    )
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForLowLevelILInstruction(
			    this.handle,
			    function.DangerousGetHandle(),
			    instruction,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArray<BNPluginCommand , PluginCommand>(
			    arrayPointer ,
			    arrayLength ,
			    PluginCommand.FromNative ,
			    NativeMethods.BNFreePluginCommandList
		    );
	    }
	    
	    
	    public PluginCommand[] GetValidPluginCommandsForMediumLevelILFunction(MediumLevelILFunction function)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForMediumLevelILFunction(
			    this.handle,
			    function.DangerousGetHandle(),
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArray<BNPluginCommand , PluginCommand>(
			    arrayPointer ,
			    arrayLength ,
			    PluginCommand.FromNative ,
			    NativeMethods.BNFreePluginCommandList
		    );
	    }
	    
	    public PluginCommand[] GetValidPluginCommandsForMediumLevelILInstruction(
		    MediumLevelILFunction function,
		    ulong instruction
	    )
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForMediumLevelILInstruction(
			    this.handle,
			    function.DangerousGetHandle(),
			    instruction,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArray<BNPluginCommand , PluginCommand>(
			    arrayPointer ,
			    arrayLength ,
			    PluginCommand.FromNative ,
			    NativeMethods.BNFreePluginCommandList
		    );
	    }
	    
	    public PluginCommand[] GetValidPluginCommandsForHighLevelILFunction(HighLevelILFunction function)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForHighLevelILFunction(
			    this.handle,
			    function.DangerousGetHandle(),
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArray<BNPluginCommand , PluginCommand>(
			    arrayPointer ,
			    arrayLength ,
			    PluginCommand.FromNative ,
			    NativeMethods.BNFreePluginCommandList
		    );
	    }
	    
	    public PluginCommand[] GetValidPluginCommandsForHighLevelILInstruction(
		    HighLevelILFunction function,
		    ulong instruction
	    )
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForHighLevelILInstruction(
			    this.handle,
			    function.DangerousGetHandle(),
			    instruction,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArray<BNPluginCommand , PluginCommand>(
			    arrayPointer ,
			    arrayLength ,
			    PluginCommand.FromNative ,
			    NativeMethods.BNFreePluginCommandList
		    );
	    }
	    
	    public bool CreateDatabase(
		    string filename,
		    SaveSettings? settings = null,
		    ProgressDelegate? progress = null)
	    {
		    if (null == progress)
		    {
			    return NativeMethods.BNCreateDatabase(
				    this.handle ,
				    filename,
				    null == settings ? IntPtr.Zero :  settings.DangerousGetHandle()
			    );
		    }
		    else
		    {
			    return NativeMethods.BNCreateDatabaseWithProgress(
				    this.handle ,
				    filename ,
				    IntPtr.Zero ,
				    Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
					    UnsafeUtils.WrapProgressDelegate(progress)
					    ) ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    );
		    }
	    }
	    
	    public bool SaveAutoSnapshot(
		    SaveSettings? settings = null,
		    ProgressDelegate? progress = null)
	    {
		    if (null == progress)
		    {
			    return NativeMethods.BNSaveAutoSnapshot(
				    this.handle ,
				    null == settings ? IntPtr.Zero :  settings.DangerousGetHandle()
			    );
		    }
		    else
		    {
			    return NativeMethods.BNSaveAutoSnapshotWithProgress(
				    this.handle ,
				    IntPtr.Zero ,
				    Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>
					    (UnsafeUtils.WrapProgressDelegate(progress)) ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    );
		    }
	    }
	    
	    public string BaseMemoryMapDescription
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNGetBaseMemoryMapDescription(this.handle)
			    );
		    }
	    }
		
	    public string MemoryMapDescription
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNGetMemoryMapDescription(this.handle)
			    );
		    }
	    }

	    public bool LogicalMemoryMapEnabled
	    {
		    set
		    {
			    NativeMethods.BNSetLogicalMemoryMapEnabled(this.handle, value);
		    }
	    }

	    public bool MemoryMapActivated
	    {
		    get
		    {
			    return NativeMethods.BNIsMemoryMapActivated(this.handle);
		    }
	    }

	    public bool AddMemoryRegion(
		    string name,
		    ulong start,
		    BinaryView data,
		    uint flags
		)
	    {
		    return NativeMethods.BNAddBinaryMemoryRegion(
			    this.handle, 
			    name, 
			    start,
			    data.DangerousGetHandle(), 
			    flags
			);
	    }
	    
	    public bool AddMemoryRegion(
		    string name,
		    ulong start,
		    DataBuffer data,
		    uint flags
	    )
	    {
		    return NativeMethods.BNAddDataMemoryRegion(
			    this.handle, 
			    name, 
			    start,
			    data.DangerousGetHandle(), 
			    flags
		    );
	    }
	    
	    public bool AddMemoryRegion(
		    string name,
		    ulong start,
		    FileAccessor data,
		    uint flags
	    )
	    {
		    return NativeMethods.BNAddRemoteMemoryRegion(
			    this.handle, 
			    name, 
			    start,
			    data.ToNative(), 
			    flags
		    );
	    }
	    
	    public bool AddMemoryRegion(
		    string name,
		    ulong start,
		    ulong length,
		    uint flags,
		    byte fill
	    )
	    {
		    return NativeMethods.BNAddUnbackedMemoryRegion(
			    this.handle, 
			    name, 
			    start,
			    length, 
			    flags,
			    fill
		    );
	    }

	    public bool RemoveMemoryRegion(string name)
	    {
		    return NativeMethods.BNRemoveMemoryRegion(this.handle, name);
	    }

	    public string GetActiveMemoryRegionAt(ulong address)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetActiveMemoryRegionAt(this.handle , address)
		    );
	    }
	    
	    public uint GetMemoryRegionFlags(string name)
	    {
		    return NativeMethods.BNGetMemoryRegionFlags(this.handle , name);
	    }
	    
	    public bool SetMemoryRegionFlags(string name , uint flags)
	    {
		    return NativeMethods.BNSetMemoryRegionFlags(this.handle , name , flags);
	    }
	    
	    public bool IsMemoryRegionEnabled(string name)
	    {
		    return NativeMethods.BNIsMemoryRegionEnabled(this.handle , name);
	    }
	    
	    public bool SetMemoryRegionEnabled(string name , bool enable)
	    {
		    return NativeMethods.BNSetMemoryRegionEnabled(this.handle , name , enable);
	    }
	    
	    public bool IsMemoryRegionRebaseable(string name)
	    {
		    return NativeMethods.BNIsMemoryRegionRebaseable(this.handle , name );
	    }
	    
	    public bool SetMemoryRegionRebaseable(string name , bool rebaseable)
	    {
		    return NativeMethods.BNSetMemoryRegionRebaseable(this.handle , name , rebaseable);
	    }
	    
	    public byte GetMemoryRegionFill(string name)
	    {
		    return NativeMethods.BNGetMemoryRegionFill(this.handle , name);
	    }
	    
	    public bool SetMemoryRegionFill(string name , byte fill)
	    {
		    return NativeMethods.BNSetMemoryRegionFill(this.handle , name , fill);
	    }
	   
	    public bool IsMemoryRegionLocal(string name)
	    {
		    return NativeMethods.BNIsMemoryRegionLocal(this.handle , name );
	    }

	    public void ResetMemoryMap()
	    {
		    NativeMethods.BNResetMemoryMap(this.handle);
	    }
	    
	    public BinaryViewType[] BinaryViewTypes
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetBinaryViewTypesForData(
				    this.handle,
				    out ulong arrayLength
			    );
	
			    return UnsafeUtils.TakeHandleArray<BinaryViewType>(
				    arrayPointer, 
				    arrayLength,
				    BinaryViewType.MustFromHandle,
				    NativeMethods.BNFreeBinaryViewTypeList
			    );
		    }
	    }
	  
	    public Logger? GetLogger(string name)
	    {
		    return Logger.GetLogger(name , this.File.SessionId);
	    }
	    
	    public Logger CreateLogger(string name)
	    {
		    return Logger.CreateLogger(name , this.File.SessionId);
	    }

	    public Logger GetOrCreateLogger(string name)
	    {
		    return Logger.GetOrCreateLogger(name , this.File.SessionId);
	    }
	    
	    public BinaryView? CreateCustomView(
		    string  name,
		    CustomBinaryView view,
		    FileMetadata? file = null
	    )
	    {
		    if (null == file)
		    {
			    file = this.File;
		    }

		    return BinaryView.TakeHandle(
			    NativeMethods.BNCreateCustomBinaryView(
				    name ,
				    file.DangerousGetHandle() ,
				    this.DangerousGetHandle() ,
				    view.ToNative()
			    )
		    );
	    }

	    public Symbol? ChooseSymbol(string prompt = "Choose" , string title = "Choose a symbol")
	    {
		    int? index = Core.GetLargeChoiceInput(
			    prompt ,
			    title ,
			    this.SymbolNames
		    );

		    if (null == index)
		    {
			    return null;
		    }
		    
		    return this.GetSymbolByRawName(this.SymbolNames[(int)index]);
	    }
	    
	    public Function? ChooseFunction(string prompt = "Choose" , string title = "Choose a function")
	    {
		    int? index = Core.GetLargeChoiceInput(
			    prompt ,
			    title ,
			    this.SymbolNames
		    );

		    if (null == index)
		    {
			    return null;
		    }
		    
		    return this.GetFunctionByRawName(this.SymbolNames[(int)index]);
	    }
	}
	
}