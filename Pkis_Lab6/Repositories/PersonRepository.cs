using Lab6.Data;
using Lab6.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6.Repositories;

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

