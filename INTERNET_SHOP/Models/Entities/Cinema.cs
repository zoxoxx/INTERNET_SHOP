namespace INTERNET_SHOP.Models.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        //Связь с сущностью город
        public int CityId { get; set; }
        public City City { get; set; }

        //Связь с продуктом
        public List<Product> Products { get; set; } = new();
        //Связь с залами
        public List<Hall> Halls { get; set; } = new();
    }
}
