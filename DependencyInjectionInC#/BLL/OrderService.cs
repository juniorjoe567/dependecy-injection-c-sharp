using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionInC_.BLL
{
    public class OrderService
    {
        private readonly IMessageService _messageService;

        public OrderService(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void PlaceOrder(string order)
        {
            
            Console.WriteLine($"Order placed {order}");
            _messageService.SendMessage($"Order confirmed for {order}");
        }
    }
}
