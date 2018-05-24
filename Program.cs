/***********************
 * BitAdmin2.0框架文件
 ***********************/
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace BitAdminCoreDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
    }
}
