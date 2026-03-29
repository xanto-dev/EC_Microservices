using System.ComponentModel.DataAnnotations;

namespace Service_Authentification.Models
{
    public class TokenRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UtilisateurId { get; set; } // Correspond à l'ID de IdentityUser 

        [Required]
        public string RefreshToken { get; set; }

        [Required]
        public DateTime DateCreation { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime DateExpiration { get; set; }

        public bool EstRevoque { get; set; } = false;

        public bool EstExpire => DateTime.UtcNow >= DateExpiration;

        public bool EstActif => !EstRevoque && !EstExpire;
    
    }
}
