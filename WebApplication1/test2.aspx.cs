using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            studentttEntities content = new studentttEntities();
            ///linq 表达式 查询 
            var students1 = from t in content.Set<studnet>().AsNoTracking()
                            where t.stuname == "hans"
                            select new { t.stuname, t.hobbyid, t.cityid };

            ///tolist 去 数据库 执行
            var query1 = students1.ToList();
            GridView1.DataSource = query1;
            GridView1.DataBind();

            ///lambda 表达式查询
            var students2 = content.studnet.Where(t => t.stuname == "hans")
                                           .Select(t => new { t.stuname, t.hobbyid, t.cityid });

            var query2 = students2.ToList();
            GridView2.DataSource = query2;
            GridView2.DataBind();
        }
    }
}