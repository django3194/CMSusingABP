using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Vishnu_MyProject.Contents;

namespace Vishnu_MyProject.CMSService.DTO
{
    [AutoMapFrom(typeof(CMSContent))]
    public class CMSContentListDTO:Entity<int>
    {
        public override int Id { get; set; }

        public string PageName { get; set; }

        public string PageContent { get;set;}
    }
}
