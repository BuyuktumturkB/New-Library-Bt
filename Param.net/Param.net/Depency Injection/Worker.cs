using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Param.net.Depency_Injection
{
	public class Worker : BackgroundService

	{
		private readonly MessageSender _messagesend = new MessageSender();
		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			while (!stoppingToken.IsCancellationRequested)
			{
				_messagesend.Write($"Worker running at : {DateTimeOffset.Now}");
				await Task.Delay(1000, stoppingToken);
			}
		}
	}
}
