using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamRandomizer
{
    public interface ITeamRandomizer
    {
        IList<Team> Build(IList<string> players);

    }
}
