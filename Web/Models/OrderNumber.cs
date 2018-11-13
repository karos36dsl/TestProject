using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class OrderNumber
    {

        public int OrderNumberId { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string MiddleName { get; set; }

        public string NumberId { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public DateTime BeginDate { get; set; }
       [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public DateTime EndDate { get; set; }
    }
}