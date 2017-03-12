using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


public partial class _Default : System.Web.UI.Page
{
    static HttpClient client = new HttpClient();


    protected void Page_Load(object sender, EventArgs e)
    {
        // ClientCall();
    }

    private void ClientCall()
    {
        //t.Start();
        //t.Wait();
        WebClient client = new WebClient();
        string resultStr = client.DownloadString("http://chanakyaapi20170125023514.azurewebsites.net/api/CourseContent/GetCourseContent");



        Response.Write(resultStr);

        //System.Threading.Thread.Sleep(30000);
    }

    protected async Task GetResponse()
    {
        client.BaseAddress = new Uri("http://chanakyaapi20170125023514.azurewebsites.net:80");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        
        HttpResponseMessage response = await client.GetAsync("api/CourseContent/GetCourseContent");

        if (response.IsSuccessStatusCode)
        {
           
        }
    }


}