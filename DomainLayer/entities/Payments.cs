namespace Domain.entities;

public class Payments
{
    public int PaymentId { get; set; }
    public int UserId { get; set; }
    public int Amount { get; set; } 
    public DateTime PaymentDate { get; set; } 
    public string PaymentMethod { get; set; }
}