using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repositories.Generic;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
        List<Person> FindByName(string firstName, string secondName);
    }
}
