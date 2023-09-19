namespace Grabli.Abstraction
{
	public interface Setter<in T>
	{
		void Set(T value);
	}
}
