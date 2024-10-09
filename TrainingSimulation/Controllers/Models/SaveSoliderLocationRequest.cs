namespace TrainingSimulation.Controllers.Models
{
    public class SaveSoliderLocationRequest
    {
        public List<SoldierLocation> SoldierLocations { get; set; } = new();
    }

    public class SoldierLocation
    {
        public long SoldierId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}