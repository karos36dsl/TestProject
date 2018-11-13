using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Number
    {
        public int NumberId { get; set; }
       
        public string QuantityRooms { get; set; }
        
        public string TypeRoom { get; set; }

        public string Status { get; set; }
        
        public string Price { get; set; }
        
        

    }
}