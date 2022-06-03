namespace HospitalmanagementSystem
{
    partial class bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bill));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.HMSprintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.line = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.billno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.room_charge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.billdate = new System.Windows.Forms.DateTimePicker();
            this.others = new System.Windows.Forms.TextBox();
            this.labelDoctorFee = new System.Windows.Forms.Label();
            this.labelOthers = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PatientCateogtyLeble = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            // 
            // HMSprintPreviewDialog1
            // 
            this.HMSprintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.HMSprintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.HMSprintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.HMSprintPreviewDialog1.Enabled = true;
            this.HMSprintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("HMSprintPreviewDialog1.Icon")));
            this.HMSprintPreviewDialog1.Name = "printPreviewDialog1";
            this.HMSprintPreviewDialog1.Visible = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = global::HospitalmanagementSystem.Properties.Resources.Hospital_blue_icon;
            this.button4.Location = new System.Drawing.Point(672, 559);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 58);
            this.button4.TabIndex = 14;
            this.button4.Text = "Home";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Image = global::HospitalmanagementSystem.Properties.Resources.Actions_session_exit_icon1;
            this.button6.Location = new System.Drawing.Point(892, 559);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 58);
            this.button6.TabIndex = 16;
            this.button6.Text = "Exit";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(381, 643);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(403, 13);
            this.line.TabIndex = 17;
            this.line.Text = "__________________________________________________________________";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Image = global::HospitalmanagementSystem.Properties.Resources.Actions_view_refresh_icon;
            this.button7.Location = new System.Drawing.Point(568, 559);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 58);
            this.button7.TabIndex = 18;
            this.button7.Text = "Refresh";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::HospitalmanagementSystem.Properties.Resources.add;
            this.button8.Location = new System.Drawing.Point(131, 335);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 42);
            this.button8.TabIndex = 20;
            this.button8.Text = "Save";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(347, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bill No :";
            // 
            // billno
            // 
            this.billno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billno.Location = new System.Drawing.Point(194, 9);
            this.billno.Name = "billno";
            this.billno.ReadOnly = true;
            this.billno.Size = new System.Drawing.Size(147, 26);
            this.billno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "P_ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // pid
            // 
            this.pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid.Location = new System.Drawing.Point(194, 101);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(147, 26);
            this.pid.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Room Charge :";
            // 
            // room_charge
            // 
            this.room_charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_charge.Location = new System.Drawing.Point(194, 193);
            this.room_charge.Name = "room_charge";
            this.room_charge.ReadOnly = true;
            this.room_charge.Size = new System.Drawing.Size(147, 26);
            this.room_charge.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "P_Name :";
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.Location = new System.Drawing.Point(194, 147);
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Size = new System.Drawing.Size(147, 26);
            this.pname.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(102, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Others :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Azure;
            this.label13.Location = new System.Drawing.Point(119, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Total :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(194, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 26);
            this.textBox1.TabIndex = 5;
            // 
            // billdate
            // 
            this.billdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.billdate.Location = new System.Drawing.Point(194, 54);
            this.billdate.Name = "billdate";
            this.billdate.Size = new System.Drawing.Size(147, 26);
            this.billdate.TabIndex = 6;
            // 
            // others
            // 
            this.others.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.others.Location = new System.Drawing.Point(194, 234);
            this.others.Name = "others";
            this.others.ReadOnly = true;
            this.others.Size = new System.Drawing.Size(147, 26);
            this.others.TabIndex = 11;
            this.others.Text = "1000";
            // 
            // labelDoctorFee
            // 
            this.labelDoctorFee.AutoSize = true;
            this.labelDoctorFee.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelDoctorFee.Location = new System.Drawing.Point(197, 497);
            this.labelDoctorFee.Name = "labelDoctorFee";
            this.labelDoctorFee.Size = new System.Drawing.Size(0, 13);
            this.labelDoctorFee.TabIndex = 13;
            // 
            // labelOthers
            // 
            this.labelOthers.AutoSize = true;
            this.labelOthers.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelOthers.Location = new System.Drawing.Point(199, 542);
            this.labelOthers.Name = "labelOthers";
            this.labelOthers.Size = new System.Drawing.Size(0, 13);
            this.labelOthers.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.labelOthers);
            this.panel1.Controls.Add(this.labelDoctorFee);
            this.panel1.Controls.Add(this.others);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.billdate);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.room_charge);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.billno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(18, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 595);
            this.panel1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(194, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(147, 26);
            this.textBox2.TabIndex = 14;
            // 
            // PatientCateogtyLeble
            // 
            this.PatientCateogtyLeble.AutoSize = true;
            this.PatientCateogtyLeble.BackColor = System.Drawing.Color.SteelBlue;
            this.PatientCateogtyLeble.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientCateogtyLeble.Location = new System.Drawing.Point(17, 6);
            this.PatientCateogtyLeble.Name = "PatientCateogtyLeble";
            this.PatientCateogtyLeble.Size = new System.Drawing.Size(142, 26);
            this.PatientCateogtyLeble.TabIndex = 21;
            this.PatientCateogtyLeble.Text = "Patient\'s Bill";
            // 
            // bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1065, 629);
            this.Controls.Add(this.PatientCateogtyLeble);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.line);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bill";
            this.Load += new System.EventHandler(this.bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog HMSprintPreviewDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox billno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox room_charge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker billdate;
        private System.Windows.Forms.TextBox others;
        private System.Windows.Forms.Label labelDoctorFee;
        private System.Windows.Forms.Label labelOthers;
        public System.Windows.Forms.Label PatientCateogtyLeble;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
    }
}