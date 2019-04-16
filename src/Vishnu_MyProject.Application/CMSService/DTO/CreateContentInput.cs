using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Vishnu_MyProject.Contents;

namespace Vishnu_MyProject.CMSService.DTO
{
    public class CreateContentInput
    {
        [Key]
        public  int Id { get; set; }

        [Required]
        [StringLength(CMSContent.MAXTITLELENGHT)]
        public  string PageName { get; set; }

      
        public  string PageContent { get; set; }
    }
}
