using Microsoft.EntityFrameworkCore;

namespace TrainingSimulation.Data
{
    public class TrainingSimulationDbContext : DbContext
    {
        public TrainingSimulationDbContext(DbContextOptions<TrainingSimulationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Soldier> Soldiers { get; set; }
        public DbSet<SoldierLocation> SoldierLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entities
            modelBuilder.Entity<Soldier>().Property(x => x.Name).HasMaxLength(128);
            modelBuilder.Entity<Soldier>().Property(x => x.Rank).HasMaxLength(128);
            modelBuilder.Entity<Soldier>().Property(x => x.Country).HasMaxLength(128);
            modelBuilder.Entity<Soldier>().Property(x => x.TrainingInfo).HasMaxLength(512);

            modelBuilder.Entity<SoldierLocation>().Property(x => x.Latitude).HasColumnType("decimal(9, 6)");
            modelBuilder.Entity<SoldierLocation>().Property(x => x.Longitude).HasColumnType("decimal(9, 6)");

            // Seed data
            SeedSoldiers(modelBuilder);
            SeedSoldiersLocations(modelBuilder);
        }

        private static void SeedSoldiers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Soldier>().HasData(
                new Soldier { Id = 1, Name = "John Doe", Rank = "Sergeant", Country = "United States", TrainingInfo="Training info" },
                new Soldier { Id = 2, Name = "Maria Ivanova", Rank = "Lieutenant", Country = "Russia", TrainingInfo="Training info" },
                new Soldier { Id = 3, Name = "Akira Tanaka", Rank = "Captain", Country = "Japan", TrainingInfo="Training info" },
                new Soldier { Id = 4, Name = "Ahmed Al-Farsi", Rank = "Major", Country = "Saudi Arabia", TrainingInfo="Training info" },
                new Soldier { Id = 5, Name = "Carlos Sanchez", Rank = "Corporal", Country = "Mexico", TrainingInfo="Training info" },
                new Soldier { Id = 6, Name = "Pierre Dupont", Rank = "Private", Country = "France", TrainingInfo="Training info" },
                new Soldier { Id = 7, Name = "Hassan Abdallah", Rank = "Lieutenant", Country = "Egypt", TrainingInfo="Training info" },
                new Soldier { Id = 8, Name = "Chen Wei", Rank = "Colonel", Country = "China", TrainingInfo="Training info" },
                new Soldier { Id = 9, Name = "Liam O'Connor", Rank = "Sergeant", Country = "Ireland", TrainingInfo="Training info" },
                new Soldier { Id = 10, Name = "Rajesh Patel", Rank = "Major", Country = "India", TrainingInfo="Training info" },
                new Soldier { Id = 11, Name = "Elena Petrova", Rank = "Captain", Country = "Russia", TrainingInfo="Training info" },
                new Soldier { Id = 12, Name = "Kofi Mensah", Rank = "Private", Country = "Ghana", TrainingInfo="Training info" },
                new Soldier { Id = 13, Name = "Miguel Ramirez", Rank = "Lieutenant", Country = "Spain", TrainingInfo="Training info" },
                new Soldier { Id = 14, Name = "Thomas Müller", Rank = "Sergeant", Country = "Germany", TrainingInfo="Training info" },
                new Soldier { Id = 15, Name = "Paulo Oliveira", Rank = "Corporal", Country = "Brazil", TrainingInfo="Training info" },
                new Soldier { Id = 16, Name = "Isabella Rossi", Rank = "Lieutenant", Country = "Italy", TrainingInfo="Training info" },
                new Soldier { Id = 17, Name = "Abdul Rahman", Rank = "Captain", Country = "Pakistan", TrainingInfo="Training info" },
                new Soldier { Id = 18, Name = "Satoshi Nakamura", Rank = "Sergeant", Country = "Japan", TrainingInfo="Training info" },
                new Soldier { Id = 19, Name = "Zainab Al-Hassan", Rank = "Major", Country = "Saudi Arabia", TrainingInfo="Training info" },
                new Soldier { Id = 20, Name = "Robert Johnson", Rank = "Corporal", Country = "United Kingdom", TrainingInfo="Training info" },
                new Soldier { Id = 21, Name = "Jorge Gonzalez", Rank = "Private", Country = "Argentina", TrainingInfo="Training info" },
                new Soldier { Id = 22, Name = "Amina Ali", Rank = "Lieutenant", Country = "Nigeria", TrainingInfo="Training info" },
                new Soldier { Id = 23, Name = "David Kim", Rank = "Sergeant", Country = "South Korea", TrainingInfo="Training info" },
                new Soldier { Id = 24, Name = "Yousef Nasser", Rank = "Colonel", Country = "United Arab Emirates", TrainingInfo="Training info" },
                new Soldier { Id = 25, Name = "Hans Schmidt", Rank = "Major", Country = "Germany", TrainingInfo="Training info" },
                new Soldier { Id = 26, Name = "Luciana Silva", Rank = "Lieutenant", Country = "Brazil", TrainingInfo="Training info" },
                new Soldier { Id = 27, Name = "Daniel Novak", Rank = "Captain", Country = "Poland", TrainingInfo="Training info" },
                new Soldier { Id = 28, Name = "Fatima Mohamed", Rank = "Private", Country = "Egypt", TrainingInfo="Training info" },
                new Soldier { Id = 29, Name = "Sebastian Berg", Rank = "Corporal", Country = "Sweden", TrainingInfo="Training info" },
                new Soldier { Id = 30, Name = "Leila El-Hadad", Rank = "Lieutenant", Country = "Morocco", TrainingInfo = "Training info" }
            );
        }

        private static void SeedSoldiersLocations(ModelBuilder modelBuilder)
        {
            var soldiersLocations = new List<SoldierLocation>();
            var random = new Random();
            var soldierLocationId = 1;
            for (int i = 1; i < 31; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    soldiersLocations.Add(new SoldierLocation
                    {
                        Id = soldierLocationId++,
                        SoldierId = i,
                        Latitude = (decimal)random.NextDouble() * 180 - 90,
                        Longitude = (decimal)random.NextDouble() * 360 - 180,
                    });
                }
            }

            modelBuilder.Entity<SoldierLocation>().HasData(soldiersLocations);
        }
    }
}
