using JetBrains.Annotations;

namespace Grabli.Abstraction
{
	[PublicAPI]
	public interface Restartable
	{
		void Restart();
	}
}
