using JetBrains.Annotations;

namespace Grabli.Abstraction
{
	[PublicAPI]
	public interface UpdateCallbackReceiver
	{
		void OnUpdate();
	}
}