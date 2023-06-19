using System;
using AutoMapper;
using PlatformService.EntityResolver.Database.Models;

namespace PlatformService.EntityResolver.DTO
{
    public class ProfileDTO : Profile
    {
        public ProfileDTO()
        {
            CreateMap<PlatformModel, PlatformReadDTO>();
            CreateMap<PlatformCreateDTO, PlatformModel>();
        }
    }
}
