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
    public partial class SignUpInformation : Form
    {
        private bool SCHOOL_DB = false;
        private bool TEACHERS_DB = false;
        private bool EVENT_DB = false;


        public SignUpInformation()
        {
            InitializeComponent();

       //     dateTimePicker1.Format = DateTimePickerFormat.Custom;
       //     dateTimePicker1.CustomFormat = "dd/MM/yyyy yyyy";

        }

        private void school_db_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "XLSX Files|*.xlsx";

            if(ofp.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                //Get the Dialog-Information
                label1.Text = ofp.FileName;
                SCHOOL_DB = true;
            }

        }

        private void teachers_db_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "XLSX Files|*.xlsx";

            if (ofp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Get the Dialog-Information
                label2.Text = ofp.FileName;
                TEACHERS_DB = true;
            }

        }

        private void event_teacher_db_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "XLSX Files|*.xlsx";

            if (ofp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Get the Dialog-Information
                label3.Text = ofp.FileName;
                EVENT_DB = true;
            }

        }

        private void Form_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(EventName.Text) && SCHOOL_DB == true && TEACHERS_DB== true && EVENT_DB == true)
            {
                //Get Year
                char[] whitespace = new char[] { ' ', '\t' };
                string[] date_information = dateTimePicker1.Text.Split(whitespace);

                //Call the signUp form
                Form2 fm2 = new Form2(label1.Text, label2.Text, label3.Text, EventName.Text, dateTimePicker1.Text, dateTimePicker1.Value.Year.ToString());
                fm2.ShowDialog();

                // Delete this Box from memory
                this.Close();

            }
        }
    }
}
