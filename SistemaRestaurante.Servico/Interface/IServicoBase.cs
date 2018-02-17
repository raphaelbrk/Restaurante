using FluentValidation.Results;
using System.Collections.Generic;

namespace SistemaRestaurante.Servico.Interface
{
    /// <summary>
    /// Interface dos serviços do sistema de restaurante.
    /// </summary>
    /// <typeparam name="T">Objeto Prato ou Restaurante.</typeparam>
    public interface IServicoBase<T>
    {
        /// <summary>
        /// Metódo responsável em excluir o objeto em banco.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        void Excluir(int Codigo);

        /// <summary>
        /// Obtenha os valores no banco.
        /// </summary>
        /// <returns>Objeto Prato ou Restaurante.</returns>
        List<T> Obtenha(string Nome);

        /// <summary>
        /// Metódo responsável em salvar o objeto em banco.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        void Salvar(T dados);

        /// <summary>
        /// Metódo responsável em validar o objeto.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        ValidationResult Valide(T dados);
    }
}