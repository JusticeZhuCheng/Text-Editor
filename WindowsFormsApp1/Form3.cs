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
    public partial class Editor : Form
    {
        public string userName;
        public string userType;
        public string file;
        public Editor(string loginName, string loginType)
        {
            InitializeComponent();
            this.userName = loginName;
            this.userType = loginType;
            file = "";
            if(userType == "View")
            {
                richTextBox1.Enabled = false;
            }
            else if(userType == "Edit"){
                richTextBox1.Enabled = true;
            }
            toolStripUserName.Text += userName;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            file = "";
        }

        private void toolStripNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            file = "";
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog
            {
                Title = "Select a file",
                Filter = "Rich Text Files (*.rtf)|*.rtf"
            };
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                file = fileOpen.FileName;
                richTextBox1.LoadFile(file);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog
            {
                Title = "Select a file",
                Filter = "Rich Text Files (*.rtf)|*.rtf"
            };
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                file = fileOpen.FileName;
                richTextBox1.LoadFile(file);
            }
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (file != "")
            {
                richTextBox1.SaveFile(file);
            }
            else if (file == "")
            {
                SaveFileDialog saveFile = new SaveFileDialog
                {
                    Filter = "Rich Text Files (*.rtf)|*.rtf",
                    RestoreDirectory = true,
                };
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    file = saveFile.FileName;
                    richTextBox1.SaveFile(file);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file != "")
            {
                richTextBox1.SaveFile(file);
            }
            else if (file == "")
            {
                SaveFileDialog saveFile = new SaveFileDialog
                {
                    Filter = "Rich Text Files (*.rtf)|*.rtf",
                    RestoreDirectory = true,
                };
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    file = saveFile.FileName;
                    richTextBox1.SaveFile(file);
                }
            }
        }

        private void toolStripSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Rich Text Files (*.rtf)|*.rtf",
                RestoreDirectory = true,
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                file = saveFile.FileName;
                richTextBox1.SaveFile(file);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Rich Text Files (*.rtf)|*.rtf",
                RestoreDirectory = true,
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                file = saveFile.FileName;
                richTextBox1.SaveFile(file);
            }
        }

        private void toolStripBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionFont.Bold == true)
                {
                    richTextBox1.SelectionFont = new Font(
                    richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(
                    richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                }
            }
        }

        private void toolStripItalics_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionFont.Italic == true)
                {
                    richTextBox1.SelectionFont = new Font(
                    richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(
                    richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
                }
            }
        }

        private void toolStripUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionFont.Underline == true)
                {
                    richTextBox1.SelectionFont = new Font(
                    richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style^FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(
                    richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                };
            }
        }

        private void toolStripFontSize_SelectionIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                float fontSize = float.Parse(toolStripFontSize.SelectedItem.ToString());

                richTextBox1.SelectionFont = new Font(
                    richTextBox1.SelectionFont.FontFamily,
                    fontSize,
                    richTextBox1.SelectionFont.Style,
                    GraphicsUnit.Point,
                    ((byte)(0)));
            }
        }

        private void toolStripCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}
