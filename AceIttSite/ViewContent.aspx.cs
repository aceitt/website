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
using System.Collections.Concurrent;
using System.Web.Security;

public partial class ViewContent : System.Web.UI.Page
{
    StringBuilder sb;

    static ConcurrentDictionary<string, string> contentVideos = new ConcurrentDictionary<string, string>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Request.IsAuthenticated)
        {
            FormsAuthentication.RedirectToLoginPage();
        }

        if (!IsPostBack)
        {
            string s = Request.Params["id"];

            if (string.IsNullOrEmpty(s))
            {
                ContentName.Text = "Content Not found";
                ContentName.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string val;
            if (!contentVideos.TryGetValue(s, out val))
            {
                CreateDataSource(s);

                if (string.IsNullOrEmpty(sb.ToString()))
                {
                    ContentName.Text = "Content Not found";
                    ContentName.ForeColor = System.Drawing.Color.Red;
                    ContentVideo.Src = "";
                    return;
                }
                else
                {
                    val = sb.ToString();
                    contentVideos.TryAdd(s, val);
                }

            }

            ContentVideo.Src = val;
        }
    }

    protected HttpResponseMessage GetResponse(string uri)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("http://chanakyadataapis20170125023046.azurewebsites.net:80");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        return client.GetAsync(uri).Result;
    }

    public void CreateDataSource(string s)
    {
        sb = new StringBuilder();

        var res = GetResponse(string.Format("api/ContentLibraries/ContentLibraries_GetContentLibraries?id={0}", s));

        var x = res.Content.ReadAsAsync<ContentLibrary>(new[] { new JsonMediaTypeFormatter() }).Result;

        if (x != null && !string.IsNullOrEmpty(x.RecommendedVideos))
        {
            sb.Append(x.RecommendedVideos);
        }

    }
}

public class ContentLibrary
{
    [JsonProperty("ContentId")]
    public string ContentId { get; set; }

    [JsonProperty("RecommendedVideos")]
    public string RecommendedVideos { get; set; }

    [JsonProperty("RecommendedBooks")]
    public string RecommendedBooks { get; set; }

    [JsonProperty("RecommendedSites")]
    public string RecommendedSites { get; set; }

}
