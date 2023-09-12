using System.Collections.Generic;

namespace Grabli.Abstraction
{
	public interface DeinitableTree
	{
		void Deinit(ISet<DeinitableTree> alreadyHandled);
	}
}
