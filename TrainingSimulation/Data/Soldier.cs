namespace TrainingSimulation.Data
{
    public class Soldier
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Country { get; set; }
        public string TrainingInfo { get; set; }

        public ICollection<SoldierLocation> Locations { get; set; }
    }
}
