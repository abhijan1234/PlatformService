using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlatformService.EntityResolver.Database.Models;

namespace PlatformService.ServiceResolver.Repository
{
    public interface IPlatformServiceRepository
    {
        public Task<IEnumerable<PlatformModel>> GetAllPlatforms();

        public Task<PlatformModel> GetPlatformById(Guid id);

        public Task<Guid> CreatePlatform(PlatformModel platformModel);
    }
}
