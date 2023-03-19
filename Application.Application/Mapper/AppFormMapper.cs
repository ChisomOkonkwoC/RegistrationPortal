using Application.Application.Dtos.Request;
using Application.Application.Dtos.Response;
using Application.Domain.Entities;
using AutoMapper;

namespace Application.Application.Mapper
{
    public class AppFormMapper : Profile
    {
        public AppFormMapper()
        {
            CreateMap<ProgramRequest, ProgramDetail> ().ReverseMap();
            CreateMap<ProgramResponseDto, ProgramDetail>().ReverseMap()
                .ForMember(program => program.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(program => program.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt));
        }
    }
}
