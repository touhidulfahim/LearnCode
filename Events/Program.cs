using System;

namespace Events
{
    class Program
    {
        public delegate void Notify(string address, string message);

        public event Notify Notification;
        static void Main(string[] args)
        {
            var instance = new Program();
            instance.Notification += EmailNotification;
            instance.Notification += MobileMessage;
            instance.Notification("info@mail.com", "Hello from Email");
            instance.Notification("","Hello from Mobile");
        }
        private static void EmailNotification(string address, string message)
        {
            Console.WriteLine($"Sending from Email to {address} Message is: {message}");
        }
        private static void MobileMessage(string address, string message)
        {
            Console.WriteLine($"Sending from Mobile to {address} Message is: {message}");
        }
    }
}
