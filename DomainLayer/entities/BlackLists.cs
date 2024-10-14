using System;
namespace Domain.entities;

public class BlackLists
{
    public int BlackListId { set; get; }
    public int UserId { set; get; }
    public string Reason { set; get; }
    public DateTime BlackListDat { set; get; }
    
    
}