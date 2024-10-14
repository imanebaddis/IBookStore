using System; 
namespace Domain.entities;

public class Subscriptions
{
    public int SubscriptionId { set; get; }
    public int UserId { set; get; }
    public int SubscriptionLevelId { set; get; }
    public DateTime StartDate { set; get; }
    public string Status { set; get; }
    
}