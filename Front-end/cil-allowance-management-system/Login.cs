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

namespace CIL_Allowance_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            AdminUserClass ad = new AdminUserClass();
            ad.CloseButton();
        }
       
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            AdminUserClass ad = new AdminUserClass();
             ad.LoginNow();
            //string connectionString = "Data Source=.;Initial Catalog=AllowanceDB;Integrated Security=True;";
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //SqlConnection cnn = new SqlConnection(connectionString);
            //SqlCommand cmd;


            //cmd = new SqlCommand("GetLoginDetails", cnn);
            //cmd.CommandType = CommandType.StoredProcedure;//"select * from AdminUsers where Username = '" + txtUsername.Text + "' AND Password = '" + txtpassword.Text + "';"


            //cnn.Open();
            //cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            //cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
            //SqlDataReader reader;
            //reader = cmd.ExecuteReader();
            //try
            //{

            //    if (reader.Read())
            //    {
            //        MessageBox.Show("             Login Successfull !                   ", txtUsername.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        new Admin_Users_Registration().Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("   Invalid Username OR Password !  ", "ClinicMaster ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    txtUsername.Text = string.Empty;
            //    txtpassword.Text = string.Empty;

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    reader.Close();
            //    cmd.Dispose();
            //}

            
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
