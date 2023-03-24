namespace Grabli.Abstraction
{
	public interface Resizable
	{
		int Capacity { get; }

		void Resize(int capacity);
	}
}
