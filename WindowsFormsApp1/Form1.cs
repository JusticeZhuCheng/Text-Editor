using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public String userType;
        public String userName;

        public Login()
        {
            InitializeComponent();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string line;
            bool userExist = false;
            System.IO.StreamReader loginFile = new System.IO.StreamReader("login.txt");
            while ((line = loginFile.ReadLine()) != null)
            {
                string[] userInfo = line.Split(',');
                if (UserNameBox.Text == userInfo[0])
                {
                    userExist = true;
                    if(PasswordBox.Text == userInfo[1])
                    {
                        userName = userInfo[3]+" "+userInfo[4];
                        userType = userInfo[2];
                        Editor editorForm = new Editor(userName, userType);
                        this.Hide();
                        editorForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                    }
                }
            }
            loginFile.Close();
            if (userExist == false)
            {
                MessageBox.Show("Unknown Username");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
