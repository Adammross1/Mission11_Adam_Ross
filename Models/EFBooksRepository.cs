namespace Mission11_Adam_Ross.Models
{
    public class EFBooksRepository : IBooksRepository
    {
        private BooksContext _context;
        public EFBooksRepository(BooksContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
