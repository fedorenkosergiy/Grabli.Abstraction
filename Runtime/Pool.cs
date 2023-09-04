namespace Grabli.Abstraction
{
	public interface Pool<T> : Getter<T>, Releaser<T>, Deinitable, Resizable, Clearable
	{
		void Init(int warmUpCount);
	}
}
