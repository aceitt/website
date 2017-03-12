using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestCompleted : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TestComplete.InnerHtml = "Test Completed Successfully. Results will be mailed to your registered email id.";
    }
}