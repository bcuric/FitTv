using System.ComponentModel.DataAnnotations;

namespace FitTv.Models
{
    public class VideoType
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}