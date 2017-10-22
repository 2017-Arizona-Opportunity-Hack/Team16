using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainHack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sign_up_button_Click(object sender, EventArgs e)
        {
            // Hide the main menu
            this.Visible = false;

            // Show the Sign up form
            SignUpInformation signNext = new SignUpInformation();
            signNext.ShowDialog();

            // Delete this Box from memory
            this.Close();
        }

        private void constant_contact_Click(object sender, EventArgs e)
        {
            // Show the Sign up form
            SignUpInformation signNext = new SignUpInformation();
            signNext.ShowDialog();

            // Delete this Box from memory
            this.Close();

        }
    }
}
