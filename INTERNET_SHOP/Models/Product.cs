namespace INTERNET_SHOP.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? PathImage { get; set; }
        public string? Description { get; set; }
        public TimeOnly TimeRun { get; set; }

        //Связь с типом (Кино, представление, гастрономическое шоу и тд)
        public int TypeProductId { get; set; }
        public TypeProduct? TypeProduct { get; set; }
        //Связь с билетом
        public List<Ticket> Tickets { get; set; } = new();
        //Связь с кинотеатром
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
    }
}
