namespace INTERNET_SHOP.Models
{
    public class Position
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int NumberRow { get; set; }
        //Связь с билетом
        List<Ticket> Tickets { get; set; } = new();
    }
}
