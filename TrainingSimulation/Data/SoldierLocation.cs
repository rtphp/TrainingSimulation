namespace TrainingSimulation.Data
{
    public class SoldierLocation
    {
        public long Id { get; set; }
        public long SoldierId { get; set; }
        public Soldier Soldier { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
