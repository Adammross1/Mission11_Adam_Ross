namespace Mission11_Adam_Ross.Models
{
    public interface IBooksRepository
    {
        IQueryable<Book> Books { get; }
    }
}
