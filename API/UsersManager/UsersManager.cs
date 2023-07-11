using ApiTestLearning;
using ApiTestLearning.ApiManagers;
using ApiTestLearning.ApiManagers.UsersManager;
using ApiTestLearning.DTO.Request;
using ApiTestLearning.DTO.Response;
using RestSharp;

namespace APITests
{
    public class UsersManager : BaseApiManager
    {
        public UsersManager() : base(BaseUrls.REQRES_IN)
        {
        }
        /*public async Task <RestResponse<GetOneUserResponse>> GetOneUser(CreateGetUserRequest payload, int id)
        {
            var response = await Get()
                .ToEndPoint(UsersRoutes.USER(id))
                .AddHeader("Accept", "application/json")
                .AddBody(payload)
                .ExecAsync<GetOneUserResponse> ();
            return response;
        }*/
        public async Task<RestResponse<GetOneUserResponse>> GetOneUser(int id)
        {
            var response = await Get()
                .ToEndPoint(UsersRoutes.USER(id))
                .AddHeader("Accept", "application/json")
                .ExecAsync<GetOneUserResponse>();
            return response;
        }
        public async Task<RestResponse<ListOfUsersResponse>> GetUsers()
        {
            var response = await Get()
                .ToEndPoint(UsersRoutes.USERS)
                .AddHeader("Accept", "application/json")
                .ExecAsync<ListOfUsersResponse>();

            return response;
        }
        public async Task<RestResponse<CreateUserResponse>> CreateUser(CreateUserRequest payload)
        {
            var response = await Post()
                .ToEndPoint(UsersRoutes.USERS)
                .AddHeader("Accept", "application/json")
                .AddBody(payload)
                .ExecAsync<CreateUserResponse>();
            return response;
        }
        public async Task<RestResponse<DeleteUserResponse>> DeleteUser(int id)
        {
            var response = await Delete()
                .ToEndPoint(UsersRoutes.USER(id))
                .AddHeader("Accept", "application/json")
                .ExecAsync<DeleteUserResponse>();
            return response;
        }
        public async Task<RestResponse<UserRegisterResponse>> RegisterUser(CreateRegisterRequest payload)
        {
            var response = await Post()
                .ToEndPoint(UsersRoutes.REGISTER)
                .AddHeader("Accept", "application/json")
                .AddBody(payload)
                .ExecAsync<UserRegisterResponse>();

            return response;
        }
        public async Task<RestResponse<GetOneUserResponse>> PutUser(CreatePutUserRequest payload, int id)
        {
            var response = await Put()
                .ToEndPoint(UsersRoutes.USER(id))
                .AddHeader("Accept", "application/json")
                .AddBody(payload)
                .ExecAsync<GetOneUserResponse>();
            return response;
        }
    }
}
