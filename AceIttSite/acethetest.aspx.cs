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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class acethetest : System.Web.UI.Page
{
    StringBuilder sb = new StringBuilder();

    protected void Page_Load(object sender, EventArgs e)
    {
        string s = Request.Params["id"];

        //if (int.Parse(Request.Params["SNO"].ToString()) > int.Parse(Request.Params["Count"].ToString()))
        //{
        //    Response.Redirect("TestCompleted.aspx");
        //    return;
        //}


        if (string.IsNullOrEmpty(s))
        {
            test.InnerHtml = "<p color=\"red\"> Course Not Found</p>";
            return;
        }

        CreateTest(Int32.Parse(s), 20);

        if (!IsPostBack)
        {
            test.InnerHtml = sb.ToString();
        }

    }

    private void CreateTest(int id, int qCount = 20)
    {
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StarterSite"].ConnectionString))
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("select top({0}) id, question, qtype from tbl_questions where exam_id = {1} order by newid()", qCount, id);

            using (var r = cmd.ExecuteReader())
            {
                int i = 1;
                while (r.Read())
                {
                    if (r.GetInt32(2) == 0)
                    {
                        sb.Append(string.Format("<p><h5><b>{0}</b>:  {1} = ____</h5></p>", i++, r.GetString(1)));
                    }
                }
            }
        }
    }
}