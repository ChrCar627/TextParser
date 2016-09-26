using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{

	//-----------------------------------------------------------------
	// Name: UnknownParameterException
	// Author: Chris Carucci
	// Date: 9-26-16
	// Description: An exception to be thrown when an unknkown parameter was found when loading a configuration file.
	//-----------------------------------------------------------------
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



