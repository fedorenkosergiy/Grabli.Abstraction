using JetBrains.Annotations;

namespace Grabli.Abstraction
{
	[PublicAPI]
	public interface Getter<T>
	{
		void Get(out T result);
		bool TryGet(out T result);
	}
}
