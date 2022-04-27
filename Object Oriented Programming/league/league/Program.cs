using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Collections.Generic;

namespace league
{ 
    public static class Program
    {

        //MAIN PROGRAM 

        static void Main(string[] args)
        {
            // 1. Create Leagues
            List<Team> teamsSerieA = new List<Team>() {
                     new Team("Team A"),
                     new Team("Team B"),
                     new Team("Team C")
 };
            List<Team> teamsPremier = new List<Team>() {
                     new Team("Team A"),
                     new Team("Team B"),
                     new Team("Team C")
 };

            // 2. work out Leaderboard 
            WorkOutLeaderboard(new SerieA(teamsSerieA));
            WorkOutLeaderboard(new Premier(teamsPremier));
            Console.ReadKey();
        }
        static void WorkOutLeaderboard(League league)
        {
            // 1. create League 
            List<Team> teams = new List<Team>() {
                     new Team("Team A"),
                     new Team("Team B"),
                     new Team("Team C")
            };

            // 2. assign and Print Results 
            List<string> results = new List<string>() { "1-2", "5-1", "1-1", "2-1", "2-3", "2-0" };
            Console.WriteLine("Results\n-------\n");
            for (int i = 0; i < league.Fixtures.Count; i++)
            {
                league.Fixtures[i].Result = results[i];
                Console.CursorLeft = 0; Console.Write(league.Fixtures[i].HomeTeam.Name);
                Console.CursorLeft = 10; Console.Write(league.Fixtures[i].Result);
                Console.CursorLeft = 20; Console.WriteLine(league.Fixtures[i].AwayTeam.Name);
            }
            // 3. Print Leaderboard
            string leagueName = league.ToString().Replace("HomeAss.Classes.", string.Empty);
            Console.WriteLine($"\nLeaderBoard (under {leagueName} rules)\n" +
            "---------------------------------\n");
            teams = league.GetLeaderboard();

            Console.CursorLeft = 0; Console.Write("Team");
            Console.CursorLeft = 10; Console.Write("Pts");
            Console.CursorLeft = 20; Console.Write("GF");
            Console.CursorLeft = 30; Console.Write("GA");
            Console.CursorLeft = 40; Console.WriteLine("GD\n");
            foreach (Team team in teams)
            {
                Console.CursorLeft = 0; Console.Write(team.Name);
                Console.CursorLeft = 10; Console.Write(team.Points);
                Console.CursorLeft = 20; Console.Write(team.GoalsFor);
                Console.CursorLeft = 30; Console.Write(team.GoalsAgainst);
                Console.CursorLeft = 40; Console.WriteLine(team.GoalDifference);

            }
            Console.WriteLine();
        }


    }
}