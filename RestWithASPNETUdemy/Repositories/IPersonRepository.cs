using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repositories.Generic;

namespace RestWithASPNETUdemy.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
    }
}
