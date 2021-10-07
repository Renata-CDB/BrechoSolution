using BrechoDomain.InputDto;
using FluentValidation;

namespace BrechoDomain.Validator
{
    public class ProdutoInputDtoValidator : AbstractValidator<ProdutoInputDto>
    {
        public ProdutoInputDtoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Nome do produto é obrigatório!")
                .NotNull().WithMessage("Nome do produto é obrigatório!")
                .MinimumLength(2).WithMessage("Nome do produto deve conter no mínimo dois caracteres!")
                .MaximumLength(30).WithMessage("Nome do produto deve conter no máximo 30 caracteres!");

            RuleFor(p => p.Valor)
                .NotEmpty().WithMessage("Valores são obrigatórios!")
                .NotNull().WithMessage("Valores são obrigatórios!");
        }


    }
}
