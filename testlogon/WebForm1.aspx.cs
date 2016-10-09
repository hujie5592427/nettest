using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace testlogon
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string userName = Request["username"].ToString();
            string password = Request["password"].ToString();
            Response.Write("用户名：" + userName);
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("密码：" + password);
            Response.Write("<br/>");

            foreach (object obj in Request.ServerVariables)
            {
                string name = obj.ToString();
                string value = Request.ServerVariables[name];
                Response.Write(name + ":" + value + "<br/>");
            }

            //string user = Request.ServerVariables["LOGON_USER"].ToString();
            //Response.Write(user);
            Response.Write("<br/>");
            Response.Write("end");

            Response.Write(Environment.UserName + "<br/>");

            Hashtable ht =(Hashtable) Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in ht) {
                string s1 = de.Key.ToString();
                string s2 = de.Value.ToString();
                Response.Write(s1 + ":" + s2 + "<br/>");
            }

        }
    }
}