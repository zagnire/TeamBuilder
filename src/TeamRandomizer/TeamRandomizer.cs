using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamRandomizer
{
    /// <summary>
    /// Team randomizer
    /// </summary>
    /// <seealso cref="TeamRandomizer.ITeamRandomizer" />
    public class TeamRandomizer : ITeamRandomizer
    {
        private int _teamSize;
        private IRandom _random;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRandomizer"/> class with <see cref="DefaultRandom"/>
        /// </summary>
        /// <param name="teamSize">Number of players in each team.</param>
        public TeamRandomizer(int teamSize) : this(teamSize, new DefaultRandom())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRandomizer"/> class.
        /// </summary>
        /// <param name="teamSize">Number of players in each team.</param>
        /// <param name="random">The random generator.</param>
        public TeamRandomizer(int teamSize, IRandom random)
        {
            _teamSize = teamSize;
            _random = random;
        }

        /// <summary>
        /// Builds a list of teams from the specified players.
        /// </summary>
        /// <param name="players">The players.</param>
        /// <returns></returns>
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
