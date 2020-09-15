using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WepApplication
{
    public partial class TodoList : System.Web.UI.UserControl
    {
        public List<TodoItem> items = new List<TodoItem>();

        public void addTodo(string todo, bool complete)
        {
            items.Add(new TodoItem(todo, complete));
        }

        public void makeList()
        {
            foreach(TodoItem item in items)
            {
                if (!item.complete)
                {
                    doing.Controls.Add(item);
                }
                else
                {
                    doing.Controls.Add(item);
                    
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            items.Add(new TodoItem("TEST 1", false));
            items.Add(new TodoItem("TEST 2", false));
            items.Add(new TodoItem("TEST 3", false));
            items.Add(new TodoItem("TEST 4", false));
            items.Add(new TodoItem("TEST 5", false));
            this.makeList();
            Response.Write("<script>alert('"+items.Count+"')</script>");

        }
    }
}