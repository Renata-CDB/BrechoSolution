using BrechoDomain.InputDTO;
using FluentValidation;

namespace BrechoDomain.Validator
{
    public class ClienteInputDtoValidator : AbstractValidator<ClienteInputDto>
    {
        public ClienteInputDtoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome do cliente é obrigatório!")
                .NotNull().WithMessage("Nome do cliente é obrigatório!")
                .MinimumLength(2).WithMessage("Nome do cliente deve conter no mínimo três caracteres!")
                .MaximumLength(50).WithMessage("Nome do cliente deve conter no máximo 50 caracteres!");

            RuleFor(c => c.Sobrenome)
                .NotEmpty().WithMessage("Sobrenome do cliente é obrigatório!")
                .NotNull().WithMessage("Sobrenome do  cliente é obrigatório!")
                .MinimumLength(2).WithMessage("Nome do  cliente deve conter no mínimo dois caracteres!")
                .MaximumLength(30).WithMessage("Nome do  cliente deve conter no máximo 30 caracteres!");

           


        }
    }
}
