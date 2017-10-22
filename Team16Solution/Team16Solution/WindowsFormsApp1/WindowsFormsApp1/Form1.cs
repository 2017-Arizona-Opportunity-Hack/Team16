using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp1
{

    
       public class Teachers
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String emailAddr { get; set; }
            public String schoolName { get; set; }
            public String schoolDist { get; set; }
            public String city { get; set; }
            public String county { get; set; }
            public String gradeTaught { get; set; }
            public String subjectTaught { get; set; }
        }

        public class WorkshopAttendence
        {
            public String year { get; set; }
            public String date { get; set; }
            public String workshopTitle { get; set; }
            public String firstName { get; set; }
            public String lastName { get; set; }
        }

        public partial class Form1 : Form
    {
        String file1Path = "";
        String file2Path = "";

        public Form1()
        {
            InitializeComponent();
            label3.Text = "Output";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static List<WorkshopAttendence> getEvent(String filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.DisplayAlerts = false;

            Excel.Workbook teacher_book = excelApp.Workbooks.Open(Filename: filePath, ReadOnly: false);
            Excel.Sheets Tables = teacher_book.Sheets;
            Worksheet Table = Tables.get_Item("Info") as Worksheet;
            // Excel._Worksheet Table = (Worksheet)teacher_book.Worksheets["Info"];

            List<WorkshopAttendence> eventList = new List<WorkshopAttendence>();

            int rows = Table.UsedRange.Row + Table.UsedRange.Rows.Count - 1;

            Range range1 = (Range)Table.Cells[1, 2];
            Range range2 = (Range)Table.Cells[rows, 5];
            Range range = Table.get_Range(range1, range2);

            object[,] values = (object[,])range.Value;

            int i;
            Range bColomn = Table.Cells[2, 1];
            Range cColomn = Table.Cells[2, 2];
            Range dColomn = Table.Cells[2, 3];
            Range fColomn = Table.Cells[2, 4];
            Range eColomn = Table.Cells[2, 5];

            for (i = 2; i <= rows; i++)
            {
                var eventAtt = new WorkshopAttendence()
                {
                    year = (string)bColomn.get_Value(null),
                    date = (string)cColomn.get_Value(null),
                    firstName = (string)dColomn.get_Value(null),
                    lastName = (string)fColomn.get_Value(null),
                    workshopTitle = (string)eColomn.get_Value(null),

                };
                eventList.Add(eventAtt);
            }

            string data = string.Empty;

            return eventList;

        }


        public static List<Teachers> getTeachers(String filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.DisplayAlerts = false;

            Excel.Workbook teacher_book = excelApp.Workbooks.Open(Filename: filePath, ReadOnly: false);
            Excel.Sheets Tables = teacher_book.Sheets;
            Worksheet Table = Tables.get_Item("Info") as Worksheet;
            // Excel._Worksheet Table = (Worksheet)teacher_book.Worksheets["Info"];

            List<Teachers> teacherList = new List<Teachers>();

            /*
            foreach (DataRow row in Table.Rows)
            {
                var teacher = new Teachers() {
                    firstName = (row["First Name"].ToString())
                    
                };
                Console.WriteLine(teacher.firstName);
                teacherList.Add(teacher);
            }
            */


            int rows = Table.UsedRange.Row + Table.UsedRange.Rows.Count - 1;

            Range range1 = (Range)Table.Cells[1, 2];
            Range range2 = (Range)Table.Cells[rows, 7];
            Range range = Table.get_Range(range1, range2);

            object[,] values = (object[,])range.Value;

            int i;
            Range bColomn = Table.Cells[2, 1];
            Range cColomn = Table.Cells[2, 2];
            Range dColomn = Table.Cells[2, 3];
            Range fColomn = Table.Cells[2, 4];
            Range eColomn = Table.Cells[2, 5];
            Range gColomn = Table.Cells[2, 6];
            Range iColomn = Table.Cells[2, 7];
            Range jColomn = Table.Cells[2, 8];
            Range kColomn = Table.Cells[2, 9];

            for (i = 2; i <= rows; i++)
            {
                var teacher = new Teachers()
                {
                    firstName = (string)bColomn.get_Value(null),
                    lastName = (string)cColomn.get_Value(null),
                    emailAddr = (string)dColomn.get_Value(null),
                    schoolName = (string)fColomn.get_Value(null),
                    schoolDist = (string)eColomn.get_Value(null),
                    city = (string)gColomn.get_Value(null),
                    county = (string)iColomn.get_Value(null),
                    gradeTaught = (string)jColomn.get_Value(null),
                    subjectTaught = (string)kColomn.get_Value(null)

                };
                teacherList.Add(teacher);
            }

            string data = string.Empty;

            Console.WriteLine();

            return teacherList;

        }
        public static double calculateTuples(List<Teachers> oldList, List<Teachers> newList)
        {
            int index = 0;
            int jndex = 0;
            int newpeople = 0;
            String previous = "";
            bool flag = false;
            double ratio = 0;


            for (index = 0; index < newList.Count; index++)
            {
                for (jndex = 0; jndex < oldList.Count; jndex++)
                {
                    //go through the entire list and if this person isn't there this person is new
                    if (((oldList[index].firstName.CompareTo(newList[jndex].firstName)) == 0) && ((oldList[index].lastName.CompareTo(newList[jndex].lastName)) == 0) && ((oldList[index].emailAddr.CompareTo(newList[jndex].emailAddr)) == 0))
                    {
                        flag = true;
                        newpeople++;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }

            ratio = (newpeople / newList.Count);


            return ratio;
        }

            private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Get the Dialog-Information
                label1.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Get the Dialog-Information
                label2.Text = ofd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Teachers> value = getTeachers(label1.Text);
            List<Teachers> value2 = getTeachers(label2.Text);
            double output = calculateTuples(value, value2);
            label3.Text = output.ToString();

        }
    }
}
