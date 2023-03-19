using Application.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Entities
{
    public class ProgramDetail : BaseEntity
    {
        public Guid PreviewId { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "Name should begin with a capital letter, followed by small letters")]
        public string ProgramTitle { get; set; }

        [MaxLength(250)]        
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
        public string SummaryOfTheProgram { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string ProgramDescription { get; set; }
        public string KeySkils { get; set; }
        public string ProgramBenefits { get; set; }
        public string ApplicationCriteria { get; set; }

        //Additional Program Information
        public ProgramType ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplicationOpen { get; set; }
        public DateTime ApplicationClose { get; set; }
        public string Duration { get; set; }
        public ProgramLocation ProgramLocation { get; set; }
        public MinQualification MinQualification { get; set; }
        public int MaxNumOfApplication { get; set; }
        public virtual Preview Previews { get; set; }
       
    }
}
