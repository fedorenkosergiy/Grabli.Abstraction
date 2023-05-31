namespace Grabli.Abstraction
{
	public interface Orderable<out T>
	{
		T GetOrder();
	}
}
