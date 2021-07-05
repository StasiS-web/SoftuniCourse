using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private IList<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public IList<Player> Player
        {
            get => players;
            set
            {
                players = value;
            }
        }

        public int Rating { get => CalculateRating(); }

        private int CalculateRating()
        {
            if (players.Any())
            {
                return (int)Math.Round(players.Average(p => p.Stats));
            }
            else
            {
                return 0;
            }
        }

        public void AddPlayers(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayers(string player)
        {
            if (!players.Any(p => p.Name == player))
            {
                throw new ArgumentException($"Player {player} is not in {this.Name} team.");
            }

            Player currPlayer = this.players.FirstOrDefault(p => p.Name == player);

            this.players.Remove(currPlayer);
        }

        public override string ToString()
        {
            return $"{Name} - {Rating}";
        }
    }
}
