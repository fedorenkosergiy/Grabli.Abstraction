namespace Grabli.Abstraction
{
	public interface Notifiable<in T>
	{
		void Notify(T notification);
	}
}
