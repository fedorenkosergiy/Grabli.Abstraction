using JetBrains.Annotations;

namespace Grabli.Abstraction
{
	[PublicAPI]
	public interface Updatable<in T>
	{
		void Update(T delta);
	}
}