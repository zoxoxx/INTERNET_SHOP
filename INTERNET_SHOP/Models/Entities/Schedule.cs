namespace INTERNET_SHOP.Models.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateOnly DateEvent { get; set; }
        public TimeOnly TimeStartEvent { get; set; }
        public TimeOnly TimeEndEvent { get; set; }
        public int CountTickets { get; set; }
        //Продукт
        public int ProductId { get; set; }
        public Product Product { get; set; }
        //Зал
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        //Билеты
        public List<Ticket> Tickets { get; set; } = new();
    }
}
