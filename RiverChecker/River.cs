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

        //declaring properties

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
        public River(int depth, int pollutionLevels)
        {
            
            this.depth = depth;
            this.pollutionLevel = pollutionLevel;
           

            //Write methods
            public void CheckStatus()
        {
            
            Random rand = new Random();
            PollutionLevel = rand.Next(1, 11);
            Depth = rand.Next(6, 101);

            Console.WriteLine("Depth: {0} \nPollution Level: {1}", Depth, PollutionLevel);
        }

    }
}
