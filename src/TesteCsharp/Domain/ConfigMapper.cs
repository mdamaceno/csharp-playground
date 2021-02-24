using AutoMapper;
using System.Collections.Generic;
using TesteCsharp.Domain.Model;
using TesteCsharp.Domain.UseCase.Stock;

namespace TesteCsharp.Domain
{
    public class ConfigMapper
    {
        public static IMapper Handle()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Dictionary<string, dynamic>, Stock>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src["id"]))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src["name"]))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src["created_at"]));
            });

            return config.CreateMapper();
        }
    }
}
