using System;
using System.Collections.Generic;
using System.Text;

namespace interface_test
{
    class SoccerPlayer : Player
    {
        String Name;
        int real_age;
        int Player.age
        {
            get
            {
                if(this.real_age > 50)
                {
                    return -1;
                }
                return this.real_age;
            }
        }
        String Player.getName() { return Name; }
        public SoccerPlayer() : this("Bobby", 5) { }
        public SoccerPlayer(String n, int a) { Name = n; real_age = a; }
    }
}
