using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Vishnu_MyProject.CMSService.DTO;
using Vishnu_MyProject.Contents;

namespace Vishnu_MyProject.CMSService
{
    public interface ICMSService:IApplicationService
    {
        Task<ListResultDto<CMSContentListDTO>> GetAll();

        Task<ContentDetailOutput> GetCMSContent(EntityDto<int> input);

        Task<CMSContent> InsertOrUpdateCMSContent(CreateContentInput input);
    }
}
