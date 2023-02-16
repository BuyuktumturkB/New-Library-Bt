using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Param.net.Depency_Injection
{
	public class MessageSender
	{
		public void Write(string comment)
		{
			Console.WriteLine($"MessageSender.Send( message: \"{comment}\"");

		}
	}
}
