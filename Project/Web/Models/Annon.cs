using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Annon
    {
        public int AnnonId { get; set; }
        [Required(ErrorMessage ="Поле обязательно для заполнения")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Organisation { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string ContactFace { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string NumberPhone { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Type { get; set; }

    }
}