using System;
namespace Domain.entities;

public class Favorites
{
    
    public int FavoriteId { get; set; }
    public int UserId { get; set; }
    public int BookId {get; set; }
    public DateTime? AddeDate { get; set; }
    
    
}