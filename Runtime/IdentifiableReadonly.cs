namespace Grabli.Abstraction
{
	public interface IdentifiableReadonly<out T>
	{
		T GetId();
	}
}
