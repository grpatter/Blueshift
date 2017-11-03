using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace Blueshift.Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = Assembly.GetAssembly(typeof(Program)).GetName().Name;
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.UseKestrel(options =>
				{
					options.Listen(IPAddress.Any, 5000);
				})
				.Build(); 
	}
}
