using System.ComponentModel.DataAnnotations;

namespace AspNetCoreID.Models
{
    public class TwoFactorModel
    {
        [Required]
        public string Token { get; set; }
    }
}