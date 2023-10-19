using FluentValidation;
using FootballIconsCAPI.DTOs;

namespace FootballIconsCAPI.Validators
{
    public class TeamValidator : AbstractValidator<TeamsDTO>
    {
        public TeamValidator()
        {
            RuleFor(t => t.TeamName).NotEmpty()
                .WithErrorCode("team_name_required")
                .WithMessage("A team MUST have a name");

            RuleFor(t => t.TeamCountry).NotEmpty()
                .WithErrorCode("team_country_required")
                .WithMessage("A team must be from some country");
        }
    }
}
