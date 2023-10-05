using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    public int EmployeeID{get; set;}

    [Required]
    public string FirstName{get; set;}

    [Required]
    public string LastName{get; set;}
    [Required]
    public string Email{get; set;}
    [Required]
    public string MobileNumber{get; set;}
    [Required]
    public string Department{get; set;}
    [Required]
    public 
}