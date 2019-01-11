using System;
using System.Collections.Generic;
using System.Linq;

namespace LiskovPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        int getBadNotificationDuration(List<Notification> arr)
        {
            int TotalDuration = 0;
            foreach(Notification n in arr)
            {
                if (n is Twitter)
                {
                    TotalDuration += (n as Twitter).getTweetLength();
                }
                else if (n is Facebook)
                {
                    TotalDuration += (n as Facebook).getFBMessageLength();
                }
                else if(n is SnapChat)
                {
                    TotalDuration += (n as SnapChat).getSnapLength();
                }
            }
            return TotalDuration;
        }

        int getGoodNotificationDuration(List<Notification> arr)
        {
            return arr.Sum(n => n.getLength());
        }

    }
}
