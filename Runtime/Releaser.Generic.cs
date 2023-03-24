namespace Grabli.Abstraction
{
	[JetBrains.Annotations.PublicAPIAttribute]
	public interface Releaser<T>
	{
			void Release(T toBeReleased);
	}
}
