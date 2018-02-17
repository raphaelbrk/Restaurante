using SistemaRestaurante.Negocio.Classes;

namespace SistemaRestaurante.Servico.Interface
{
    /// <summary>
    /// Interface do serviço de pratos do sistema de restaurante.
    /// </summary>
    /// <typeparam name="Prato">Objeto prato.</typeparam>
    /// <seealso cref="SistemaRestaurante.Servico.Interface.IServico{Prato}" />
    public interface IServicoDePrato : IServicoBase<Prato>
    {
    }
}