using Hexagon.Datas.Data;
using Hexagon.Domains;

namespace Hexagon.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>
    {
        public PessoaRepository(HexagonAPIContext context) : base(context)
        {
        }
    }
}
