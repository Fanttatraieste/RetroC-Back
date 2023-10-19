using FluentValidation;
using FootballIconsCAPI.Data;
using FootballIconsCAPI.DTOs;
using FootballIconsCAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FootballIconsCAPI.Controllers
{
    [Route("api/nations")]
    [ApiController]
    public class NationsController: ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IValidator<NationsDTO> _nationValidator;

        public NationsController(DataContext dataContext, IValidator<NationsDTO> nationValidator)
        {
            _dataContext = dataContext;
            _nationValidator = nationValidator;
        }

        //[HttpGet]
        //[Route("")]
        //public async Task<IActionResult> GetNations()
        //{
        //    return Ok(_dataContext.Nations);
        //}

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<Nation>> GetNations()
        {
            var list = _dataContext.Nations.ToArray();
            return list;
        }

        [HttpPost]
        [Route("addNation")]
        public async Task<IActionResult> AddNation([FromBody] NationsDTO nationDTO)
        {
            var validate = _nationValidator.Validate(nationDTO);
            if (!validate.IsValid)
            {
                var errors = validate.Errors.Select(e => new { e.ErrorCode, e.ErrorMessage });
                return BadRequest(errors);
            }

            _dataContext.Nations.Add(new Entities.Nation
            {
                NationName = nationDTO.NationName,
                Confederation = nationDTO.NationConfederation
            });

            int result = await _dataContext.SaveChangesAsync();
            return result == 1 ? Ok("Nation added successfully") : BadRequest("Error adding the nation in the db");
        }

        [HttpPut]
        [Route("updateNation/{id}")]
        public async Task<ActionResult> UpdateNation([FromBody] NationsDTO nationDTO, int id)
        {
            _dataContext.Nations.Update(new Entities.Nation
            {
                NationID = id,
                NationName = nationDTO.NationName,
                Confederation = nationDTO.NationConfederation
            });

            int result = await _dataContext.SaveChangesAsync();
            return result == 1 ? Ok("Nation updated successfully") : BadRequest("Error updating the nation in the db");
        }

        [HttpDelete]
        [Route("deleteNation/{id}")]
        public async Task<ActionResult> DeleteNation(int id)
        {
            var NationItem = await _dataContext.Nations.FindAsync(id);
            if (NationItem == null)
            {
                return NotFound();
            }

            await _dataContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
