
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
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
            this.btnRevice = new System.Windows.Forms.Button();
            this.lbSuccess = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 435);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 45);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "취소하기";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(88, 435);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 45);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "예약하기";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbVaccine
            // 
            this.cbVaccine.FormattingEnabled = true;
            this.cbVaccine.Location = new System.Drawing.Point(186, 174);
            this.cbVaccine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVaccine.Name = "cbVaccine";
            this.cbVaccine.Size = new System.Drawing.Size(218, 28);
            this.cbVaccine.TabIndex = 48;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(186, 215);
            this.dtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(218, 27);
            this.dtDate.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(121, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResidenRegisNum
            // 
            this.tbResidenRegisNum.Location = new System.Drawing.Point(186, 342);
            this.tbResidenRegisNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbResidenRegisNum.Name = "tbResidenRegisNum";
            this.tbResidenRegisNum.Size = new System.Drawing.Size(218, 27);
            this.tbResidenRegisNum.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Resident Regis Num";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(186, 301);
            this.tbPhoneNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(218, 27);
            this.tbPhoneNum.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(69, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Phone Num";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(186, 257);
            this.tbArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(218, 27);
            this.tbArea.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(120, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Area";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(100, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vaccine";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPw
            // 
            this.tbPw.Location = new System.Drawing.Point(187, 129);
            this.tbPw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPw.Name = "tbPw";
            this.tbPw.Size = new System.Drawing.Size(218, 27);
            this.tbPw.TabIndex = 37;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(186, 35);
            this.tbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(218, 27);
            this.tbId.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(130, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "PW";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(113, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(97, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Hospital";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHospital
            // 
            this.lbHospital.AutoSize = true;
            this.lbHospital.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbHospital.Location = new System.Drawing.Point(184, 85);
            this.lbHospital.Name = "lbHospital";
            this.lbHospital.Size = new System.Drawing.Size(17, 17);
            this.lbHospital.TabIndex = 36;
            this.lbHospital.Text = "-";
            // 
            // btnRevice
            // 
            this.btnRevice.Location = new System.Drawing.Point(88, 435);
            this.btnRevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRevice.Name = "btnRevice";
            this.btnRevice.Size = new System.Drawing.Size(119, 45);
            this.btnRevice.TabIndex = 31;
            this.btnRevice.Text = "수정하기";
            this.btnRevice.UseVisualStyleBackColor = true;
            this.btnRevice.Visible = false;
            this.btnRevice.Click += new System.EventHandler(this.btnRevice_Click);
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSuccess.Location = new System.Drawing.Point(184, 389);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(17, 17);
            this.lbSuccess.TabIndex = 49;
            this.lbSuccess.Text = "-";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(73, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 26);
            this.label10.TabIndex = 50;
            this.label10.Text = "접종여부";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 519);
            this.Controls.Add(this.lbSuccess);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.btnRevice);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btnRevice;
        private System.Windows.Forms.Label lbSuccess;
        private System.Windows.Forms.Label label10;
    }
}