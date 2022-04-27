using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace league
{
    internal class Fixture
    {
        // home team 
        public  Team HomeTeam { get; set; }
        //away team
        public Team AwayTeam { get; set; }
        //result property
        public string result;

        
        public Fixture(Team ht,Team at)
        {
            //setting data members
            HomeTeam = ht;
            AwayTeam = at;
            result = String.Empty;
        }

        public string Result {
            get { return result; }
            set {
                // splitting the result values by '-'
                result = value;
                string[] points = value.Split('-');
                // points[0] is the score of HomeTeam and points[1] is te score of AwayTeam 
                // parsing the result points 
                HomeTeam.GoalsFor += int.Parse(points[0]);
                HomeTeam.GoalsAgainst += int.Parse(points[1]);
                HomeTeam.GoalDifference = HomeTeam.GoalsFor - HomeTeam.GoalsAgainst;

                AwayTeam.GoalsFor += int.Parse(points[1]);
                AwayTeam.GoalsAgainst += int.Parse(points[0]);
                AwayTeam.GoalDifference = AwayTeam.GoalsFor - AwayTeam.GoalsAgainst;

                //awarded 3 points to winning team
                if (int.Parse(points[0]) > int.Parse(points[1]))
                {
                    HomeTeam.Points += 3;
                }
                else if (int.Parse(points[0]) < int.Parse(points[1]))
                {
                    AwayTeam.Points += 3;
                }
                // if it is a tie then reward 1 point to each team;
                else
                {
                    HomeTeam.Points += 1;
                    AwayTeam.Points += 1;
                }
            }
        }
    }
}
