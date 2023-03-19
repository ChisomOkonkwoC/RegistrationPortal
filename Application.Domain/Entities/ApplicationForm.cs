using Application.Domain.Enums;

namespace Application.Domain.Entities
{
    public class ApplicationForm : BaseEntity
    {
        public byte[]? PictureUpload { get; set; }

        //Personal Information
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        //Profile
        public string Education { get; set; }
        public string Experience { get; set; }
        public string Resume { get; set; }

        //Additional Questions
        public string ParagraphQuestion { get; set; }
        public string DropDownQuestion { get; set; }
        public string MultiChoiceQuestion { get; set; }
        public string Choice { get; set; }
        public string NumberQuestion { get; set; }
        public string FileUploadQuestion { get; set; }
        public string DateQuestion { get; set; }
        public string YesOrNoQuestion { get; set; }
        public int MaxChoiceAllowed { get; set; }
        public QuestionType QuestionType { get; set; }
        public string MaxVideoTime { get; set; }
        public TimeSpan MaxVideoTimeInMinSec { get; set; }
        public string VideoQuestion1 { get; set; }
        public string VideoQuestion2 { get; set; }

    }
}