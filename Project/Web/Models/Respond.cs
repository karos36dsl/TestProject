using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Respond
    {

        public int RespondId { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Name { get; set; }
        public string AnnonId { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string AboutMe { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string MyNomberPhone { get; set; }
    }
}