using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Entities
{
    public class QuestionType : BaseEntity
    {
        public string Paragraph { get; set; }
        public string ShortAnswer { get; set; }
        public string YesOrNo { get; set; }
        public string DropDown { get; set; }
        public string MultiChoice { get; set; }
        public string Date { get; set; }
        public string Number { get; set; }
        public string FileUpload { get; set; }
        public string VideoQuestion { get; set; }
    }
}
