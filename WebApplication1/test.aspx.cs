using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// webform databae first
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void Button1_Click(object sender, EventArgs e)
        {
            studentttEntities content = new studentttEntities();
            var query = from a in content.Set<studnet>().AsNoTracking()
                        join b in content.Set<city>().AsNoTracking() on a.cityid equals b.cityid
                        join c in content.Set<hobby>().AsNoTracking() on a.hobbyid equals c.hobbyid
                        where a.stuname == TextBox1.Text
                        select new
                        {
                            a.stuname,
                            b.cityname,
                            c.hobbyname
                        };
         

            string sql = query.ToString();
            Label1.Text = sql;

           GridView1.DataSource = query.ToList();
           GridView1.DataBind();
        }
    }
}