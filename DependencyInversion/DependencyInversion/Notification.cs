using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    abstract class Notification : LockScreenItem
    {
        abstract public string Message { get; protected set; }
        abstract public string Caption { get; protected set; }
        abstract public int Priority { get; protected set; }
        abstract public int GetLength();
        abstract public string NotificationMessage { get; protected set; }
    }

    class Twitter : Notification
    {
        public int getTweetLength() { return 4; }
        override public string NotificationMessage { get; protected set; }
        override public string Message { get; protected set; }
        override public string Caption { get; protected set; }
        override public int Priority { get; protected set; }

        public override int GetLength() { return getTweetLength(); }

        public Twitter(string msg) { NotificationMessage = msg; }

    }
}
