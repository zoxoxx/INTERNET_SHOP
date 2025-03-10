namespace INTERNET_SHOP.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? PathImage { get; set; }
        public string? Description { get; set; }
        public TimeOnly TimeRun { get; set; }
        //Ценник в рамках сеанса считать по формуле - Цена услуги + (Коэффициентная цена места / 100 и * 10 ).
        // Может быть еще какое нибудь рандомное число из небольшого интервала добавлять
        public double Price { get; set; }

        //Связь с типом (Кино, представление, гастрономическое шоу и тд)
        public int TypeProductId { get; set; }
        public TypeProduct? TypeProduct { get; set; }
        //Связь с билетом
        public List<Ticket> Tickets { get; set; } = new();
    }
}
