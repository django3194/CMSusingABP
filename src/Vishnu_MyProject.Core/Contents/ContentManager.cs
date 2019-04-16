using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.UI;
using Microsoft.EntityFrameworkCore;

namespace Vishnu_MyProject.Contents
{
    public class ContentManager : IContentManager
    {

        private readonly IRepository<CMSContent, int> _contentRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public ContentManager(IUnitOfWorkManager unitOfWorkManager,IRepository<CMSContent, int> contentRepository)
        {
            _contentRepository = contentRepository;
            _unitOfWorkManager = unitOfWorkManager;
        }

       [UnitOfWork(IsDisabled = true)]
       
        public async Task<CMSContent> InsertOrUpdateAsync(CMSContent content)
        {
                var @result = await _contentRepository.InsertOrUpdateAsync(@content);
                return result;
           
        }
    }
}
