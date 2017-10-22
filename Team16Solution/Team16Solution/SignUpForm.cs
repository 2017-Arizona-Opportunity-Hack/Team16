using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace MainHack
{
    public partial class Form2 : Form
    {
        //Fill in List
        private List<string> school_list = new List<string>();
        private List<string> school_county_list = new List<string>();
        private List<string> school_city_list = new List<string>();
        private List<string> school_district_list = new List<string>();

        private List<string> subject_list;
        private List<string> grade_list;
        private List<string> county_list;

        // For opening an excel files 
        private Excel.Application excelApp;
        private Workbook workbook_schools;
        private Sheets sheets_schools;
        private Worksheet sheet_schools;

        private Excel.Application TeachersApp;
        private Workbook workbook;
        private Sheets sheets;
        private Worksheet sheet;

        private Excel.Application EventsApp;
        private Workbook event_workbook;
        private Sheets event_sheets;
        private Worksheet event_sheet;

        //Global var
        string pathOfTeachersTable;
        string pathOfEventTable;
        string pathOfSchoolTable;
        string nameOFEvent;
        string Event_Date;
        string Event_Year;

        //Update Info 
        bool updated_info = false;
        int update_index = 0;

        public Form2(string school_db, string teacher_db, string Event_db, string nameEvent, string date, string year)
        {
            InitializeComponent();

            //Set Global Var
            pathOfTeachersTable = teacher_db;
            pathOfEventTable = Event_db;
            pathOfSchoolTable = school_db;
            nameOFEvent = nameEvent;
            Event_Date = date;
            Event_Year = year;

            // Read the School Data
            excelApp = new Excel.Application();

            excelApp.DisplayAlerts = false; //Don't want Excel to display error messageboxes

            workbook_schools = excelApp.Workbooks.Open(pathOfSchoolTable);
            sheets_schools = workbook_schools.Sheets;

            sheet_schools = sheets_schools.get_Item("Info") as Worksheet;

            int rows = sheet_schools.UsedRange.Row + sheet_schools.UsedRange.Rows.Count - 1;

            Range range1 = (Range)sheet_schools.Cells[1, 2];
            Range range2 = (Range)sheet_schools.Cells[rows, 7];
            Range range = sheet_schools.get_Range(range1, range2);

            object[,] values = range.Value;

            int i;
            for (i = 2; i <= rows; i++)
            {
                school_list.Add((string)values[i, 1]);
                school_county_list.Add((string)values[i, 5]);
                school_city_list.Add((string)values[i, 3]);
                school_district_list.Add((string)values[i, 6]);
            }

            //Remove the hold on 
            workbook_schools.Close();
            excelApp.Quit();

            //Add the schools
            school_list.Add("Other");
            schools.DataSource = school_list;

            // Put blank input for schools
            schools.ResetText();
            schools.SelectedIndex = -1;

            //Add Subject
            subject_list = new List<string>(new string[] { "General", "Mathematics", "Economics", "Science", "Social Science", "Business",
                 "Other" });
            subjectbox.DataSource = subject_list;

            // Put blank input for subjectbox
            subjectbox.ResetText();
            subjectbox.SelectedIndex = -1;

            // Add county
            county_list = new List<string>(new string[] { "Apache", "Cochise", "Coconino", "Gila", "Grhama", "Greenlee", "Maricpa", "Mohave", "Navajo",
                "Pima", "Pinal", "Santa Cruz", "Yavapai", "Yuma", "La Paz", "Out of Arizona", "Department of Corrections", "Other"});
            countybox.DataSource = county_list;

            // Put a blank in for county
            countybox.ResetText();
            countybox.SelectedIndex = -1;

            // Add Grade
            grade_list = new List<string>(new string[] { "K-6th", "7th-8th", "9th-12th","Other" });
            gradebox.DataSource = grade_list;

            // Put blank input for gradebox
            gradebox.ResetText();
            gradebox.SelectedIndex = -1;

            LastName.KeyPress += new KeyPressEventHandler(OnlyAlpha);
            FirstName.KeyPress += new KeyPressEventHandler(OnlyAlpha);
            schools.SelectedIndexChanged += OnSelectedIndexChanged;


            // Open another excel file to perform "fill information" 
            TeachersApp = new Excel.Application();
            TeachersApp.DisplayAlerts = false;
            workbook = TeachersApp.Workbooks.Open(Filename: pathOfTeachersTable , ReadOnly: false);
            sheets = workbook.Sheets;
            sheet = sheets.get_Item("Info") as Worksheet;

            // Open another excel file to perform "fill information" 
            EventsApp = new Excel.Application();
            EventsApp.DisplayAlerts = false;
            event_workbook = EventsApp.Workbooks.Open(Filename: pathOfEventTable, ReadOnly: false);
            event_sheets = event_workbook.Sheets;
            event_sheet = event_sheets.get_Item("Info") as Worksheet;

        }

        ~Form2()  // destructor
        {
            //Remove the hold on 
            workbook.Close();
            TeachersApp.Quit();

            //Remove the hold on 
            event_workbook.Close();
            EventsApp.Quit();
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int index = schools.Items.IndexOf(schools.Text);
            
            schooldistrict.Text = school_district_list[index];
            citybox.Text = school_city_list[index];
            countybox.Text = school_county_list[index]; 

    }

        private void OnlyAlpha(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar)) return;

            if (e.KeyChar < 65 || e.KeyChar > 122 || e.KeyChar == 39 || e.KeyChar == 37 || e.KeyChar == 46)
            {
                e.Handled = true;
            }
        }

        private void schools_DropDown(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown += new PreviewKeyDownEventHandler(schools_PreviewKeyDown);
        }

        private void schools_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown -= schools_PreviewKeyDown;
            if (cbo.DroppedDown) cbo.Focus();
        }

        private void subjectbox_DropDown(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown += new PreviewKeyDownEventHandler(subjectbox_PreviewKeyDown);
        }

        private void subjectbox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown -= subjectbox_PreviewKeyDown;
            if (cbo.DroppedDown) cbo.Focus();
        }

        private void gradebox_DropDown(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown += new PreviewKeyDownEventHandler(gradebox_PreviewKeyDown);
        }

        private void gradebox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown -= gradebox_PreviewKeyDown;
            if (cbo.DroppedDown) cbo.Focus();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            //Check to see if Last name and First name is inputed
            if(!string.IsNullOrWhiteSpace(FirstName.Text) && !string.IsNullOrWhiteSpace(LastName.Text))
            {
                FirstName.Text = FirstName.Text.Replace(" ", "");
                LastName.Text = LastName.Text.Replace(" ", "");

                int rows = sheet.UsedRange.Row + sheet.UsedRange.Rows.Count - 1;
                int i;
                for (i = 2; i <= rows; i++)
                {
                    Range bColumn = sheet.Cells[i, 1];
                    string teacherFirstName = bColumn.get_Value(null);
                    if (FirstName.Text.Equals(teacherFirstName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        bColumn = sheet.Cells[i, 2];
                        string teacherLastName = bColumn.get_Value(null);
                        if (LastName.Text.Equals(teacherLastName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            // Fill the information
                            updated_info = true;
                            update_index = i;

                            // Chnage the button to update
                            insertInfo.Text = "Update/Verify Information";

                            string temp;
                            //Email
                            bColumn = sheet.Cells[update_index, 3];
                            temp = bColumn.get_Value(null);
                            email.Text = temp;

                            //School
                            bColumn = sheet.Cells[update_index, 4];
                            temp = bColumn.get_Value(null);
                            schools.Text = temp;

                            //District
                            bColumn = sheet.Cells[update_index, 5];
                            temp = bColumn.get_Value(null);
                            schooldistrict.Text = temp;

                            //City
                            bColumn = sheet.Cells[update_index, 6];
                            temp = bColumn.get_Value(null);
                            citybox.Text = temp;

                            //County
                            bColumn = sheet.Cells[update_index, 7];
                            temp = bColumn.get_Value(null);
                            countybox.Text = temp;

                            //Grade Taught
                            bColumn = sheet.Cells[update_index, 8];
                            temp = bColumn.get_Value(null);
                            gradebox.Text = temp;

                            //Subject Taught
                            bColumn = sheet.Cells[update_index, 9];
                            temp = bColumn.get_Value(null);
                            subjectbox.Text = temp;

                        }
                    }
                }

                if(updated_info == false)
                {
                    MessageBox.Show("Your are not in the DB. Please Enter your information");
                }

            }
            else
            {
                MessageBox.Show("Please Enter the First and Last Name."); 
            }

        }
        private void removeAllFields()
        {
            FirstName.Text = "";
            LastName.Text ="";
            email.Text = "";
            schools.Text ="";
            schooldistrict.Text ="";
            citybox.Text = "";
            countybox.Text = "";
            gradebox.Text= "";
            subjectbox.Text = "";
        }
        private void insertInfo_Click(object sender, EventArgs e)
        {
            //If updated is true update information
            if (!string.IsNullOrWhiteSpace(FirstName.Text)
                && !string.IsNullOrWhiteSpace(LastName.Text)
                && !string.IsNullOrWhiteSpace(email.Text)
                && !string.IsNullOrWhiteSpace(schools.Text)
                && !string.IsNullOrWhiteSpace(schooldistrict.Text)
                && !string.IsNullOrWhiteSpace(citybox.Text)
                && !string.IsNullOrWhiteSpace(countybox.Text)
                && !string.IsNullOrWhiteSpace(gradebox.Text)
                && !string.IsNullOrWhiteSpace(subjectbox.Text))
            {
                if (updated_info)
                {
                    //Re-save the information
                    sheet.Cells[update_index, 3] = email.Text;
                    sheet.Cells[update_index, 4] = schools.Text;
                    sheet.Cells[update_index, 5] = schooldistrict.Text;
                    sheet.Cells[update_index, 6] = citybox.Text;
                    sheet.Cells[update_index, 7] = countybox.Text;
                    sheet.Cells[update_index, 8] = gradebox.Text;
                    sheet.Cells[update_index, 9] = subjectbox.Text;

                    workbook.SaveAs(pathOfTeachersTable, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);

                    updated_info = false;

                }
                else
                {
                    //New entry - All info needs to be filled
                    int new_entry = sheet.UsedRange.Row + sheet.UsedRange.Rows.Count;
                    sheet.Cells[new_entry, 1] = FirstName.Text;
                    sheet.Cells[new_entry, 2] = LastName.Text;
                    sheet.Cells[new_entry, 3] = email.Text;
                    sheet.Cells[new_entry, 4] = schools.Text;
                    sheet.Cells[new_entry, 5] = schooldistrict.Text;
                    sheet.Cells[new_entry, 6] = citybox.Text;
                    sheet.Cells[new_entry, 7] = countybox.Text;
                    sheet.Cells[new_entry, 8] = gradebox.Text;
                    sheet.Cells[new_entry, 9] = subjectbox.Text;

                    workbook.SaveAs(pathOfTeachersTable, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);

                }

                // Add to the Events DB. 
                int new_event_entry = event_sheet.UsedRange.Row + event_sheet.UsedRange.Rows.Count;
                event_sheet.Cells[new_event_entry, 1] = Event_Year;
                event_sheet.Cells[new_event_entry, 2] = Event_Date;
                event_sheet.Cells[new_event_entry, 3] = nameOFEvent;
                event_sheet.Cells[new_event_entry, 4] = FirstName.Text;
                event_sheet.Cells[new_event_entry, 5] = LastName.Text;

                event_workbook.SaveAs(pathOfEventTable, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);

                removeAllFields();
            }
            else
            {
                MessageBox.Show("Enter all Fields to Register.");

            }

        }
    }
}
