using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Quartett
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = new FileInfo(Assembly.GetExecutingAssembly().Location).FullName;
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@root + "..\\..\\..\\..\\HarryPotter_Schulprojekt\\Harry_Potter_Logo\\HarryPotterLogo.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            file.Close();
            Game game = new Game();
        }
    }
}
