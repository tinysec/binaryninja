using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum LowLevelILOperation : uint
	{
		/// <summary>
		/// 
		/// </summary>
		LLIL_NOP = 0,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SET_REG = 1,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SET_REG_SPLIT = 2,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SET_FLAG = 3,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SET_REG_STACK_REL = 4,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_PUSH = 5,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_ASSERT = 6,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FORCE_VER = 7,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_LOAD = 8,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_STORE = 9,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_PUSH = 10,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_POP = 11,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG = 12,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_SPLIT = 13,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_REL = 14,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_POP = 15,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_FREE_REG = 16,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_FREE_REL = 17,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CONST = 18,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CONST_PTR = 19,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_EXTERN_PTR = 20,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLOAT_CONST = 21,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLAG = 22,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLAG_BIT = 23,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_ADD = 24,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_ADC = 25,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SUB = 26,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SBB = 27,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_AND = 28,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_OR = 29,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_XOR = 30,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_LSL = 31,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_LSR = 32,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_ASR = 33,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_ROL = 34,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_RLC = 35,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_ROR = 36,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_RRC = 37,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_MUL = 38,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_MULU_DP = 39,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_MULS_DP = 40,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_DIVU = 41,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_DIVU_DP = 42,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_DIVS = 43,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_DIVS_DP = 44,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_MODU = 45,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_MODU_DP = 46,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_MODS = 47,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_MODS_DP = 48,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_NEG = 49,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_NOT = 50,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SX = 51,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_ZX = 52,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_LOW_PART = 53,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_JUMP = 54,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_JUMP_TO = 55,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CALL = 56,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CALL_STACK_ADJUST = 57,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_TAILCALL = 58,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_RET = 59,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_NORET = 60,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_IF = 61,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_GOTO = 62,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLAG_COND = 63,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLAG_GROUP = 64,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CMP_E = 65,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CMP_NE = 66,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CMP_SLT = 67,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CMP_ULT = 68,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CMP_SLE = 69,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CMP_ULE = 70,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CMP_SGE = 71,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CMP_UGE = 72,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CMP_SGT = 73,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CMP_UGT = 74,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_TEST_BIT = 75,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_BOOL_TO_INT = 76,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_ADD_OVERFLOW = 77,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SYSCALL = 78,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_BP = 79,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_TRAP = 80,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_INTRINSIC = 81,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_UNDEF = 82,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_UNIMPL = 83,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_UNIMPL_MEM = 84,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FADD = 85,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FSUB = 86,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FMUL = 87,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FDIV = 88,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FSQRT = 89,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FNEG = 90,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FABS = 91,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLOAT_TO_INT = 92,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_INT_TO_FLOAT = 93,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLOAT_CONV = 94,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_ROUND_TO_INT = 95,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLOOR = 96,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CEIL = 97,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FTRUNC = 98,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FCMP_E = 99,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FCMP_NE = 100,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FCMP_LT = 101,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FCMP_LE = 102,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FCMP_GE = 103,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FCMP_GT = 104,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FCMP_O = 105,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FCMP_UO = 106,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SET_REG_SSA = 107,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SET_REG_SSA_PARTIAL = 108,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SET_REG_SPLIT_SSA = 109,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SET_REG_STACK_REL_SSA = 110,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SET_REG_STACK_ABS_SSA = 111,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_SPLIT_DEST_SSA = 112,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_DEST_SSA = 113,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_SSA = 114,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_SSA_PARTIAL = 115,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_SPLIT_SSA = 116,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_REL_SSA = 117,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_ABS_SSA = 118,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_FREE_REL_SSA = 119,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_FREE_ABS_SSA = 120,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SET_FLAG_SSA = 121,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_ASSERT_SSA = 122,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FORCE_VER_SSA = 123,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLAG_SSA = 124,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLAG_BIT_SSA = 125,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CALL_SSA = 126,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SYSCALL_SSA = 127,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_TAILCALL_SSA = 128,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CALL_PARAM = 129,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CALL_STACK_SSA = 130,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_CALL_OUTPUT_SSA = 131,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SEPARATE_PARAM_LIST_SSA = 132,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_SHARED_PARAM_SLOT_SSA = 133,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_MEMORY_INTRINSIC_OUTPUT_SSA = 134,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_LOAD_SSA = 135,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_STORE_SSA = 136,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_INTRINSIC_SSA = 137,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_MEMORY_INTRINSIC_SSA = 138,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_PHI = 139,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_REG_STACK_PHI = 140,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_FLAG_PHI = 141,
		
		/// <summary>
		/// 
		/// </summary>
		LLIL_MEM_PHI = 142
	}
}