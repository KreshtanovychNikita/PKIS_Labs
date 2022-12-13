using Lab4.Models;
using Lab4.Repositories;

namespace Lab4.Controllers;

public sealed class GoodsController : GenericController<Goods>
{
    public GoodsController(IRepository<Goods> repository) : base(repository) { }
}
