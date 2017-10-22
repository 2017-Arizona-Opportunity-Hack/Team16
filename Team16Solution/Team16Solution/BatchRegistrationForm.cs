using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Team16Solution
{
    public partial class BatchRegistrationForm : Form
    {
        readonly String EXCEL_WORKSHEET = "Sheet1$";
        readonly String TEACHERS_WORKSHEET = "sheet1$";
        readonly String TEACHERS_FILE_PATH = "C:\\Users\\evanxia\\Source\\Repos\\OpporHack\\Team16\\Team16Solution\\Team16Solution\\Data\\Teachers.xlsx";
        readonly String WORKSHOP_FILE_PATH = "C:\\Users\\evanxia\\Source\\Repos\\OpporHack\\Team16\\Team16Solution\\Team16Solution\\Data\\Workshop-attending.xlsx";
        public BatchRegistrationForm()
        {
            InitializeComponent();
        }

        private void btn_selectEvent_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog() { Filter = "Excel Workbook |*.xls;*.xlsx;*.xlsm", ValidateNames = true };
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                // clear file path history
                textBox_showEventFilePath.Text = "";
                String excelConn = "Provider=Microsoft.Ace.Oledb.12.0;Data Source=" + opfd.FileName + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";

                if (opfd.FileName != "")
                {
                    textBox_showEventFilePath.Text = opfd.FileName;
                    OleDbDataAdapter oda = new OleDbDataAdapter("Select * from [" + EXCEL_WORKSHEET + "]", excelConn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGrid_excel.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Ooops, Error!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_addEvent_Click(object sender, EventArgs e)
        {
            if (dataGrid_excel.Rows.Count == 0)
            {
                MessageBox.Show("Please select an excel file first!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_WorkshopTitle.Text.Equals(""))
            {
                MessageBox.Show("Please enter the Workshop Title!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Excel.Application oXL;
            Excel._Workbook oWB, oWB2;
            Excel._Worksheet oSheet, oSheet2;
            Excel.Range oRng, oRng2;
            //Start Excel and get Application object.
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = true;
            //Get a new workbook.
            oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Open(TEACHERS_FILE_PATH));
            oWB2 = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Open(WORKSHOP_FILE_PATH));
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;
            oSheet2 = (Microsoft.Office.Interop.Excel._Worksheet)oWB2.ActiveSheet;
            oRng = oSheet.UsedRange;
            oRng2 = oSheet2.UsedRange;
            int teachersRowsCount = oRng.Rows.Count;
            int workshopRowsCount = oRng2.Rows.Count;
            for (int i = 0; i < dataGrid_excel.Rows.Count - 1; i++)
            {
                String firstName = dataGrid_excel.Rows[i].Cells["First Name"].Value.ToString();
                String lastName = dataGrid_excel.Rows[i].Cells["Last Name"].Value.ToString();
                String preferredEmail = dataGrid_excel.Rows[i].Cells["Preferred Email"].Value.ToString();
                String schoolName = dataGrid_excel.Rows[i].Cells["School Name"].Value.ToString();
                String schoolDistrict = dataGrid_excel.Rows[i].Cells["School District"].Value.ToString();
                String city = dataGrid_excel.Rows[i].Cells["City"].Value.ToString();
                String county = dataGrid_excel.Rows[i].Cells["County"].Value.ToString();
                String gradeTaught = dataGrid_excel.Rows[i].Cells["Grade Taught"].Value.ToString();
                String subjectsTaught = dataGrid_excel.Rows[i].Cells["Subjects Taught"].Value.ToString();

                try
                {
                    oSheet.Cells[i + teachersRowsCount + 1, 1] = firstName;
                    oSheet.Cells[i + teachersRowsCount + 1, 2] = lastName;
                    oSheet.Cells[i + teachersRowsCount + 1, 3] = preferredEmail;
                    oSheet.Cells[i + teachersRowsCount + 1, 4] = schoolName;
                    oSheet.Cells[i + teachersRowsCount + 1, 5] = schoolDistrict;
                    oSheet.Cells[i + teachersRowsCount + 1, 6] = city;
                    oSheet.Cells[i + teachersRowsCount + 1, 7] = county;
                    oSheet.Cells[i + teachersRowsCount + 1, 8] = gradeTaught;
                    oSheet.Cells[i + teachersRowsCount + 1, 9] = subjectsTaught;

                    oSheet2.Cells[i * 10 + workshopRowsCount + 1, 1] = dateTimePicker1.Value.Year;
                    oSheet2.Cells[i * 10 + workshopRowsCount + 1, 2] = dateTimePicker1.Text;
                    oSheet2.Cells[i * 10 + workshopRowsCount + 1, 3] = textBox_WorkshopTitle.Text;
                    oSheet2.Cells[i * 10 + workshopRowsCount + 1, 4] = firstName;
                    oSheet2.Cells[i * 10 + workshopRowsCount + 1, 5] = lastName;
                }
                catch (Exception theException)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, theException.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, theException.Source);
                    MessageBox.Show(errorMessage, "Error");
                }






                /********************************************** Validate user input for the DB **************************************/

                // TO-BE-DONE: Check if the teacher already exists in the Teacher table.

                /******************************************** Validate user input for the DB end *******************************************/
            }

            //oSheet.Range.AllocateChanges();
        }
      
    }
}
