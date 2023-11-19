namespace Grabli.Abstraction
{
	public partial struct RangeFloatClosed
	{
		[System.Flags]
		public enum EdgeInclusion : byte
		{
			None = 0,
			Start = 1,
			End = 1 << 1,
			Both = Start | End,
		}
	}
}