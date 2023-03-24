namespace Grabli.Abstraction
{
	public interface Pool<T> : Getter<T>, Releaser<T>, Resetable, Resizable, Clearable
	{
		void WarmUp(int count);
	}
}
