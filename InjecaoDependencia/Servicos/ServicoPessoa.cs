using InjecaoDependencia.Interfaces;

namespace InjecaoDependencia.Servicos
{
    public class ServicoPessoa : IServicoPessoa
    {
        public string ObterNomePessoa()
        {
            return "Robson";
        }
    }
}
