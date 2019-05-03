using GraphQl.Api.Models;
using GraphQL.Types;

namespace GraphQl.Api.GraphQL.Types
{
    public class VehicleTypeEnumType : EnumerationGraphType<UserVehicleType>
    {
        public VehicleTypeEnumType()
        {
            Name = "Type";
            Description = "The type of vehicle";
        }
    }
}