using Avalonia.Controls;
using Avalonia.Logging.Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo;
using Serilog;

namespace ConsoleApplication1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitializeLogging();
            AppBuilder.Configure<App>()
               .UsePlatformDetect()
               .Start<MainWindow>();
        }

        // This will be made into a runtime configuration extension soon!
        private static void InitializeLogging()
        {
#if DEBUG
            SerilogLogger.Initialize(new LoggerConfiguration()
                .MinimumLevel.Warning()
                .WriteTo.Trace(outputTemplate: "{Area}: {Message}")
                .CreateLogger());
#endif
        }
    }
}
