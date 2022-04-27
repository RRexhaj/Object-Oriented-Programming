using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace league
{
    internal class Team
    {
        // public properties of team class with getter/setter
        public string Name { get; set; }
        public int Points { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifference { get; set; }

        //  takes name of the team and assigns every thing else to 0  
        public Team(string n)
        {
            Name = n;
            Points = 0;
            GoalsFor = 0;
            GoalsAgainst = 0;
            GoalDifference = 0;
        }
    }
}
