using System;
using JetBrains.Annotations;

namespace Grabli.Abstraction
{
	/// <summary>
	/// Type that generates events that can be listened by added listeners
	/// </summary>
	/// <typeparam name="T">Type with a method that should be called when the listenable event is happening</typeparam>
	[PublicAPI]
	public interface Listenable<in T>
	{
		/// <summary>
		/// Adds a unique listener. No duplicates allowed
		/// </summary>
		/// <param name="listener">Object that is going to listen events</param>
		/// <returns>
		/// <para>
		/// Returns a listener index that can be used to remove it
		/// </para>
		/// <para>
		/// &gt;= 0 means that the listener was added or it was already there.
		/// </para>
		/// <para>
		/// -1 means that the listener wasn't added
		/// </para>
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// if listener == null
		/// </exception>
		int AddListener([NotNull] T listener);

		/// <summary>
		/// Removes previously added listener
		/// </summary>
		/// <param name="listener">Listener that is going to stop listen events</param>
		/// <returns>
		/// <para>
		/// true if removed
		/// </para>
		/// <para>
		/// false if the listener was not found among added listeners or it has been already removed
		/// </para>
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// if listener == null
		/// </exception>
		bool RemoveListener([NotNull] T listener);

		/// <summary>
		/// <inheritdoc cref="RemoveListener(T)"/>
		/// </summary>
		/// <param name="index">The identifier that was returned when a listener was added</param>
		/// <returns>
		/// <inheritdoc cref="RemoveListener(T)"/>
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// if index &lt; 0 or index &gt; the max internal index
		/// </exception>
		bool RemoveListener(int index);
	}
}
