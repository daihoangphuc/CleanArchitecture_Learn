using CleanArchitecture.Application.Services;
using CleanArchitecture.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data.SqlTypes;

namespace CleanArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        public readonly NewService _newsService;
        public NewController(NewService newService)
        {
            _newsService = newService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<New>> GetNewById(string id) 
        { 
            return await _newsService.GetNewById(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<New>>> GetAllNews()
        {
            var news = await _newsService.GetAllNewsSerViece();
            return Ok(news);
        }

        [HttpPost]
        public async Task<ActionResult> AddNewAsync(New news)
        {
            await _newsService.AddNewService(news);
            return CreatedAtAction(nameof(GetNewById), new { id = news.NewId }, news);
        }
    }
}
