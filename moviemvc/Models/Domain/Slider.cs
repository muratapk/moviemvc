using System.ComponentModel.DataAnnotations.Schema;

namespace moviemvc.Models.Domain
{
    public class Slider
    {
        public int SliderId { get; set; }
        public string? Heading1 { get; set; }
        public string? Heading2 { get; set; }
        public string? Context { get; set; }
        public string? SliderImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile{get; set; }

    }
}
