using ApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly ExternalApiService _apiservice;
        private readonly DatabaseContext _db;
        public AlbumController(ExternalApiService externalApiService, DatabaseContext db)
        {
            _apiservice = externalApiService;
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> FetchAndSaveAlbums()
        {
           var albums = await _apiservice.GetFile();

            // Return a success response
            return Ok(new { Message = "Albums fetched and saved successfully", AlbumCount = albums.Count });
        }

        [HttpGet]
        public async Task<IEnumerable<Albums>> Get()
        {
            return await _db.Album.ToListAsync();
        }

    }
}
