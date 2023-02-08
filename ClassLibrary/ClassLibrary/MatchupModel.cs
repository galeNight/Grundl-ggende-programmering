using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MatchupModel
    {

        //
        public List<MatchupEntryModel> Entryes { get; set; } = new List<MatchupEntryModel>();
        public TeamModel? Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
