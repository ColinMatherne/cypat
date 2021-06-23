using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cypat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string EditValue(string strPassOpt, string msg, string txtText, string strLastChars)       
        {
            if (strPassOpt == "False")      // For bool
            {
                return msg + "0";
            } else if (strPassOpt == "True")    // For bool
            {
                return msg + "1";
            } else if (strPassOpt != "")
            {
                return msg + txtText;
            } else
            {
                return msg + strLastChars;
            }
        }

        private static string GetLastChars(string[] aryLines, string msg)
        {
            string element = aryLines.Where(x => x.Contains(msg)).FirstOrDefault();
            char temp = element[element.Length - 1];
            // if second char isn't a space
            if (Convert.ToString(element[element.Length - 2]) != " ")
            {
                char temp2 = element[element.Length - 2];
                return Convert.ToString(temp2) + Convert.ToString(temp);
            } else
                return Convert.ToString(temp);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result;
            
            result = MessageBox.Show("Do you want to apply the current settings", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Initial vars
                string strPassLen = txtPassLen.Text;
                string strMinPassAge = txtMinPassAge.Text;
                string strMaxPassAge = txtMaxPassAge.Text;
                string strPassComp = cbPassComp.Checked.ToString();
                string strPassEnc = cbPassEnc.Checked.ToString();
                string strPassHist = txtPassHist.Text;

                // Make array with all lines in file
                string[] aryLines = System.IO.File.ReadAllLines(@"securityconfig.cfg");

                // Get the last 1 or 2 chars (if no input was put in) and edit the line in the array
                string strPassLenLastChars = GetLastChars(aryLines, "MinimumPasswordLength = ");
                aryLines[5] = EditValue(strPassLen, "MinimumPasswordLength = ", txtPassLen.Text, strPassLenLastChars);

                string strMinPassAgeLastChars = GetLastChars(aryLines, "MinimumPasswordAge = ");
                aryLines[3] = EditValue(strMinPassAge, "MinimumPasswordAge = ", txtMinPassAge.Text, strMinPassAgeLastChars);

                string strMaxPassAgeLastChars = GetLastChars(aryLines, "MaximumPasswordAge = ");
                aryLines[4] = EditValue(strMaxPassAge, "MaximumPasswordAge = ", txtMaxPassAge.Text, strMaxPassAgeLastChars);

                string strPassCompLastChars = GetLastChars(aryLines, "PasswordComplexity = ");
                aryLines[6] = EditValue(strPassComp, "PasswordComplexity = ", strPassComp, strPassCompLastChars);

                string strPassEncLastChars = GetLastChars(aryLines, "PasswordHistorySize = ");
                aryLines[7] = EditValue(strPassHist, "PasswordHistorySize = ", txtPassHist.Text, strPassEncLastChars);

                string strPassHistLastChars = GetLastChars(aryLines, "ClearTextPassword = ");
                aryLines[13] = EditValue(strPassEnc, "ClearTextPassword = ", strPassEnc, strPassHistLastChars);

                System.IO.File.WriteAllLines(@"securityconfig.cfg", aryLines);

                // Get current directory
                string strDir = System.AppContext.BaseDirectory;

                // Start cypat.bat with cmd.exe
                string strCmdText = "/C start " + strDir + "cypat.bat && exit";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is just here for show", "Message");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to quit", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();       // Closes the main application
            }
        }
    }
}
