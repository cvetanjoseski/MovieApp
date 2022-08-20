using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Database;
using MovieApp.DTOs;
using MovieApp.Entities;
using System.Linq;

namespace MovieApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movies : ControllerBase
    {
        [HttpGet("getAllMoviesByIdDto")]
        public IActionResult GetMovieById([FromQuery] GetMovieByIdDto getMovieById )
        {
            Movie movieDb = MovieDatabase.MOVIES.FirstOrDefault(x => x.Id == getMovieById.Id) ;

            if(movieDb == null)
                return NotFound();
            return StatusCode(StatusCodes.Status200OK);
        }        
    }
}
