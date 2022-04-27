using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace league
{
    // SerieA class inherits with League class
    internal class SerieA : League
    {
        // calling the base 
        public SerieA(List<Team> teams) : base(teams) { }

        // Implementing the abstract method of Parent class
        public override List<Team> GetLeaderboard()
        {
            // if a deserves higher placing, result = -1;
            // if b deserves higher placing, result = 1;
            Teams.Sort(delegate (Team a, Team b)
            {
                int a_score = 0;
                int b_score = 0;
                int result = 0;
                // if pointsof a grater than b, result = -1 
                if (a.Points > b.Points)
                    result = -1;
                // if pointsof b grater than a, result = 1 
                else if (a.Points < b.Points)
                    result = 1;
                // its a tie
                else
                {
                   
                    string[] res;
                    foreach(Fixture f in Fixtures)
                    {
                        // calculating points on their ead to head matches
                        if(f.HomeTeam.Name==a.Name && f.AwayTeam.Name == b.Name)
                        {
                            res = f.Result.Split('-');
                            if (int.Parse(res[0]) > int.Parse(res[1]))
                                a_score += 3;
                            else if (int.Parse(res[0]) < int.Parse(res[1]))
                                b_score += 3;
                            else
                            {
                                a_score += 1;
                                b_score += 1;
                            }
                        }
                        else if(f.HomeTeam.Name == b.Name && f.AwayTeam.Name == a.Name)
                        {
                            res = f.Result.Split('-');
                            if (int.Parse(res[0]) > int.Parse(res[1]))
                                b_score += 3;
                            else if (int.Parse(res[0]) < int.Parse(res[1]))
                                a_score += 3;
                            else
                            {
                                a_score += 1;
                                b_score += 1;
                            }
                        }
                    }
                    // if pointsof a grater than b, result = -1
                    if (a_score > b_score)
                        result = -1;
                    // if pointsof b grater than b, result = 1
                    else if (a_score < b_score)
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
