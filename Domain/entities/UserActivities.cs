using System; 
using System.Runtime.InteropServices.JavaScript;

namespace Domain.entities;

public class UserActivities
{
    public int  ActivityId { set; get; }
    public int UserId { set; get; }
    public string ActivityType { set; get; }
    public int  BookId { set; get; }
    public DateTime ActivityDate { set; get; }
}

