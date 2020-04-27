namespace NotificationSender
{
    using NotificationSender.Internal;
    using System;
    using System.Threading.Tasks;

    class Program
    {
        private

        static async Task Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine($"{DateTime.UtcNow}: Hello World!");
                await Task.Delay(Constants.ActionTimeout);
            }          
        }
    }
}