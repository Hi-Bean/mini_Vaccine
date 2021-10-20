
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.병원열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연결하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tbNote = new System.Windows.Forms.TextBox();
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
            this.btnChatt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.webBrowser1.Location = new System.Drawing.Point(12, 18);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(22, 27);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(500, 400);
            this.webBrowser1.TabIndex = 15;
            // 
            // tbNote
            // 
            this.tbNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNote.Location = new System.Drawing.Point(12, 426);
            this.tbNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(500, 139);
            this.tbNote.TabIndex = 17;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(736, 154);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(79, 28);
            this.btnTest.TabIndex = 18;
            this.btnTest.Text = "조회";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(568, 110);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 27);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbHospPhone);
            this.groupBox2.Controls.Add(this.lbHospiName);
            this.groupBox2.Location = new System.Drawing.Point(568, 190);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(230, 129);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "병원 정보";
            // 
            // lbHospPhone
            // 
            this.lbHospPhone.AutoSize = true;
            this.lbHospPhone.Location = new System.Drawing.Point(26, 85);
            this.lbHospPhone.Name = "lbHospPhone";
            this.lbHospPhone.Size = new System.Drawing.Size(109, 20);
            this.lbHospPhone.TabIndex = 0;
            this.lbHospPhone.Text = "병원 전화 번호";
            // 
            // lbHospiName
            // 
            this.lbHospiName.AutoSize = true;
            this.lbHospiName.Location = new System.Drawing.Point(26, 45);
            this.lbHospiName.Name = "lbHospiName";
            this.lbHospiName.Size = new System.Drawing.Size(74, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(566, 327);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(231, 227);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "백신 종류/수량";
            // 
            // lbVaccineM
            // 
            this.lbVaccineM.AutoSize = true;
            this.lbVaccineM.Location = new System.Drawing.Point(140, 178);
            this.lbVaccineM.Name = "lbVaccineM";
            this.lbVaccineM.Size = new System.Drawing.Size(17, 20);
            this.lbVaccineM.TabIndex = 2;
            this.lbVaccineM.Text = "0";
            // 
            // lbVaccineH
            // 
            this.lbVaccineH.AutoSize = true;
            this.lbVaccineH.Location = new System.Drawing.Point(140, 133);
            this.lbVaccineH.Name = "lbVaccineH";
            this.lbVaccineH.Size = new System.Drawing.Size(17, 20);
            this.lbVaccineH.TabIndex = 2;
            this.lbVaccineH.Text = "0";
            // 
            // lbVaccineY
            // 
            this.lbVaccineY.AutoSize = true;
            this.lbVaccineY.Location = new System.Drawing.Point(140, 92);
            this.lbVaccineY.Name = "lbVaccineY";
            this.lbVaccineY.Size = new System.Drawing.Size(17, 20);
            this.lbVaccineY.TabIndex = 2;
            this.lbVaccineY.Text = "0";
            // 
            // lbVaccineA
            // 
            this.lbVaccineA.AutoSize = true;
            this.lbVaccineA.Location = new System.Drawing.Point(140, 52);
            this.lbVaccineA.Name = "lbVaccineA";
            this.lbVaccineA.Size = new System.Drawing.Size(17, 20);
            this.lbVaccineA.TabIndex = 2;
            this.lbVaccineA.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "모더나";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "화이자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "얀센";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(60, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(28, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "AZ";
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(546, 563);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(84, 29);
            this.btnReservation.TabIndex = 19;
            this.btnReservation.Text = "예약";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "<<병원과 날짜를 선택해주세요>>";
            // 
            // cbHospitalName
            // 
            this.cbHospitalName.FormattingEnabled = true;
            this.cbHospitalName.Location = new System.Drawing.Point(568, 65);
            this.cbHospitalName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHospitalName.Name = "cbHospitalName";
            this.cbHospitalName.Size = new System.Drawing.Size(230, 28);
            this.cbHospitalName.TabIndex = 23;
            this.cbHospitalName.SelectedIndexChanged += new System.EventHandler(this.cbHospitalName_SelectedIndexChanged);
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(636, 563);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(84, 29);
            this.btnLookup.TabIndex = 24;
            this.btnLookup.Text = "조회";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(726, 563);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(84, 29);
            this.btnModify.TabIndex = 24;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnChatt
            // 
            this.btnChatt.BackColor = System.Drawing.SystemColors.Control;
            this.btnChatt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChatt.Image = ((System.Drawing.Image)(resources.GetObject("btnChatt.Image")));
            this.btnChatt.Location = new System.Drawing.Point(12, 570);
            this.btnChatt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChatt.Name = "btnChatt";
            this.btnChatt.Size = new System.Drawing.Size(50, 38);
            this.btnChatt.TabIndex = 25;
            this.btnChatt.UseVisualStyleBackColor = false;
            this.btnChatt.Click += new System.EventHandler(this.btnChatt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "※※예약 취소를 원하시는 경우, 상담사 채팅을 이용해주세요!※※";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChatt);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.cbHospitalName);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "백신 예약 프로그램 (ver.1.0.3)";
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
        private System.Windows.Forms.TextBox tbNote;
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
        private System.Windows.Forms.Button btnChatt;
        private System.Windows.Forms.Label label4;
    }
}

