using Application.Domain.Entities;
using Application.Infastructure.Data;

namespace Application.Infrastructure.Seeder
{
    public class Seeder
    {
        public async static Task Seed(AppDbContext dbContext)
        {
            await dbContext.Database.EnsureCreatedAsync();
            await SeedApplicationForm(dbContext);
            await SeedPreview(dbContext);
            await SeedProgramDetail(dbContext);
            await SeedWorkFlowAndStageType(dbContext);
            await SeedVideoInterview (dbContext);
        }
        public async static Task SeedApplicationForm(AppDbContext dbContext)
        {
            if (!dbContext.ApplicationForms.Any())
            {
                var appForm = SeederHelper<ApplicationForm>.GetData("ApplicationForm.Json");
                await dbContext.ApplicationForms.AddRangeAsync(appForm);
                await dbContext.SaveChangesAsync();
            }
        }
        public async static Task SeedProgramDetail(AppDbContext dbContext)
        {
            if (!dbContext.ProgramDetails.Any())
            {
                var programDetail = SeederHelper<ProgramDetail>.GetData("ProgramDetail.Json");
                await dbContext.ProgramDetails.AddRangeAsync(programDetail);
                await dbContext.SaveChangesAsync();
            }
        }
        public async static Task SeedPreview(AppDbContext dbContext)
        {
            if (!dbContext.Previews.Any())
            {
                var preview = SeederHelper<Preview>.GetData("Preview.Json");
                await dbContext.Previews.AddRangeAsync(preview);
                await dbContext.SaveChangesAsync();
            }
        }
        public async static Task SeedVideoInterview(AppDbContext dbContext)
        {            
            if (!dbContext.VideoInterviews.Any())
            {
                var video = SeederHelper<VideoInterview>.GetData("VideoInterview.Json");
                await dbContext.VideoInterviews.AddRangeAsync(video);
                await dbContext.SaveChangesAsync();
            }
        }

        public async static Task SeedWorkFlowAndStageType(AppDbContext dbContext)
        {            
            if (!dbContext.WorkFlows.Any())
            {
                var workFlow = SeederHelper<WorkFlow>.GetData("WorkFlow.Json");
                await dbContext.WorkFlows.AddRangeAsync(workFlow);
                await dbContext.SaveChangesAsync();
            }
            if (!dbContext.StageTypes.Any())
            {
                var stageType = SeederHelper<StageType>.GetData("StageType.Json");
                await dbContext.StageTypes.AddRangeAsync(stageType);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}