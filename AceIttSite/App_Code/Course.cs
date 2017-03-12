using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net.Http.Formatting;

public class Course
{
    [JsonProperty("CourseId")]
    public Int64 CourseId { get; set; }

    [JsonProperty("Grade")]
    public string Grade { get; set; }

    [JsonProperty("ExamId")]
    public Int64 ExamId { get; set; }

    [JsonProperty("Language")]
    public string Language { get; set; }

    [JsonProperty("CourseName")]
    public string CourseName { get; set; }
}