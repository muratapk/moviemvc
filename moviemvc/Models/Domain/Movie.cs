using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moviemvc.Models.Domain
{
    public class Movie
    {
      [Key]
       public int MovieId { get; set; }

        public string? Title { get; set; }

        public string? ReleaseYear { get; set; }

        public  string? MovieImage { get; set; }
        
        public string? Cast { get; set; }
        
        public string Director { get; set; }

        public string? Details { get; set; }

        public string? MovieTime { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public int? GenreId { get; set; }

        virtual public Genre? Genre{get; set; }

       

    }
}
