using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification n = new Twitter("test");
            Console.WriteLine(n.NotificationMessage);
            Console.ReadKey();
        }
    }
}
