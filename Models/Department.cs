using System;
using System.Runtime.CompilerServices;

namespace RecordManagement.Models;

public class Department
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public bool IsActive { get; set; }
}
