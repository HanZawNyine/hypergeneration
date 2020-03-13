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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        int select = 0;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                
                MySqlCommand cmd = con.CreateCommand();
               

                string TechnicalName = txtTechnicalName.Text.ToString();
                string UTechnicalName = txtUpdateTechnicalName.Text.ToString();

                string PhonePassword = txtPassword.Text.ToString();
                string UPhonePassword = txtUpdatePassword.Text.ToString();

                string Amount = txtAmount.Text.ToString();
                string UAMount = txtUpdateAmount.Text.ToString();

                string error = txtError.Text.ToString();
                string Uerror = txtUpdateError.Text.ToString();

                string StartDate = dtpStartDate.Value.ToString();
                string UStartDate = dtpUpdateStartDate.Value.ToString();

                string EndDate = dtpEndDate.Value.ToString();
                string UEndDate = dtpUpdateEndDate.Value.ToString();

                string Done=cboDone.Text.ToString();
                string UDone = cboUpdateDone.Text.ToString();

                string CustomerName = txtCoustomerName.Text.ToString();
                string UCustomerName = txtUpdateCustomerName.Text.ToString();

                string PhoneNumber = txtPHoneNo.Text.ToString();
                string UPhoneNumber = txtUpdatePhoneNumber.Text.ToString();

                string SimCard = cboSimCard.Text.ToString();
                string USimCard = cboUpdateSimCard.Text.ToString();

                string SdCard = cboSdCard.Text.ToString();
                string USdCard = cboUpdateSdCard.Text.ToString();


                if (TechnicalName != UTechnicalName)
                {


                   
                    con.Open();

                    cmd.CommandText = "UPDATE phone01.technical SET `technical_name`=@UTechnicalName where `technical_name`='" + TechnicalName + "'";                   
                    cmd.Parameters.AddWithValue("@UTechnicalName", UTechnicalName);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update TechnicalName ----!!");
                }
                if (PhonePassword != UPhonePassword)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.technical SET `phone_password`=@UPhonePassword where `phone_password`='" + PhonePassword + "'";
                    cmd.Parameters.AddWithValue("@UPhonePassword", UPhonePassword);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd.CommandText = "UPDATE phone01.customer SET `password`=@UPhonePassword where password`='" + PhonePassword + "'";
                    cmd.Parameters.AddWithValue("@UPhonePassword", UPhonePassword);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update Password ----!!");

                }
                if (Amount != UAMount)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.technical SET `amount`=@UAMount where `amount`='" + Amount + "'";
                    cmd.Parameters.AddWithValue("@UAMount", UAMount);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd.CommandText = "UPDATE phone01.customer SET `amount`=@UAMount where `amount`='" + Amount + "'";
                    cmd.Parameters.AddWithValue("@UAMount", UAMount);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update Amount ----!!");

                }
                if (error != Uerror)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.technical SET `error`=@Uerror where `error`='" + error + "'";
                    cmd.Parameters.AddWithValue("@Uerror", Uerror);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.customer SET `error`=@Uerror where `error`='" + error + "'";
                    cmd.Parameters.AddWithValue("@Uerror", Uerror);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update Error ----!!");

                }
                if (StartDate != UStartDate)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.technical SET `start_date`=@UStartDate where `start_date`='" + StartDate + "'";
                    cmd.Parameters.AddWithValue("@UStartDate", UStartDate);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.customer SET `start_date`=@UStartDate where `start_date`='" + StartDate + "'";
                    cmd.Parameters.AddWithValue("@UStartDate", UStartDate);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update Start Date ----!!");

                }
                if (EndDate != UEndDate)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.technical SET `end_date`=@UEndDate where `end_date`='" + EndDate + "'";
                    cmd.Parameters.AddWithValue("@UEndDate", UEndDate);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.customer SET `end_date`=@UEndDate where `end_date`='" + EndDate + "'";
                    cmd.Parameters.AddWithValue("@UEndDate", UEndDate);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update End Date ----!!");

                }
                if (Done != UDone)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.technical SET `done`=@UDone where `done`='" + Done + "'";
                    cmd.Parameters.AddWithValue("@UDone", UDone);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update  Done ----!!");

                }
                if (CustomerName != UCustomerName)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.customer SET `customer_name`=@UCustomerName where `customer_name`='" + CustomerName + "'";
                    cmd.Parameters.AddWithValue("@UCustomerName", UCustomerName);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update CustomerName ----!!");

                }
                if (PhoneNumber != UPhoneNumber)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.customer SET `phoneno`=@UPhoneNumber where `phoneno`='" + PhoneNumber + "'";
                    cmd.Parameters.AddWithValue("@UPhoneNUmber", UPhoneNumber);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update Phone Number----!!");

                }
                if (SimCard != USimCard)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.customer SET `sim_card`=@USimCard where `sim_card`='" + SimCard + "'";
                    cmd.Parameters.AddWithValue("@USimCard", USimCard);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update SimCard----!!");

                }
                if (SdCard != USdCard)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE phone01.customer SET `sd_card`=@USdCard where `sd_card`='" + SdCard + "'";
                    cmd.Parameters.AddWithValue("@USdCard", USdCard);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update SD Card----!!");

                }



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        



        }
        





    }
}
        