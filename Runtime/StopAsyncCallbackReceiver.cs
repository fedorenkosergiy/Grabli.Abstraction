namespace Grabli.Abstraction
{
	public interface StopAsyncCallbackReceiver<out T>
	{
		T OnStopAsync();
	}
}
