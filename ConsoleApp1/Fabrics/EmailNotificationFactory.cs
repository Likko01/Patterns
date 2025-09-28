using ConsoleApp1.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Fabrics
{
    public class EmailNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification() => new EmailNotification();
    }

}
