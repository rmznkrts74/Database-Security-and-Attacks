using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace formForSuggestion
{
    public partial class formSuggest : Form
    {
        public formSuggest()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=192.168.1.39;INITIAL CATALOG=HR;UID=SA;PWD=Password1;";
            SqlConnection conn=new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=conn;
            string sql = "insert into hr.dbo.suggestion(NameSurname,Date_,SuggestionText)";
            sql = sql + " Values('" + txtNameSurname.Text + "',GETDATE(),'" + txtsuggestion.Text + "');";
                sql = sql + "Select @@IDENTITY";//it give us to identity number of suggestion
            cmd.CommandText=sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                MessageBox.Show("Your Suggestion has been posted. ID: " + id.ToString());
            }

        }
    }
}
