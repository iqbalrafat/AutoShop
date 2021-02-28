using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class Feature
    {
        [Required]
        [Key]       
        public int ID { get; set; }
        [Required]
        [MaxLength(255)]
        public String Name { get; set; }
    }
}
