using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; // Add this for validation attributes

namespace SereneEmployees.Personnel;

[ConnectionKey("Default"), Module("Personnel"), TableName("Employee")]
[DisplayName("Employee"), InstanceName("Employee")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class EmployeeRow : Row<EmployeeRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Full Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string FullName { get => fields.FullName[this]; set => fields.FullName[this] = value; }

    [DisplayName("Hire Date"), NotNull]
    [DateRangeValidation("2020-01-01")]  // Custom validation for Hire Date
    public DateTime? HireDate { get => fields.HireDate[this]; set => fields.HireDate[this] = value; }

    [DisplayName("Birth Date"), NotNull]
    [AgeValidation(25, 60)]  // Custom validation for Age range
    public DateTime? BirthDate { get => fields.BirthDate[this]; set => fields.BirthDate[this] = value; }

    [DisplayName("Age"), Expression("(DATEDIFF(YEAR, T0.BirthDate, GETDATE()) - CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, T0.BirthDate, GETDATE()), T0.BirthDate) > GETDATE() THEN 1 ELSE 0 END)")]
    public int? Age
    {
        get => Fields.Age[this];
        set => Fields.Age[this] = value;
    }

    [DisplayName("Salary"), Size(19), Scale(5), NotNull]
    public decimal? Salary { get => fields.Salary[this]; set => fields.Salary[this] = value; }

    [DisplayName("Image"), Size(255)]
    [ImageUploadEditor]
    public string Image { get => fields.Image[this]; set => fields.Image[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField FullName;
        public DateTimeField HireDate;
        public DateTimeField BirthDate;
        public DecimalField Salary;
        public StringField Image;
        public Int32Field Age;
    }
}
