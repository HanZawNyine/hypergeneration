using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // a = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnBack.Hide();
            SignUpHide();
            //SignUpShow();
            btnBLogin.Hide();
            btnQuestion.Hide();
        }

        public void LoginHide()
        {
            txtUserName.Clear();
            txtPass.Clear();
            btnLogin.Hide();


            btnSignUp.Show();
        }
        //int a = 0;
        private void btnSignUp_Click(object sender, EventArgs e)
        {
          
            SignUpCondition();
        }

        public void SignUpHide()
        {
            //btnForgot.Hide();
            progressBar1.Show();
            lblDate.Hide();
            lblGender.Hide();
            //lblPass.Hide();
            lblConfirm.Hide();
            //lblUserName.Hide();

            //txtUserName.Hide();
            //txtPass.Hide();
            txtConfirm.Hide();
            dtpDate.Hide();
            cboGender.Hide();
            //btnSignUp.Hide();

            txtUserName.Clear();
            txtPass.Clear();
            btnLogin.Show();


        }

        public void SignUpShow()
        {

            txtConfirm.Show();
            lblConfirm.Show();
            btnLogin.Hide();
            lblDate.Show();
            lblGender.Show();
            dtpDate.Show();
            cboGender.Show();
            progressBar1.Hide();
            btnForgot.Hide();

        }
        string user;// = txtUserName.Text.ToString();
        string DateOfBirth;// = dtpDate.Text.ToString();
        string gender;
        string pass;
        int b = 0;
        public void SignUpCondition()
        {
            user = txtUserName.Text.ToString();
            pass = txtPass.Text.ToString();
            string confirm = txtConfirm.Text.ToString();
            DateOfBirth = dtpDate.Text.ToString();
            gender = cboGender.Text.ToString();
            btnBLogin.Show();
            if (b == 0)
            {
                txtUserName.Clear();
                txtPass.Clear();
                SignUpShow();

                b++;
            }
            else if (b == 1)
            {
                b = 0;

                if (txtUserName.Text == "" || txtPass.Text == "" || txtConfirm.Text == "")
                {
                    MessageBox.Show("Check Your Input !");
                }
                else
                {
                    if (pass == confirm)
                    {
                        DialogResult result = MessageBox.Show("Sign Up Secuessfully !");
                        if (result == DialogResult.OK)
                        {
                            SignUpHide();
                            //btnBLogin.Hide();
                            btnForgot.Show();
                            btnBack.Hide();
                            //SignUpHide();
                            //SignUpShow();
                            btnBLogin.Hide();
                            btnQuestion.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Sign Up Falied ! \n Passwords shouldbe same !");

                    }
                    txtUserName.Clear();
                    txtPass.Clear();
                    txtConfirm.Clear();
                }

            }




        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string CUser = txtUserName.Text.ToString();
            string CPass = txtPass.Text.ToString();

            if (txtUserName.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Check Your input !");
            }
            else
            {
                if (user == CUser || pass == CPass)
                {
                    MessageBox.Show("Login Sucessfully !");
                }
                else
                {                   
                    DialogResult result =   MessageBox.Show("Login Failed ! ");

                    if (result == DialogResult.OK)
                    {
                        txtPass.Clear();
                    }
                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        public void forgotUI()
        {
            btnBack.Show();
            LoginHide();
            btnSignUp.Hide();
            progressBar1.Hide();
            //lblUserName.Hide();
            lblPass.Hide();
            txtPass.Hide();
            btnForgot.Hide();
            btnBLogin.Hide();

            btnQuestion.Show();
            /// lblUserName.Show();

        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            forgotUI();
            //string RUser = txtUserName.Text.ToString();
            // if(RUser == user ||  )
        }


        private void btnBLogin_Click(object sender, EventArgs e)
        {
            SignUpHide();
            btnForgot.Show();
            btnBLogin.Hide();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            data();
            Check();
        }
        int s = 0;
        string USER;
        string DATE;
        string GENDER;
        public void data()
        {
            //string USER;
            //string DATE;
            //string GENDER;

            if (s == 0)
            {

                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Check Your Input !");
                }
                else
                {
                    lblUserName.Text = "Date Of Birth";
                    USER = txtUserName.Text.ToString();
                    s++;
                    txtUserName.Clear();
                }
            }
            else if (s == 1)
            {

                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Check Your Input !");
                }
                else
                {
                    lblUserName.Text = "Gender";
                    // lblUserName.Text = "Date Of Birth";
                    DATE = txtUserName.Text.ToString();
                    s++;
                    txtUserName.Clear();
                }
            }
            else if (s == 2)
            {

                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Check Your Input !");
                }
                else
                {
                    GENDER = txtUserName.Text.ToString();
                    s = 0;
                    txtUserName.Clear();
                }

            }
        }
        int w = 0;
        public void Check()
        {
            //string user;// = txtUserName.Text.ToString();
            //string DateOfBirth;// = dtpDate.Text.ToString();
            //string gender;
            //string pass;
            if (user == USER || DateOfBirth == DATE || gender == GENDER)
            {
                txtUserName.Clear();
                txtPass.Show();
                txtPass.Clear();
                lblUserName.Text = "New Password";
                lblPass.Text = "Confirm Password";
                
                if ( txtUserName.Text == txtPass.Text)
                {
                    pass = txtUserName.Text.ToString();
                    MessageBox.Show("change New Password ! \n your password is  {0}", pass);
                }
                else
                {

                    txtUserName.Clear();
                    //txtPass.Show();
                    txtPass.Clear();
                }


            }
            else
            {
                if (w == 0)
                {
                    data();
                    w++;
                }
                else if (w == 1)
                {
                    data();
                    w++;
                }
                else if(w==2)
                {
                    data();
                    w++;
                }
                else
                {
                    SignUpHide();
                    //SignUpShow();
                    btnBLogin.Hide();
                    btnQuestion.Hide();
                    w = 0;
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Hide();
            SignUpHide();
            //SignUpShow();
            btnBLogin.Hide();
            btnQuestion.Hide();
            btnSignUp.Show();
            lblPass.Show();
            txtPass.Show();
        }
    }
}
