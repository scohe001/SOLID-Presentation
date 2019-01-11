using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple
{
    class Twitter : Notification
    {
        public int getTweetLength() { return 4; }
        public override int getLength() { return getTweetLength(); }
    }

    class Facebook : Notification
    {
        public int getFBMessageLength() { return 42; }
        public override int getLength() { return getFBMessageLength(); }
    }

    class SnapChat : Notification
    {
        public int getSnapLength() { return 19; }
        public override int getLength() { return getSnapLength(); }
    }
}
