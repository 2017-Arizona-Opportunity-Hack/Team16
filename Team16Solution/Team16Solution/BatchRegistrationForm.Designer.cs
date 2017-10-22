namespace MainHack
{
    partial class BatchRegistrationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_WorkshopTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addEvent = new System.Windows.Forms.Button();
            this.dataGrid_excel = new System.Windows.Forms.DataGridView();
            this.btn_selectEvent = new System.Windows.Forms.Button();
            this.textBox_showEventFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_excel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_WorkshopTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_addEvent);
            this.groupBox1.Controls.Add(this.dataGrid_excel);
            this.groupBox1.Controls.Add(this.btn_selectEvent);
            this.groupBox1.Controls.Add(this.textBox_showEventFilePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1972, 1108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BatchRegistration";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(927, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(310, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Workshop date";
            // 
            // textBox_WorkshopTitle
            // 
            this.textBox_WorkshopTitle.Location = new System.Drawing.Point(251, 50);
            this.textBox_WorkshopTitle.Multiline = true;
            this.textBox_WorkshopTitle.Name = "textBox_WorkshopTitle";
            this.textBox_WorkshopTitle.Size = new System.Drawing.Size(384, 36);
            this.textBox_WorkshopTitle.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Workshop title";
            // 
            // btn_addEvent
            // 
            this.btn_addEvent.Location = new System.Drawing.Point(1651, 1031);
            this.btn_addEvent.Name = "btn_addEvent";
            this.btn_addEvent.Size = new System.Drawing.Size(288, 50);
            this.btn_addEvent.TabIndex = 4;
            this.btn_addEvent.Text = "Add";
            this.btn_addEvent.UseVisualStyleBackColor = true;
            this.btn_addEvent.Click += new System.EventHandler(this.btn_addEvent_Click);
            // 
            // dataGrid_excel
            // 
            this.dataGrid_excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_excel.Location = new System.Drawing.Point(33, 168);
            this.dataGrid_excel.Name = "dataGrid_excel";
            this.dataGrid_excel.RowTemplate.Height = 33;
            this.dataGrid_excel.Size = new System.Drawing.Size(1906, 838);
            this.dataGrid_excel.TabIndex = 3;
            // 
            // btn_selectEvent
            // 
            this.btn_selectEvent.Location = new System.Drawing.Point(1651, 100);
            this.btn_selectEvent.Name = "btn_selectEvent";
            this.btn_selectEvent.Size = new System.Drawing.Size(288, 50);
            this.btn_selectEvent.TabIndex = 2;
            this.btn_selectEvent.Text = "Select";
            this.btn_selectEvent.UseVisualStyleBackColor = true;
            this.btn_selectEvent.Click += new System.EventHandler(this.btn_selectEvent_Click);
            // 
            // textBox_showEventFilePath
            // 
            this.textBox_showEventFilePath.Location = new System.Drawing.Point(685, 114);
            this.textBox_showEventFilePath.Multiline = true;
            this.textBox_showEventFilePath.Name = "textBox_showEventFilePath";
            this.textBox_showEventFilePath.ReadOnly = true;
            this.textBox_showEventFilePath.Size = new System.Drawing.Size(880, 36);
            this.textBox_showEventFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the event registration excel file";
            // 
            // BatchRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1994, 1131);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(2020, 1202);
            this.Name = "BatchRegistrationForm";
            this.Text = "BatchRegistrationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_excel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_selectEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_showEventFilePath;
        private System.Windows.Forms.DataGridView dataGrid_excel;
        private System.Windows.Forms.Button btn_addEvent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_WorkshopTitle;
        private System.Windows.Forms.Label label2;
    }
}

