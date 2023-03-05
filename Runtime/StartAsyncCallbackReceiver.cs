namespace Grabli.Abstraction
{
	public interface StartAsyncCallbackReceiver<out T>
	{
		T OnStartAsync();
	}
}
