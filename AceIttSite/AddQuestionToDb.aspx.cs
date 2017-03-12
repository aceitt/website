using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class AddQuestionToDb : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var p = Request.Params;

        Dictionary<Tuple<int, int>, string> qa = new Dictionary<Tuple<int, int>, string>();

        var question = p["Question"];
        var choices = p["choices"];
        var ans = p["answer"];
        // var pwd = p["password"];
        var subId = p["SubId"];


        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EmacetUser"].ConnectionString))
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertEamcetQuestion";

            cmd.Parameters.AddWithValue("@question", question);
            cmd.Parameters.AddWithValue("@choices", choices);
            cmd.Parameters.AddWithValue("@answer", ans);

            cmd.ExecuteNonQuery();

            {   
                Response.Write(string.Format("<script>alert('Success:');</script>"));
            }

            Response.Redirect("addquestions.aspx?isSuccess=1");
        }
        
    }
}