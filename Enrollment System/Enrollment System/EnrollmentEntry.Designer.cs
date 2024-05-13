namespace Enrollment_System
{
    partial class EnrollmentEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumberlabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IDnumberTextBox = new System.Windows.Forms.TextBox();
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.EDPcodeLabel = new System.Windows.Forms.Label();
            this.EDPcodeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EDPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            // 
            // IDnumberlabel
            // 
            this.IDnumberlabel.AutoSize = true;
            this.IDnumberlabel.Location = new System.Drawing.Point(105, 118);
            this.IDnumberlabel.Name = "IDnumberlabel";
            this.IDnumberlabel.Size = new System.Drawing.Size(61, 13);
            this.IDnumberlabel.TabIndex = 1;
            this.IDnumberlabel.Text = "ID Number:";
            this.IDnumberlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(105, 159);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(43, 13);
            this.CourseLabel.TabIndex = 2;
            this.CourseLabel.Text = "Course:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enrollment Entry Form";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(428, 118);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(428, 156);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(32, 13);
            this.YearLabel.TabIndex = 5;
            this.YearLabel.Text = "Year:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(79, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(601, 124);
            this.label10.TabIndex = 9;
            // 
            // IDnumberTextBox
            // 
            this.IDnumberTextBox.Location = new System.Drawing.Point(172, 118);
            this.IDnumberTextBox.Name = "IDnumberTextBox";
            this.IDnumberTextBox.Size = new System.Drawing.Size(148, 20);
            this.IDnumberTextBox.TabIndex = 10;
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Location = new System.Drawing.Point(172, 156);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(148, 20);
            this.CourseTextBox.TabIndex = 11;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(472, 115);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(158, 20);
            this.NameTextBox.TabIndex = 12;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(472, 156);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(158, 20);
            this.YearTextBox.TabIndex = 13;
            // 
            // EDPcodeLabel
            // 
            this.EDPcodeLabel.AutoSize = true;
            this.EDPcodeLabel.Location = new System.Drawing.Point(76, 224);
            this.EDPcodeLabel.Name = "EDPcodeLabel";
            this.EDPcodeLabel.Size = new System.Drawing.Size(60, 13);
            this.EDPcodeLabel.TabIndex = 14;
            this.EDPcodeLabel.Text = "EDP Code:";
            // 
            // EDPcodeTextBox
            // 
            this.EDPcodeTextBox.Location = new System.Drawing.Point(142, 221);
            this.EDPcodeTextBox.Name = "EDPcodeTextBox";
            this.EDPcodeTextBox.Size = new System.Drawing.Size(148, 20);
            this.EDPcodeTextBox.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDPCode,
            this.SubjectCode,
            this.StartTime,
            this.EndTime,
            this.Days,
            this.Room,
            this.Units});
            this.dataGridView1.Location = new System.Drawing.Point(37, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EDPCode
            // 
            this.EDPCode.HeaderText = "EDP Code";
            this.EDPCode.Name = "EDPCode";
            // 
            // SubjectCode
            // 
            this.SubjectCode.HeaderText = "Subject Code";
            this.SubjectCode.Name = "SubjectCode";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            // 
            // Days
            // 
            this.Days.HeaderText = "Days";
            this.Days.Name = "Days";
            // 
            // Room
            // 
            this.Room.HeaderText = "Room";
            this.Room.Name = "Room";
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Units:0";
            // 
            // EnrollmentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EDPcodeTextBox);
            this.Controls.Add(this.EDPcodeLabel);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.IDnumberTextBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.IDnumberlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "EnrollmentEntry";
            this.Text = "EnrollmentEntry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDnumberlabel;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IDnumberTextBox;
        private System.Windows.Forms.TextBox CourseTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label EDPcodeLabel;
        private System.Windows.Forms.TextBox EDPcodeTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDPCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}