using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
	public class ConsoleLogger : ILogger
	{
		public void LogMessage(string message)
		{
			Console.WriteLine("Logging to console " + message);
		}
	}
}
