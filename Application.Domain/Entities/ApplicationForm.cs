using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Entities
{
    public class ApplicationForm : BaseEntity
    {
        public byte[] PictureUpload { get; set; }

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
        public string Paragraph { get; set; }
        public DateTime DropDown { get; set; }
        public string Question { get; set; }
        public string Choice { get; set; }
        public string YesOrNoQuestion { get; set; }
        public int MaxChoice { get; set; }
        public string QuestionType { get; set; }
        public string MaxVideoTime { get; set; }

    }
}
