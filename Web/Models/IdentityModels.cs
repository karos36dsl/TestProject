using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Web.Models
{
    // В профиль пользователя можно добавить дополнительные данные, если указать больше свойств для класса ApplicationUser. Подробности см. на странице https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }
    //Модель Номера Отеля
    public class Number
    {
        public int NumberId { get; set; }

        public string QuantityRooms { get; set; }

        public string TypeRoom { get; set; }

        public string Status { get; set; }

        public string Price { get; set; }
    }

    //Модель оформления номера
    public class OrderNumber
    {
        public int OrderNumberId { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string MiddleName { get; set; }

        public int NumberId { get; set; }
        public string UserId { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public DateTime BeginDate { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public DateTime EndDate { get; set; }
    }


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Number> Numbers { get; set; }
        public DbSet<OrderNumber> OrderNumbers { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnectionn", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}