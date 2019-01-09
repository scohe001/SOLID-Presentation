using System;
using System.Collections.Generic;
using System.Text;

namespace GoodPlayerNamespace
{
    class PlayerReport
    {
        /* Imagine this guy has a bunch of data that's
         *  been calculated for a single player... */
        public int PlayerRating { get; private set; }

        public PlayerReport(SingleResponsibility.GoodSoccerPlayer player) { }

    };
}

namespace SingleResponsibility
{
    class GoodSoccerPlayer
    {
        public string Name { get; }
        public int PhoneNumber { get; }
        public int GoalsScored { get; private set; }


        public GoodSoccerPlayer(string n, int p) { Name = n; PhoneNumber = p; GoalsScored = 0; }
    }
}
