namespace Grabli.Abstraction
{
	public interface Creator<out T>
	{
		T Create();
	}
}
