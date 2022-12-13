using Lab4.Models;
using Lab4.Repositories;

namespace Lab4.Controllers;

public sealed class PersonController : GenericController<Person>
{
    public PersonController(IRepository<Person> repository) : base(repository) { }
}