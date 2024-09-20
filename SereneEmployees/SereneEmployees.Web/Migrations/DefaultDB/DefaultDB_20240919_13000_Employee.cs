using FluentMigrator;

namespace Serene.Migrations.DefaultDB;
[Migration(20240919_13000)]
public class DefaultDB_20240919_13000_Employee : AutoReversingMigration
{
    public override void Up()
    {
        

        Create.Table("Employee")
            .WithColumn("Id").AsInt32().Identity().PrimaryKey().Unique().NotNullable()
            .WithColumn("FullName").AsString(100).NotNullable()
            .WithColumn("HireDate").AsDate().NotNullable()
            .WithColumn("BirthDate").AsDate().NotNullable()
            .WithColumn("Salary").AsDecimal().NotNullable()
            .WithColumn("Image").AsString().Nullable();
    }
}