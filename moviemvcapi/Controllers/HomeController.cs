using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Data;
using moviemvcapi.Repository;

namespace moviemvcapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        

        public readonly IMovieRepository _movieRepository;

        public HomeController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            try
            {
                return Ok(await _movieRepository.GetAll());
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Hata Oluştu");
            }
        }

    }
}
