using InjecaoDependencia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependencia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IServicoPessoa _servicoPessoa;

        public PessoaController(IServicoPessoa servicoPessoa)
        {
            _servicoPessoa = servicoPessoa;
        }

        [HttpGet]
        public string ObterUsuario()
        {
            return _servicoPessoa.ObterNomePessoa();
        }
    }
}