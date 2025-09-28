using Factory.Fabrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory factory;

            factory = new EmailNotificationFactory();
            var email = factory.CreateNotification();
            email.Send("Hello via Email!");

            factory = new SmsNotificationFactory();
            var sms = factory.CreateNotification();
            sms.Send("Hello via SMS!");

        }
    }
}
