using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChanakyaDataApi.Models
{
    public class CourseContent
    {
        public Int64 CourseId { get; set; }

        public Int64 ContentId { get; set; }

        public string ContentName { get; set; }
    }
}