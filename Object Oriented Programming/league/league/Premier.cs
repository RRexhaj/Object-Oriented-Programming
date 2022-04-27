using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace league
{
    internal class Premier: League
    {
        public Premier(List<Team> teams): base(teams) { }

        public override List<Team> GetLeaderboard()
        {
            Teams.Sort(delegate (Team a, Team b)
            {
                int result = 0;
                // if a deserves higher placing then result = -1;
                if (a.Points > b.Points)
                    result = -1;
                // if b deserves higher placing then result = 1;
                else if (a.Points < b.Points)
                    result = 1;
                // its a tie
                else
                {

                    // if a deserves higher placing, result = -1; 
                    if (a.GoalDifference > b.GoalDifference)
                        result = -1;
                    // if b deserves higher placing, result = 1;
                    else if (a.GoalDifference < b.GoalDifference)
                        result = 1;
                    // else result = -1
                    else
                        result = -1;
                }
                return result;
            });
            return Teams;
        }
    }
}
