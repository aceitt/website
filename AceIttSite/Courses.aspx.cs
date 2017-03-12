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

public partial class Courses : System.Web.UI.Page
{
    StringBuilder sb;
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateDataSource();

        if (!IsPostBack)
        {           
            // test.InnerHtml = sb.ToString();
        }
    }

    protected HttpResponseMessage GetResponse(string uri)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("http://chanakyaapi20170125023514.azurewebsites.net:80");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        return client.GetAsync(uri).Result;
    }

    public void CreateDataSource()
    {       
        //sb = new StringBuilder();

        //var res = GetResponse("api/StudentCourses/GetStudentCourses");

        //var x = res.Content.ReadAsAsync<ICollection<Course>>(new[] { new JsonMediaTypeFormatter() }).Result;

        

        //foreach (var v in x.ToList().OrderBy(c => c.CourseId))
        //{
        //    sb.Append(string.Format("<a href=\"ShowCourseContent.aspx?courseid={0}\"> {1}</a><br/>", v.CourseId, v.CourseName));
        //}
     
        //sb.Append("</p>");
    }    
}