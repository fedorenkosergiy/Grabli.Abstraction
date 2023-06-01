namespace Grabli.Abstraction
{
	public interface OrderableReadonly<out T>
	{
		T GetOrder();
	}
}
