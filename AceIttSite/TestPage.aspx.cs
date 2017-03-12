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
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

public partial class TestPage : System.Web.UI.Page
{
    StringBuilder sb;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Request.IsAuthenticated)
        {
            FormsAuthentication.RedirectToLoginPage();
        }

        if (int.Parse(Request.Params["SNO"].ToString()) > int.Parse(Request.Params["Count"].ToString()))
        {
            Response.Redirect("TestCompleted.aspx");            
            return;
        }

        PopulateExamContent();

        questions.InnerHtml = sb.ToString();
    }



    public void PopulateExamContent()
    {
        sb = new StringBuilder();
        //string rbList = "<asp:RadioButtonList ID =\"Ans{0}\" a runat=\"server\">";
        //string ans = "<asp:ListItem Text = \"{0}\" Value = \"{1}\" runat = \"server\" />";

        string rbList = "<input type=\"radio\" Name =\"Ans_{3}_{0}\" value={1}>  <i>{2}</i></>";
        // string ans = "<asp:ListItem Text = \"{0}\" Value = \"{1}\" />";

        string Sno = Request.Params["SNO"];
        string tblId = Request.Params["ExamId"];

        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StarterSite"].ConnectionString))
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "GetQuestion";

            SqlParameter pSNo = new SqlParameter("@SNo", Int32.Parse(Sno));
            SqlParameter pTblId = new SqlParameter("@tableId", tblId);

            pSNo.Direction = System.Data.ParameterDirection.Input;
            pTblId.Direction = System.Data.ParameterDirection.Input;

            cmd.Parameters.Add(pSNo);
            cmd.Parameters.Add(pTblId);

            using (SqlDataReader r = cmd.ExecuteReader())
            {
                if (r.Read())
                {
                    sb.Append(string.Format("<p><b>{0}</b><br />  <h5>{1}</h5></p>", Sno, r.GetString(0)));
                    int i = 65;
                    foreach (var a in r.GetString(1).Split(','))
                    {
                        sb.Append(string.Format(rbList, Sno, Convert.ToChar(i++), a, Sno));
                        sb.Append("<p> </p>");
                    }

                    sb.Append(string.Format("<input type=\"hidden\" value=\"{0}\" name=\"SNO\" />", int.Parse(Request.Params["SNO"]) + 1));
                    sb.Append(string.Format("<input type=\"hidden\" value=\"{0}\" name=\"ExamId\" />", Request.Params["ExamId"]));
                    sb.Append(string.Format("<input type=\"hidden\" value=\"{0}\" name=\"Count\" />", Request.Params["Count"]));
                }
            }
        }

    }

}