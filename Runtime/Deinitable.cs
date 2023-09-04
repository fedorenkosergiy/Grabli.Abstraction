using System.Collections.Generic;

namespace Grabli.Abstraction
{
	public interface Deinitable
	{
		void Deinit(ISet<Deinitable> alreadyHandled);
	}
}
