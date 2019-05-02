using GraphQl.Api.Models;
using GraphQL.Types;

namespace GraphQl.Api.GraphQL.Types
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(t => t.Id);
            Field(t => t.UserName);
            Field(t => t.DateOfBirth);
            Field(t => t.Gender);
            Field(t => t.City);
            Field(t => t.Country);
        }
    }
}