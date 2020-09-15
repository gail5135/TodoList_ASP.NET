using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WepApplication
{
    public partial class TodoItem : System.Web.UI.UserControl
    {
        public string todo = "temp";
        public bool complete = false;

        public TodoItem(string todo, bool complete)
        {
            this.todo = todo;
            this.complete = complete;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Click_Complete(object sender, EventArgs e)
        {
            Response.Write("<script>alert('TEST22')</script>");
        }

        protected void Click_Remove(object sender, EventArgs e)
        {
            Response.Write("<script>alert('TEST333')</script>");
        }
    }
}