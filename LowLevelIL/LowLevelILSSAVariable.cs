namespace BinaryNinja
{
	public sealed class LowLevelILSSAVariable : AbstractSSAVariable<LowLevelILVariable>
	{
		public LowLevelILSSAVariable(LowLevelILVariable variable , ulong version) 
			:base(variable , version)
		{
			
		}
	}
}
