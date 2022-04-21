using Microsoft.EntityFrameworkCore;
using WebApiWeek2.Models;
using WebApiWeek2.Repositories.Abstracts;

namespace WebApiWeek2.Repositories.Concrete
{
    public class BooksRepository : GenericRepository<Book>, IBookRepository
    {
        public BooksRepository(BookAuthorContext dbContext) : base(dbContext)
        {
        }
    }
}
