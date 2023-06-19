using System;
using System.ComponentModel.DataAnnotations;

namespace PlatformService.EntityResolver.Database.Models
{
    public class PlatformModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public int Cost { get; set; }
    }
}
