using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CIL_Allowance_Management_System
{
    class AdminUserClass
    {   public AdminUserClass()
        {

        }

        public object Text { get; private set; }
        public object txtUsername { get; private set; }
        public object txtpassword { get; private set; }
        public object txtPassword { get; private set; }
        public object txtEmail { get; private set; }
        public object txtPhoneNumber { get; private set; }

        public void ConnectToDataBase()
        {
            try
            {


                string connectionString = "Data Source=.;Initial Catalog=AllowanceDB;Integrated Security=True;";
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlConnection cnn = new SqlConnection(connectionString);
                

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void RegisterNow()
        {
            string connectionString = "Data Source=.;Initial Catalog=AllowanceDB;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd;
            cmd = new SqlCommand("RegisterAdmin", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();

            try
            {
                adapter.InsertCommand = cmd;
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                int a = adapter.InsertCommand.ExecuteNonQuery();
                if (a > 0)
                {

                    MessageBox.Show("Admin Registered Successfully", "  ClinicMaster ADMIN ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                cnn.Close();

            }

        }


        public void LoginNow()
        {g
            string connectionString = "Data Source=.;Initial Catalog=AllowanceDB;Integrated Security=True;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd;


            cmd = new SqlCommand("GetLoginDetails", cnn);
            cmd.CommandType = CommandType.StoredProcedure;//"select * from AdminUsers where Username = '" + txtUsername.Text + "' AND Password = '" + txtpassword.Text + "';"


            cnn.Open();
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            try
            {

                if (reader.Read())
                {
                    if(txtUsername == string.Empty)
                    {
                        MessageBox.Show("Please enter Username");
                    }
                    else if(txtpassword == string.Empty)
                    {
                        MessageBox.Show("Please enter Password");
                    }
                    else
                    {

                        MessageBox.Show("             Login Successfull !                   ", txtUsername.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Admin_Users_Registration().Show();
                        this.Hide();
                    }
                   
                }
                else
                {
                    MessageBox.Show("   Invalid Username OR Password !  ", "ClinicMaster ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtUsername.Text = string.Empty;
                txtpassword.Text = string.Empty;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
            }


        }

        public void CloseButton()
        {
            Application.ExitThread();
            //this.Close();
        }

      

    }

}

