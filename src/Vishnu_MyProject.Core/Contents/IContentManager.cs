using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Services;

namespace Vishnu_MyProject.Contents
{
    public interface IContentManager: IDomainService
    {

        /// <summary>
        /// Create contents
        /// </summary>
        /// <param name="content">content</param>
        /// <returns></returns>
        Task<CMSContent> InsertOrUpdateAsync(CMSContent @content);
    }
}
