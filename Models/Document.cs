using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Document
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string DocumentName { get; set; } = string.Empty;
    }
}