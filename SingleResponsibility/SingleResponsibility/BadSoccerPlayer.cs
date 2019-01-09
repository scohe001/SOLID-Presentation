using System;
using System.Collections.Generic;
using System.Text;

namespace BadPlayerNamespace
{
    class PlayerReport { };
}

namespace SingleResponsibility
{
    class BadSoccerPlayer
    {
        public string Name { get; }
        public int PhoneNumber { get; }
        public int GoalsScored { get; private set; }


        public BadSoccerPlayer(string n, int p) { Name = n; PhoneNumber = p; GoalsScored = 0; }

        public BadPlayerNamespace.PlayerReport CalculatePlayerReport() {
            //Imagine this actually contained logic to generate a report
            // using GoalsScored and some other data to be fetched...
            return new BadPlayerNamespace.PlayerReport();
        }

        public int CalculatePlayerRating()
        {
            //Imagine this actually contained logic to calculate a rating
            // based on GoalsScored and some other datat to be fetched...
            return 4;
        }
    }
}
