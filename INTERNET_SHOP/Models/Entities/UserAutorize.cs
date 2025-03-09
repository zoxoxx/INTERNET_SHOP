using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace INTERNET_SHOP.Models.Entities
{
    public class UserAutorize
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        [MaxLength(128)]
        public string Login { get; set; }
        [MaxLength(128)]
        public string Password { get; set; }
        //Связь с ролью
        public int RoleId { get; set; }
        public Role Role { get; set; }
        //Связь с билетами
        public List<Ticket> Tickets { get; set; } = new();
    }
}
