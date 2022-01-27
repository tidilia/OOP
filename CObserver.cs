using System;
using System.Collections.Generic;
using System.Text;
using laba07.Observer;

namespace laba07.Observer
{
	abstract class CObserver
	{
		public abstract void onSubjectChanged(CSubject who);
	};
}
