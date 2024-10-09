using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainingSimulation.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Soldiers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Rank = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    TrainingInfo = table.Column<string>(type: "TEXT", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soldiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoldierLocations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SoldierId = table.Column<long>(type: "INTEGER", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9, 6)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldierLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoldierLocations_Soldiers_SoldierId",
                        column: x => x.SoldierId,
                        principalTable: "Soldiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Soldiers",
                columns: new[] { "Id", "Country", "Name", "Rank", "TrainingInfo" },
                values: new object[,]
                {
                    { 1L, "United States", "John Doe", "Sergeant", "Training info" },
                    { 2L, "Russia", "Maria Ivanova", "Lieutenant", "Training info" },
                    { 3L, "Japan", "Akira Tanaka", "Captain", "Training info" },
                    { 4L, "Saudi Arabia", "Ahmed Al-Farsi", "Major", "Training info" },
                    { 5L, "Mexico", "Carlos Sanchez", "Corporal", "Training info" },
                    { 6L, "France", "Pierre Dupont", "Private", "Training info" },
                    { 7L, "Egypt", "Hassan Abdallah", "Lieutenant", "Training info" },
                    { 8L, "China", "Chen Wei", "Colonel", "Training info" },
                    { 9L, "Ireland", "Liam O'Connor", "Sergeant", "Training info" },
                    { 10L, "India", "Rajesh Patel", "Major", "Training info" },
                    { 11L, "Russia", "Elena Petrova", "Captain", "Training info" },
                    { 12L, "Ghana", "Kofi Mensah", "Private", "Training info" },
                    { 13L, "Spain", "Miguel Ramirez", "Lieutenant", "Training info" },
                    { 14L, "Germany", "Thomas Müller", "Sergeant", "Training info" },
                    { 15L, "Brazil", "Paulo Oliveira", "Corporal", "Training info" },
                    { 16L, "Italy", "Isabella Rossi", "Lieutenant", "Training info" },
                    { 17L, "Pakistan", "Abdul Rahman", "Captain", "Training info" },
                    { 18L, "Japan", "Satoshi Nakamura", "Sergeant", "Training info" },
                    { 19L, "Saudi Arabia", "Zainab Al-Hassan", "Major", "Training info" },
                    { 20L, "United Kingdom", "Robert Johnson", "Corporal", "Training info" },
                    { 21L, "Argentina", "Jorge Gonzalez", "Private", "Training info" },
                    { 22L, "Nigeria", "Amina Ali", "Lieutenant", "Training info" },
                    { 23L, "South Korea", "David Kim", "Sergeant", "Training info" },
                    { 24L, "United Arab Emirates", "Yousef Nasser", "Colonel", "Training info" },
                    { 25L, "Germany", "Hans Schmidt", "Major", "Training info" },
                    { 26L, "Brazil", "Luciana Silva", "Lieutenant", "Training info" },
                    { 27L, "Poland", "Daniel Novak", "Captain", "Training info" },
                    { 28L, "Egypt", "Fatima Mohamed", "Private", "Training info" },
                    { 29L, "Sweden", "Sebastian Berg", "Corporal", "Training info" },
                    { 30L, "Morocco", "Leila El-Hadad", "Lieutenant", "Training info" }
                });

            migrationBuilder.InsertData(
                table: "SoldierLocations",
                columns: new[] { "Id", "Latitude", "Longitude", "SoldierId" },
                values: new object[,]
                {
                    { 1L, 47.854450092316140m, 29.52004895912160m, 1L },
                    { 2L, -81.5945499692995860m, 80.705906462651040m, 1L },
                    { 3L, 47.452451176406700m, 19.441644717833280m, 2L },
                    { 4L, -11.873775657593340m, -144.8039289875823000m, 2L },
                    { 5L, -12.650158787296320m, -147.7167384365849160m, 3L },
                    { 6L, 27.215154100837620m, 136.478167890174720m, 3L },
                    { 7L, 63.717301751111280m, 151.151648107140720m, 4L },
                    { 8L, 34.62999456716640m, 52.885107805547160m, 4L },
                    { 9L, -67.342986991076580m, -87.349896673826760m, 5L },
                    { 10L, 85.689737806192020m, 159.383973893060160m, 5L },
                    { 11L, 1.364295885852060m, -167.1891258241598040m, 6L },
                    { 12L, 51.152782676153580m, -4.436196363562320m, 6L },
                    { 13L, -78.0640152052077720m, 33.533475125273640m, 7L },
                    { 14L, -17.631888985770120m, -29.043942845110920m, 7L },
                    { 15L, 68.002710132734640m, 54.942339205574280m, 8L },
                    { 16L, 73.256002529843880m, 25.551524205843840m, 8L },
                    { 17L, -33.960915965910960m, -129.587510037946320m, 9L },
                    { 18L, -61.714803544043040m, 159.240163294463040m, 9L },
                    { 19L, 58.528387389850740m, 136.052918259020640m, 10L },
                    { 20L, 17.655713830423440m, 106.359641055239760m, 10L },
                    { 21L, 12.485057182610040m, 51.712722917395560m, 11L },
                    { 22L, -0.953918749930500m, -51.020895172372920m, 11L },
                    { 23L, -63.14481135772020m, -165.9675961732638960m, 12L },
                    { 24L, 23.294308230335700m, 124.735404322236960m, 12L },
                    { 25L, -63.228416688403920m, 167.746617067019400m, 13L },
                    { 26L, 79.915385224240920m, 106.090113238595280m, 13L },
                    { 27L, -38.835613316917440m, -29.574693946662480m, 14L },
                    { 28L, 44.636086429724160m, -29.84804542956240m, 14L },
                    { 29L, -2.850695199591480m, 11.853348314089320m, 15L },
                    { 30L, -88.52602433791677840m, 169.231598076524040m, 15L },
                    { 31L, 26.541958270638240m, 71.582114742033960m, 16L },
                    { 32L, 35.486624048112900m, -143.774961311543040m, 16L },
                    { 33L, -42.738774289996320m, 84.388142404588320m, 17L },
                    { 34L, -88.4476389143974860m, -96.472079458450560m, 17L },
                    { 35L, -8.673818696902440m, 73.203705805776480m, 18L },
                    { 36L, 53.564601290399280m, 89.70346803054240m, 18L },
                    { 37L, 17.298280028354580m, 51.047936495663400m, 19L },
                    { 38L, -86.0348015067389760m, -19.203903314885880m, 19L },
                    { 39L, 86.686700902341660m, 42.846353730278640m, 20L },
                    { 40L, -30.054701986498980m, -69.31293996716280m, 20L },
                    { 41L, 22.843063394019900m, 86.129213350067280m, 21L },
                    { 42L, 65.422919534990580m, -84.803386941649080m, 21L },
                    { 43L, -89.72950146171317640m, -18.782459546300280m, 22L },
                    { 44L, 17.162425466124660m, 92.971175372159400m, 22L },
                    { 45L, 0.573137919128700m, 95.061045380473440m, 23L },
                    { 46L, -34.16410059681780m, 79.939911937182480m, 23L },
                    { 47L, 0.255067614513900m, 82.066298030024040m, 24L },
                    { 48L, 15.582000522857940m, 135.884040964821000m, 24L },
                    { 49L, -59.77441274290020m, 32.726911377077640m, 25L },
                    { 50L, 80.244994051024380m, 3.123086725185840m, 25L },
                    { 51L, -26.985265815012120m, -149.9072345731798920m, 26L },
                    { 52L, 78.749286274380240m, -133.618863896655120m, 26L },
                    { 53L, -29.941901687895840m, 146.842609773155040m, 27L },
                    { 54L, 24.171127872265980m, -18.667386515448720m, 27L },
                    { 55L, 85.934826975854520m, -144.4230707046722640m, 28L },
                    { 56L, 40.888948898292120m, 40.389679728017280m, 28L },
                    { 57L, 89.363541936667320m, 36.138396712467960m, 29L },
                    { 58L, 26.628726487650300m, -75.981891929178960m, 29L },
                    { 59L, -79.5655036710256320m, -1.969818268506840m, 30L },
                    { 60L, -84.4928404047055980m, -30.059933708008080m, 30L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoldierLocations_SoldierId",
                table: "SoldierLocations",
                column: "SoldierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoldierLocations");

            migrationBuilder.DropTable(
                name: "Soldiers");
        }
    }
}
