using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Security;
using Microsoft.AspNet.Identity;

public partial class ViewExam : System.Web.UI.Page
{
    StringBuilder sb;
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = Request.Params["Id"];

        if (!Request.IsAuthenticated)
        {
            FormsAuthentication.RedirectToLoginPage();
        }
        
        int userId = User.Identity.GetUserId<int>();

        if (string.IsNullOrEmpty(s))
        {
            test.InnerHtml = "<p color=\"red\"> Course Not Found</p>";
            return;
        }

        PopulateExamContent(s);
        if (!IsPostBack)
        {
            questions.InnerHtml = sb.ToString();
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

    public void PopulateExamContent(string s)
    {
        sb = new StringBuilder();

        var res = GetResponse(string.Format("api/Questions?examid={0}", s), "http://chanakyadataapis20170125023046.azurewebsites.net:80");

        var x = res.Content.ReadAsAsync<ICollection<ExamQuestions>>(new[] { new JsonMediaTypeFormatter() }).Result;

        //string rbList = "<asp:RadioButtonList ID =\"Ans{0}\" a runat=\"server\">";
        //string ans = "<asp:ListItem Text = \"{0}\" Value = \"{1}\" runat = \"server\" />";

        string rbList = "<input type=\"radio\" Name =\"Ans_{3}_{0}\" value={1}>  <i>{2}</i></>";
        // string ans = "<asp:ListItem Text = \"{0}\" Value = \"{1}\" />";



        foreach (var v in x.ToList())
        {
            sb.Append(string.Format("<p><b>{0}</b>  {1}</p>", v.QuestionId, v.Question));

            // sb.AppendLine();

            // sb.Append(string.Format(rbList, v.QuestionId));

            int i = 65;
            foreach (var a in v.Choices.Split(','))
            {
                sb.Append(string.Format(rbList, v.QuestionId, Convert.ToChar(i++), a, s));
                sb.Append("<p> </p>");
            }
            

            sb.Append("<p/>");
        }

        PopulateExamName(s);
    }

    public void PopulateExamName(string s)
    {
        ExamTitle.Text = string.Format("Test {0}", s);
        ExamTitle.ForeColor = System.Drawing.Color.Blue;
    }
}

public class ExamQuestions
{

    [Column("question")]
    public string Question { get; set; }

    [Column("question_type")]

    public Int32 QuestionType { get; set; }

    [Column("choices")]
    public string Choices { get; set; }

    [Column("question_id")]

    public Int64 QuestionId { get; set; }
}