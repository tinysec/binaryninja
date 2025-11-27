using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class Function : AbstractSafeHandle
	{
	    internal Function(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static Function? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Function(
			    NativeMethods.BNNewFunctionReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Function MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Function(
			    NativeMethods.BNNewFunctionReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Function? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Function(handle, true);
	    }
	    
	    internal static Function MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Function(handle, true);
	    }
	    
	    internal static Function? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Function(handle, false);
	    }
	    
	    internal static Function MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Function(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeFunction(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        return true;
	    }
	    

	    /// <summary>
	    /// BinaryView that contains this function ?
	    /// </summary>
	    public BinaryView View
	    {
		    get
		    {
			    return BinaryView.MustTakeHandle(
				    NativeMethods.BNGetFunctionData(this.handle)
				);
		    }
	    }

	    public Architecture Architecture
	    {
		    get
		    {
			    IntPtr raw = NativeMethods.BNGetFunctionArchitecture(this.handle);

			    if (IntPtr.Zero == raw)
			    {
				    throw new NoNullAllowedException("function must have a architecture");
			    }
			    
			    return new Architecture(raw);
		    }
	    }

	    public Platform? Platform
	    {
		    get
		    {
			    IntPtr raw = NativeMethods.BNGetFunctionPlatform(this.handle);

			    if (IntPtr.Zero == raw)
			    {
				    return null;
			    }
			    
			    return new Platform(raw, true);
		    }
	    }

	    public ulong Start
	    {
		    get
		    {
			    return NativeMethods.BNGetFunctionStart(this.handle);
		    }
	    }

	    public ulong HighestAddress
	    {
		    get
		    {
			    return NativeMethods.BNGetFunctionHighestAddress(this.handle);
		    }
	    }

	    public ulong LowestAddress
	    {
		    get
		    {
			    return NativeMethods.BNGetFunctionLowestAddress(this.handle);
		    }
	    }

	    public AddressRange[] AddressRanges
	    {
		    get
		    {
			    ulong arrayLength = 0;
			    
			    IntPtr arrayPointer = NativeMethods.BNGetFunctionAddressRanges(this.handle , out arrayLength);

			    return UnsafeUtils.TakeStructArray<BNAddressRange , AddressRange>(
				    arrayPointer ,
				    arrayLength ,
				    AddressRange.FromNative ,
				    NativeMethods.BNFreeAddressRanges
			    );
		    }
	    }

	    public Symbol Symbol
	    {
		    get
		    {
			    IntPtr raw = NativeMethods.BNGetFunctionSymbol(this.handle);

			    if (IntPtr.Zero == raw)
			    {
				    throw new NoNullAllowedException("function must have a symbol");
			    }

			    return new Symbol(raw , true);
		    }
	    }

	    public ulong Address
	    {
		    get
		    {
			    return this.Symbol.Address;
		    }
	    }

	    public string ShortName
	    {
		    get
		    {
			    return this.Symbol.ShortName;
		    }
	    }
	    
	    public string FullName
	    {
		    get
		    {
			    return this.Symbol.FullName;
		    }
	    }
	    
	    public string RawName
	    {
		    get
		    {
			    return this.Symbol.RawName;
		    }
	    }

	    public bool WasAutomaticallyDiscovered
	    {
		    get
		    {
			    return NativeMethods.BNWasFunctionAutomaticallyDiscovered(this.handle);
		    }
	    }

	    public bool HasUserAnnotations
	    {
		    get
		    {
			    return NativeMethods.BNFunctionHasUserAnnotations(this.handle);
		    }
	    }

	    public BoolWithConfidence CanFunctionReturn
	    {
		    get
		    {
			    return BoolWithConfidence.FromNative( NativeMethods.BNCanFunctionReturn(this.handle) );
		    }

		    set
		    {
			    NativeMethods.BNSetUserFunctionCanReturn(this.handle,  value.ToNative() );
		    }
	    }

	    public BoolWithConfidence IsPure
	    {
		    get
		    {
			    return BoolWithConfidence.FromNative( NativeMethods.BNIsFunctionPure(this.handle));
		    }
		    
		    set
		    {
			    NativeMethods.BNSetUserFunctionPure(this.handle, value.ToNative() );
		    }
	    }
		
	    public void SetAutoType(BinaryNinja.Type type)
	    {
		    NativeMethods.BNSetFunctionAutoType(this.handle , type.DangerousGetHandle());
	    }
	    
	    public void SetUserType(BinaryNinja.Type type)
	    {
		    NativeMethods.BNSetFunctionUserType(this.handle , type.DangerousGetHandle());
	    }

	    public bool HasUserType
	    {
		    get
		    {
			    return NativeMethods.BNFunctionHasUserType(this.handle);
		    }
	    }

	    public void SetAutoReturnType(TypeWithConfidence type)
	    {
		    NativeMethods.BNSetAutoFunctionReturnType(
			    this.handle,
			    type.ToNative()
			);
	    }
	    
	    public void SetAutoCallingConvention(CallingConventionWithConfidence convention)
	    {
		    NativeMethods.BNSetAutoFunctionCallingConvention(
			    this.handle,
			    convention.ToNative()
		    );
	    }
	    
	    public void SetAutoParameterVariables(ParameterVariablesWithConfidence parameterVariables)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    NativeMethods.BNSetAutoFunctionParameterVariables(
				    this.handle,
				    parameterVariables.ToNativeEx(allocator)
			    );
		    }
	    }
	    
	    public bool HasExplicitlyDefinedType
	    {
		    get
		    {
			    return NativeMethods.BNFunctionHasExplicitlyDefinedType(this.handle);
		    }
	    }
	    
	    public bool UpdateNeeded
	    {
		    get
		    {
			    return NativeMethods.BNIsFunctionUpdateNeeded(this.handle);
		    }
	    }

	    public BasicBlock[] BasicBlocks
	    {
		    get
		    {
			    ulong arrayLength = 0;
			    
			    IntPtr arrayPointer = NativeMethods.BNGetFunctionBasicBlockList(this.handle, out arrayLength);

			    return UnsafeUtils.TakeHandleArrayEx<BasicBlock>(
				    arrayPointer ,
				    arrayLength ,
				    BasicBlock.MustNewFromHandle ,
				    NativeMethods.BNFreeBasicBlockList
			    );
		    }
	    }

	    public IReadOnlyDictionary<ulong , string> Comments
	    {
		    get
		    {
			    ulong addressCount = 0;

			    IntPtr addressArrayPointer = NativeMethods.BNGetCommentedAddresses(this.handle , out addressCount);

			    ulong[] addresses = UnsafeUtils.TakeNumberArray<ulong>(
				    addressArrayPointer ,
				    addressCount ,
				    NativeMethods.BNFreeAddressList
			    );
			    
			    Dictionary<ulong, string> comments = new Dictionary<ulong, string>();

			    foreach (ulong address in addresses)
			    {
				    comments[address] = GetCommentForAddress(address);
			    }

			    return comments;
		    }
	    }

	    public Tag[] GetAddressTags(Architecture arch , ulong address)
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetAddressTags(
			    this.handle,
			    arch.DangerousGetHandle(),
			    address,
			    out arrayLength
			);

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle ,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetAutoAddressTags(Architecture arch , ulong address)
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetAutoAddressTags(
			    this.handle,
			     arch.DangerousGetHandle(),
			    address,
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetUserAddressTags(Architecture arch , ulong address)
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetUserAddressTags(
			    this.handle,
			    arch.DangerousGetHandle(),
			    address,
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle ,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetAddressTagsInRange(Architecture arch , ulong start , ulong end)
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetAddressTagsInRange(
			    this.handle,
			     arch.DangerousGetHandle(),
			    start,
			    end,
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle ,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetAutoAddressTagsInRange(Architecture arch , ulong start , ulong end)
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetAutoAddressTagsInRange(
			    this.handle,
			    arch.DangerousGetHandle(),
			    start,
			    end,
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle ,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetUserAddressTagsInRange(Architecture arch , ulong start , ulong end)
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetUserAddressTagsInRange(
			    this.handle,
			    arch.DangerousGetHandle(),
			    start,
			    end,
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle ,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetFunctionTags()
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetFunctionTags(
			    this.handle,
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle ,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetAutoFunctionTags()
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetAutoFunctionTags(
			    this.handle,
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle ,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetUserFunctionTags()
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetUserFunctionTags(
			    this.handle,
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle ,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetFunctionTagsOfType(TagType kind)
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetFunctionTagsOfType(
			    this.handle,
			    kind.DangerousGetHandle(),
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle ,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetAutoFunctionTagsOfType(TagType kind)
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetAutoFunctionTagsOfType(
			    this.handle,
			    kind.DangerousGetHandle(),
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle,
			    NativeMethods.BNFreeTagList
		    );
	    }
	    
	    public Tag[] GetUserFunctionTagsOfType(TagType kind)
	    {
		    ulong arrayLength = 0;
		    
		    IntPtr arrayPointer = NativeMethods.BNGetUserFunctionTagsOfType(
			    this.handle,
			    kind.DangerousGetHandle(),
			    out arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<Tag>(
			    arrayPointer ,
			    arrayLength ,
			    Tag.MustNewFromHandle,
			    NativeMethods.BNFreeTagList
		    );
	    }

	    
	    public void AddAutoFunctionTag(Tag tag)
	    {
		   NativeMethods.BNAddAutoFunctionTag(this.handle, tag.DangerousGetHandle());
	    }
	    
	    public void AddUserFunctionTag(Tag tag)
	    {
		    NativeMethods.BNAddUserFunctionTag(this.handle, tag.DangerousGetHandle());
	    }
	    
	    public void AddAutoAddressTag(Architecture arch ,ulong address , Tag tag)
	    {
		    NativeMethods.BNAddAutoAddressTag(
			    this.handle, 
			    arch.DangerousGetHandle(),
			    address,
			    tag.DangerousGetHandle()
			);
	    }
	    
	    public void AddUserAddressTag(Architecture arch ,ulong address , Tag tag)
	    {
		    NativeMethods.BNAddUserAddressTag(
			    this.handle, 
			    arch.DangerousGetHandle(),
			    address,
			    tag.DangerousGetHandle()
		    );
	    }

	    public void RemoveAutoAddressTag(Architecture arch , ulong address , Tag tag)
	    {
		    NativeMethods.BNRemoveAutoAddressTag(
			    this.handle, 
			    arch.DangerousGetHandle(),
			    address ,
			    tag.DangerousGetHandle()
		    );
	    }
	    
	    public void RemoveAutoAddressTagsOfType(Architecture arch , ulong address , TagType kind)
	    {
		    NativeMethods.BNRemoveAutoAddressTagsOfType(
			    this.handle, 
			    arch.DangerousGetHandle(),
			    address ,
			    kind.DangerousGetHandle()
		    );
	    }
	    
	    public void RemoveUserAddressTag(Architecture arch , ulong address , Tag tag)
	    {
		    NativeMethods.BNRemoveUserAddressTag(
			    this.handle, 
			    arch.DangerousGetHandle(),
			    address ,
			    tag.DangerousGetHandle()
			);
	    }
	    
	    public void RemoveUserAddressTagsOfType(Architecture arch , ulong address , TagType kind)
	    {
		    NativeMethods.BNRemoveUserAddressTagsOfType(
			    this.handle, 
			    arch.DangerousGetHandle(),
			    address ,
			    kind.DangerousGetHandle()
		    );
	    }
	    
	    public void RemoveUserFunctionTag( Tag tag)
	    {
		    NativeMethods.BNRemoveUserFunctionTag(
			    this.handle, 
			    tag.DangerousGetHandle()
		    );
	    }
	    
	    public void RemoveUserFunctionTagsOfType( TagType kind)
	    {
		    NativeMethods.BNRemoveAutoFunctionTagsOfType(
			    this.handle, 
			    kind.DangerousGetHandle()
		    );
	    }

	    public LowLevelILFunction LowLevelIL
	    {
		    get
		    {
			    return LowLevelILFunction.MustTakeHandle(
				    NativeMethods.BNGetFunctionLowLevelIL(this.handle)
			    );
		    }
	    }
	    
	    public LowLevelILFunction? GetLowLevelIL()
	    {
		    
		    return LowLevelILFunction.TakeHandle(
			    NativeMethods.BNGetFunctionLowLevelIL(
				    this.handle
			    )
		    );
	    }
	    
	    public LowLevelILFunction? GetLowLevelILIfAvailable()
	    {
		    
		    return LowLevelILFunction.TakeHandle(
			    NativeMethods.BNGetFunctionLowLevelILIfAvailable(
				    this.handle
			    )
		    );
	    }
	    
	    public LowLevelILFunction LiftedIL
	    {
		    get
		    {
			    return LowLevelILFunction.MustTakeHandle(
				    NativeMethods.BNGetFunctionLiftedIL(this.handle)
			    );
		    }
	    }
	    
	    public LowLevelILFunction? GetLiftedILIfAvailable()
	    {
		    IntPtr raw = NativeMethods.BNGetFunctionLiftedILIfAvailable(this.handle);

		    if (IntPtr.Zero == raw)
		    {
			    return null;
		    }

		    return new LowLevelILFunction(raw , true);
	    }
	    
	    public MediumLevelILFunction MediumLevelIL
	    {
		    get
		    {
			    return MediumLevelILFunction.MustTakeHandle(
				    NativeMethods.BNGetFunctionMediumLevelIL(this.handle)
			    );
		    }
	    }
	    
	    public MediumLevelILFunction? GetMediumLevelIL()
	    {
		    return MediumLevelILFunction.TakeHandle(
			    NativeMethods.BNGetFunctionMediumLevelIL(this.handle)
		    );
	    }
	    
	    public MediumLevelILFunction? GetMediumLevelILIfAvailable()
	    {
		    return MediumLevelILFunction.TakeHandle(
			    NativeMethods.BNGetFunctionMediumLevelILIfAvailable(this.handle)
		    );
	    }
	    
	    public MediumLevelILFunction MappedMediumLevelIL
	    {
		    get
		    {
			    return MediumLevelILFunction.MustTakeHandle(
				    NativeMethods.BNGetFunctionMappedMediumLevelIL(this.handle)
			    );
		    }
	    }
	    
	    public MediumLevelILFunction? GetMappedMediumLevelILIfAvailable()
	    {
		    IntPtr raw = NativeMethods.BNGetFunctionMappedMediumLevelILIfAvailable(this.handle);

		    if (IntPtr.Zero == raw)
		    {
			    return null;
		    }

		    return new MediumLevelILFunction(raw , true);
	    }
	    
	    
	    public HighLevelILFunction HighLevelIL
	    {
		    get
		    {
			    return HighLevelILFunction.MustTakeHandle(
				    NativeMethods.BNGetFunctionHighLevelIL(this.handle)
			    );
		    }
	    }
	    
	    public HighLevelILFunction? GetHighLevelIL()
	    {
		    return HighLevelILFunction.TakeHandle(
			    NativeMethods.BNGetFunctionHighLevelIL(this.handle)
		    );
	    }
	    
	    public HighLevelILFunction? GetHighLevelILIfAvailable()
	    {
		    IntPtr raw = NativeMethods.BNGetFunctionHighLevelILIfAvailable(this.handle);

		    if (IntPtr.Zero == raw)
		    {
			    return null;
		    }

		    return new HighLevelILFunction(raw , true);
	    }
	    
	    public LanguageRepresentationFunction? GetLanguageRepresentation(string language = "Pseudo C")
	    {
		    return LanguageRepresentationFunction.TakeHandle(
			    NativeMethods.BNGetFunctionLanguageRepresentation(this.handle , language)
		    );
	    }
	    
	    public LanguageRepresentationFunction? GetLanguageRepresentationIfAvailable(string language = "Pseudo C")
	    {
		    IntPtr raw = NativeMethods.BNGetFunctionLanguageRepresentationIfAvailable(this.handle , language);

		    if (IntPtr.Zero == raw)
		    {
			    return null;
		    }
		  
		    return new LanguageRepresentationFunction(raw , true);
	    }
	    
	    public FunctionType Type
	    {
		    get
		    {
			    return BinaryNinja.FunctionType.MustTakeHandle(
				    NativeMethods.BNGetFunctionType(this.handle)
			    );
		    }
	    }

	    public VariableNameAndType[] StackLayout
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetStackLayout(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeStructArrayEx<BNVariableNameAndType , VariableNameAndType>(
				    arrayPointer ,
				    arrayLength ,
				    (_native) => VariableNameAndType.FromNativeEx(this, _native) ,
				    NativeMethods.BNFreeVariableNameAndTypeList
			    );
		    }
	    }

	    public VariableNameAndType[] Variables
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetFunctionVariables(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeStructArrayEx<BNVariableNameAndType , VariableNameAndType>(
				    arrayPointer ,
				    arrayLength ,
				    (_native) => VariableNameAndType.FromNativeEx(this, _native),
				    NativeMethods.BNFreeVariableNameAndTypeList
			    );
		    }
	    }

	    public string[] VariableNames
	    {
		    get
		    {
			    List<string> items = new List<string>();

			    foreach (VariableNameAndType item in this.Variables)
			    {
				    if (!items.Contains(item.Name))
				    {
					    items.Add(item.Name);
				    }
			    }
			    
			    return items.ToArray();
		    }
	    }

	    public VariableNameAndType? GetVariableByName(string name)
	    {
		    foreach (VariableNameAndType variable in Variables)
		    {
			    if (variable.Name == name)
			    {
				    return variable;
			    }
		    }

		    return null;
	    }

	    public IndirectBranchInfo[] IndirectBranchs
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetIndirectBranches(
				    this.handle ,
				    out ulong arrayLength
			    );
			    
			    return UnsafeUtils.TakeStructArray<BNIndirectBranchInfo , IndirectBranchInfo>(
				    arrayPointer ,
				    arrayLength ,
				    IndirectBranchInfo.FromNative ,
				    NativeMethods.BNFreeIndirectBranchList
			    );
		    }
	    }
	    
	    public ArchitectureAndAddress[] UnresolvedIndirectBranches
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetUnresolvedIndirectBranches(
				    this.handle ,
				    out ulong arrayLength
			    );
			    
			    return UnsafeUtils.TakeStructArray<BNArchitectureAndAddress , ArchitectureAndAddress>(
				    arrayPointer ,
				    arrayLength ,
				    ArchitectureAndAddress.FromNative ,
				    NativeMethods.BNFreeArchitectureAndAddressList
			    );
		    }
	    }

	    public bool HasUnresolvedIndirectBranches
	    {
		    get
		    {
			    return NativeMethods.BNHasUnresolvedIndirectBranches(this.handle);
		    }
	    }
	    
	    public TypeWithConfidence ReturnType
	    {
		    get
		    {
			    return TypeWithConfidence.FromNative(
				    NativeMethods.BNGetFunctionReturnType(this.handle)
			    );
		    }

		    set
		    {
			    NativeMethods.BNSetUserFunctionReturnType(
				    this.handle, 
				    value.ToNative()
				);
		    }
	    }

	    public CallingConventionWithConfidence CallingConvention
	    {
		    get
		    {
			    return CallingConventionWithConfidence.FromNative(
				    NativeMethods.BNGetFunctionCallingConvention(this.handle)
			    );
		    }

		    set
		    {
			    NativeMethods.BNSetUserFunctionCallingConvention(
				    this.handle, 
				    value.ToNative()
				);
		    }
	    }

	    public ParameterVariablesWithConfidence ParameterVariables
	    {
		    get
		    {
			    return new ParameterVariablesWithConfidence(
				    this,
				    NativeMethods.BNGetFunctionParameterVariables(this.handle)
			    );
		    }

		    set
		    {
			    using (ScopedAllocator allocator = new ScopedAllocator())
			    {
				    NativeMethods.BNSetUserFunctionParameterVariables(
					    this.handle,
					    value.ToNativeEx(allocator)
					);
			    }
		    }
	    }
	    
	    public BoolWithConfidence HasVariableArguments
	    {
		    get
		    {
			    return BoolWithConfidence.FromNative(
				    NativeMethods.BNFunctionHasVariableArguments(this.handle)
			    );
		    }

		    set
		    {
			    NativeMethods.BNSetUserFunctionHasVariableArguments(
				    this.handle, 
				    value.ToNative()
			    );
		    }
	    }

	    public string Comment
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNGetFunctionComment(this.handle)
			    );
		    }

		    set
		    {
			    NativeMethods.BNSetFunctionComment(this.handle, value);
		    }
	    }

	    public bool TooLarge
	    {
		    get
		    {
			    return NativeMethods.BNIsFunctionTooLarge(this.handle);
		    }
	    }
	    
	    public bool AnalysisSkipped
	    {
		    get
		    {
			    return NativeMethods.BNIsFunctionAnalysisSkipped(this.handle);
		    }
	    }

	    public string GetCommentForAddress(ulong address)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetCommentForAddress(this.handle , address)
		    );
	    }

	    public void SetCommentForAddress(ulong address , string comment)
	    {
		    NativeMethods.BNSetCommentForAddress(this.handle , address, comment);
	    }

	    public void AddUserCodeReference(
		    ulong fromAddress , 
		    ulong toAddress,
		    Architecture? arch = null
		)
	    {
		    NativeMethods.BNAddUserCodeReference(
			    this.handle ,
			    null == arch ? IntPtr.Zero : arch.DangerousGetHandle() ,
			    fromAddress ,
			    toAddress
		    );
	    }
	    
	    public void RemoveUserCodeReference(
		    ulong fromAddress , 
		    ulong toAddress,
		    Architecture? arch = null
	    )
	    {
		    NativeMethods.BNRemoveUserCodeReference(
			    this.handle ,
			    null == arch ? IntPtr.Zero : arch.DangerousGetHandle() ,
			    fromAddress ,
			    toAddress
		    );
	    }
	    
	    public RegisterValue GetRegisterValueAtInstruction(
		    ulong address,
		    RegisterIndex reg,
		    Architecture? arch = null
	    )
	    {
		    return RegisterValue.FromNative(
			    NativeMethods.BNGetRegisterValueAtInstruction(
				    this.handle ,
				    null == arch ? IntPtr.Zero : arch.DangerousGetHandle() ,
				    address ,
				    reg
			    )
		    );
	    }
	    
	    public RegisterValue GetRegisterValueAfterInstruction(
		    ulong address,
		    RegisterIndex reg,
		    Architecture? arch = null
	    )
	    {
		    return RegisterValue.FromNative(
			    NativeMethods.BNGetRegisterValueAfterInstruction(
				    this.handle ,
				    null == arch ? IntPtr.Zero : arch.DangerousGetHandle() ,
				    address ,
				    reg
			    )
		    );
	    }
	    
	    
	    public RegisterValue GetStackContentsAtInstruction(
		    ulong address,
		    long offset,
		    ulong size,
		    Architecture? arch = null
	    )
	    {
		    return RegisterValue.FromNative(
			    NativeMethods.BNGetStackContentsAtInstruction(
				    this.handle ,
				    null == arch ? IntPtr.Zero : arch.DangerousGetHandle() ,
				    address ,
				    offset,
				    size
			    )
		    );
	    }
	    
	    public RegisterValue GetStackContentsAfterInstruction(
		    ulong address,
		    long offset,
		    ulong size,
		    Architecture? arch = null
	    )
	    {
		    return RegisterValue.FromNative(
			    NativeMethods.BNGetStackContentsAfterInstruction(
				    this.handle ,
				    null == arch ? IntPtr.Zero : arch.DangerousGetHandle() ,
				    address ,
				    offset,
				    size
			    )
		    );
	    }
	    
	    
	    public RegisterValue GetParameterValueAtInstruction(
		    ulong address,
		    ulong index,
		    BinaryNinja.Type? type,
		    Architecture? arch = null
		)
	    {
		    return RegisterValue.FromNative(
			    NativeMethods.BNGetParameterValueAtInstruction(
				    this.handle ,
				    null == arch ? IntPtr.Zero : arch.DangerousGetHandle() ,
				    address ,
				    null == type ? IntPtr.Zero : type.DangerousGetHandle() ,
				    index
			    )
		    );
	    }
	    
	    public RegisterValue GetParameterValueAtLowLevelILInstruction(
		    ulong instructionIndex,
		    ulong index,
		    BinaryNinja.Type? type
	    )
	    {
		    return RegisterValue.FromNative(
			    NativeMethods.BNGetParameterValueAtLowLevelILInstruction(
				    this.handle ,
				    instructionIndex,
				    null == type ? IntPtr.Zero : type.DangerousGetHandle() ,
				    index
			    )
		    );
	    }
	    
	    
	    
	    public void Analyze()
	    {
		    NativeMethods.BNAnalyzeFunction(this.handle);
	    }
	    
	    public void Reanalyze(FunctionUpdateType type = FunctionUpdateType.FullAutoFunctionUpdate)
	    {
		    NativeMethods.BNReanalyzeFunction(this.handle , type);
	    }

	    public BasicBlock? GetBasicBlockAtAddress(ulong address , Architecture? arch = null)
	    {
		    if (null == arch)
		    {
			    arch = this.Architecture;
		    }
		    
		    return BasicBlock.TakeHandle(
			    NativeMethods.BNGetFunctionBasicBlockAtAddress(
				    this.handle, 
				    null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
				    address)
		    );
	    }

	    public HighlightColor GetInstructionHighlight(ulong address , Architecture? arch = null)
	    {
		    return HighlightColor.FromNative(
			    NativeMethods.BNGetInstructionHighlight(
				    this.handle ,
				    null == arch ? IntPtr.Zero : arch.DangerousGetHandle() ,
				    address
			    )
		    );
	    }

	    public void SetAutoInstructionHighlight(ulong address , HighlightColor color , Architecture? arch = null)
	    {
		    NativeMethods.BNSetAutoInstructionHighlight(
			    this.handle ,
			    null == arch ? IntPtr.Zero : arch.DangerousGetHandle() ,
			    address ,
			    color.ToNative()
		    );
	    }
	    
	    public void SetUserInstructionHighlight(ulong address , HighlightColor color , Architecture? arch = null)
	    {
		    NativeMethods.BNSetUserInstructionHighlight(
			    this.handle ,
			    null == arch ? IntPtr.Zero : arch.DangerousGetHandle() ,
			    address ,
			    color.ToNative()
		    );
	    }
	    
	    public void CreateAutoStackVariable(
		    long offset ,
		    TypeWithConfidence type ,
		    string name 
	    )
	    {
		    NativeMethods.BNCreateAutoStackVariable(
			    this.handle ,
			    offset ,
			    type.ToNative() ,
			    name 
		    );
	    }
	    
	    public void CreateUserStackVariable(
		    long offset ,
		    TypeWithConfidence type ,
		    string name 
	    )
	    {
		    NativeMethods.BNCreateUserStackVariable(
			    this.handle ,
			    offset ,
			    type.ToNative() ,
			    name 
		    );
	    }
	    
	    public void DeleteAutoStackVariable(long offset)
	    {
		    NativeMethods.BNDeleteAutoStackVariable(this.handle , offset );
	    }
	    
	    public void DeleteUserStackVariable(long offset)
	    {
		    NativeMethods.BNDeleteUserStackVariable(this.handle , offset );
	    }

	    public void CreateAutoVariable(
		    AbstractVariable variable,
		    TypeWithConfidence type ,
		    string name ,
		    bool ignoreDisjointUses = false
	    )
	    {
		    NativeMethods.BNCreateAutoVariable(
			    this.handle ,
			    variable.ToNative() ,
			    type.ToNative() ,
			    name ,
			    ignoreDisjointUses
		    );
	    }
	    
	    public void CreateUserVariable(
		    AbstractVariable variable,
			TypeWithConfidence type ,
			string name ,
			bool ignoreDisjointUses = false
	    )
	    {
		    NativeMethods.BNCreateUserVariable(
			    this.handle ,
			    variable.ToNative() ,
			    type.ToNative() ,
			    name ,
			    ignoreDisjointUses
		    );
	    }

	    public void DeleteUserVariable(AbstractVariable variable)
	    {
		    NativeMethods.BNDeleteUserVariable(this.handle , variable.ToNative());
	    }
	    
	    public ReferenceSource[] CallSites
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetFunctionCallSites(
				    this.handle,
				    out ulong arrayLength
				);

			    return UnsafeUtils.TakeStructArrayEx<BNReferenceSource , ReferenceSource>(
				    arrayPointer ,
				    arrayLength ,
				    ReferenceSource.FromNative ,
				    NativeMethods.BNFreeCodeReferences
			    );
		    }
	    }

	    public Function[] Callers
	    {
		    get
		    {
			    Dictionary<ulong ,Function> functions = new Dictionary<ulong , Function>();

			    foreach (ReferenceSource callSite in this.CallSites)
			    {
				    if (null != callSite.Function)
				    {
					    functions[callSite.Function.Address] = callSite.Function;
				    }
			    }
			    
			    return functions.Values.ToArray();
		    }
	    }

	    public Function[] Callees
	    {
		    get
		    {
			    Dictionary<ulong , Function> functions = new Dictionary<ulong , Function>();

			    foreach (ReferenceSource callSite in this.CallSites)
			    {
				    Function? function = this.View.GetFunctionByAddress(callSite.Address);
				    
				    if (null != function)
				    {
					    functions[callSite.Address] = function;
				    }
			    }
			    
			    return functions.Values.ToArray();
		    }
	    }
	    
	    public ulong[] CalleeAddresses
	    {
		    get
		    {
			    HashSet<ulong> addresses = new HashSet<ulong>();

			    foreach (ReferenceSource callSite in this.CallSites)
			    {
				    addresses.Add(callSite.Address);
			    }
			    
			    return addresses.ToArray();
		    }
	    }

	    public Workflow? Workflow
	    {
		    get
		    {
			    return Workflow.TakeHandle(
				    NativeMethods.BNGetWorkflowForFunction(this.handle)
				);
		    }
	    }

	    public ILReferenceSource[] GetMediumLevelILVariableReferences(Variable variable)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetMediumLevelILVariableReferences(
			    this.handle,
			    variable.ToNative(),
			    out ulong arrayLength
			);

		    return UnsafeUtils.TakeStructArrayEx<BNILReferenceSource , ILReferenceSource>(
			    arrayPointer ,
			    arrayLength ,
			    ILReferenceSource.FromNative,
			    NativeMethods.BNFreeVariableReferenceSourceList
		    );
	    }
	    
	    public ILReferenceSource[] GetMediumLevelILVariableReferencesFrom(
		    ulong address,
		    Architecture? arch = null
		)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetMediumLevelILVariableReferencesFrom(
			    this.handle,
			    null == arch? IntPtr.Zero : arch.DangerousGetHandle(),
			    address,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArrayEx<BNILReferenceSource , ILReferenceSource>(
			    arrayPointer ,
			    arrayLength ,
			    ILReferenceSource.FromNative,
			    NativeMethods.BNFreeVariableReferenceSourceList
		    );
	    }
	    
	    public ILReferenceSource[] GetHighLevelILVariableReferencesFrom(
		    ulong address,
		    Architecture? arch = null
	    )
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetHighLevelILVariableReferencesFrom(
			    this.handle,
			    null == arch? IntPtr.Zero : arch.DangerousGetHandle(),
			    address,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArrayEx<BNILReferenceSource , ILReferenceSource>(
			    arrayPointer ,
			    arrayLength ,
			    ILReferenceSource.FromNative,
			    NativeMethods.BNFreeVariableReferenceSourceList
		    );
	    }

	    public ulong? GetInstructionContainingAddress(ulong address , Architecture? arch = null)
	    {
		    bool ok = NativeMethods.BNGetInstructionContainingAddress(
			    this.handle, 
			    null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
			    address,
			    out ulong start
			);

		    if (!ok)
		    {
			    return null;
		    }

		    return start;
	    }

	    public LinearViewObject Disassembly( DisassemblySettings? settings = null) 
	    {
		    return this.CreateLinearViewDisassembly(settings);
	    }
	    
	    public LinearViewObject CreateLinearViewDisassembly( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionDisassembly(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }
	    
	    public LinearViewObject CreateLinearViewLiftedIL( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionLiftedIL(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }

	    public LinearViewObject CreateLinearViewLowLevelIL( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionLowLevelIL(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }
	    
	    public LinearViewObject CreateLinearViewLowLevelILSSAForm( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionLowLevelILSSAForm(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }
	    
	    public LinearViewObject CreateLinearViewMediumLevelIL( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionMediumLevelIL(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }
	    
	    public LinearViewObject CreateLinearViewMediumLevelILSSAForm( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionMediumLevelILSSAForm(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }
	    
	    public LinearViewObject CreateLinearViewMappedMediumLevelIL( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionMappedMediumLevelIL(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }
	    
	    public LinearViewObject CreateLinearViewMappedMediumLevelILSSAForm( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionMappedMediumLevelILSSAForm(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }
	    
	    public LinearViewObject CreateLinearViewHighLevelIL( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionHighLevelIL(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }
	    
	    public LinearViewObject CreateLinearViewHighLevelILSSAForm( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionHighLevelILSSAForm(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }
	    
	    public LinearViewObject? CreateLinearViewLanguageRepresentation( 
		    DisassemblySettings? settings = null,
		    string language = "Pseudo C"
		) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    LanguageRepresentationFunction? pseudo = this.GetLanguageRepresentation(language);

		    if (null == pseudo)
		    {
			    return null;
		    }
		    
		    return LinearViewObject.TakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionLanguageRepresentation(
				    pseudo.OwnerFunction.DangerousGetHandle() ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle() ,
				    language
			    )
		    );
	    }

		//  disassembly
	    public LinearDisassemblyLine[] GetLinearDisassemblyLines(DisassemblySettings? settings = null)
	    {
		    LinearViewObject linear = this.CreateLinearViewDisassembly(settings);
		    
		    LinearViewCursor cursor = linear.CreateCursor();
		    
		    List<LinearDisassemblyLine> targets = new List<LinearDisassemblyLine>();
		    
		    cursor.SeekToAddress(this.LowestAddress);
		    foreach (LinearDisassemblyLine line in cursor.PreviousLines)
		    {
			    if (!targets.Contains(line))
			    {
				    targets.Add(line);
			    }
		    }
		    
		    cursor.SeekToAddress(this.HighestAddress);
		    foreach (LinearDisassemblyLine line in cursor.NextLines)
		    {
			    if (!targets.Contains(line))
			    {
				    targets.Add(line);
			    }
		    }

		    return targets.ToArray();
	    }
	    
	    public LinearDisassemblyLine[] LinearDisassemblyLines
	    {
		    get
		    {
			    return this.GetLinearDisassemblyLines();
		    }
	    }
	    
	    public string GetLinearDisassemblyText(DisassemblySettings? settings = null)
	    {
		    StringBuilder builder = new StringBuilder();

		    LinearDisassemblyLine[] lines = this.GetLinearDisassemblyLines(settings);

		    for (int i = 0; i < lines.Length; i++)
		    {
			    if (i == ( lines.Length - 1 ))
			    {
				    builder.Append(lines[i].ToString());
			    }
			    else
			    {
				    builder.AppendLine(lines[i].ToString());
			    }
		    }
		
		    return builder.ToString();
	    }
	    
	    public string LinearDisassemblyText
	    {
		    get
		    {
			    return this.GetLinearDisassemblyText();
		    }
	    }
	    
	    public PluginCommand[] PluginCommands
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForFunction(
				    this.View.DangerousGetHandle(),
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

	    public string[] PluginCommandNames
	    {
		    get
		    {
			    List<string> items = new List<string>();

			    foreach (PluginCommand command in this.PluginCommands)
			    {
				    if (!items.Contains(command.Name))
				    {
					    items.Add(command.Name);
				    }
			    }
			    
			    return items.ToArray();
		    }
	    }

	    public PluginCommand? GetPluginCommandByName(string name)
	    {
		    foreach (PluginCommand command in this.PluginCommands)
		    {
			    if (name == command.Name)
			    {
				    return  command;
			    }
		    }

		    return null;
	    }

	    public string GetVariableNameOrDefault(CoreVariable variable)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetVariableNameOrDefault(
				    this.handle ,
				    variable.ToNative()
			    )
		    );
	    }
	    
	    public string GetLastSeenVariableNameOrDefault(CoreVariable variable)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetLastSeenVariableNameOrDefault(
				    this.handle ,
				    variable.ToNative()
			    )
		    );
	    }
	    
	    public DisassemblyTextLine[] GetTypeTokens(DisassemblySettings? settings = null)
	    {
		    ulong arrayLength = 0;
			
		    IntPtr arrayPointer = NativeMethods.BNGetFunctionTypeTokens(
			    this.handle ,
			    null == settings ? IntPtr.Zero :  settings.DangerousGetHandle() ,
			    out arrayLength
		    );

		    return UnsafeUtils.TakeStructArrayEx<BNDisassemblyTextLine , DisassemblyTextLine>(
			    arrayPointer ,
			    arrayLength ,
			    DisassemblyTextLine.FromNative ,
			    NativeMethods.BNFreeDisassemblyTextLines
		    );
	    }

	    public DisassemblyTextLine[] TypeTokens
	    {
		    get
		    {
			    return this.GetTypeTokens();
		    }
	    }
		
	    public VariableNameAndType? ChooseVariable(string prompt = "Choose" , string title = "Choose a variable")
	    {
		    string[] names = this.VariableNames;
		    
		    int? index = Core.GetLargeChoiceInput(
			    prompt ,
			    title ,
			    names
		    );

		    if (null == index)
		    {
			    return null;
		    }
		    
		    return this.GetVariableByName(names[(int)index]);
	    }
	    
	    public PluginCommand? ChoosePluginCommand(string prompt = "Choose" , string title = "Choose a plugin command")
	    {
		    string[] names = this.PluginCommandNames;
		    
		    int? index = Core.GetLargeChoiceInput(
			    prompt ,
			    title ,
			    names
		    );

		    if (null == index)
		    {
			    return null;
		    }
		    
		    return this.GetPluginCommandByName(names[(int)index]);
	    }
	}
}