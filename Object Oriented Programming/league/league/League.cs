using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace league
{
    internal abstract class League
    {
        // league class with getter/setter 
        public List<Team> Teams { get; set; }
        public List<Fixture> Fixtures { get; set; }

        public League(List<Team> teamList)
        {
            Teams = teamList;
            Fixtures = new List<Fixture>();
            foreach(Team team1 in Teams)
            {
                foreach(Team team2 in Teams)
                {
                    if(team1.Name != team2.Name)
                    {
                        Fixtures.Add(new Fixture(team1, team2));
                    }
                }
            }
        }
        
        abstract public List<Team> GetLeaderboard();
    }
}
