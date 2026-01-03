using System.ComponentModel.DataAnnotations;

namespace JarmuMvcApp.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Rendszám")]
        public string LicensePlate { get; set; } = string.Empty;

        [Display(Name = "Tulaj")]
        public string? Owner { get; set; }

        [Display(Name = "Név")]
        public string? Name { get; set; }

        [Display(Name = "Típus")]
        public string? Type { get; set; }
    }
}
