
namespace miniProject_Vaccine
{
    partial class frmAppointment
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbVaccine = new System.Windows.Forms.ComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbResidenRegisNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbHospital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(202, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 34);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "취소하기";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(78, 326);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 34);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "예약하기";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbVaccine
            // 
            this.cbVaccine.FormattingEnabled = true;
            this.cbVaccine.Location = new System.Drawing.Point(167, 144);
            this.cbVaccine.Name = "cbVaccine";
            this.cbVaccine.Size = new System.Drawing.Size(194, 23);
            this.cbVaccine.TabIndex = 48;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(167, 175);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(194, 25);
            this.dtDate.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Date";
            // 
            // tbResidenRegisNum
            // 
            this.tbResidenRegisNum.Location = new System.Drawing.Point(167, 270);
            this.tbResidenRegisNum.Name = "tbResidenRegisNum";
            this.tbResidenRegisNum.Size = new System.Drawing.Size(194, 25);
            this.tbResidenRegisNum.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Resident Regis Num";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(167, 239);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(194, 25);
            this.tbPhoneNum.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Phone Num";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(167, 206);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(194, 25);
            this.tbArea.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vaccine";
            // 
            // tbPw
            // 
            this.tbPw.Location = new System.Drawing.Point(168, 110);
            this.tbPw.Name = "tbPw";
            this.tbPw.Size = new System.Drawing.Size(194, 25);
            this.tbPw.TabIndex = 37;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(167, 40);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(194, 25);
            this.tbId.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "PW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Hospital";
            // 
            // lbHospital
            // 
            this.lbHospital.AutoSize = true;
            this.lbHospital.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbHospital.Location = new System.Drawing.Point(165, 77);
            this.lbHospital.Name = "lbHospital";
            this.lbHospital.Size = new System.Drawing.Size(17, 17);
            this.lbHospital.TabIndex = 36;
            this.lbHospital.Text = "-";
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 389);
            this.Controls.Add(this.cbVaccine);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbResidenRegisNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPhoneNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPw);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbHospital);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppointment";
            this.Text = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.ComboBox cbVaccine;
        public System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbResidenRegisNum;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbPw;
        public System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbHospital;
    }
}