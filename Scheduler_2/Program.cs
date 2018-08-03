using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scheduler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSchedule();
        }

        public static void RunSchedule()
        {
            string path = Path.GetFullPath(@"G:\Jitendra\Scheduler_Testing\TestFiles") + @"\" + DateTime.Now.ToString("MM_dd_yyyy_HH_mm") + "_Log.txt";
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                    File.AppendAllText(path, Environment.NewLine + "Hello File Created on :" + DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                string errorLogPath = Path.GetFullPath(@"G:\Jitendra\Scheduler_Testing\TestFiles\Test.txt");
                File.AppendAllText(errorLogPath, Environment.NewLine + ex.Message);
            }
        }
    }
}
