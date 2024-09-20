using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneEmployees.Personnel.EmployeeRow>;
using MyRow = SereneEmployees.Personnel.EmployeeRow;

namespace SereneEmployees.Personnel;

public interface IEmployeeListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class EmployeeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeListHandler
{
    public EmployeeListHandler(IRequestContext context)
            : base(context)
    {
    }
}