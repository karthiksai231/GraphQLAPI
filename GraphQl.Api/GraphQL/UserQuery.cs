using GraphQl.Api.GraphQL.Types;
using GraphQl.Api.Repository;
using GraphQL.Types;

namespace GraphQl.Api.GraphQL
{
    public class UserQuery : ObjectGraphType
    {
        public UserQuery(UserRepository userRepository)
        {
            Field<ListGraphType<UserType>>("users", resolve: c => userRepository.GetAllUsersAsync());
        }
    }
}