using Avalonia.Controls;
using Avalonia.Logging.Serilog;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
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
            //SerilogLogger.Initialize(new LoggerConfiguration()
            //    .MinimumLevel.Warning()
            //    .WriteTo.Trace(outputTemplate: "{Area}: {Message}")
            //    .CreateLogger());
#endif
        }
    }
}
