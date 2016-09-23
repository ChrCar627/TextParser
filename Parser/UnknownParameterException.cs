using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
	class UnknownParameterException: Exception
	{
		public UnknownParameterException()
		{
		}

		public UnknownParameterException(string message): base(message)
		{
		}

		public UnknownParameterException(string message, Exception inner): base(message,inner)
		{

		}
	}
}
