using System.ComponentModel.DataAnnotations;

namespace moviemvc.Models.Domain
{
    public class MovieGenre
    {
     [Key]
     public int Id { get; set; }
     public int MovieId { get; set; }
     public  int GenreId { get; set; }
    }
}
