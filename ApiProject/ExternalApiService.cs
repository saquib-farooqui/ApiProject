using System.Net.Http;
using System.Threading.Tasks;
using ApiProject.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ApiProject
{
    public class ExternalApiService
    {
        private readonly HttpClient _httpclient;
        private readonly DatabaseContext _db;

        public ExternalApiService(HttpClient httpClient, DatabaseContext db)
        {
            _httpclient = httpClient;
            _db = db;
        }

        public async Task<List<Albums>> GetFile()
        {

            var response = await _httpclient.GetStringAsync("https://potterapi-fedeperin.vercel.app/en/books");

            var albums = JsonConvert.DeserializeObject<List<Albums>>(response);
      
            await  _db.Album.AddRangeAsync(albums);
           await _db.SaveChangesAsync();

            return albums;
        }
     



    }
}

