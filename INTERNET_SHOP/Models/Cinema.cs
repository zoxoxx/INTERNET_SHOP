namespace INTERNET_SHOP.Models
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
    }
}
