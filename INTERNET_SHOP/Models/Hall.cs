namespace INTERNET_SHOP.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool VIP { get; set; }
        public int NumberSeats { get; set; }
        //Связь с площадкой
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
    }
}
