namespace GraphQl.Api.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Colour { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public UserVehicleType Type { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
