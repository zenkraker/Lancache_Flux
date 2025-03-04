﻿namespace DeveLanCacheUI_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly ILogger<StatusController> _logger;
        private readonly DeveLanCacheUIDbContext _dbContext;

        public StatusController(ILogger<StatusController> logger, DeveLanCacheUIDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<StatusModel> GetAsync()
        {
            _logger.Log(LogLevel.Information, "### Status Controller Get() called");

            var statusModel = StatusObtainer.GetStatus();

            if (SteamAppInfoService._currentChangeNumber != 0)
            {
                statusModel.SteamChangeNumber = SteamAppInfoService._currentChangeNumber.ToString();
            }
            else
            {
                var depotVersionSetting = await _dbContext.Settings.FirstOrDefaultAsync(t => t.Key == DbSetting.SettingKey_DepotVersion);
                statusModel.SteamDepotVersion = depotVersionSetting?.Value;
            }
            return statusModel;
        }
    }
}
