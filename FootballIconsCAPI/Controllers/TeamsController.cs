using FluentValidation;
using FootballIconsCAPI.Data;
using FootballIconsCAPI.DTOs;
using FootballIconsCAPI.Entities;
//using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

namespace FootballIconsCAPI.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamsController: ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IValidator<TeamsDTO> _teamValidator;

        public TeamsController(DataContext dataContext, IValidator<TeamsDTO> teamValidator)
        {
            _dataContext = dataContext;
            _teamValidator = teamValidator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<Team>> GetTeams()
        {
            var list = _dataContext.Teams.ToArray();
            return list;
        }

        [HttpPost]
        [Route("addTeam")]
        public async Task<IActionResult> AddTeam([FromBody] TeamsDTO teamsDTO)
        {
            var validate = _teamValidator.Validate(teamsDTO);
            if (!validate.IsValid)
            {
                var errors = validate.Errors.Select(e => new { e.ErrorCode, e.ErrorMessage });
                return BadRequest(errors);
            }

         

            _dataContext.Teams.Add(new Entities.Team
            {
                TeamName = teamsDTO.TeamName,
                Country = teamsDTO.TeamCountry,
            });

            int result = await _dataContext.SaveChangesAsync();
            return result == 1 ? Ok("Team added successfully") : BadRequest("Error adding the team in the db");
        }

        [HttpPut]
        [Route("updateTeam/{id}")]
        public async Task<ActionResult> UpdateTeam([FromBody] TeamsDTO teamsDTO, int id)
        {
            _dataContext.Teams.Update(new Team
            {
                TeamID = id,
                TeamName = teamsDTO.TeamName,
                Country = teamsDTO.TeamCountry,
            });

            int result = await _dataContext.SaveChangesAsync();
            return result == 1 ? Ok("Team updated successfully") : BadRequest("Error updating the team in the db");
        }

        [HttpDelete]
        [Route("deleteTeam/{id}")]
        public async Task<ActionResult> DeleteTeam(int id)
        {
            var TeamItem = await _dataContext.Teams.FindAsync(id);
            if (TeamItem == null)
            {
                return NotFound();
            }

            _dataContext.Teams.Remove(TeamItem);

            await _dataContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
