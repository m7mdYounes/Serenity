using MyRequest = SereneEmployees.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneEmployees.Administration.UserRow>;
using MyRow = SereneEmployees.Administration.UserRow;

namespace SereneEmployees.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}