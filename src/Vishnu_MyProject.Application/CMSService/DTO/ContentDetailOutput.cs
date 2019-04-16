using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Vishnu_MyProject.Contents;

namespace Vishnu_MyProject.CMSService.DTO
{
    [AutoMapFrom(typeof(CMSContent))]
    public class ContentDetailOutput
    {
        public int Id { get; set; }
        public string PageName { get; set; }

        public string PageContent { get; set; }
    }
}
