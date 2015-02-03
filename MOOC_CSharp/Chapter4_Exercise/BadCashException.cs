using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4_Exercise
{
	class BadCashException:Exception
	{
		public BadCashException(string message) : base(message)
		{
			
		}
	}
}
