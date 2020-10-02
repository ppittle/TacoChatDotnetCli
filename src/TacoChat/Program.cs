using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Reflection;
using System.Threading.Tasks;

namespace TacoChat
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            Console.WriteLine(TacoChatLogo);

            var rootCommand = new RootCommand
            {
                Description = "Taco Themed Sample Dotnet Cli Tool",
                Handler = CommandHandler.Create(async () =>
                {
                    Console.Write("Connecting to TacoChat Server ... ");

                    await Task.Delay(TimeSpan.FromMilliseconds(400));

                    var defaultColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FAILED");
                    Console.ForegroundColor = defaultColor;

                    Console.WriteLine("");
                    Console.WriteLine("Just kidding.  This is just a Sample.  There's no TacoChat Server.");
                    Console.WriteLine("Good bye.");
                })
            };

            rootCommand.Add(new Command("version")
            {
                Description = "Displays the current version",
                Handler = CommandHandler.Create(() =>
                {
                    var ass = Assembly.GetEntryAssembly();

                    Console.WriteLine(
                        $"Assembly Version: {ass?.GetName().Version?.ToString() ?? "unknown" }");

                    Console.WriteLine(
                        $"Informational Version: {ass?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "unknown"}");

                })
            });

            return await rootCommand.InvokeAsync(args);
        }

        private const string TacoChatLogo =
@"
Welcome to 
     _____                 _____ _           _   
    |_   _|               /  __ \ |         | |  
      | | __ _  ___ ___   | /  \/ |__   __ _| |_ 
      | |/ _` |/ __/ _ \  | |   | '_ \ / _` | __|
      | | (_| | (__ (_) | | \__/\ | | | (_| | |_ 
      \_/\__,_|\___\___/   \____/_| |_|\__,_|\__|
";
    }
}
