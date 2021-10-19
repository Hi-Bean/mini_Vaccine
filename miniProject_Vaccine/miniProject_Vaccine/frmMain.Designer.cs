
namespace miniProject_Vaccine
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.병원열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연결하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbHospPhone = new System.Windows.Forms.Label();
            this.lbHospiName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbVaccineM = new System.Windows.Forms.Label();
            this.lbVaccineH = new System.Windows.Forms.Label();
            this.lbVaccineY = new System.Windows.Forms.Label();
            this.lbVaccineA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnReservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHospitalName = new System.Windows.Forms.ComboBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.병원열기ToolStripMenuItem,
            this.연결하기ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // 병원열기ToolStripMenuItem
            // 
            this.병원열기ToolStripMenuItem.Name = "병원열기ToolStripMenuItem";
            this.병원열기ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.병원열기ToolStripMenuItem.Text = "병원열기";
            // 
            // 연결하기ToolStripMenuItem
            // 
            this.연결하기ToolStripMenuItem.Name = "연결하기ToolStripMenuItem";
            this.연결하기ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.연결하기ToolStripMenuItem.Text = "연결하기";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webBrowser1.Location = new System.Drawing.Point(22, 31);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(494, 400);
            this.webBrowser1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(19, 447);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(497, 105);
            this.textBox2.TabIndex = 17;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(719, 135);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(70, 30);
            this.btnTest.TabIndex = 18;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(564, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbHospPhone);
            this.groupBox2.Controls.Add(this.lbHospiName);
            this.groupBox2.Location = new System.Drawing.Point(565, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 97);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "병원 정보";
            // 
            // lbHospPhone
            // 
            this.lbHospPhone.AutoSize = true;
            this.lbHospPhone.Location = new System.Drawing.Point(23, 69);
            this.lbHospPhone.Name = "lbHospPhone";
            this.lbHospPhone.Size = new System.Drawing.Size(107, 15);
            this.lbHospPhone.TabIndex = 0;
            this.lbHospPhone.Text = "병원 전화 번호";
            // 
            // lbHospiName
            // 
            this.lbHospiName.AutoSize = true;
            this.lbHospiName.Location = new System.Drawing.Point(23, 39);
            this.lbHospiName.Name = "lbHospiName";
            this.lbHospiName.Size = new System.Drawing.Size(72, 15);
            this.lbHospiName.TabIndex = 0;
            this.lbHospiName.Text = "병원 이름";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbVaccineM);
            this.groupBox1.Controls.Add(this.lbVaccineH);
            this.groupBox1.Controls.Add(this.lbVaccineY);
            this.groupBox1.Controls.Add(this.lbVaccineA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Location = new System.Drawing.Point(564, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 170);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "백신 종류/수량";
            // 
            // lbVaccineM
            // 
            this.lbVaccineM.AutoSize = true;
            this.lbVaccineM.Location = new System.Drawing.Point(94, 136);
            this.lbVaccineM.Name = "lbVaccineM";
            this.lbVaccineM.Size = new System.Drawing.Size(15, 15);
            this.lbVaccineM.TabIndex = 2;
            this.lbVaccineM.Text = "0";
            // 
            // lbVaccineH
            // 
            this.lbVaccineH.AutoSize = true;
            this.lbVaccineH.Location = new System.Drawing.Point(94, 102);
            this.lbVaccineH.Name = "lbVaccineH";
            this.lbVaccineH.Size = new System.Drawing.Size(15, 15);
            this.lbVaccineH.TabIndex = 2;
            this.lbVaccineH.Text = "0";
            // 
            // lbVaccineY
            // 
            this.lbVaccineY.AutoSize = true;
            this.lbVaccineY.Location = new System.Drawing.Point(94, 71);
            this.lbVaccineY.Name = "lbVaccineY";
            this.lbVaccineY.Size = new System.Drawing.Size(15, 15);
            this.lbVaccineY.TabIndex = 2;
            this.lbVaccineY.Text = "0";
            // 
            // lbVaccineA
            // 
            this.lbVaccineA.AutoSize = true;
            this.lbVaccineA.Location = new System.Drawing.Point(94, 41);
            this.lbVaccineA.Name = "lbVaccineA";
            this.lbVaccineA.Size = new System.Drawing.Size(15, 15);
            this.lbVaccineA.TabIndex = 2;
            this.lbVaccineA.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "모더나";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "화이자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "얀센";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(23, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(25, 15);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "AZ";
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(534, 486);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(78, 28);
            this.btnReservation.TabIndex = 19;
            this.btnReservation.Text = "예약";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "[병원, 날짜 선택]";
            // 
            // cbHospitalName
            // 
            this.cbHospitalName.FormattingEnabled = true;
            this.cbHospitalName.Location = new System.Drawing.Point(564, 57);
            this.cbHospitalName.Name = "cbHospitalName";
            this.cbHospitalName.Size = new System.Drawing.Size(200, 23);
            this.cbHospitalName.TabIndex = 23;
            this.cbHospitalName.SelectedIndexChanged += new System.EventHandler(this.cbHospitalName_SelectedIndexChanged);
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(630, 486);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(75, 28);
            this.btnLookup.TabIndex = 24;
            this.btnLookup.Text = "조회";
            this.btnLookup.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(719, 486);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 28);
            this.btnModify.TabIndex = 24;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 574);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.cbHospitalName);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 병원열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 연결하기ToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbHospPhone;
        private System.Windows.Forms.Label lbHospiName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbVaccineM;
        private System.Windows.Forms.Label lbVaccineH;
        private System.Windows.Forms.Label lbVaccineY;
        private System.Windows.Forms.Label lbVaccineA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnReservation;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHospitalName;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnModify;
    }
}

