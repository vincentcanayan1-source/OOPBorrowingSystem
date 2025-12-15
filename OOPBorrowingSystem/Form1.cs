using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OOPBorrowingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if ((textBoxUsername.Text == "admin" && textBoxPassword.Text == "123") ||
                       (textBoxUsername.Text == "radley" && textBoxPassword.Text == "123") ||
                       (textBoxUsername.Text == "hans" && textBoxPassword.Text == "123") ||
                       (textBoxUsername.Text == "vincent" && textBoxPassword.Text == "123"))
            {
                MessageBox.Show("Login Successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Selection form2 = new Selection();
                form2.Show();
                this.Hide();
                form2.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
