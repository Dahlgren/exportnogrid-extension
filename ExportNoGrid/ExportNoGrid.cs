using Maca134.Arma.DllExport;
using System;
using System.Diagnostics;
using System.Reflection;

namespace ExportNoGrid
{
    public class ExportNoGrid
    {
        static private Process Process;

        [ArmaDllExport]
        public static string Invoke(string input, int size)
        {
            if (input == "export")
            {
                if (Process == null)
                {
                    Process = new Process();
                    Process.StartInfo.FileName = "exportnogrid.exe";
                    Process.EnableRaisingEvents = true;
                    Process.Exited += (sender, e) =>
                    {
                        Process = null;
                    };
                    Process.Start();
                }

                return Process.Id.ToString();
            }

            if (input == "reset")
            {
                Process.Kill();
                Process = null;
                return (Process == null).ToString();
            }

            if (input == "status")
            {
                return (Process != null).ToString();
            }

            if (input == "version")
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }

            return "Invalid Input";
        }
    }
}
