using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace phone01
{

    public partial class frmRegister : Form
    {



        public frmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      //  MySqlConnection con = new MySqlConnection("server=localhost; database=phone01; user=root;pooling = false; convert zero datetime=True");

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=phone01; user=root;pooling = false; convert zero datetime=True");

            string CustomerName= txtCoustomerName.Text.ToString();
            string PhoneNumber = txtPHoneNo.Text.ToString();
            string SimCard = cboSimCard.Text.ToString();
            string SdCard = cboSimCard.Text.ToString();
            string Password =txtPassword.Text.ToString();
            string Amount = txtAmount.Text.ToString();
            string Error = txtError.Text.ToString();
            string StartDate =dtpStartDate.Text.ToString();
            string EndDate = dtpEndDate.Text.ToString();

            string TechnicalName = txtTechnicalName.Text.ToString();
            string Done = cboDone.Text.ToString();
            if(CustomerName==""||PhoneNumber==""||Password==""||Amount==""||Error=="")
            {
                MessageBox.Show("Check Your Input...........................!");

            }
            else
            {
                try

                {
                   // MySqlConnection con = new MySqlConnection("server=localhost; database=phone01; user=root;pooling = false; convert zero datetime=True");
                    //server = localhost; User Id = root; password = mautauaja; Persist Security Info = True; database = test; Convert Zero Datetime = True
                    con.Open();

                    MySqlCommand cmd = con.CreateCommand();
                   // cmd.CommandText = "INSERT INTO phone01.customer ( `customer_name`, `phoneno`, `sim_card`, `sd_card`, `password`, `amount`, `error`, `start_date`, `end_date`) VALUES(@CustomerName, @PhoneNumber,@SimCard, @SdCard, @Passowrd, @Amount, @Error, @StartDate, @EndDate)";
                    cmd.CommandText = "INSERT INTO phone01.customer (`customer_id`, `customer_name`, `phoneno`, `sim_card`, `sd_card`, `password`, `amount`, `error`, `start_date`, `end_date`) VALUES(NULL, @CustomerName,  @PhoneNumber, @SimCard, @SimCard, @Password, @Amount, @Error, @StartDate, @EndDate)";

                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@SimCard", SimCard);
                    cmd.Parameters.AddWithValue("@SdCard", SdCard);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Error", Error);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.Parameters.AddWithValue("@Amount", Amount);
                    cmd.Parameters.AddWithValue("@EndDate", EndDate);


                    cmd.ExecuteNonQuery();

                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = " INSERT INTO phone01.technical ( `technical_name`, `phone_password`, `amount`, `error`, `start_date`, `end_date`, `done`) VALUES(@TechnicalName,@Password,@Amount,@Error,@StartDate,@EndDate,@Done)";

                    command.Parameters.AddWithValue("@TechnicalName", TechnicalName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Amount", Amount);
                    command.Parameters.AddWithValue("@Error", Error);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);
                    command.Parameters.AddWithValue("@Done", Done);


                    command.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("registered !");
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
           // dtpStartDate.Value = DateTime.MinValue();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

              //  dtpEndDate.Value = DateTime.MinValue();
        }

        private void lblCoustomerID_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=phone01; user=root;pooling = false; convert zero datetime=True");

            string CustomerName = txtCoustomerName.Text.ToString();
            string PhoneNumber = txtPHoneNo.Text.ToString();
            string SimCard = cboSimCard.Text.ToString();
            string SdCard = cboSimCard.Text.ToString();
            string Password = txtPassword.Text.ToString();
            string Amount = txtAmount.Text.ToString();
            string Error = txtError.Text.ToString();
            string StartDate = dtpStartDate.Text.ToString();
            string EndDate = dtpEndDate.Text.ToString();
            string CustomerID = txtCustomerId.Text.ToString();
            string OrderID = txtOrderID.Text.ToString();

            string TechnicalName = txtTechnicalName.Text.ToString();
            string Done = cboDone.Text.ToString();
            if (CustomerName == "" || PhoneNumber == "" || Password == "" || Amount == "" || Error == "")
            {
                MessageBox.Show("Check Your Input...........................!");

            }
            else
            {
                try

                {
                    con.Open();

                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "UPDATE phone01.technical SET `technical_name`=@TechnicalName,`phone_password`=@Password,`amount`=@Amount,`error`=@Error,`start_date`=@StartDate,`end_date`=@EndDAte,`done`=@Done";
                    // command.CommandText = "ALTER TABLE phone01.technical CHANGE COLUMN `id` `id` INT(11) NOT NULL AUTO_INCREMENT, DROP PRIMARY KEY,  ADD PRIMARY KEY(`id`); ";





                    command.Parameters.AddWithValue("@TechnicalName", TechnicalName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Amount", Amount);
                    command.Parameters.AddWithValue("@Error", Error);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);
                    command.Parameters.AddWithValue("@Done", Done);


                    command.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Updated++++++++++++++++++ !");
                    //this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
