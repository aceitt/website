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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

public partial class ViewExam : System.Web.UI.Page
{
    StringBuilder sb;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Request.IsAuthenticated)
        //{
        //    FormsAuthentication.RedirectToLoginPage();
        //    return;
        //}

        try
        {
            sb = new StringBuilder();

            //if (string.IsNullOrEmpty(Response.Cookies["LoggedInUser"].Value))
            //{
            //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StarterSite"].ConnectionString))
            //    {
            //        conn.Open();
            //        SqlCommand cmd = conn.CreateCommand();

            //        cmd.CommandText = string.Format("select UserId from UserProfile where UserName = '{0}'", Session["UserId"]);

            //        using (var r = cmd.ExecuteReader())
            //        {
            //            if(r.Read())
            //            {
            //                Response.Cookies["LoggedInUser"].Value = r.GetInt32(0).ToString();
            //            }
            //        }
            //    }
            //}

            if (!IsPostBack)
            {
                string tableName = string.Empty;
                int count = 0;
                CreateExam(out tableName, out count);
                Response.Redirect(string.Format("TestPage.aspx?SNO=1&ExamId={0}&Count={1}", tableName, count));
                
            }
        }
        catch (Exception ex)
        {
            sb.Append(ex.ToString() + (string)Session["UserId"] + Response.Cookies["LoggedInUser"].Value);
            test.InnerHtml = sb.ToString();
            return;
        }
    }

    public void CreateExam(out string tableName, out int qcount)
    {
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StarterSite"].ConnectionString))
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            

            SqlParameter studenId = new SqlParameter("@id", Int32.Parse(Request.Params["Id"]));
            SqlParameter cateogryId = new SqlParameter("@content_id", Int32.Parse(Request.Params["cateogryId"]));
            SqlParameter questionCount = new SqlParameter("@qCount", 20);//  Int64.Parse(Request.Params["questionCount"]));
            SqlParameter tblNameout = new SqlParameter("@testid", System.Data.SqlDbType.VarChar, 256);
            SqlParameter status = new SqlParameter("@status", System.Data.SqlDbType.Bit);
            
            SqlParameter durationInMins = new SqlParameter("@durationInMins", 20);


            tblNameout.Direction = System.Data.ParameterDirection.Output;
            status.Direction = System.Data.ParameterDirection.Output;
            studenId.Direction = System.Data.ParameterDirection.Input;
            questionCount.Direction = System.Data.ParameterDirection.Input;
           
            durationInMins.Direction = System.Data.ParameterDirection.Input;
            cmd.Parameters.Add(studenId);
            cmd.Parameters.Add(cateogryId);
            cmd.Parameters.Add(questionCount);
            cmd.Parameters.Add(tblNameout);
            cmd.Parameters.Add(status);
            cmd.Parameters.Add(durationInMins);
            cmd.CommandText = "sp_CreateTest";

           
            using (var r = cmd.ExecuteReader())
            {
                //if (r.Read())
                //{
                //    Response.Cookies["LoggedInUser"].Value = "User" + r.GetInt32(0);
                //}

                tableName =  "t" + tblNameout.Value.ToString();
                qcount = 20;
            }
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
        ExamTitle.Text = string.Format("Test {0} for User: {1}", s, Session["LoggedInUser"]);
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

public class UserProfileContext : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public UserProfileContext() : base("name=StarterSite")
    {
    }

    public System.Data.Entity.DbSet<UserProfile> Users { get; set; }
}

[Table("UserProfile")]
public class UserProfile
{
    [Column("UserId")]    
    [Key]
    public Int64 UserId { get; set; }

    [Column("UserName")]
    public string UserName { get; set; }
}