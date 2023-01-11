using Hexagon.Domains;
using Hexagon.Repositories.Interfaces;
using Hexagon.Services.Interfaces;

namespace Hexagon.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        public PessoaService(IRepository<Pessoa> repository) : base(repository)
        {
        }
    }
}
