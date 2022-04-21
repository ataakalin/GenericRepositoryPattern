using Microsoft.EntityFrameworkCore;
using WebApiWeek2.Models;
using WebApiWeek2.Repositories.Abstracts;

namespace WebApiWeek2.Repositories.Concrete
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(BookAuthorContext dbContext) : base(dbContext)
        {

        }

        
    }
}
