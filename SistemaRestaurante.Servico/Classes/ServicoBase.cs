using FluentValidation.Results;
using SistemaRestaurante.Servico.Interface;
using System.Collections.Generic;

namespace SistemaRestaurante.Servico.Classes
{
    /// <summary>
    /// Classe abstrata que possuí os serviços do sistema.
    /// </summary>
    /// <typeparam name="T">Objeto Prato ou Restaurante.</typeparam>
    public abstract class ServicoBase<T> : IServicoBase<T>
    {
        /// <summary>
        /// Metódo responsável em excluir o objeto em banco.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        public abstract void Excluir(int Codigo);

        /// <summary>
        /// Obtenha os valores no banco.
        /// </summary>
        /// <returns>Objeto Prato ou Restaurante.</returns>
        public abstract List<T> Obtenha(string Nome);

        /// <summary>
        /// Metódo responsável em salvar o objeto em banco.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        public abstract void Salvar(T dados);

        /// <summary>
        /// Metódo responsável em validar o objeto.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        /// <returns></returns>
        public abstract ValidationResult Valide(T dados);
    }
}