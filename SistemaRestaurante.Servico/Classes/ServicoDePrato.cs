using FluentValidation.Results;
using SistemaRestaurante.Negocio.Classes;
using SistemaRestaurante.Negocio.Validacoes;
using SistemaRestaurante.Persistencia;
using SistemaRestaurante.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaRestaurante.Servico.Classes
{
    public class ServicoDePrato : ServicoBase<Prato>, IServicoDePrato
    {
        /// <summary>
        /// Metódo responsável em excluir o objeto em banco.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void Excluir(int Codigo)
        {
            using (RestauranteModel context = new RestauranteModel())
            {
                if (Codigo > 0)
                {
                    var prato = Obtenha(Codigo.ToString()).FirstOrDefault();
                    if (prato != null)
                    {
                        context.Pratos.Remove(prato);
                        context.SaveChanges();
                    }
                }
            }
        }

        /// <summary>
        /// Obtenha os valores no banco.
        /// </summary>
        /// <param name="Codigo"></param>
        /// <returns>
        /// Objeto Prato ou Restaurante.
        /// </returns>
        public override List<Prato> Obtenha(string Nome)
        {
            using (RestauranteModel context = new RestauranteModel())
            {
                var pratos = !string.IsNullOrWhiteSpace(Nome) ? (from r in context.Pratos where r.CodigoRestaurante == Convert.ToInt32(Nome) select r)
                                         : (from r in context.Pratos select r);

                return pratos.ToList();
            }
        }

        /// <summary>
        /// Metódo responsável em salvar o objeto em banco.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        public override void Salvar(Prato dados)
        {
            using (RestauranteModel context = new RestauranteModel())
            {
                if (dados != null)
                {
                    context.Pratos.Remove(dados);
                    context.Pratos.Add(dados);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Metódo responsável em validar o objeto.
        /// </summary>
        /// <param name="dados">Objeto Prato ou Restaurante.</param>
        /// <returns></returns>
        public override ValidationResult Valide(Prato dados)
        {
            if (dados != null)
            {
                ValidacaoPrato validacao = new ValidacaoPrato();
                return validacao.Validate(dados);
            }

            return new ValidationResult();
        }
    }
}