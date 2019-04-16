using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Vishnu_MyProject.CMSService;
using Vishnu_MyProject.CMSService.DTO;
using Xunit;

namespace Vishnu_MyProject.Tests
{
   public class CMSService_Tests: Vishnu_MyProjectTestBase
   {
       private readonly ICMSService _cmsService;

       public CMSService_Tests()
       {
           _cmsService = Resolve<ICMSService>();
       }

       [Fact]
       public async Task Should_Get_Contents()
       {
           var output = await _cmsService.GetAll();
           output.Items.Count.ShouldBe(1);
       }

       [Fact]
       public async Task Should_Create_Contents()
       {
            //Arrange
           var pageName = "FAQ";

           //Act
           await _cmsService.InsertOrUpdateCMSContent(new CreateContentInput
           {
              
               PageName = "FAQ",
               PageContent = "Fre Asked Q"
           });

           //Assert
           UsingDbContext(context =>
           {
               context.CmsContents.FirstOrDefault(e=>e.PageName== pageName).ShouldNotBe(null);
           });
       }

       public async Task Should_Update_Contents()
       {
           //Arrange
           var pageName = "FAQ";

           //Act
           await _cmsService.InsertOrUpdateCMSContent(new CreateContentInput
           {
                Id =  1,
               PageName = "FAQ1",
               PageContent = "Fre Asked Q"
           });

           //Assert
           UsingDbContext(context =>
           {
               context.CmsContents.FirstOrDefault(e => e.PageName == pageName).ShouldBe(null);
           });
       }

    }
}
