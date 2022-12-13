using Lab4.Models;
using Lab4.Repositories;

namespace Lab4.Controllers;

public sealed class CompanyController : GenericController<Company>
{
    public CompanyController(IRepository<Company> repository) : base(repository) { }
}