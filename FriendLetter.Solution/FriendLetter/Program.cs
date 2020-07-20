using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FriendLetter
{
  public class Program
  {
    var host = new WebHostBuilder();
        .UseKestrel();
        .UseContentRoot(Directory.GetCurrentDirectory());
        .UseIISIntegration();
        .UseStartup<Startup>();
        .Build();

      host.Run();
  }
}