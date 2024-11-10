using System;
using RecordManagement.Models;

namespace RecordManagement.ViewModels;

public class DepartmentViewModel
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }

    //Relationship with Employees
    public ICollection<Employee> Employees { get; set; }//Collection Navigation Property
}
