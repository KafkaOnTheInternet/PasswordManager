using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        User usr;
        public Form1()
        {
            InitializeComponent();
            usr = new User(1, "123");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usr.TestDB();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInitTable_Click(object sender, EventArgs e)
        {
            txtConfirm.Text = usr.TestDB();
        }

        private void btnSelectRes1_Click(object sender, EventArgs e)
        {
            
            try
            {
                usr.con.Open();
                SqlCommand cm = new SqlCommand("Select * from Passwords", usr.con);
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    txtConfirm.Text = sdr["URL"].ToString();
                }
                //txtConfirm.Text = "query executed";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                txtConfirm.Text = "query not executed" + ex;
            } finally
            {
                usr.con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String url = txtURL.Text;
            String passwd = txtPasswd.Text;

            try
            {
                usr.con.Open();
                SqlCommand cm = new SqlCommand($"Insert into Passwords values ('{url}', '{passwd}')", usr.con);
                cm.ExecuteNonQuery();
                txtConfirm.Text = "Inserted records successfully";
            } catch (Exception ex)
            {
                txtConfirm.Text = "Fucky wucky " + ex;
            } finally
            {
                usr.con.Close();
            }

        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSelect_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            String url = txtSelectWebsite.Text;
            try
            {
                usr.con.Open();
                SqlCommand cm = new SqlCommand($"Select * from Passwords where URL='{url}'", usr.con);
                SqlDataReader sdr = cm.ExecuteReader();

                while (sdr.Read())
                {
                    txtSelectPass.Text = $"{sdr["password"].ToString()}";
                    Clipboard.SetText(sdr["password"].ToString());
                }

            } catch (Exception ex)
            {
                txtConfirm.Text = "Select didn't work all too well " + ex;
            } finally
            {
                usr.con.Close();
            }
        }

        private void textSelectPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSelectPass.Text);
            txtConfirm.Text = "Copied your password successfully";
        }
    }
}
