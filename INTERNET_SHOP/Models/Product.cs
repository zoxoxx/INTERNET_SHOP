namespace INTERNET_SHOP.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? PathImage { get; set; }
        public string? Description { get; set; }

        //Связь с типом (Кино, представление, гастрономическое шоу и тд)
        public int TypeProductId { get; set; }
        public TypeProduct? TypeProduct { get; set; }
    }
}
