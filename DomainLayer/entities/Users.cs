using System;
namespace Domain.entities;

public class Users
{
    public int UserId { set; get; }
    public string UserName { set; get; }
    public string PasswordHash { set; get; }
    public string Email { set; get; }
    public string Role { set; get; }
    public DateTime CreateDat { set; get; }
    
}