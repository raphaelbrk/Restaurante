using FluentValidation;
using SistemaRestaurante.Negocio.Classes;

namespace SistemaRestaurante.Negocio.Validacoes
{
    /// <summary>
    /// Classe responsável por validar os dados do prato.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{SistemaRestaurante.Negocio.Classes.Prato}" />
    public class ValidacaoPrato : AbstractValidator<Prato>
    {
        public ValidacaoPrato()
        {
            RuleFor(prato => prato.CodigoRestaurante)
                .NotEqual(0)
                .WithMessage("Código do restaurante é obrigatório");

            RuleFor(prato => prato.Nome)
                .NotEmpty()
                .WithMessage("Nome do prato é obrigatório");

            RuleFor(prato => prato.Valor)
                .NotEqual(0)
                .WithMessage("Valor do prato é obrigatório");
        }
    }
}