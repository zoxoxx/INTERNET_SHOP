using Microsoft.Identity.Client;

namespace INTERNET_SHOP.Models.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        //Связь с заказом
        public Guid OrderId { get; set; }
        public Order Order {get; set;}
        //Связб с покупаемым продуктом
        public int ProductId { get; set; }
        public Product Product { get; set; }
        //Связь с местом
        public int PositionId { get; set; }
        public Position Position { get; set; }
        //Связь с расписанием
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        //Пользователь который купил
        public int UserAutorizeId { get; set; }
        public UserAutorize User { get; set; }
    }
}
