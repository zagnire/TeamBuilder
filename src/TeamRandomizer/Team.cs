using System.Collections.Generic;

namespace TeamRandomizer
{
    /// <summary>
    /// Team class
    /// </summary>
    public class Team
    {
        private List<string> _players = new List<string>();

        /// <summary>
        /// Gets the team name.
        /// </summary>
        /// <value>
        /// Team name.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the players of the team.
        /// </summary>
        /// <value>
        /// The players.
        /// </value>
        public IReadOnlyList<string> Players
        {
            get { return _players.AsReadOnly(); }
        }

        /// <summary>
        /// Gets the size of the team.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public int Size
        {
            get { return _players.Count; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Team"/> class.
        /// </summary>
        /// <param name="name">Team name.</param>
        public Team(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Adds the specified player to the team.
        /// </summary>
        /// <param name="player">The player.</param>
        internal void Add(string player)
        {
            _players.Add(player);
        }
    }
}