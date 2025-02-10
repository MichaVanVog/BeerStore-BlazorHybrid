using BeerStore.CoreBusiness;
using BeerStore.Server.Models;
using BeerStore.UseCases.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace BeerStore.Server.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SubdivisionsController(ISubdivisionRepository subdivisionRepository) : ControllerBase
    {
        private readonly ISubdivisionRepository subdivisionRepository = subdivisionRepository;

        [HttpGet]
        public async Task<IActionResult> GetSubdivisionsAsync()
        {
            var subdivisions = await subdivisionRepository.GetSubdivisionsAsync();
            if (subdivisions is null)
            {
                return NotFound();
            }
            return Ok(subdivisions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubdivisionAsync(int id)
        {
            var subdivision = await subdivisionRepository.GetSubdivisionAsync(id);
            if (subdivision is null)
            {
                return NotFound();
            }
            return Ok(subdivision);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditSubdivisionAsync(int id, EditSubdivision model)
        {
            var subdivision = await subdivisionRepository.GetSubdivisionAsync(id);
            if (subdivision is null)
            {
                return NotFound();
            }

            subdivision.Name = model.Name;
            subdivision.NameOnWebsite = model.NameOnWebsite;
            subdivision.TelegramChatIdIntern = model.TelegramChatIdIntern;
            subdivision.Active = model.Active;
            subdivision.TelegramChatIdExtern = model.TelegramChatIdExtern;
            subdivision.WhatsAppContact = model.WhatsAppContact;
            subdivision.Phone = model.Phone;
            subdivision.TelegramChannel = model.TelegramChannel;
            subdivision.Address = model.Address;
            subdivision.OpenTime = model.OpenTime;
            subdivision.StoreImagePath = model.StoreImagePath;

            await subdivisionRepository.UpdateSubdivisionAsync(subdivision);

            return Ok(subdivision);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteSubdivisionAsync(int id)
        {
            var subdivision = await subdivisionRepository.GetSubdivisionAsync(id);
            if (subdivision is null)
            {
                return NotFound();
            }

            await subdivisionRepository.DeleteSubdivisionAsync(subdivision);

            return Ok(subdivision);
        }
    }
}
