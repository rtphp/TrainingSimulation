using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingSimulation.Controllers.Models;
using TrainingSimulation.Data;

namespace TrainingSimulation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainingSimulationController : ControllerBase
    {
        private readonly TrainingSimulationDbContext _dbContext;

        public TrainingSimulationController(TrainingSimulationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("saveSoldiersLocations")]
        public async Task<IActionResult> SaveSoldiersLocations(SaveSoliderLocationRequest saveSoliderLocationRequest, CancellationToken cancellationToken)
        {
            var entities = saveSoliderLocationRequest.SoldierLocations.Select(x => new Data.SoldierLocation
            {
                SoldierId = x.SoldierId,
                Latitude = x.Latitude,
                Longitude = x.Longitude,
            });

            await _dbContext.BulkInsertAsync(entities, cancellationToken: cancellationToken);

            return Created();
        }

        [HttpGet("getSoldiers")]
        public async Task<IActionResult> GetSoldiersLocations(CancellationToken cancellationToken)
        {
            var soldiers = await _dbContext.Soldiers.Select(x => new
            {
                Soldier = x,
                CurrentLocation = x.Locations.OrderByDescending(x => x.Id).FirstOrDefault()
            })
            .ToListAsync(cancellationToken);

            var result = soldiers.Select(x => new
            {
                Id = x.Soldier.Id,
                Name = x.Soldier.Name,
                Rank = x.Soldier.Rank,
                Country = x.Soldier.Country,
                TrainingInfo = x.Soldier.TrainingInfo,
                Latitude = x.CurrentLocation?.Latitude,
                Longitude = x.CurrentLocation?.Longitude,
            }).ToList();

            return Ok(result);
        }
    }
}
