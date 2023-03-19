using Application.Application.Dtos.Request;
using Application.Application.Dtos.Response;
using Application.Application.Utilities;

namespace Application.Application.Services.Interfaces
{
    public interface IProgramDetailService
    {
        Task<GenericResponse<ProgramResponseDto>> CreateProgramDetails(ProgramRequest programRequest);
    }
}