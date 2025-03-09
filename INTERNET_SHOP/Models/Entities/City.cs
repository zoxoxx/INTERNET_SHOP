namespace INTERNET_SHOP.Models.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Связь с другими сущностями
        public List<Ticket> Tickets { get; set; } = new();
        public List<Cinema> Cinemas { get; set; } = new();
    }
}
