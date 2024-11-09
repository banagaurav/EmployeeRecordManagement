using System;
using System.Runtime.CompilerServices;

namespace RecordManagement.Models;

public class Department
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }

    //Relationship with Employees
    public ICollection<Employee> Employees { get; set; }//Collection Navigation Property
}

