namespace MainHack
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gradebox = new System.Windows.Forms.ComboBox();
            this.subjectbox = new System.Windows.Forms.ComboBox();
            this.schools = new System.Windows.Forms.ComboBox();
            this.countybox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.schooldistrict = new System.Windows.Forms.TextBox();
            this.citybox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fillbutton = new System.Windows.Forms.Button();
            this.insertInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            resources.ApplyResources(this.FirstName, "FirstName");
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            resources.ApplyResources(this.LastName, "LastName");
            this.LastName.Name = "LastName";
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.Name = "email";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // gradebox
            // 
            this.gradebox.FormattingEnabled = true;
            resources.ApplyResources(this.gradebox, "gradebox");
            this.gradebox.Name = "gradebox";
            // 
            // subjectbox
            // 
            this.subjectbox.FormattingEnabled = true;
            resources.ApplyResources(this.subjectbox, "subjectbox");
            this.subjectbox.Name = "subjectbox";
            // 
            // schools
            // 
            this.schools.AllowDrop = true;
            this.schools.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.schools.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.schools.FormattingEnabled = true;
            resources.ApplyResources(this.schools, "schools");
            this.schools.Name = "schools";
            // 
            // countybox
            // 
            this.countybox.FormattingEnabled = true;
            resources.ApplyResources(this.countybox, "countybox");
            this.countybox.Name = "countybox";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // schooldistrict
            // 
            resources.ApplyResources(this.schooldistrict, "schooldistrict");
            this.schooldistrict.Name = "schooldistrict";
            // 
            // citybox
            // 
            resources.ApplyResources(this.citybox, "citybox");
            this.citybox.Name = "citybox";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // fillbutton
            // 
            resources.ApplyResources(this.fillbutton, "fillbutton");
            this.fillbutton.Name = "fillbutton";
            this.fillbutton.UseVisualStyleBackColor = true;
            this.fillbutton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // insertInfo
            // 
            resources.ApplyResources(this.insertInfo, "insertInfo");
            this.insertInfo.Name = "insertInfo";
            this.insertInfo.UseVisualStyleBackColor = true;
            this.insertInfo.Click += new System.EventHandler(this.insertInfo_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.insertInfo);
            this.Controls.Add(this.fillbutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.citybox);
            this.Controls.Add(this.schooldistrict);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.countybox);
            this.Controls.Add(this.schools);
            this.Controls.Add(this.subjectbox);
            this.Controls.Add(this.gradebox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox gradebox;
        private System.Windows.Forms.ComboBox subjectbox;
        private System.Windows.Forms.ComboBox schools;
        private System.Windows.Forms.ComboBox countybox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox schooldistrict;
        private System.Windows.Forms.TextBox citybox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button fillbutton;
        private System.Windows.Forms.Button insertInfo;
    }
}