using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WepApplication
{
    public partial class TodoInput : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('TEST')</script>");
            text.Text = "";
        }
    }
}