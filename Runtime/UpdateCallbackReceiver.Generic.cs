using JetBrains.Annotations;

namespace Grabli.Abstraction
{
	[PublicAPI]
	public interface UpdateCallbackReceiver<in T>
	{
		void OnUpdate(T delta);
	}
}
