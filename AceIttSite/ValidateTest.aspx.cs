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

public partial class ValidateTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var p = Request.Params;

        if (!Request.IsAuthenticated)
        {
            FormsAuthentication.RedirectToLoginPage();
        }
        string query = "";

        Dictionary<Tuple<int, int>, string> qa = new Dictionary<Tuple<int,int>, string>();

        foreach(var v in p)
        {
            if (v.ToString().Contains("Ans_"))
            {
                var val = p[v.ToString()];
                qa.Add(Tuple.Create(int.Parse(v.ToString().Split('_')[1]), int.Parse(v.ToString().Split('_')[2])), val);
                query = string.Format("update {0} set isanswered=1, answer='{1}' where SNO= ({2} -1) ", Request.Params["ExamId"], val, Request.Params["SNO"]);
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StarterSite"].ConnectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                    return;
                }
            }
        }

        if (int.Parse(Request.Params["SNO"].ToString()) > int.Parse(Request.Params["Count"].ToString()))
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "Showalert();", true);
            Response.Redirect("TestCompleted.aspx");
            return;
        }

        Response.Redirect(string.Format("TestPage.aspx?SNO={0}&ExamId={1}&Count={2}", Request.Params["SNO"], Request.Params["ExamId"], Request.Params["Count"]));
    }
}