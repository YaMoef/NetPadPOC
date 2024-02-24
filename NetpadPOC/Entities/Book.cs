namespace NetpadPOC.Entities;

public class Book
{
    public int Id { get; set; }
    public string ISBN { get; set; }
    public Author Author { get; set; }
    public int RandomPrimaryKey { get; set; }
}