using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using System.Text;


public partial class ShowCourseContent : System.Web.UI.Page
{
    StringBuilder sb;
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = Request.Params["courseid"];

        if (string.IsNullOrEmpty(s))
        {
            test.InnerHtml = "<p color=\"red\"> Course Not Found</p>";
            return;
        }

        PopulateCourseContent(s);
        if (!IsPostBack)
        {
            content.InnerHtml = sb.ToString();
        }
    }

    protected HttpResponseMessage GetResponse(string uri, string baseAddress)
    {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        return client.GetAsync(uri).Result;
    }

    public void PopulateCourseContent(string s)
    {
        sb = new StringBuilder();
 
        var res = GetResponse(string.Format("api/CourseContent/GeContentByCourseId?key={0}", s), "http://chanakyaapi20170125023514.azurewebsites.net:80");

        var x = res.Content.ReadAsAsync<ICollection<CourseContent>>(new[] { new JsonMediaTypeFormatter() }).Result;

        foreach (var v in x.ToList())
        {
             sb.Append(string.Format("<a href=\"ViewContent.aspx?id={0}\"> {1}</a><br/>", v.ContentId, v.ContentName));
        }

        sb.Append("</p>");

        PopulateCourseName(s);

        PopulateTests(s, x.ToList());
    }

    public void PopulateCourseName(string s)
    {
        var res = GetResponse(string.Format("api/StudentCourses/GetStudentCourse?key={0}", s), "http://chanakyaapi20170125023514.azurewebsites.net:80");
        var x = res.Content.ReadAsAsync<ICollection<Course>>(new[] { new JsonMediaTypeFormatter() }).Result;

        courseName.Text = x.FirstOrDefault().CourseName;
    }

    public void PopulateTests(string s, List<CourseContent> courseContent)
    {
        StringBuilder htmlOut = new StringBuilder();

        var res = GetResponse(string.Format("api/Exams?id={0}", s), "http://chanakyadataapis20170125023046.azurewebsites.net:80");
        var x = res.Content.ReadAsAsync<ICollection<Exam>>(new[] { new JsonMediaTypeFormatter() }).Result;

        foreach (var v in x.ToList())
        {
            htmlOut.Append(string.Format("<a href=\"ShowTest.aspx?id={0}&cateogryId={1}\"> Test {1}</a><br/>", v.ExamId, v.ContentId));
        }

        tests.InnerHtml = htmlOut.ToString();

    }
}

public class CourseContent
{
    [JsonProperty("CourseId")]
    public string CourseId { get; set; }

    [JsonProperty("ContentName")]
    public string ContentName { get; set; }

    [JsonProperty("ContentId")]
    public string ContentId { get; set; }

}

public class Exam
{    
    [JsonProperty("ExamId")]
    public Int64 ExamId { get; set; }

    [JsonProperty("CourseId")]
    public string CourseId { get; set; }

    [JsonProperty("ContentId")]
    public string ContentId { get; set; }

    [JsonProperty("TotalStudentsTaken")]
    public Int64 TotalStudentsTaken { get; set; }

    [JsonProperty("StudentsPassed")]
    public Int64 StudentsPassed { get; set; }

    [JsonProperty("DifficultyLevel")]
    public Int64 DifficultyLevel { get; set; }

}
