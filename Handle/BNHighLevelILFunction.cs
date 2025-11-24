using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class HighLevelILFunction : AbstractSafeHandle<HighLevelILFunction>
	{
		public bool IsSSAForm { get; } = false;
			
	    internal HighLevelILFunction( 
		    IntPtr handle , 
		    bool owner ,
		    bool ssa = false
		) : base(handle , owner)
	    {
		    this.IsSSAForm = ssa;
	    }
	    
	    internal static HighLevelILFunction? NewFromHandle(IntPtr handle ,  bool ssa = false)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new HighLevelILFunction(
			    NativeMethods.BNNewHighLevelILFunctionReference(handle) ,
			    true,
			    ssa
		    );
	    }
	    
	    internal static HighLevelILFunction MustNewFromHandle(IntPtr handle,  bool ssa = false)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new HighLevelILFunction(
			    NativeMethods.BNNewHighLevelILFunctionReference(handle) ,
			    true,
			    ssa
		    );
	    }
	    
	    internal static HighLevelILFunction? TakeHandle(IntPtr handle,  bool ssa = false)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new HighLevelILFunction(handle, true , ssa);
	    }
	    
	    internal static HighLevelILFunction MustTakeHandle(IntPtr handle,  bool ssa = false)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new HighLevelILFunction(handle, true , ssa);
	    }
	    
	    internal static HighLevelILFunction? BorrowHandle(IntPtr handle,  bool ssa = false)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new HighLevelILFunction(handle, false , ssa);
	    }
	    
	    internal static HighLevelILFunction MustBorrowHandle(IntPtr handle , bool ssa = false)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new HighLevelILFunction(handle, false , ssa);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeHighLevelILFunction(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	    
	    public Function OwnerFunction
	    {
		    get
		    {
			    return Function.MustTakeHandle(
				    NativeMethods.BNGetHighLevelILOwnerFunction(this.handle) 
			    );
		    }
	    }

	    public ulong ExpressionCount
	    {
		    get
		    {
			    return NativeMethods.BNGetHighLevelILExprCount(this.handle);
		    }
	    }
	    
	    public ulong InstructionCount
	    {
		    get
		    {
			    return NativeMethods.BNGetHighLevelILInstructionCount(this.handle);
		    }
	    }

	    public HighLevelILInstruction? GetExpression(
		    HighLevelILExpressionIndex index ,
		    bool asFullAst = false
	    )
	    {
		    if ((ulong)index >= this.ExpressionCount)
		    {
			    return null;
		    }
		    
		    return HighLevelILInstruction.FromExpressionIndex(
			    this,
			    index ,
			    asFullAst
		    );
	    }
	    
	    public HighLevelILInstruction MustGetExpression(
		    HighLevelILExpressionIndex index ,
		    bool asFullAst = false
		)
	    {
		    if ((ulong)index >= this.ExpressionCount)
		    {
			    throw new ArgumentOutOfRangeException(nameof(index));
		    }
		    
		    return HighLevelILInstruction.FromExpressionIndex(
			    this,
			    index ,
			    asFullAst
			);
	    }
	    
	    public HighLevelILInstruction? GetInstruction(
		    HighLevelILInstructionIndex index ,
		    bool asFullAst = false
	    )
	    {
		    if ((ulong)index >= this.InstructionCount)
		    {
			    return null;
		    }
		  
		    return HighLevelILInstruction.FromExpressionIndex(
			    this,
			    NativeMethods.BNGetHighLevelILIndexForInstruction(this.handle , index) ,
			    asFullAst
		    );
	    }
	    
	    public HighLevelILInstruction MustGetInstruction(
		    HighLevelILInstructionIndex index ,
		    bool asFullAst = false
	    )
	    {
		    if ((ulong)index >= this.InstructionCount)
		    {
			    throw new ArgumentOutOfRangeException(nameof(index));
		    }
		    
		    return HighLevelILInstruction.FromExpressionIndex(
			    this,
			    NativeMethods.BNGetHighLevelILIndexForInstruction(this.handle , index) ,
			    asFullAst
		    );
	    }
	    
	    public HighLevelILInstruction[] MustGetExpressions(HighLevelILExpressionIndex[] indexes)
	    {
		    List<HighLevelILInstruction> instructions = new List<HighLevelILInstruction>();

		    foreach (HighLevelILExpressionIndex index in indexes)
		    {
			    instructions.Add( this.MustGetExpression(index) );
		    }

		    return instructions.ToArray();
	    }
	    
	    public HighLevelILInstruction[] MustGetInstructions(HighLevelILInstructionIndex[] indexes)
	    {
		    List<HighLevelILInstruction> instructions = new List<HighLevelILInstruction>();

		    foreach (HighLevelILInstructionIndex index in indexes)
		    {
			    instructions.Add( this.MustGetInstruction(index) );
		    }

		    return instructions.ToArray();
	    }

	    public HighLevelILBasicBlock[] BasicBlocks
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetHighLevelILBasicBlockList(
				    this.handle ,
				    out ulong arrayLength
				);

			    return UnsafeUtils.TakeHandleArrayEx<HighLevelILBasicBlock>(
				    arrayPointer ,
				    arrayLength ,
				    (_native) => HighLevelILBasicBlock.MustNewFromHandleEx(
					    this, 
					    _native
					) ,
				    NativeMethods.BNFreeBasicBlockList
			    );
		    }
	    }
	    
	    public ulong CurrentAddress
	    {
		    get
		    {
			    return NativeMethods.BNHighLevelILGetCurrentAddress(this.handle);
		    }

		    set
		    {
			    this.SetCurrentAddress(value);
		    }
	    }

	    public void SetCurrentAddress(ulong address , Architecture? arch = null)
	    {
		    NativeMethods.BNHighLevelILSetCurrentAddress(
			    this.handle, 
			    null == arch ? IntPtr.Zero : arch.DangerousGetHandle(),
			    address 
		    );
	    }

	    public HighLevelILInstruction? RootExpression
	    {
		    get
		    {
			    return this.GetExpression(
				    NativeMethods.BNGetHighLevelILRootExpr(this.handle)
			    );
		    }

		    set
		    {
			    if (null != value)
			    {
				    NativeMethods.BNSetHighLevelILRootExpr(this.handle , value!.ExpressionIndex);
			    }
		    }
	    }

	    public HighLevelILBasicBlock? GetBasicBlockForInstruction(HighLevelILInstructionIndex instruction)
	    {
		    return HighLevelILBasicBlock.TakeHandleEx(
			    this,
			    NativeMethods.BNGetHighLevelILBasicBlockForInstruction(
				    this.handle ,
				    instruction
			    )
		    );
	    }
	    
	    public IEnumerable<HighLevelILInstruction> Instructions
	    {
		    get
		    {
			    for (ulong index = 0; index < this.InstructionCount; index++)
			    {
				    yield return this.MustGetInstruction( (HighLevelILInstructionIndex)index);
			    }
		    }
	    }

	    public HighLevelILFunction SSAForm
	    {
		    get
		    {
			    if (this.IsSSAForm)
			    {
				    return this;
			    }
			    
			    return HighLevelILFunction.MustTakeHandle(
				    NativeMethods.BNGetHighLevelILSSAForm(this.handle),
				    true
			    );
		    }
	    }

	    public HighLevelILFunction? NonSSAForm
	    {
		    get
		    {
			    if (!this.IsSSAForm)
			    {
				    return this;
			    }
			    
			    return HighLevelILFunction.TakeHandle(
				    NativeMethods.BNGetHighLevelILNonSSAForm(this.handle),
				    false
			    );
		    }
	    }
	    
	    public MediumLevelILFunction? MediumLevelIL
	    {
		    get
		    {
			    return MediumLevelILFunction.TakeHandle(
				    NativeMethods.BNGetMediumLevelILForHighLevelILFunction(this.handle),
				    this.IsSSAForm
			    );
		    }
	    }
	    
	    public MediumLevelILFunction? MediumLevelILSSAForm
	    {
		    get
		    {
			    return this.MediumLevelIL?.SSAForm;
		    }
	    }
	    
	    public MediumLevelILFunction? MediumLevelILNonSSAForm
	    {
		    get
		    {
			    return this.MediumLevelIL?.NonSSAForm;
		    }
	    }
	    
	    public LowLevelILFunction? LowLevelIL
	    {
		    get
		    {
			    return this.MediumLevelIL?.LowLevelIL;
		    }
	    }
	    
	    public LanguageRepresentationFunction? PseudoC
	    {
		    get
		    {
			    return this.GetLanguageRepresentation("Pseudo C");
		    }
	    }
	    
	    public LanguageRepresentationFunction? GetLanguageRepresentation(string language = "Pseudo C")
	    {
		    return LanguageRepresentationFunction.TakeHandle(
			    NativeMethods.BNGetFunctionLanguageRepresentation(
				    this.OwnerFunction.DangerousGetHandle() ,
				    language
				)
		    );
	    }
	    
	    public LanguageRepresentationFunction? GetLanguageRepresentationIfAvailable(string language = "Pseudo C")
	    {
		    return LanguageRepresentationFunction.TakeHandle(
			    NativeMethods.BNGetFunctionLanguageRepresentationIfAvailable(
				    this.OwnerFunction.DangerousGetHandle(),
				    language
				)
		    );
	    }

	    public HighLevelILInstructionIndex? GetSSAInstructionIndex(HighLevelILInstructionIndex instruction)
	    {
		    HighLevelILInstructionIndex index = NativeMethods.BNGetHighLevelILSSAInstructionIndex(
			    this.handle ,
			    instruction
		    );

		    if ((ulong)index >= this.ExpressionCount)
		    {
			    return null;
		    }

		    return index;
	    }
	    
	    public HighLevelILInstructionIndex? GetNonSSAInstructionIndex(HighLevelILInstructionIndex instruction)
	    {
		    HighLevelILInstructionIndex index = NativeMethods.BNGetHighLevelILNonSSAInstructionIndex(
			    this.handle ,
			    instruction
		    );

		    if ((ulong)index >= this.ExpressionCount)
		    {
			    return null;
		    }

		    return index;
	    }

	    public HighLevelILInstruction? GetSSAVariableDefinition(Variable variable , ulong version)
	    {
		    return this.GetExpression(
			    NativeMethods.BNGetHighLevelILSSAVarDefinition(
				    this.handle ,
				    variable.ToNative() ,
				    version
			    )
		    );
	    }
	    
	    public HighLevelILInstruction[] GetSSAVariableUses(Variable variable , ulong version)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetHighLevelILSSAVarUses(
			    this.handle ,
			    variable.ToNative() ,
			    version ,
			    out ulong arrayLength
		    );

		    ulong[] indexes = UnsafeUtils.TakeNumberArray<ulong>(
			    arrayPointer ,
			    arrayLength ,
			    NativeMethods.BNFreeILInstructionList
		    );
		    
		    List<HighLevelILInstruction>  instructions = new List<HighLevelILInstruction>();

		    foreach (HighLevelILExpressionIndex index in indexes)
		    {
			    instructions.Add(
				    this.MustGetExpression(index)
				 );
		    }
		    
		    return instructions.ToArray();
	    }
	    
	    public HighLevelILInstruction? GetSSAMemoryDefinition(ulong version)
	    {
		    return this.GetExpression(
			    NativeMethods.BNGetHighLevelILSSAMemoryDefinition(
				    this.handle ,
				    version
			    )
		    );
	    }
	    
	    public HighLevelILInstruction[] GetSSAMemoryUses( ulong version)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetHighLevelILSSAMemoryUses(
			    this.handle ,
			    version ,
			    out ulong arrayLength
		    );

		    ulong[] indexes = UnsafeUtils.TakeNumberArray<ulong>(
			    arrayPointer ,
			    arrayLength ,
			    NativeMethods.BNFreeILInstructionList
		    );
		    
		    List<HighLevelILInstruction>  instructions = new List<HighLevelILInstruction>();

		    foreach (HighLevelILExpressionIndex index in indexes)
		    {
			    instructions.Add(
				    this.MustGetExpression(index)
			    );
		    }
		    
		    return instructions.ToArray();
	    }

	    public bool IsSSAVariableLive(Variable variable , ulong version)
	    {
		    return NativeMethods.BNIsHighLevelILSSAVarLive(
			    this.handle ,
			    variable.ToNative() ,
			    version
		    );
	    }
	    
	    public bool IsVariableLiveAt(Variable variable , HighLevelILInstructionIndex instruction)
	    {
		    return NativeMethods.BNIsHighLevelILVarLiveAt(
			    this.handle ,
			    variable.ToNative() ,
			    instruction
		    );
	    }
	    
	    public bool IsSSAVariableLiveAt(Variable variable ,ulong version, HighLevelILInstructionIndex instruction)
	    {
		    return NativeMethods.BNIsHighLevelILSSAVarLiveAt(
			    this.handle ,
			    variable.ToNative() ,
			    version,
			    instruction
		    );
	    }
	    
	 
	    public void ReplaceExpression(HighLevelILExpressionIndex oldExpr , HighLevelILExpressionIndex newExpr)
	    {
		    NativeMethods.BNReplaceHighLevelILExpr(
			    this.handle ,
			    oldExpr ,
			    newExpr
		    );
	    }

	    public void SetExpressionAttributes(HighLevelILExpressionIndex expression , uint attributes)
	    {
		    NativeMethods.BNSetHighLevelILExprAttributes(
			    this.handle ,
			    expression ,
			    attributes
		    );
	    }
	    
	    public LinearViewObject CreateLinearView( DisassemblySettings? settings = null) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
		    }
		    
		    if (this.IsSSAForm)
		    {
			    return LinearViewObject.MustTakeHandle(
				    NativeMethods.BNCreateLinearViewSingleFunctionHighLevelILSSAForm(
					    this.handle ,
					    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				    )
			    );
		    }
		    else
		    {
			    return LinearViewObject.MustTakeHandle(
				    NativeMethods.BNCreateLinearViewSingleFunctionHighLevelIL(
					    this.handle ,
					    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
				    )
			    );
		    }
	    }

	    public PluginCommand[] ValidPluginCommands
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForHighLevelILFunction(
						this.OwnerFunction.View.DangerousGetHandle(),
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
	    
	    public HighLevelILExpressionIndex AddOperandList(ulong[] operands)
	    {
		    return NativeMethods.BNHighLevelILAddOperandList(
			    this.handle ,
			    operands ,
			    (ulong)operands.Length
		    );
	    }
	    
	    public HighLevelILExpressionIndex AddOperandList(HighLevelILExpressionIndex[] operands)
	    {
		    List<ulong> targets = new List<ulong>();

		    foreach (HighLevelILExpressionIndex operand in operands)
		    {
			    targets.Add( (ulong)operand);
		    }
		    
		    return NativeMethods.BNHighLevelILAddOperandList(
			    this.handle ,
			    targets.ToArray() ,
			    (ulong)operands.Length
		    );
	    }
	    
	    public HighLevelILExpressionIndex AddVariableList(Variable[] variables)
	    {
		    List<HighLevelILExpressionIndex> operands = new List<HighLevelILExpressionIndex>();

		    foreach (Variable variable in variables)
		    {
			    operands.Add( (HighLevelILExpressionIndex)variable.Identifier);
		    }
		    
		    return this.AddOperandList(operands.ToArray());
	    }
	    
	    public HighLevelILPossibleValueSetCacheIndex CachePossibleValueSet(PossibleValueSet pvs)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    return NativeMethods.BNCacheHighLevelILPossibleValueSet(
				    this.handle, 
				    pvs.ToNativeEx(allocator)
			    );
		    }
	    }

	    public void FinalizeILFunction()
	    {
		    NativeMethods.BNFinalizeHighLevelILFunction(this.handle);
	    }

	    public void GenerateSSAForm(Variable[] aliases)
	    {
		    NativeMethods.BNGenerateHighLevelILSSAForm(
			    this.handle,
			    UnsafeUtils.ConvertToNativeArray<BNVariable,Variable>(aliases),
			   (ulong)aliases.Length
			);
	    }

	    public HighLevelILFlowGraph CreateGraph(DisassemblySettings? settings = null)
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultGraph();
		    }
		    
		    return HighLevelILFlowGraph.MustTakeHandleEx(
			    this,
			    NativeMethods.BNCreateHighLevelILFunctionGraph(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }
	    
	    public HighLevelILFlowGraph CreateImmediateGraph(DisassemblySettings? settings = null)
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultGraph();
		    }
		    
		    return HighLevelILFlowGraph.MustTakeHandleEx(
			    this,
			    NativeMethods.BNCreateHighLevelILImmediateFunctionGraph(
				    this.handle ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle()
			    )
		    );
	    }

	    public FunctionGraphType FunctionGraphType
	    {
		    get
		    {
			    if (this.BasicBlocks.Length < 1)
			    {
				    return FunctionGraphType.InvalidILViewType;
			    }
			    
			    return NativeMethods.BNGetBasicBlockFunctionGraphType(
				    this.BasicBlocks[0].DangerousGetHandle()
				);
		    }
	    }

	    public HighLevelILVariable[] Variables
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetHighLevelILVariables(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeStructArray<BNVariable , HighLevelILVariable>(
				    arrayPointer ,
				    arrayLength ,
				    (_native) => HighLevelILVariable.FromNativeEx(this , _native) ,
				    NativeMethods.BNFreeVariableList
			    );
		    }
	    }
	    
	    public HighLevelILVariable[] AliasedVariables
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetHighLevelILAliasedVariables(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeStructArray<BNVariable , HighLevelILVariable>(
				    arrayPointer ,
				    arrayLength ,
				    (_native) => HighLevelILVariable.FromNativeEx(this , _native) ,
				    NativeMethods.BNFreeVariableList
			    );
		    }
	    }

	    public HighLevelILSSAVariable[] SSAVariables
	    {
		    get
		    {
			    List<HighLevelILSSAVariable> targets = new List<HighLevelILSSAVariable>();
			    
			    foreach (HighLevelILVariable variable in this.Variables)
			    {
				    IntPtr arrayPointer = NativeMethods.BNGetHighLevelILVariableSSAVersions(
					    this.handle ,
					    variable.ToNative(),
					    out ulong arrayLength
				    );

				    ulong[] versions = UnsafeUtils.TakeNumberArray<ulong>(
					    arrayPointer ,
					    arrayLength ,
					    NativeMethods.BNFreeILInstructionList
				    );

				    foreach (ulong version in versions)
				    {
					    targets.Add( new HighLevelILSSAVariable(variable, version) );
				    }
			    }

			    return targets.ToArray();
		    }
	    }

	    public HighLevelILInstructionIndex? GetInstructionIndexForExpressionIndex(
		    HighLevelILExpressionIndex expression)
	    {
		    HighLevelILInstructionIndex index = NativeMethods.BNGetHighLevelILInstructionForExpr(
			    this.handle,
			    expression);

		    if ((ulong)index >= this.InstructionCount)
		    {
			    return null;
		    }
		    
		    return index;
	    }
	    
	    public HighLevelILExpressionIndex? GetExpressionIndexByInstructionIndex(
		    HighLevelILInstructionIndex instruction)
	    {
		    HighLevelILExpressionIndex index = NativeMethods.BNGetHighLevelILIndexForInstruction(
			    this.handle,
			    instruction);

		    if ((ulong)index >= this.ExpressionCount)
		    {
			    return null;
		    }
		    
		    return index;
	    }
	    
	    
	    public PluginCommand[] GetValidPluginCommandsForInstruction(ulong instruction)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetValidPluginCommandsForHighLevelILInstruction(
			    this.OwnerFunction.View.DangerousGetHandle(),
			    this.handle,
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
	    
	    
	    public HighLevelILExpressionIndex AddExpression(
		    HighLevelILOperation operation,
		    SourceLocation? location = null,
		    ulong size = 0, 
		    params ulong[] operands
	    )
	    {
		    ulong a = 0;
		    ulong b = 0;
		    ulong c = 0;
		    ulong d = 0;
		    ulong e = 0;

		    if (operands.Length > 0)
		    {
			    a = operands[0];
		    }
		    
		    if (operands.Length > 1)
		    {
			    b = operands[1];
		    }
		    
		    if (operands.Length > 2)
		    {
			    c = operands[2];
		    }
		    
		    if (operands.Length > 3)
		    {
			    d = operands[3];
		    }
		    
		    if (operands.Length > 4)
		    {
			    e = operands[4];
		    }
		    
		    if (null == location)
		    {
			    return NativeMethods.BNHighLevelILAddExpr(
				    this.handle ,
				    operation,
				    size ,
				    a,
				    b ,
				    c ,
				    d ,
				    e
			    );
		    }
		    else
		    {
			    return NativeMethods.BNHighLevelILAddExprWithLocation(
				    this.handle ,
				    operation,
				    location.Address,
				    (uint)location.Operand,
				    size ,
				    a,
				    b ,
				    c ,
				    d ,
				    e
			    );
		    }
		     
	    }

	    public HighLevelILExpressionIndex EmitNop(SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_NOP ,
			    location
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitBlock(
		    HighLevelILExpressionIndex[] expressions,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_BLOCK ,
			    location,
			    0,
			    (ulong)expressions.Length,
			    (ulong)this.AddOperandList(expressions)
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitIf(
		    HighLevelILExpressionIndex condition,
		    HighLevelILExpressionIndex trueBranch,
		    HighLevelILExpressionIndex falseBranch,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_IF ,
			    location,
			    0,
			    (ulong)condition,
			    (ulong)trueBranch,
			    (ulong)falseBranch
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitWhile(
		    HighLevelILExpressionIndex condition,
		    HighLevelILExpressionIndex loop,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_WHILE ,
			    location,
			    0,
			    (ulong)condition,
			    (ulong)loop
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitDoWhile(
		    HighLevelILExpressionIndex condition,
		    HighLevelILExpressionIndex loop,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_DO_WHILE ,
			    location,
			    0,
			    (ulong)condition,
			    (ulong)loop
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitFor(
		    HighLevelILExpressionIndex init ,
		    HighLevelILExpressionIndex condition,
		    HighLevelILExpressionIndex update,
		    HighLevelILExpressionIndex loop,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_FOR ,
			    location,
			    0,
			    (ulong)init,
			    (ulong)condition,
			    (ulong)update,
			    (ulong)loop
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitSwtich(
		    HighLevelILExpressionIndex condition,
		    HighLevelILExpressionIndex defaultExpr,
		    HighLevelILExpressionIndex[] cases,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_SWITCH ,
			    location,
			    0,
			    (ulong)condition,
			    (ulong)defaultExpr,
			    (ulong)cases.Length,
			    (ulong)this.AddOperandList(cases)
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitCase(
		    HighLevelILExpressionIndex[] values,
		    HighLevelILExpressionIndex expression,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_CASE ,
			    location,
			    0,
			    (ulong)values.Length,
			    (ulong)this.AddOperandList(values),
			    (ulong)expression
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitBreak(
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_BREAK ,
			    location,
			    0
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitContinue(
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_CONTINUE ,
			    location,
			    0
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitJump(
		    HighLevelILExpressionIndex target,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_JUMP ,
			    location,
			    0,
			    (ulong)target
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitRet(
		    HighLevelILExpressionIndex[] sources,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_RET ,
			    location,
			    0,
			    (ulong)sources.Length,
			    (ulong)this.AddOperandList(sources)
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitNoRet(
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_NORET ,
			    location,
			    0
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitUnreachable(
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_UNREACHABLE ,
			    location,
			    0
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitGoto(
		    ulong target,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_GOTO ,
			    location,
			    0,
			    target
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitLabel(
		    ulong target,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_LABEL ,
			    location,
			    0,
			    target
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitVariableDeclare(
		    Variable variable,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_VAR_DECLARE ,
			    location,
			    0,
			    variable.Identifier
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitVariableInit(
		    ulong size,
		    Variable dest,
		    HighLevelILExpressionIndex src,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_VAR_INIT ,
			    location,
			    size,
			    dest.Identifier,
			    (ulong)src
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitAssign(
		    ulong size,
		    HighLevelILExpressionIndex dest,
		    HighLevelILExpressionIndex src,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_ASSIGN ,
			    location,
			    size,
			    (ulong)dest,
			    (ulong)src
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitAssignUnpack(
		    ulong size,
		    HighLevelILExpressionIndex[] output,
		    HighLevelILExpressionIndex src,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_ASSIGN_UNPACK ,
			    location,
			    size,
			    (ulong)output.Length,
			    (ulong)this.AddOperandList(output),
			    (ulong)src
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitVariable(
		    ulong size,
		    Variable src,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_VAR ,
			    location,
			    size,
			    (ulong)src.Identifier
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitStructField(
		    ulong size,
		    HighLevelILExpressionIndex src,
		    long offset,
		    ulong memberIndex,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_STRUCT_FIELD ,
			    location,
			    size,
			    (ulong)src,
			    (ulong)offset,
			    (ulong)memberIndex
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitSplit(
		    ulong size,
		    HighLevelILExpressionIndex high,
		    HighLevelILExpressionIndex low,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_SPLIT ,
			    location,
			    size,
			    (ulong)high,
			    (ulong)low
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitArrayIndex(
		    ulong size,
		    HighLevelILExpressionIndex source,
		    HighLevelILExpressionIndex index,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_SPLIT ,
			    location,
			    size,
			    (ulong)source,
			    (ulong)index
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitDeref(
		    ulong size,
		    HighLevelILExpressionIndex source,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_DEREF ,
			    location,
			    size,
			    (ulong)source
		    );
	    }
	    
	    public HighLevelILExpressionIndex EmitDerefField(
		    ulong size,
		    HighLevelILExpressionIndex source,
		    long offset ,
		    ulong memberIndex,
		    SourceLocation? location = null)
	    {
		    return this.AddExpression(
			    HighLevelILOperation.HLIL_DEREF_FIELD ,
			    location,
			    size,
			    (ulong)source,
			    (ulong)offset,
			    memberIndex
		    );
	    }
	}
}