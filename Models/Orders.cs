using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        [Required]
        [ForeignKey("CustomerDetail")]
        public long CustomerMobile { get; set; }

        [ForeignKey("VendorDetail")]
        public long? VendorMobile { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime PickupDate { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        [MaxLength(20)]
        public OrderStatus Status { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        [MaxLength(20)]
        public PaymentStatus PaymentStatus { get; set; }

        [MaxLength(255)]
        public string? SpecialInstructions { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Timestamp { get; set; }

        public CustomerDetail CustomerDetail { get; set; } = new CustomerDetail();
        public VendorDetail VendorDetail { get; set; } = new VendorDetail();
    }
}