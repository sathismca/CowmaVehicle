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
using System.Configuration;

namespace CowmaVehicle
{
    public partial class loginForm : Form
    {
        SqlConnection con;//global vriable for connection to database
        ErrorHandler objErrorHandler = new ErrorHandler();//creating object for error handling
        public static string role;
        public static string userName;

        public loginForm()
        {
            InitializeComponent();
        }

        private void login()//creating function for login
        {
            if ((txtUserName.Text != "") && (txtPassword.Text != ""))
            {
                role = "";
                userName = "";

                //query to check userName, password and role in data base
                SqlCommand cmd = new SqlCommand("select * from tblLoginDetails where userName='" + txtUserName.Text + "' and passwords='" + txtPassword.Text + "'", con);
                con.Open();
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();//to search the username and password in data base
                    if (dr.Read())
                    {
                        role = dr["userRole"].ToString();
                        userName = dr["userName"].ToString();
                        dr.Close();
                        con.Close();
                        this.Hide();

                        if (role == "admin" || role == "superVicer")//to restruct the access for user
                        {
                            vehicleMaster vehicleMaster = new vehicleMaster();
                            vehicleMaster.Show();
                        }
                        else
                        {
                            DialogResult pressKey = MessageBox.Show("Because your user " + userName, "You Dont have access", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter Correct Username and Password");
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
            con.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //calling login function
            login();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            try
            {
                string strcon = ConfigurationManager.ConnectionStrings["DatLocation"].ConnectionString;
                con = new SqlConnection(strcon);
            }
            catch (Exception objException)
            {
                objErrorHandler.ErrorMsg = objException;
                objErrorHandler.CreateLog();
                MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='\r')
            {
                //calling login function
                login();
            }
        }
    }
}
