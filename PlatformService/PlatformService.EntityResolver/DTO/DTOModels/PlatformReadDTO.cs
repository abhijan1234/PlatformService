using System;
namespace PlatformService.EntityResolver.DTO
{
    public class PlatformReadDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public int Cost { get; set; }
    }
}
