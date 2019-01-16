using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    interface LockScreenItem
    {
        string Message { get; }
        string Caption { get; }
        int Priority { get; }
    }

    class LockScreen
    {
        List<Notification> Notifications;

        private void RefreshDisplay() { }

        public void Display(Notification n)
        {
            Notifications.Add(n);
            RefreshDisplay();
        }

        //But what if we want to display more than just notifications?
        //What about alerts?
        List<LockScreenItem> DisplayItems;
        public void Display(LockScreenItem item)
        {
            DisplayItems.Add(item);
            RefreshDisplay();
        }
    }
}
