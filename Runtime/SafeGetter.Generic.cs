namespace Grabli.Abstraction
{
	public interface SafeGetter<T> : Getter<T>
	{
		bool TryGet(out T result);
	}
}
