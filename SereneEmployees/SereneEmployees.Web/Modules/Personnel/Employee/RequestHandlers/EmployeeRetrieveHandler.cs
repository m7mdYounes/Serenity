using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SereneEmployees.Personnel.EmployeeRow>;
using MyRow = SereneEmployees.Personnel.EmployeeRow;

namespace SereneEmployees.Personnel;

public interface IEmployeeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class EmployeeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeRetrieveHandler
{
    public EmployeeRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}