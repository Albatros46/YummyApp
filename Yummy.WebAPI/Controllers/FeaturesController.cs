using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.WebAPI.Data;
using Yummy.WebAPI.DTOs.FeatureDtos;
using Yummy.WebAPI.Entities;

namespace Yummy.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public FeaturesController(IMapper mapper, ApplicationDbContext context = null)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public IActionResult featureGetList()
        {
            var values = _context.Features.ToList();
            return Ok(_mapper.Map<List<ResultFeatureDto>>(values));
        }
        [HttpPost]
        public IActionResult createFeature(CreateFeatureDto dto)
        {
            var valaues = _mapper.Map<Feature>(dto);
            _context.Features.Add(valaues);
            _context.SaveChanges();
            return Ok("Einfügung erfolgreich...");
        }
        [HttpDelete]
        public IActionResult deleteFeature(int id)
        {
            var value = _context.Features.Find(id);
            _context.Features.Remove(value);
            _context.SaveChanges();
            return Ok("Löschung erfolgreich...");
        }
        [HttpGet]
        public IActionResult getFeature(int id)
        {
            var value = _context.Features.Find(id);
            return Ok(_mapper.Map<ResultFeatureDto>(value));
        }
        [HttpPut]
        public IActionResult updateFeature(UpdateFeatureDto dto)
        {
            var value = _mapper.Map<Feature>(dto);
            _context.Features.Update(value);
            _context.SaveChanges();
            return Ok("Aktualisierung erfolgreich...");
        }
    }
}
