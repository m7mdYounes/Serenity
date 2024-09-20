using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SereneEmployees.Personnel.Pages;

[PageAuthorize(typeof(EmployeeRow))]
public class EmployeePage : Controller
{
    [Route("Personnel/Employee")]
    public ActionResult Index()
    {
        return this.GridPage("@/Personnel/Employee/EmployeePage",
            EmployeeRow.Fields.PageTitle());
    }
}