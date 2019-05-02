using GraphQl.Api.Models;
using GraphQL.Types;

namespace GraphQl.Api.GraphQL.Types
{
    public class VehicleType : ObjectGraphType<Vehicle>
    {
        public VehicleType()
        {
            Field(t => t.Id);
            Field(t => t.Colour);
            Field(t => t.Make);
            Field(t => t.Model);
            Field<VehicleTypeEnumType>("VehicleType", "The type of vehicle");
        }
    }
}