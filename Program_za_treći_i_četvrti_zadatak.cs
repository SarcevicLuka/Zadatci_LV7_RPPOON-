using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treći_i_četvrti_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider systemDataProvider = new SystemDataProvider();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("D:\\Users\\Korisnik\\Desktop\\LV7-3. zadatak.txt");
            systemDataProvider.Attach(consoleLogger);
            systemDataProvider.Attach(fileLogger);

            while (true)
            {
                consoleLogger.Log(systemDataProvider);
                fileLogger.Log(systemDataProvider);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
