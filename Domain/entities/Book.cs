using System;
namespace Domain.entities;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int CategoryId { get; set; }
    public string ISBN { get; set;  }
    public string description { get; set; }
    public DateTime? PublishedDate { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreateDat { get; set; }
}