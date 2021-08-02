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
    public partial class Admin_Users_Registration : Form
    {

        public Admin_Users_Registration()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            AdminUserClass ad = new AdminUserClass();
            ad.CloseButton();
           // Application.ExitThread();
            //this.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            AdminUserClass ad = new AdminUserClass();
            ad.RegisterNow();
            //string connectionString = "Data Source=.;Initial Catalog=AllowanceDB;Integrated Security=True;";
            //SqlConnection cnn = new SqlConnection(connectionString);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //SqlCommand cmd;
            //cmd = new SqlCommand("RegisterAdmin", cnn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cnn.Open();

            //try
            //{
            //    adapter.InsertCommand = cmd;
            //    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
            //    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
            //    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            //    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
            //    int a = adapter.InsertCommand.ExecuteNonQuery();
            //    if (a > 0)
            //    {

            //        MessageBox.Show("Admin Registered Successfully", "  ClinicMaster ADMIN ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    txtUsername.Text = string.Empty;
            //    txtPassword.Text = string.Empty;
            //    txtEmail.Text = string.Empty;
            //    txtPhoneNumber.Text = string.Empty;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    cmd.Dispose();
            //    cnn.Close();

            //}
            //cnn.Close();

        }

        private void Admin_Users_Registration_Load(object sender, EventArgs e)
        {
           
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }



        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }

 
    }
