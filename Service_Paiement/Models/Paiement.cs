using System.ComponentModel.DataAnnotations;

namespace Service_Paiement.Models
{
    public class Paiement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ReservationId { get; set; }
        public string StripeSessionId { get; set; } // ID retourné par Stripe [cite: 239]
        public decimal Montant { get; set; }
        public string Devise { get; set; } = "CAD";
        public string StatutPaiement { get; set; } // "Succeeded", "Pending", "Failed" [cite: 250]
        public DateTime DateTransaction { get; set; } = DateTime.UtcNow;
    }
}
