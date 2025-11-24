using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class Architecture : AbstractSafeHandle<Architecture>
	{
		internal Architecture(IntPtr handle)
			:base(handle, false)
	    {
		    
	    }
		
		internal static Architecture? FromHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new Architecture(handle);
		}
	    
		internal static Architecture MustFromHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new Architecture(handle);
		}
		
		public static Architecture? FromName(string name)
		{
			return Architecture.FromHandle(
				NativeMethods.BNGetArchitectureByName(name)
			);
		}
		
		public static Architecture[] GetAllArchitectures()
		{
			IntPtr arrayPointer = NativeMethods.BNGetArchitectureList(
				out ulong arrayLength
			);

			return UnsafeUtils.TakeHandleArray(
				arrayPointer ,
				arrayLength ,
				Architecture.MustFromHandle ,
				NativeMethods.BNFreeArchitectureList
			);
		}
	  
		public static Architecture NativeTypeParserArchitecture()
		{
			return Architecture.MustFromHandle(
				NativeMethods.BNGetNativeTypeParserArchitecture()
			);
		}
		
		public override string ToString()
		{
			return this.Name;
		}

		public string Name
	    {
		    get
		    {
			    IntPtr raw = NativeMethods.BNGetArchitectureName(this.handle);

			    return UnsafeUtils.TakeAnsiString(raw);
		    }
	    }
	    
	    public Endianness Endianness
	    {
		    get
		    {
			    return NativeMethods.BNGetArchitectureEndianness(this.handle);;
		    }
	    }
	    
	    public ulong AddressSize
	    {
		    get
		    {
			    return NativeMethods.BNGetArchitectureAddressSize(this.handle);;
		    }
	    }
	    
	    public ulong DefaultIntegerSize
	    {
		    get
		    {
			    return NativeMethods.BNGetArchitectureDefaultIntegerSize(this.handle);;
		    }
	    }
	    
	    public ulong InstructionAlignment
	    {
		    get
		    {
			    return NativeMethods.BNGetArchitectureInstructionAlignment(this.handle);;
		    }
	    }
	    
	    public ulong MaxInstructionLength
	    {
		    get
		    {
			    return NativeMethods.BNGetArchitectureMaxInstructionLength(this.handle);;
		    }
	    }
	    
	    public ulong OpcodeDisplayLength
	    {
		    get
		    {
			    return NativeMethods.BNGetArchitectureOpcodeDisplayLength(this.handle);;
		    }
	    }
	    
	    public ILRegister[] FullWidthRegisters
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetFullWidthArchitectureRegisters(
				    this.handle ,
				    out ulong arrayLength
			    );

			    uint[] indexes = UnsafeUtils.TakeNumberArray<uint>(
				    arrayPointer ,
				    arrayLength ,
				    NativeMethods.BNFreeRegisterList
			    );
			    
			    List<ILRegister> targets = new List<ILRegister>();

			    foreach (RegisterIndex index in indexes)
			    {
				    targets.Add( new ILRegister(this , index) );
			    }

			    return targets.ToArray();
		    }
	    }
	    
	    public ILRegister[] Registers
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetAllArchitectureRegisters(
				    this.handle ,
				    out ulong arrayLength
			    );

			    uint[] indexes = UnsafeUtils.TakeNumberArray<uint>(
				    arrayPointer ,
				    arrayLength ,
				    NativeMethods.BNFreeRegisterList
			    );
			    
			    List<ILRegister> targets = new List<ILRegister>();

			    foreach (RegisterIndex index in indexes)
			    {
				    targets.Add( new ILRegister(this , index) );
			    }

			    return targets.ToArray();
		    }
	    }
	    
	    public ILRegister[] GlobalRegister
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetArchitectureGlobalRegisters(
				    this.handle ,
				    out ulong arrayLength
			    );

			    uint[] indexes = UnsafeUtils.TakeNumberArray<uint>(
				    arrayPointer ,
				    arrayLength ,
				    NativeMethods.BNFreeRegisterList
			    );
			    
			    List<ILRegister> targets = new List<ILRegister>();

			    foreach (RegisterIndex index in indexes)
			    {
				    targets.Add( new ILRegister(this , index) );
			    }

			    return targets.ToArray();
		    }
	    }
	    
	    public ILRegister[] SystemRegister
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetArchitectureSystemRegisters(
				    this.handle ,
				    out ulong arrayLength
			    );

			    uint[] indexes = UnsafeUtils.TakeNumberArray<uint>(
				    arrayPointer ,
				    arrayLength ,
				    NativeMethods.BNFreeRegisterList
			    );
			    
			    List<ILRegister> targets = new List<ILRegister>();

			    foreach (RegisterIndex index in indexes)
			    {
				    targets.Add( new ILRegister(this , index) );
			    }

			    return targets.ToArray();
		    }
	    }
	    
	    public ILFlag[] Flags
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetAllArchitectureFlags(
				    this.handle ,
				    out ulong arrayLength
			    );

			    uint[] indexes = UnsafeUtils.TakeNumberArray<uint>(
				    arrayPointer ,
				    arrayLength ,
				    NativeMethods.BNFreeRegisterList
			    );
			    
			    List<ILFlag> targets = new List<ILFlag>();

			    foreach (FlagIndex index in indexes)
			    {
				    targets.Add( new ILFlag(this , index) );
			    }

			    return targets.ToArray();
		    }
	    }
	    
	    public uint[] FlagWriteTypes
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetAllArchitectureFlagWriteTypes(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeNumberArray<uint>(
				    arrayPointer ,
				    arrayLength ,
				    NativeMethods.BNFreeRegisterList
			    );
		    }
	    }
	    
	    public SemanticFlagClass[] SemanticFlagClasses
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetAllArchitectureSemanticFlagClasses(
				    this.handle ,
				    out ulong arrayLength
			    );

			    uint[] indexes = UnsafeUtils.TakeNumberArray<uint>(
				    arrayPointer ,
				    arrayLength ,
				    NativeMethods.BNFreeRegisterList
			    );
			    
			    List<SemanticFlagClass> targets = new List<SemanticFlagClass>();

			    foreach (SemanticFlagClassIndex index in indexes)
			    {
				    targets.Add( new SemanticFlagClass(this , index) );
			    }

			    return targets.ToArray();
		    }
	    }
	    
	    public SemanticFlagGroup[] SemanticFlagGroups
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetAllArchitectureSemanticFlagGroups(
				    this.handle ,
				    out ulong arrayLength
			    );

			    uint[] indexes = UnsafeUtils.TakeNumberArray<uint>(
				    arrayPointer ,
				    arrayLength ,
				    NativeMethods.BNFreeRegisterList
			    );
			    
			    List<SemanticFlagGroup> targets = new List<SemanticFlagGroup>();

			    foreach (SemanticFlagGroupIndex index in indexes)
			    {
				    targets.Add( new SemanticFlagGroup(this , index) );
			    }

			    return targets.ToArray();
		    }
	    }

	    public BinaryNinja.CallingConvention[] CallingConventions
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetArchitectureCallingConventions(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeHandleArrayEx<BinaryNinja.CallingConvention>(
				    arrayPointer ,
				    arrayLength ,
				    BinaryNinja.CallingConvention.MustNewFromHandle ,
				    NativeMethods.BNFreeCallingConventionList
			    );
		    }
	    }

	    public Platform StandalonePlatform
	    {
		    get
		    {
			    return Platform.MustTakeHandle(
				    NativeMethods.BNGetArchitectureStandalonePlatform(this.handle )
			    );
		    }
	    }

	    public TypeLibrary[] TypeLibrares
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetArchitectureTypeLibraries(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeHandleArrayEx<TypeLibrary>(
				    arrayPointer ,
				    arrayLength ,
				    TypeLibrary.MustNewFromHandle,
				    NativeMethods.BNFreeTypeLibraryList
			    );
		    }
	    }
	    
	    public bool CanAssemble
	    {
		    get
		    {
			    return NativeMethods.BNCanArchitectureAssemble(this.handle);
		    }
	    }
	    
	    
	    public string GetFlagName(FlagIndex flag)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetArchitectureFlagName(this.handle, flag)
		    );
	    }
	    
	    public string GetFlagWriteTypeName(uint flags)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetArchitectureFlagWriteTypeName(this.handle, flags)
		    );
	    }
	    
	    public string GetSemanticFlagClassName(SemanticFlagClassIndex semClass)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetArchitectureSemanticFlagClassName(this.handle, semClass)
		    );
	    }
	    
	    public string GetSemanticFlagGroupName(SemanticFlagGroupIndex semGroup)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetArchitectureSemanticFlagGroupName(this.handle, semGroup)
		    );
	    }

	    public FlagRole GetFlagRole(uint flag , uint semClass)
	    {
		    return NativeMethods.BNGetArchitectureFlagRole(this.handle, flag, semClass);
	    }

	    public uint[] GetFlagsRequiredForFlagCondition(
		    LowLevelILFlagCondition condition,
		    uint semClass
		)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetArchitectureFlagsRequiredForFlagCondition(
			    this.handle ,
			    condition ,
			    semClass ,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeNumberArray<uint>(
			    arrayPointer ,
			    arrayLength ,
			    NativeMethods.BNFreeRegisterList
		    );
	    }
	    
	    public uint[] GetFlagsRequiredForSemanticFlagGroup(
		    uint semGroup
	    )
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetArchitectureFlagsRequiredForSemanticFlagGroup(
			    this.handle ,
			    semGroup,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeNumberArray<uint>(
			    arrayPointer ,
			    arrayLength ,
			    NativeMethods.BNFreeRegisterList
		    );
	    }
	    
	    public FlagConditionForSemanticClass[] GetFlagConditionsForSemanticFlagGroup(uint semGroup)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetArchitectureFlagConditionsForSemanticFlagGroup(
			    this.handle ,
			    semGroup,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArray<BNFlagConditionForSemanticClass,FlagConditionForSemanticClass>(
			    arrayPointer ,
			    arrayLength ,
			    FlagConditionForSemanticClass.FromNative,
			    NativeMethods.BNFreeFlagConditionsForSemanticFlagGroup
		    );
	    }

	    public uint[] GetFlagsWrittenByFlagWriteType(uint writeType)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetArchitectureFlagsWrittenByFlagWriteType(
			    this.handle ,
			    writeType,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeNumberArray<uint>(
			    arrayPointer ,
			    arrayLength ,
			    NativeMethods.BNFreeRegisterList
		    );
	    }
	    
	    public uint GetSemanticClassForFlagWriteType(uint writeType)
	    {
		    return NativeMethods.BNGetArchitectureSemanticClassForFlagWriteType(
			    this.handle ,
			    writeType
		    );
	    }
	    
	 
	    

	    public bool GetInstructionInfo(
		    byte[] data ,
		    ulong address ,
		    ulong maxLength ,
		    out InstructionInfo info
	    )
	    {
		    bool ok = false;

		    BNInstructionInfo raw;

		    ok = NativeMethods.BNGetInstructionInfo(
			    this.handle ,
			    data ,
			    address ,
			    maxLength ,
			    out raw
		    );

		    if (ok)
		    {
			    info = InstructionInfo.FromNative(raw);
		    }
		    else
		    {
			    info = new InstructionInfo();
		    }
		    
		    return ok;
	    }
	    
	    public InstructionTextToken[] GetInstructionText(byte[]data , ulong address , ref ulong length )
	    {
		    IntPtr arrayPointer = IntPtr.Zero;

		    ulong arrayLength = 0;

		    bool ok = false;

		    length = (ulong)data.Length;

		    ok = NativeMethods.BNGetInstructionText(
			    this.handle ,
			    data ,
			    address ,
			    ref length ,
			    out arrayPointer ,
			    out arrayLength 
		    );

		    InstructionTextToken[] tokens = Array.Empty<InstructionTextToken>();
		
		    if (ok )
		    {
			    tokens = UnsafeUtils.TakeStructArrayEx<BNInstructionTextToken ,InstructionTextToken>(
				    arrayPointer ,
				    arrayLength,
				    InstructionTextToken.FromNative,
				    NativeMethods.BNFreeInstructionText
			    );
		    }

		    return tokens;
	    }

	    public string GetRegisterName(RegisterIndex reg)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetArchitectureRegisterName(this.handle, reg)
		    );
	    }
	    
	    public RegisterInfo GetRegisterInfo(RegisterIndex reg)
	    {
		    return RegisterInfo.FromNative(
			    NativeMethods.BNGetArchitectureRegisterInfo(this.handle , reg)
		    );
	    }
	    
	    public ILRegister GetRegisterByName(string name)
	    {
		    return new ILRegister(
			    this ,
			    NativeMethods.BNGetArchitectureRegisterByName(this.handle , name)
		    );
	    }
	    
	    public string GetRegisterStackName(RegisterStackIndex regStack)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetArchitectureRegisterStackName(this.handle, regStack)
		    );
	    }
	    
	    public ulong? GetInstructionLowLevelIL(
		    byte[] data , 
		    ulong address ,
		    LowLevelILFunction function
	    )
	    {
		    ulong size = (ulong)data.Length;
		    
		    bool ok = NativeMethods.BNGetInstructionLowLevelIL(
			    this.handle,
			    data ,
			    address,
			    ref size,
			    function.DangerousGetHandle()
		    );

		    if (!ok)
		    {
			    return null;
		    }

		    return size;
	    }

	    public ulong GetFlagWriteLowLevelIL(
		    LowLevelILOperation operation,
		    ulong size ,
		    uint flagWriteType ,
		    uint flag,
		    RegisterOrConstant[] operands,
		    LowLevelILFunction il
		)
	    {
		    return NativeMethods.BNGetArchitectureFlagWriteLowLevelIL(
			    this.handle ,
			    operation ,
			    size ,
			    flagWriteType ,
			    flag ,
			    UnsafeUtils.ConvertToNativeArray<BNRegisterOrConstant , RegisterOrConstant>(operands) ,
			    (uint)operands.Length ,
			    il.DangerousGetHandle()
		    );
	    }
	    
	    public ulong GetDefaultFlagWriteLowLevelIL(
		    LowLevelILOperation operation,
		    ulong size ,
		    FlagRole role ,
		    RegisterOrConstant[] operands,
		    LowLevelILFunction il
	    )
	    {
		    return NativeMethods.BNGetDefaultArchitectureFlagWriteLowLevelIL(
			    this.handle ,
			    operation ,
			    size ,
			    role,
			    UnsafeUtils.ConvertToNativeArray<BNRegisterOrConstant , RegisterOrConstant>(operands) ,
			    (uint)operands.Length ,
			    il.DangerousGetHandle()
		    );
	    }
	    
	    public ulong GetFlagConditionLowLevelIL(
		    LowLevelILFlagCondition condition,
		    uint semClass,
		    LowLevelILFunction il
	    )
	    {
		    return NativeMethods.BNGetArchitectureFlagConditionLowLevelIL(
			    this.handle ,
			    condition,
			    semClass,
			    il.DangerousGetHandle()
		    );
	    }
	    
	    public ulong GetSemanticFlagGroupLowLevelIL(
		    uint semGroup,
		    LowLevelILFunction il
	    )
	    {
		    return NativeMethods.BNGetArchitectureSemanticFlagGroupLowLevelIL(
			    this.handle ,
			    semGroup,
			    il.DangerousGetHandle()
		    );
	    }
	    
	    public uint[] GetModifiedRegistersOnWrite(uint reg)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetModifiedArchitectureRegistersOnWrite(
			    this.handle ,
			    reg,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeNumberArray<uint>(
			    arrayPointer ,
			    arrayLength ,
			    NativeMethods.BNFreeRegisterList
		    );
	    }
	    
	    public Architecture? GetAssociatedArchitectureByAddress(ref ulong address)
	    {
		    return Architecture.FromHandle(
			    NativeMethods.BNGetAssociatedArchitectureByAddress(this.handle , ref address)
		    );
	    }

	    
	    public bool Assemble(
		    string code , 
		    ulong address , 
		    out byte[] data,
		    out string errors
		)
	    {
		    DataBuffer buffer = new DataBuffer( Array.Empty<byte>());
		    
		    IntPtr errorPtr = IntPtr.Zero;

		    bool ok = false;

		    data = Array.Empty<byte>();
		    
		    errors = "";
		    
		    ok = NativeMethods.BNAssemble(
			    this.handle ,
			    code ,
			    address ,
			    buffer.DangerousGetHandle() ,
			    out errorPtr
		    );

		    errors = UnsafeUtils.TakeAnsiString(errorPtr);

		    if (ok)
		    {
			    data = buffer.Contents;
		    }
		    
		    return ok;
	    }

	    public bool IsNeverBranchPatchAvailable(byte[] data , ulong address)
	    {
		    return NativeMethods.BNIsArchitectureNeverBranchPatchAvailable(
			    this.handle ,
			    data ,
			    address ,
			    (ulong)data.Length
		    );
	    }
	    
	    public bool IsAlwaysBranchPatchAvailable(byte[] data , ulong address)
	    {
		    return NativeMethods.BNIsArchitectureAlwaysBranchPatchAvailable(
			    this.handle ,
			    data ,
			    address ,
			    (ulong)data.Length
		    );
	    }
	    
	    public bool IsInvertBranchPatchAvailable(byte[] data , ulong address)
	    {
		    return NativeMethods.BNIsArchitectureInvertBranchPatchAvailable(
			    this.handle ,
			    data ,
			    address ,
			    (ulong)data.Length
		    );
	    }
	    
	    public bool IsSkipAndReturnZeroPatchAvailable(byte[] data , ulong address)
	    {
		    return NativeMethods.BNIsArchitectureSkipAndReturnZeroPatchAvailable(
			    this.handle ,
			    data ,
			    address ,
			    (ulong)data.Length
		    );
	    }
	    
	    public bool IsSkipAndReturnValuePatchAvailable(byte[] data , ulong address)
	    {
		    return NativeMethods.BNIsArchitectureSkipAndReturnValuePatchAvailable(
			    this.handle ,
			    data ,
			    address ,
			    (ulong)data.Length
		    );
	    }
	    
	    public bool ConvertToNop(byte[] data , ulong address)
	    {
		    return NativeMethods.BNArchitectureConvertToNop(
			    this.handle ,
			    data ,
			    address ,
			    (ulong)data.Length
		    );
	    }
	    
	    public bool AlwaysBranch(byte[] data , ulong address)
	    {
		    return NativeMethods.BNArchitectureAlwaysBranch(
			    this.handle ,
			    data ,
			    address ,
			    (ulong)data.Length
		    );
	    }
	    
	    public bool InvertBranch(byte[] data , ulong address)
	    {
		    return NativeMethods.BNArchitectureInvertBranch(
			    this.handle ,
			    data ,
			    address ,
			    (ulong)data.Length
		    );
	    }
	    
	    public bool SkipAndReturnValue(byte[] data , ulong address , ulong _value)
	    {
		    return NativeMethods.BNArchitectureSkipAndReturnValue(
			    this.handle ,
			    data ,
			    address ,
			    (ulong)data.Length,
			    _value
		    );
	    }
	    
	    public TypeLibrary? LookupTypeLibraryByName(string name)
	    {
		    IntPtr raw = NativeMethods.BNLookupTypeLibraryByName(this.handle ,name);

		    if (IntPtr.Zero == raw)
		    {
			    return null;
		    }
		    
		    return new TypeLibrary(raw, true);
	    }
	    
	    public TypeLibrary? LookupTypeLibraryByGuid(string name)
	    {
		    IntPtr raw = NativeMethods.BNLookupTypeLibraryByGuid(this.handle ,name);

		    if (IntPtr.Zero == raw)
		    {
			    return null;
		    }
		    
		    return new TypeLibrary(raw, true);
	    }

	    public Intrinsic[] Intrinsics
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetAllArchitectureIntrinsics(
				    this.handle ,
				    out ulong arrayLength
			    );

			    uint[] indexes = UnsafeUtils.TakeNumberArray<uint>(
				    arrayPointer ,
				    arrayLength ,
				    NativeMethods.BNFreeRegisterList
			    );
			    
			    List<Intrinsic> targets = new List<Intrinsic>();

			    foreach (IntrinsicIndex index in indexes)
			    {
				    targets.Add(
					    new Intrinsic(this , index)
				    );
			    }

			    return targets.ToArray();
		    }
	    }
	    
	    public void FinalizeArchitectureHook()
	    {
		    NativeMethods.BNFinalizeArchitectureHook(this.handle);
	    }

	    public ILRegister StackPointerRegister
	    {
		    get
		    {
			    return new ILRegister(
				    this ,
				    (RegisterIndex)NativeMethods.BNGetArchitectureStackPointerRegister(this.handle)
			    );
		    }
	    }

	    
	}
	
}