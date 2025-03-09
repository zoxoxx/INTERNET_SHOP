namespace INTERNET_SHOP.Models.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime DateTimeOrder { get; set; }
        public double Amount { get; set; }
        public Ticket Ticket { get; set; }
    }
}
