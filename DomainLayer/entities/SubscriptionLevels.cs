using System;
namespace Domain.entities;

public class SubscriptionLevels
{
    public int SubscriptionLevelId { set; get; }
    public string Name { set; get; }
    public int MaxDevice { set; get; }
    public int Price { set; get; }
    public string description { set; get; }
}