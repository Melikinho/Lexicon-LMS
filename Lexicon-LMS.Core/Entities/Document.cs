﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lexicon_LMS.Core.Entities
{
    public class Document
    {
        public int Id { get; set; }

        [DisplayName("Document Name")]
        public string DocumentName { get; set; }

        [StringLength(200)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Time Stamp")]
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        [StringLength(100)]
        [Display(Name = "User Information")]
        public string UserInformation { get; set; }

        public int UserId { get; set; }
        public int? CourseId { get; set; }
        public int? ModuleId { get; set; }        
        public int? Activity { get; set; }


    }
}