using System;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            BadSoccerPlayer bsp = new BadSoccerPlayer("Brad", 999);
            Console.WriteLine(bsp.Name);
            Console.WriteLine(bsp.PhoneNumber);
            Console.ReadKey();
        }
    }
}
