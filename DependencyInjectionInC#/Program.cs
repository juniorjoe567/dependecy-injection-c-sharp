using DependencyInjectionInC_.BLL;

class Program { 
    static void Main(String[] args)
    {
        IMessageService messageService = new SMSService();
        var orderService = new OrderService(messageService);
        orderService.PlaceOrder("Order No. 1");
    }
}