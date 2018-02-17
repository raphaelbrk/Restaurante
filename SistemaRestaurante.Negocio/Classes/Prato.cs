using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaRestaurante.Negocio.Classes
{
    /// <summary>
    /// Objeto que referência os pratos de um determinado restaurante.
    /// </summary>
    public class Prato
    {
        /// <summary>
        /// Código do pratos.
        /// </summary>
        /// <value>
        /// Código do pratos.
        /// </value>
        public int Codigo { get; set; }

        /// <summary>
        /// Código do restaurante.
        /// </summary>
        /// <value>
        /// Código do Restaurante.
        /// </value>
        public int CodigoRestaurante { get; set; }

        /// <summary>
        /// Nome do pratos.
        /// </summary>
        /// <value>
        /// Nome do pratos.
        /// </value>
        public string Nome { get; set; }

        /// <summary>
        /// Valor individual do prato.
        /// </summary>
        /// <value>
        /// Valor individual do prato.
        /// </value>
        public double Valor { get; set; }

        [ForeignKey("CodigoRestaurante")]
        public Restaurante Restaurante { get; set; }
    }
}