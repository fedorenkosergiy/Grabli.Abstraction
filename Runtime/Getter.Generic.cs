using JetBrains.Annotations;

namespace Grabli.Abstraction
{
	[PublicAPI]
	public interface Getter<out T>
	{
		T Get();
	}
}
