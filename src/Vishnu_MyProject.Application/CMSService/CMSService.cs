using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using Vishnu_MyProject.CMSService.DTO;
using Vishnu_MyProject.Contents;
using Vishnu_MyProject.EntityFrameworkCore;

namespace Vishnu_MyProject.CMSService
{
    [AbpAuthorize]
    public class CMSService: Vishnu_MyProjectAppServiceBase,ICMSService
    {
        private readonly IContentManager _contentManager;
        private readonly IRepository<CMSContent, int> _contentRepository;
        
         public CMSService(IUnitOfWorkManager unitOfWorkManager,IContentManager contentManager, IRepository<CMSContent, int> contentRepository)
        {
            _contentManager = contentManager;
            _contentRepository = contentRepository;
        }

        // Inserts or updates the Contents based on the id value inserted.
        public async Task<CMSContent> InsertOrUpdateCMSContent(CreateContentInput input)
        {
            try
            {
                var exists = await _contentRepository
                    .GetAll()
                    .AnyAsync(e => e.Id == input.Id);
                if (!exists)
                {
                    var @content = CMSContent.CreateContent(input.PageName, input.PageContent);
                    return await _contentRepository.InsertAsync(@content);
                }
                else
                {
                    var @content = CMSContent.CreateContent(input.Id, input.PageName, input.PageContent);
                    return await _contentRepository.UpdateAsync(@content);
                }
            }
            catch (Exception e)
            {
                // To do :Log the message somewhere 
                throw new UserFriendlyException($"There was an error while inserting/updating the contect . Please contact Us {0}",e.StackTrace);
            }

            
            
        }

        // Get the Contents with provided id. 
        public async Task<ContentDetailOutput> GetCMSContent(EntityDto<int> input)
        {
            var @content = await _contentRepository
                .GetAll()
                .Where(e => e.Id == input.Id)
                .FirstOrDefaultAsync();

            if (@content == null)
            {
                throw new UserFriendlyException("Could not found the event, maybe it's deleted.");
            }

            return @content.MapTo<ContentDetailOutput>();
        }

        //Get all the contents.
        public async Task<ListResultDto<CMSContentListDTO>> GetAll()
        {
            var @contents = await _contentRepository
                .GetAll()
                .Take(3)
                .ToListAsync();
            if (@contents == null)
            {
                throw new UserFriendlyException("Could not found the event, maybe it's deleted.");
            }

            return new ListResultDto<CMSContentListDTO>(contents.MapTo<List<CMSContentListDTO>>());
        }
    }
}
