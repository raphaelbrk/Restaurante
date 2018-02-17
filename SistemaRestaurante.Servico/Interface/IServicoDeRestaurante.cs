using SistemaRestaurante.Negocio.Classes;

namespace SistemaRestaurante.Servico.Interface
{
    /// <summary>
    /// Interface do serviço de restaurante do sistema de restaurante.
    /// </summary>
    /// <typeparam name="Restaurante">Objeto restaurante.</typeparam>
    /// <seealso cref="SistemaRestaurante.Servico.Interface.IServico{Restaurante}" />
    public interface IServicoDeRestaurante : IServicoBase<Restaurante>
    {
    }
}