using System.ComponentModel.DataAnnotations;

namespace INTERNET_SHOP.Models.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        //Связь с пользователями
        public List<UserAutorize> Users { get; set; } = new();
    }
}
