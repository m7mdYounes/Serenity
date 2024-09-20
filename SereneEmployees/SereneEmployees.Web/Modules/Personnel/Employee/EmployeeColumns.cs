using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace SereneEmployees.Personnel.Columns;

[ColumnsScript("Personnel.Employee")]
[BasedOnRow(typeof(EmployeeRow), CheckNames = true)]
public class EmployeeColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    [QuickFilter]
    public string FullName { get; set; }
    public DateTime HireDate { get; set; }
    [DisplayName("Age")]
    [QuickFilter]
    public Int32? Age { get; set; }
    public decimal Salary { get; set; }

}