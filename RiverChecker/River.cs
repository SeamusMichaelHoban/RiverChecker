using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverChecker
{
    class River
    {
        // declaring fields
        private int depth;//depth 6-100
        private int pollutionLevel; // level of 1-10
        private string name;

        //declaring properties


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }

        public int PollutionLevel
        {
            get { return this.pollutionLevel; }
            set { this.pollutionLevel = value; }
        }
        //Create constructors
        public River()
        {

        }
        public River(string name)
        {
            Name = name;
            Console.WriteLine("Name: {0} ", Name);
            Console.WriteLine("What is the current depth of the river?");
            Depth = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the current pollution level of the river? (1-10)");
            PollutionLevel = int.Parse(Console.ReadLine());
            testLevels();
        } 

        public River(int depth, int pollutionLevel, string name)
        {

            Depth = depth;
            PollutionLevel = pollutionLevel;
            Name = name;
        }
        //Write methods
        public void CheckStatus()
        {

            Random rand = new Random();
            PollutionLevel = rand.Next(1, 11);
            Depth = rand.Next(6, 101);

            Console.WriteLine("Depth: {0} \nPollution Level: {1}", Depth, PollutionLevel);
            testLevels();
        }

        public void testLevels()
        {
            Random rand = new Random();
            if (depth > 80)
            {

                Console.WriteLine("Alert river depth has exceeded acceptible levels!!!");
                Console.WriteLine("Would you like to drain the depth level?");
                string exitResp = Console.ReadLine().ToLower();
                if (exitResp == "yes")
                {
                    Depth = rand.Next(6, 80);
                    Console.WriteLine("New depth: {0}", Depth);
                }
            }
            if (pollutionLevel > 6)
            {
                Console.WriteLine("Alert river pollution level has exceeded acceptible levels!!!");
                Console.WriteLine("Would you like to clean the pollution level to an acceptible level?");
                string exitResp = Console.ReadLine().ToLower();
                if (exitResp == "yes")
                {
                    PollutionLevel = rand.Next(1, 6);
                    Console.WriteLine("New pollution level: {0}", PollutionLevel);
                }
            }
        }

        public void changeDepth()
        {
            Console.WriteLine("What is the current depth of the river?");
            Depth = int.Parse(Console.ReadLine());
            Console.WriteLine("New depth: {0}", Depth);
            testLevels();

        }
        public void changePollutionLevel()
        {
            Console.WriteLine("What is the current pollution level of the river?");
            PollutionLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("New pollution level: {0}", PollutionLevel);
            testLevels();

        }
        public void menu()
        {//provide menu for river name, current depth and pollution levels

            Console.WriteLine("Name: {0}, depth: {1}, pollution level: {2}", Name, Depth, PollutionLevel);
            testLevels();
        }
    }
}
