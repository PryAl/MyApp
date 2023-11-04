using BusinessLogic;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PremisesController : ControllerBase
    {
        private readonly IEntityService<Premise> _premiseService;

        public PremisesController(IEntityService<Premise> premiseService)
        {
            _premiseService = premiseService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get() => Ok(_premiseService.GetAll());
        [HttpPost]
        public IActionResult Post() => Ok(_premiseService.Create(new Premise()
        {
            Floor = 3,
            Name = "home",
            Rooms = new List<Room>()
        }));
    }   
}