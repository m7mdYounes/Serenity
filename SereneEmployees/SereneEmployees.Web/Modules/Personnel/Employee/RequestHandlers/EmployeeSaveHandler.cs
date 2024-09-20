using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SereneEmployees.Personnel.EmployeeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneEmployees.Personnel.EmployeeRow;

namespace SereneEmployees.Personnel;

public interface IEmployeeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class EmployeeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeSaveHandler
{
    public EmployeeSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}