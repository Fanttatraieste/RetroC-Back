using FluentValidation;
using FootballIconsCAPI.DTOs;

namespace FootballIconsCAPI.Validators
{
    public class NationValidator: AbstractValidator<NationsDTO>
    {
        public NationValidator()
        {
            RuleFor(n => n.NationName).NotEmpty()
                .WithErrorCode("nation_name_required")
                .WithMessage("A Nation MUST have a name");

            RuleFor(n => n.NationConfederation).NotEmpty()
                .WithErrorCode("nation_confederation_required")
                .WithMessage("A Nation MUST have a confederation");
        }
    }
}
