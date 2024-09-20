using Serenity.ComponentModel;
using System;

namespace SereneEmployees.Personnel.Forms;

[FormScript("Personnel.Employee")]
[BasedOnRow(typeof(EmployeeRow), CheckNames = true)]
public class EmployeeForm
{
    public string FullName { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal Salary { get; set; }
    public string Image { get; set; }
}