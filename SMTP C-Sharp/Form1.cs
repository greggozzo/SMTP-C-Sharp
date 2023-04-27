using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SMTP_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
                var comboBox = CbRegion;
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[] 
                { 
                    new DataColumn("Endpoint", typeof(string)), 
                    new DataColumn("Region", typeof(string)) 
                });

                dt.Rows.Add("Choose Region", "Choose Region");
                dt.Rows.Add("email-smtp.us-east-1.amazonaws.com", "US-East-1");
                dt.Rows.Add("email-smtp.us-east-2.amazonaws.com", "US-East-2");
                dt.Rows.Add("email-smtp.us-west-1.amazonaws.com","US-West-1");
                dt.Rows.Add("email-smtp.us-west-2.amazonaws.com", "US-West-2");                
                dt.Rows.Add("email-smtp.eu-west-1.amazonaws.com", "EU-West-1");
                dt.Rows.Add("email-smtp.eu-west-2.amazonaws.com", "EU-West-2");
                dt.Rows.Add("email-smtp.eu-west-3.amazonaws.com", "EU-West-3");
                dt.Rows.Add("email-smtp.eu-north-1.amazonaws.com", "EU-North-1");
                dt.Rows.Add("email-smtp.eu-central-1.amazonaws.com", "EU-Central-1");
                dt.Rows.Add("email-smtp.ap-northeast-1.amazonaws.com", "AP-NorthEast-1");
                dt.Rows.Add("email-smtp.ap-northeast-2.amazonaws.com", "AP-NorthEast-2");
                dt.Rows.Add("email-smtp.ap-northeast-3.amazonaws.com", "AP-NorthEast-3");                
                dt.Rows.Add("email-smtp.ap-southeast-1.amazonaws.com", "AP-SouthEast-1");
                dt.Rows.Add("email-smtp.ap-southeast-2.amazonaws.com", "AP-SouthEast-2");                
                dt.Rows.Add("email-smtp.ap-south-1.amazonaws.com", "AP-South-1");
                dt.Rows.Add("email-smtp.ca-central-1.amazonaws.com", "CA-Central-1");                
                dt.Rows.Add("email-smtp.sa-east-1.amazonaws.com", "SA-East-1");
                dt.Rows.Add("email-smtp.us-gov-west-1.amazonaws.com", "US-GOV-West-1");
                comboBox.DataSource = dt;
                comboBox.DisplayMember = "Region";
                comboBox.ValueMember = "Endpoint";                
            }

            CbRegion.SelectedIndex = 0;
            TxtBody.Text = "This is a Test";
            ButtonSearch.Visible = false;
            TxtFilePath.Visible = false;
        }
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            var username = TxtKey.Text;
            var password = TxtSecret.Text;
            var host = CbRegion.SelectedValue.ToString();
            int port = 587;
            var From = TxtFrom.Text;
            var sTo = TxtTo.Text;
            var Subject = TxtSubject.Text;
            var Body = TxtBody.Text;

            if (checkBox1.Checked == true)
            {
                username = getUserName();
                password = getUserPass();
            }

            if (CheckTextBoxEmpty(CbRegion.Text, username, password) > 0)
                return;

            if (CheckEmailStrings(sTo, From, Subject, Body) > 0)
                return;

            var mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.From = new System.Net.Mail.MailAddress(From);
            mailMessage.To.Add(sTo);
            mailMessage.Subject = Subject;
            mailMessage.Body = Body;

            try
            {
                using (var client = new System.Net.Mail.SmtpClient(host, port))
                {
                    client.Credentials = new System.Net.NetworkCredential(username, password);
                    client.EnableSsl = true;
                    if (txtAttachment.Text != "")
                    {
                        string file = txtAttachment.Text;
                        System.Net.Mail.Attachment attachment;
                        attachment = new System.Net.Mail.Attachment(file);
                        mailMessage.Attachments.Add(attachment);
                    }
                    if (CheckDelegate.Checked)
                    {
                        string headerARN = TxtDelegate.Text;
                        mailMessage.Headers.Add("X-SES-SOURCE-ARN", headerARN);
                        mailMessage.Headers.Add("X-SES-FROM-ARN", headerARN);
                        mailMessage.Headers.Add("X-SES-RETURN-PATH-ARN", headerARN);
                    }
                    client.Send(mailMessage);
                }
                MessageBox.Show("Sent successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string getUserPass()
        {
            var accesskey = "";
            string filePath = TxtFilePath.Text;
            filePath = filePath.Replace("\"", "").Trim();
            using (TextFieldParser myReader = new TextFieldParser(filePath))
            {
                myReader.TextFieldType = FieldType.Delimited;
                myReader.SetDelimiters(",");

                string[] currentRow;
                while (!myReader.EndOfData)
                {
                    try
                    {
                        currentRow = myReader.ReadFields();
                        accesskey = currentRow[2];
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            return accesskey;
        }
        private string getUserName()
        {
            string accessID = "";
            string filePath = TxtFilePath.Text;

            filePath = filePath.Replace("\"", "").Trim();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                string[] currentRow;
                while (!parser.EndOfData)
                {
                    try
                    {
                        currentRow = parser.ReadFields();
                        accessID = currentRow[1];
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            return accessID;
        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            TxtFilePath.Visible = true;
            ButtonSearch.Visible = true;
        }
        private void TxtFilePath_GotFocus()
        {
            TxtFilePath.Text = "";
        }
        private int CheckEmailStrings(string sTo, string sFrom, string sSubject, string sBody)
        {
            int count = 0;
            if (sTo == "")
            {
                MessageBox.Show("Please Enter To Address");
                count = 1;
                return count;
            }
            if (sFrom == "")
            {
                MessageBox.Show("Please Enter From Address");
                count += 1;
                return count;
            }
            if (sSubject == "")
            {
                MessageBox.Show("Please Enter Subject");
                count += 1;
                return count;
            }
            if (sBody == "")
            {
                MessageBox.Show("Please Enter Body");
                count += 1;
                return count;
            }
            return count;
        }
        private int CheckTextBoxEmpty(string CbRegion, string userName, string password)
        {
            int count = 0;
            if (CbRegion == "Choose Region")
            {
                MessageBox.Show("Please Select Region");
                count += 1;
                return count;
            }
            if (userName == "")
            {
                MessageBox.Show("User Name Is Empty");
                count += 1;
                return count;
            }
            if (password == "")
            {
                MessageBox.Show("Access Secret KeyIs Empty");
                count += 1;
                return count;
            }
            return count;
        }

        private void TxtBody_GotFocus(object sender, EventArgs e)
        {
            TxtBody.Text = "";
        }

        private string removeQuotes(string filePath)
        {
            filePath.Replace("\"", "").Trim();
            return filePath;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            TxtFilePath.Visible = true;
            ButtonSearch.Visible = true;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if ((openFileDialog1.ShowDialog() == DialogResult.OK))
                TxtFilePath.Text = openFileDialog1.FileName;
        }

        private void ButtonSearchFile_Click(object sender, EventArgs e)
        {
            if ((openFileDialog1.ShowDialog() == DialogResult.OK))
                txtAttachment.Text = openFileDialog1.FileName;
        }

        private void TxtDelegate_Enter(object sender, EventArgs e)
        {
            if (TxtDelegate.Text == "Identity ARN")
                TxtDelegate.Text = "";  
        }
        
    }
}
