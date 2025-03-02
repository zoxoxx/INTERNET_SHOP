using Microsoft.Identity.Client;

namespace INTERNET_SHOP.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        //Связь с сущностью город
        public int CityId { get; set; }
        public City City { get; set; }
        //Связь с заказом
        public Guid OrderId { get; set; }
        public Order Order {get; set;}
    }
}
