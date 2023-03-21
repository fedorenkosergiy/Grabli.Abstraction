namespace Grabli.Abstraction
{
	public sealed class NonNegativeCounter : Counter, Countable
	{
		private int count;

		public int Count() => count;

		public bool GoDown()
		{
			if (count <= 0) { return false; }

			count--;

			return true;
		}

		public bool GoUp()
		{
			if (count >= int.MaxValue) { return false; }

			count++;

			return true;
		}
	}
}
