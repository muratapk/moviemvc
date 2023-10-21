using System.ComponentModel.DataAnnotations;

namespace moviemvc.Models.Domain
{
    public class Genre
    {
     [Key]
     public int GenreId { get; set; }

     public string? GenreName{ get; set; }

     virtual public List<Movie>? Movies { get; set; }

    }
}
