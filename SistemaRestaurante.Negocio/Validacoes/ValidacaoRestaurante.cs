using FluentValidation;
using SistemaRestaurante.Negocio.Classes;

namespace SistemaRestaurante.Negocio.Validacoes
{
    /// <summary>
    /// Classe responsável por validar os dados do restaurante.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{SistemaRestaurante.Negocio.Classes.Restaurante}" />
    public class ValidacaoRestaurante : AbstractValidator<Restaurante>
    {
        public ValidacaoRestaurante()
        {
            RuleFor(rest => rest.Nome)
                .NotEmpty()
                .WithMessage("Nome do restaurante é obrigatório");
        }
    }
}