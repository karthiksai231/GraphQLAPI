using GraphQl.Api.Models;
using GraphQl.Api.Repository;
using GraphQL.Types;

namespace GraphQl.Api.GraphQL.Types
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType(VehicleRepository vehicleRepository)
        {
            Field(t => t.Id);
            Field(t => t.UserName);
            Field(t => t.DateOfBirth);
            Field(t => t.Gender);
            Field(t => t.City);
            Field(t => t.Country);
            Field<ListGraphType<VehicleType>>("Vehicles",
            resolve: context => vehicleRepository.GetVehicleForUsersAsync(context.Source.Id));
        }
    }
}