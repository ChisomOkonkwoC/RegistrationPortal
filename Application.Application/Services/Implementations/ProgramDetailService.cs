using Application.Application.Dtos.Request;
using Application.Application.Dtos.Response;
using Application.Application.Services.Interfaces;
using Application.Application.Utilities;
using Application.Domain.Entities;
using Application.Infastructure.Data;
using Application.Infrastructure.Repositories.Interfaces;
using AutoMapper;

namespace Application.Application.Services.Implementations
{
    public class ProgramDetailService : IProgramDetailService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ProgramDetailService(AppDbContext dbContext, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _dbContext = dbContext;
            _mapper = mapper;
           _unitOfWork = unitOfWork;
        }

        public async Task<GenericResponse<ProgramResponseDto>> CreateProgramDetails(ProgramRequest programRequest)
        {
            var programDetails = _mapper.Map<ProgramDetail>(programRequest);
            var APreviewPage = await  _unitOfWork.PreviewRepository.GetARecordAsync(programRequest.PreviewId);
            if(APreviewPage == null)
            {
                return GenericResponse<ProgramResponseDto>.Fail($"The Preview page cannot be found for the provided ID: {programDetails.PreviewId}");
            }
            programDetails.CreatedAt = DateTime.Now;
            programDetails.PreviewId = APreviewPage.Id;
            if (await _unitOfWork.ProgramDetailsRepository.CreateProgramDetail(programDetails))
            {
                return GenericResponse<ProgramResponseDto>.Success("Successful", _mapper.Map<ProgramResponseDto>(programDetails));
            }
            return GenericResponse<ProgramResponseDto>.Fail("Failed to create Program Details");
        }
    }
}