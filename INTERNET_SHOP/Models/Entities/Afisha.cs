namespace INTERNET_SHOP.Models.Entities
{
    public class Afisha
    {
        public int Id { get; set; }
        public string InputCategory { get; set; }
        //Связь с продуктом
        public int ProductId { get; set; }
        public Product Product { get; set; }
        //Связь с подчиненными расписаниями
        public List<Schedule> Schedules { get; set; } = new();
    }
}
