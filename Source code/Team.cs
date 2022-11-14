using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup2022
{

    //Class that stores a team name and flag
    public class Team
    {
        public string Name { get; set; }
        public string Flag { get; set; }

        public Team()
        {

        }

        public Team (string name, string flag)
        {
            Name = name;
            Flag = flag;
        }
    }
}
