using Lab5.Data;
using Lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Repositories;

public class PersonRepository : GenericRepository<Person>
{
    public PersonRepository(LibraryDbContext context) : base(context) { }

    public override async Task<IEnumerable<Person>> GetAllAsync()
    {
        return await Context.Set<Person>()
            .AsNoTracking()
            .Include(r => r.Company)
            .ToListAsync();
    }

    public override async Task<Person> GetAsync(Guid id)
    {
        var entity = await Context.Set<Person>()
            .AsNoTracking()
            .Include(r => r.Company)
            .FirstOrDefaultAsync(e => e.Id == id);

        return entity!;
    }
}