using SistemaRestaurante.Negocio.Classes;
using SistemaRestaurante.Servico.Classes;
using SistemaRestaurante.Servico.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SistemaRestaurante.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/ServicoRestaurante")]
    public class ServicoRestauranteController : ApiController
    {
        [AcceptVerbs("POST")]
        [Route("CadastrarPrato")]
        public void CadastrarPrato([FromBody]Prato Prato)
        {
            IServicoDePrato servicoPratos = new ServicoDePrato();
            var validacao = servicoPratos.Valide(Prato);
            if (!validacao.Errors.Any())
            {
                servicoPratos.Salvar(Prato);
            }
        }

        [AcceptVerbs("POST")]
        [Route("CadastrarRestaurante")]
        public void CadastrarRestaurante([FromBody]Restaurante Restaurante)
        {
            IServicoDeRestaurante servicoRestaurante = new ServicoDeRestaurante();
            var validacao = servicoRestaurante.Valide(Restaurante);
            if (!validacao.Errors.Any())
            {
                servicoRestaurante.Salvar(Restaurante);
            }
        }

        [AcceptVerbs("DELETE")]
        [Route("DeletarPrato")]
        public void DeletarPrato(int Codigo)
        {
            IServicoDePrato servicoPratos = new ServicoDePrato();
            servicoPratos.Excluir(Codigo);
        }

        [AcceptVerbs("DELETE")]
        [Route("DeletarPrato")]
        public void DeletarResturante(int Codigo)
        {
            IServicoDeRestaurante servicoRestaurante = new ServicoDeRestaurante();
            servicoRestaurante.Excluir(Codigo);
        }

        [AcceptVerbs("GET")]
        [Route("ObtenhaPratos")]
        public IEnumerable<Prato> ObtenhaPratos(int Codigo)
        {
            IServicoDePrato servicoPratos = new ServicoDePrato();
            var pratos = servicoPratos.Obtenha(Codigo.ToString());
            return pratos;
        }

        [AcceptVerbs("GET")]
        [Route("ObtenhaRestaurantes")]
        public IEnumerable<Restaurante> ObtenhaRestaurantes(string Nome)
        {
            IServicoDeRestaurante servicoRestaurante = new ServicoDeRestaurante();
            var restaurante = servicoRestaurante.Obtenha(Nome);
            return restaurante;
        }
    }
}