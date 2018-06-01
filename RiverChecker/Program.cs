using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            River ohio = new River("Ohio River");

            ohio.menu();
            Console.WriteLine("One week goes by.....");
            Console.WriteLine("New levels.....");
            ohio.CheckStatus();
            ohio.menu();

            ohio.changeDepth();
            ohio.changePollutionLevel();
            ohio.menu();
        }
    }
}
