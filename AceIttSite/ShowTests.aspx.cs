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

public partial class ShowTests : System.Web.UI.Page
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

        CreateDataSource(s);
        if (!IsPostBack)
        {
            test.InnerHtml = sb.ToString();

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

    public void CreateDataSource(string s)
    {
        sb = new StringBuilder();

        var res = GetResponse(string.Format("api/CourseContent/GeContentByCourseId?key={0}", s));

        var x = res.Content.ReadAsAsync<ICollection<CourseContent>>(new[] { new JsonMediaTypeFormatter() }).Result;

        foreach (var v in x.ToList())
        {
            sb.Append(string.Format("<a href=\"ViewContent.aspx?id={0}\"> {1}</a><br/>", v.ContentId, v.ContentName));
        }

        sb.Append("</p>");

    }

    public class CourseContent
    {
        [JsonProperty("ContentId")]
        public string ContentId { get; set; }

        [JsonProperty("ContentName")]
        public string ContentName { get; set; }

        [JsonProperty("CourseId")]
        public string CourseId { get; set; }
    }
}
