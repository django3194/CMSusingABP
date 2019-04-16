using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Vishnu_MyProject.Contents
{
    [Table("CMSContents")]
    public class CMSContent:Entity<int>
    {
        public const int MAXTITLELENGHT = 128;

        public const int MAXCONTENTLENGTH = 10000;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        /// <summary>
        /// The title of the content.
        /// </summary>
        [Required]
        [StringLength(MAXTITLELENGHT)]
        public virtual string PageName { get;  set; }

        /// <summary>
        /// The Cms Content
        /// </summary>
        public virtual  string PageContent { get; set; }

        protected CMSContent()
        {
           
        }

        public static CMSContent CreateContent(int id,string title ,string contents)
        {
            var @content = new CMSContent
            {
                Id =  id, 
                PageName = title,
                PageContent = contents
            };

            return @content;
        }

        public static CMSContent CreateContent( string title, string contents)
        {
            var @content = new CMSContent
            {
                PageName = title,
                PageContent = contents
            };

            return @content;
        }
    }
}
