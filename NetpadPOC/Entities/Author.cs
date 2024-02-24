namespace NetpadPOC.Entities;

public class Author
{
    public int RandomPrimaryKey { get; set; }
    public ICollection<Book> Books { get; set; }
}