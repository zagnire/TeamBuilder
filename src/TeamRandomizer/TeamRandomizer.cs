using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamRandomizer
{
    public class TeamRandomizer : ITeamRandomizer
    {
        private int _teamSize;
        private IRandom _random;

        public TeamRandomizer(int teamSize) : this(teamSize, new DefaultRandom())
        {
        }

        public TeamRandomizer(int teamSize, IRandom random)
        {
            _teamSize = teamSize;
            _random = random;
        }

        public IList<Team> Build(IList<string> players)
        {
            var teams = new List<Team>();
            var remainingPlayers = players.Select(player => player.Clone().ToString()).ToList<string>();

            var team = new Team("Dream team");
            while (remainingPlayers.Count > 0)
            {
                var playerIndex = _random.Next(0, remainingPlayers.Count);
                team.Add(remainingPlayers[playerIndex]);
                remainingPlayers.RemoveAt(playerIndex);

                if (team.Size == _teamSize)
                {
                    teams.Add(team);
                    team = new Team(String.Empty);
                }
            }

            return teams;
        }
    }
}
