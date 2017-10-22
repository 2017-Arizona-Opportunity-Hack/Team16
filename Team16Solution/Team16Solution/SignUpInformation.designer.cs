namespace MainHack
{
    partial class SignUpInformation
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
            this.school_db = new System.Windows.Forms.Button();
            this.teachers_db = new System.Windows.Forms.Button();
            this.event_teacher_db = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Form = new System.Windows.Forms.Button();
            this.EventName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // school_db
            // 
            this.school_db.Location = new System.Drawing.Point(53, 60);
            this.school_db.Name = "school_db";
            this.school_db.Size = new System.Drawing.Size(240, 41);
            this.school_db.TabIndex = 0;
            this.school_db.Text = "Select School DB";
            this.school_db.UseVisualStyleBackColor = true;
            this.school_db.Click += new System.EventHandler(this.school_db_Click);
            // 
            // teachers_db
            // 
            this.teachers_db.Location = new System.Drawing.Point(53, 126);
            this.teachers_db.Name = "teachers_db";
            this.teachers_db.Size = new System.Drawing.Size(240, 41);
            this.teachers_db.TabIndex = 1;
            this.teachers_db.Text = "Select Teachers DB";
            this.teachers_db.UseVisualStyleBackColor = true;
            this.teachers_db.Click += new System.EventHandler(this.teachers_db_Click);
            // 
            // event_teacher_db
            // 
            this.event_teacher_db.Location = new System.Drawing.Point(53, 187);
            this.event_teacher_db.Name = "event_teacher_db";
            this.event_teacher_db.Size = new System.Drawing.Size(240, 46);
            this.event_teacher_db.TabIndex = 2;
            this.event_teacher_db.Text = "Select Event-Teacher DB";
            this.event_teacher_db.UseVisualStyleBackColor = true;
            this.event_teacher_db.Click += new System.EventHandler(this.event_teacher_db_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(550, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2017, 10, 22, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the School DB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the Teacher DB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter the Event-Teacher DB";
            // 
            // Form
            // 
            this.Form.Location = new System.Drawing.Point(53, 302);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(743, 41);
            this.Form.TabIndex = 8;
            this.Form.Text = "Initialize the Form";
            this.Form.UseVisualStyleBackColor = true;
            this.Form.Click += new System.EventHandler(this.Form_Click);
            // 
            // EventName
            // 
            this.EventName.Location = new System.Drawing.Point(339, 261);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(457, 22);
            this.EventName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Event Name";
            // 
            // SignUpInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.Form);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.event_teacher_db);
            this.Controls.Add(this.teachers_db);
            this.Controls.Add(this.school_db);
            this.Name = "SignUpInformation";
            this.Text = "SignUpInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button school_db;
        private System.Windows.Forms.Button teachers_db;
        private System.Windows.Forms.Button event_teacher_db;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Form;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.Label label4;
    }
}