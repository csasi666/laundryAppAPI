using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class VendorIdentityProof
    {
        [Key]
        public int IdentityNumber { get; set; }

        [ForeignKey("VendorDetail")]
        public long VendorMobile { get; set; }

        [ForeignKey("Document")]
        public int ProofId { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        [Required]
        public byte[] ProofImage { get; set; } = Array.Empty<byte>();

        [Required]
        public byte[] VendorSelfieImage { get; set; } = Array.Empty<byte>();

        [Required]
        public bool IsProofValidated { get; set; } = false;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Timestamp { get; set; }

        // Navigation properties
        public VendorDetail VendorDetail { get; set; } = new VendorDetail();
        public Document Document { get; set; } = new Document();
    }
}