using Serenity.Services;
using MyRequest = testweb.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<testweb.Administration.UserRow>;
using MyRow = testweb.Administration.UserRow;

namespace testweb.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}