using System;
using System.ComponentModel.DataAnnotations;
using RecordManagement.Models;

namespace RecordManagement.ViewModels;

public class DepartmentViewModel
{

    public int DepartmentId { get; set; }

    [Required(ErrorMessage = "Department name is required.")]
    public string Name { get; set; }
}
