using GraphQL;
using GraphQL.Types;

namespace GraphQl.Api.GraphQL
{
    public class UserSchema : Schema
    {
        public UserSchema(IDependencyResolver dependencyResolver) : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<UserQuery>();
        }
    }
}