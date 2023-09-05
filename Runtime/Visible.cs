namespace Grabli.Abstraction
{
	public interface Visible
	{
		bool IsVisible { get; }

		void Hide();

		void Show();
	}
}
