using AutoMapper;
using BusinessLogic;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApp.Dto;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PremisesController : ControllerBase
    {
        private readonly IEntityService<Premise> _premiseService;
        private readonly IMapper _mapper;

        public PremisesController(IEntityService<Premise> premiseService, IMapper mapper)
        {
            _premiseService = premiseService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public IActionResult Get() => Ok(_premiseService.GetAll());
        
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id) => Ok(_premiseService.GetById(id));

        [HttpPost]
        public IActionResult Post(PremiseDto newPremise)
        {
            return Ok(_premiseService.Create(_mapper.Map<Premise>(newPremise)));
        }
        
        [HttpPut]
        public IActionResult Update(Premise premise) => Ok(_premiseService.Update(premise));

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _premiseService.Delete(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }   
}