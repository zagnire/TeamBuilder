using System.Collections.Generic;

namespace TeamRandomizer
{
    /// <summary>
    /// Team randomizer interface that builds a list of teams (<see cref="Team"/>)
    /// </summary>
    public interface ITeamRandomizer
    {
        /// <summary>
        /// Builds a list of teams from the specified players.
        /// </summary>
        /// <param name="players">The players.</param>
        /// <returns></returns>
        IList<Team> Build(IList<string> players);

    }
}
