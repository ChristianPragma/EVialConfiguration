using AutoMapper;
using EVialConfig.Domain.Dtos;
using EVialConfig.Domain.Models;

namespace EVialConfig.Application.Mappers
{
    public class TypeTrafficViolationMappingProfile:Profile
    {
        public TypeTrafficViolationMappingProfile()
        {
            CreateMap<GetTypeTrafficViolationResponseDto, TypesTrafficViolation>().ReverseMap();
            CreateMap<CreateTypeTrafficViolationRequestDto, TypesTrafficViolation>().ReverseMap();
        }
    }
}
