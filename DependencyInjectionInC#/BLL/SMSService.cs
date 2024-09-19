using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionInC_.BLL
{
    public class SMSService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS Message {message}");
        }
    }
}
