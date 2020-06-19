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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = this.T_name.Text;
            string sex = this.T_sex.Text;
            string homes = this.T_homes.Text;
            string phonenum = this.T_phonenum.Text;
            string email=this.T_email.Text;
            string bandcard = this.T_bandcard.Text;
            string age = this.T_age.Text;
            string until = this.T_until.Text;
            string qq = this.T_qq.Text;
            string remark = this.T_remark.Text;
            string connStr = "Data Source=.;Initial Catalog=PhoneCard;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = string.Format(" INSERT INTO [PhoneCard].[dbo].[T_User]VALUES(' {0}', ' {1}', ' {2}', {3},' {4}',' {5}',' {6}',' {7}',' {8}','{9}')",
name, bandcard, sex, age, homes, until, phonenum,qq,email,remark) ;

            SqlCommand cmd = new SqlCommand(sql,conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();

        }
}
}
