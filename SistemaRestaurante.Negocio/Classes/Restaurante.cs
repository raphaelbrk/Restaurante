using System.Collections.Generic;

namespace SistemaRestaurante.Negocio.Classes
{
    /// <summary>
    /// Objeto que referência os restaurante.
    /// </summary>
    public class Restaurante
    {
        /// <summary>
        /// Código do restaurante.
        /// </summary>
        /// <value>
        /// Código do pratos.
        /// </value>
        public int Codigo { get; set; }

        /// <summary>
        /// Nome do restaurante.
        /// </summary>
        /// <value>
        /// Nome do restaurante.
        /// </value>
        public string Nome { get; set; }

        /// <summary>
        /// Lista de Pratos do restaurante.
        /// </summary>
        /// <value>
        /// Pratos restaurantes.
        /// </value>
        public List<Prato> Pratos { get; set; }
    }
}