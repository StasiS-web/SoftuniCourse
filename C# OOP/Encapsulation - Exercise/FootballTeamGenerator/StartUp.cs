using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string commnads;

            while ((commnads = Console.ReadLine()) != "END")
            {

                string[] tokens = commnads.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string commandArg = tokens[0];
                string teamName = tokens[1];

                try
                {

                    if (commandArg == "Team")
                    {
                        teams.Add(new Team(teamName));
                    }
                    else if (commandArg == "Add")
                    { 
                        if (!teams.Any(t => t.Name == teamName))
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            var currentTeam = teams.First(t => t.Name == teamName);
                            string playerName = tokens[2];
                            int eduranceStats = int.Parse(tokens[3]);
                            int sprintStats = int.Parse(tokens[4]);
                            int dribbleStats = int.Parse(tokens[5]);
                            int passingStats = int.Parse(tokens[6]);
                            int shootingStats = int.Parse(tokens[7]);

                            currentTeam.AddPlayers(new Player(playerName, eduranceStats, sprintStats, dribbleStats, passingStats, shootingStats));
                        }
                    }
                    else if (commandArg == "Remove")
                    {
                        string playerName = tokens[2];
                        var removeTeam = teams.First(t => t.Name == teamName);
                        removeTeam.RemovePlayers(playerName);
                    }
                    else if (commandArg == "Rating")
                    {
                        if (!teams.Any(t => t.Name == teamName))
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            Console.WriteLine(teams.First(t => t.Name == teamName).ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }
    }
}