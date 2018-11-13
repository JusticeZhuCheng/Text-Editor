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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == RePasswordBox.Text && PasswordBox.Text.Length > 0)
            {
                if (UsernameBox.Text.Length * FirstNameBox.Text.Length * LastNameBox.Text.Length != 0 && UserTypeBox.SelectedIndex != -1)
                {
                    System.IO.StreamReader readFile = new System.IO.StreamReader("login.txt");
                    string readLine;
                    bool userExist = false;
                    while ((readLine = readFile.ReadLine()) != null)
                    {
                        string[] userInfo = readLine.Split(',');
                        if (UsernameBox.Text ==userInfo[0])
                        {
                            userExist = true;
                        }
                    }
                    readFile.Close();
                    if (!userExist)
                    {
                        Login loginForm = new Login();
                        loginForm.Show();
                        this.Hide();
                        string line = UsernameBox.Text + ',' + PasswordBox.Text + ',' + UserTypeBox.SelectedItem + ',' + FirstNameBox.Text + ',' + LastNameBox.Text + ',' + dateTimePicker1.Value.Date.ToString("dd/MM/yyyy").Replace('/', '-');
                        System.IO.StreamWriter writeFile = new System.IO.StreamWriter("login.txt", true);
                        writeFile.WriteLine(line);
                        writeFile.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username Already Exists");
                    }

                }
                else
                {
                    MessageBox.Show("Please fill in all the information");
                }
            }
            else
            {
                MessageBox.Show("Please input the same password twice");
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
