using FluentValidation.Results;
using SistemaRestaurante.Negocio.Classes;
using SistemaRestaurante.Negocio.Validacoes;
using SistemaRestaurante.Persistencia;
using SistemaRestaurante.Servico.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SistemaRestaurante.Servico.Classes
{
    /// <summary>
    /// Serviço responsável para o acesso o repositório de banco restaurante.
    /// </summary>
    /// <seealso cref="SistemaRestaurante.Servico.Classes.ServicoBase{SistemaRestaurante.Negocio.Classes.Restaurante}" />
    /// <seealso cref="SistemaRestaurante.Servico.Interface.IServicoDeRestaurante" />
    public class ServicoDeRestaurante : ServicoBase<Restaurante>, IServicoDeRestaurante
    {
        /// <summary>
        /// Metódo responsável em excluir o objeto em banco.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        public override void Excluir(int Codigo)
        {
            using (RestauranteModel context = new RestauranteModel())
            {
                if (Codigo > 0)
                {
                    var restaurante = (from r in context.Restaurantes where r.Codigo == Codigo select r).FirstOrDefault();
                    if (restaurante != null)
                    {
                        new ServicoDePrato().Excluir(Codigo);
                        context.Restaurantes.Remove(restaurante);
                        context.SaveChanges();
                    }
                }
            }
        }

        /// <summary>
        /// Obtenha os valores no banco.
        /// </summary>
        /// <returns>
        /// Objeto Prato ou Restaurante.
        /// </returns>
        public override List<Restaurante> Obtenha(string Nome)
        {
            using (RestauranteModel context = new RestauranteModel())
            {
                var restaurantes = !string.IsNullOrWhiteSpace(Nome) ? (from r in context.Restaurantes where r.Nome.Contains(Nome) select r)
                                              : (from r in context.Restaurantes select r);

                return restaurantes.ToList();
            }
        }

        /// <summary>
        /// Metódo responsável em salvar o objeto em banco.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        public override void Salvar(Restaurante dados)
        {
            using (RestauranteModel context = new RestauranteModel())
            {
                if (dados != null)
                {
                    //context.Restaurantes.Remove(dados);
                    context.Restaurantes.Add(dados);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Metódo responsável em validar o objeto.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override ValidationResult Valide(Restaurante dados)
        {
            if (dados != null)
            {
                ValidacaoRestaurante validacao = new ValidacaoRestaurante();
                return validacao.Validate(dados);
            }
            return new ValidationResult();
        }
    }
}