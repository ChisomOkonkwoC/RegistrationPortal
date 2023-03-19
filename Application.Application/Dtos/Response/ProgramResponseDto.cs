namespace Application.Application.Dtos.Response
{
    public class ProgramResponseDto : BaseResponse
    {
        public Guid PreviewId { get; set; }
        public string ProgramTitle { get; set; }        
        public string SummaryOfTheProgram { get; set; }
        public string ProgramDescription { get; set; }
        public string KeySkils { get; set; }
        public string ProgramBenefits { get; set; }
        public string ApplicationCriteria { get; set; }

        //Additional Program Information
        public string ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplicationOpen { get; set; }
        public DateTime ApplicationClose { get; set; }
        public string Duration { get; set; }
        public string ProgramLocation { get; set; }
        public string MinQualification { get; set; }
        public int MaxNumOfApplication { get; set; }

    }
}