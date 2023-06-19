using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatformService.EntityResolver.Database;
using PlatformService.EntityResolver.Database.Models;

namespace PlatformService.ServiceResolver.Repository
{
    public class PlatformServiceRepository : IPlatformServiceRepository
    {
        private readonly DataContext _dataContext;
        public PlatformServiceRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Guid> CreatePlatform(PlatformModel platformModel)
        {
            if (platformModel == null)
            {
                throw new ArgumentNullException("Invalid Input");
            }

            var Id = Guid.NewGuid();
            platformModel.Id = Id;
            _dataContext.platformModels.Add(platformModel);
            await _dataContext.SaveChangesAsync();
            return Id;
        }

        public async Task<IEnumerable<PlatformModel>> GetAllPlatforms()
        {
            return await _dataContext.platformModels.ToListAsync();
        }

        public async Task<PlatformModel> GetPlatformById(Guid id)
        {
            return await _dataContext.platformModels.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
