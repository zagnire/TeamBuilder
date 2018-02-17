using System.Collections.Generic;

namespace TeamRandomizer
{
    public class Team
    {
        private List<string> _players = new List<string>();

        public string Name { get; private set; }

        public IReadOnlyList<string> Players
        {
            get { return _players.AsReadOnly(); }
        }

        public int Size
        {
            get { return _players.Count; }
        }

        public Team(string name)
        {
            Name = name;
        }

        internal void Add(string player)
        {
            _players.Add(player);
        }
    }
}