using GraphQl.Api.Models;
using GraphQL.Types;

namespace GraphQl.Api.GraphQL.Types
{
    public class VehicleTypeEnumType : EnumerationGraphType<VehicleType>
    {
        public VehicleTypeEnumType()
        {
            Name = "VehicleType";
            Description = "The type of vehicle";
        }
    }
}