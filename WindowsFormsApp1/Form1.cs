using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// winfrom database first
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            studentttEntities content = new studentttEntities();

            var query = (from a in content.Set<studnet>().AsNoTracking()
                         join b in content.Set<city>().AsNoTracking() on a.cityid equals b.cityid
                         join c in content.Set<hobby>().AsNoTracking() on a.hobbyid equals c.hobbyid
                         select new
                         {
                             a.stuname,
                             a.stuid,
                             b.cityname,
                             c.hobbyname
                         }
                      );

            string sql = query.ToString();
            label1.Text += sql;

            dataGridView1.DataSource = query.ToList();
        }
    }
}
