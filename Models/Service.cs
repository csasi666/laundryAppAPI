using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }

        [Required]
        [MaxLength(100)]
        public string ServiceName { get; set; } = string.Empty;

        [MaxLength(255)]
        public string Description { get; set; } = string.Empty; 

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal Price { get; set; }
    }
}