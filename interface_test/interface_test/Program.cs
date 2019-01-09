using System;

namespace interface_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Player ed = new SoccerPlayer("Ed", 72);
            Console.WriteLine(ed.getName());
            Console.WriteLine(ed.age);
            Console.ReadKey();
        }
    }
}
