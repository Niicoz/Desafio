using System.Web.Http;
using Desafio.Repositorio;

namespace Desafio.Controllers
{
    public class MdrController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var repositorioDeMdr = new RepositorioMdr();
            var adquirentes = repositorioDeMdr.RetornarTodasAsMdr();
            return Ok(adquirentes);
        }
    }
}
