using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace newAPP
{
    public partial class Addcardnum : Form
    {
        public Addcardnum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string phone = this.textBox2.Text;
            string money = this.textBox3.Text;
            string connstr = "Data Source=.;Initial Catalog=PhoneCard;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = string.Format(" INSERT INTO [PhoneCard].[dbo].[T_User]VALUES(' {0}', ' {1}', ' {2}')",
name,phone,money);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
