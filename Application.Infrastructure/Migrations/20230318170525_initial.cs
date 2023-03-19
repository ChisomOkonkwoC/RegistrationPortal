using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PictureUpload = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentResidence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParagraphQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DropDownQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultiChoiceQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Choice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileUploadQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YesOrNoQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxChoiceAllowed = table.Column<int>(type: "int", nullable: false),
                    QuestionType = table.Column<int>(type: "int", nullable: false),
                    MaxVideoTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxVideoTimeInMinSec = table.Column<TimeSpan>(type: "time", nullable: false),
                    VideoQuestion1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoQuestion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Previews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Previews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PreviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProgramTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SummaryOfTheProgram = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProgramDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeySkils = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramBenefits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationCriteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramType = table.Column<int>(type: "int", nullable: false),
                    ProgramStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationOpen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationClose = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramLocation = table.Column<int>(type: "int", nullable: false),
                    MinQualification = table.Column<int>(type: "int", nullable: false),
                    MaxNumOfApplication = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramDetails_Previews_PreviewId",
                        column: x => x.PreviewId,
                        principalTable: "Previews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StageTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkFlowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Placement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Applied = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Offered = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StageTypes_WorkFlows_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "WorkFlows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoInterviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StageTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VideoQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxVideoDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationMinAndSec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDeadline = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoInterviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoInterviews_StageTypes_StageTypeId",
                        column: x => x.StageTypeId,
                        principalTable: "StageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramDetails_PreviewId",
                table: "ProgramDetails",
                column: "PreviewId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StageTypes_WorkFlowId",
                table: "StageTypes",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoInterviews_StageTypeId",
                table: "VideoInterviews",
                column: "StageTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationForms");

            migrationBuilder.DropTable(
                name: "ProgramDetails");

            migrationBuilder.DropTable(
                name: "VideoInterviews");

            migrationBuilder.DropTable(
                name: "Previews");

            migrationBuilder.DropTable(
                name: "StageTypes");

            migrationBuilder.DropTable(
                name: "WorkFlows");
        }
    }
}
