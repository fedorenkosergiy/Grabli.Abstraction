namespace Grabli.Abstraction
{
	public interface Identifiable<out T>
	{
		T GetId();
	}
}
