namespace DTIWinformProject
{
    partial class FrmSAURegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAURegister));
            this.label1 = new System.Windows.Forms.Label();
            this.mcRegis = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLevelRegis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbSubjectRegis = new System.Windows.Forms.ListBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.lsbSubjectSelectedRegis = new System.Windows.Forms.ListBox();
            this.tbNameRegis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNoRegis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdNormalRegis = new System.Windows.Forms.RadioButton();
            this.rdFundRegis = new System.Windows.Forms.RadioButton();
            this.btSelectImageRegis = new System.Windows.Forms.Button();
            this.cbConfirmRegis = new System.Windows.Forms.CheckBox();
            this.pbImageRegis = new System.Windows.Forms.PictureBox();
            this.btRegis = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.btSelectSub = new System.Windows.Forms.Button();
            this.btSelectAllSub = new System.Windows.Forms.Button();
            this.btUnSelectSub = new System.Windows.Forms.Button();
            this.btUnSelectAllSub = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageRegis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(981, 106);
            this.label1.TabIndex = 21;
            this.label1.Text = "ลงทะเบียนเรียน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mcRegis
            // 
            this.mcRegis.Location = new System.Drawing.Point(66, 225);
            this.mcRegis.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcRegis.Name = "mcRegis";
            this.mcRegis.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(68, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "วันที่ลงทะเบียน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(62, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "ระดับชั้น";
            // 
            // cbbLevelRegis
            // 
            this.cbbLevelRegis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevelRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbbLevelRegis.FormattingEnabled = true;
            this.cbbLevelRegis.Items.AddRange(new object[] {
            "ชันมัธยมศึกษาปีที่ 1",
            "ชันมัธยมศึกษาปีที่ 2",
            "ชันมัธยมศึกษาปีที่ 3",
            "ชันมัธยมศึกษาปีที่ 4",
            "ชันมัธยมศึกษาปีที่ 5",
            "ชันมัธยมศึกษาปีที่ 6"});
            this.cbbLevelRegis.Location = new System.Drawing.Point(66, 465);
            this.cbbLevelRegis.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLevelRegis.Name = "cbbLevelRegis";
            this.cbbLevelRegis.Size = new System.Drawing.Size(301, 28);
            this.cbbLevelRegis.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(62, 522);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "รายวิชาที่ลงทะเบียน";
            // 
            // lsbSubjectRegis
            // 
            this.lsbSubjectRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lsbSubjectRegis.FormattingEnabled = true;
            this.lsbSubjectRegis.ItemHeight = 24;
            this.lsbSubjectRegis.Items.AddRange(new object[] {
            "ภาษาไทย",
            "ภาษาอังกฤษ",
            "ภาษาญี่ปุ่น",
            "ภาษาจีน",
            "สังคมศึกษา",
            "คณิตศาสตร์",
            "พลศึกษา",
            "ประวัติศาสตร์",
            "คอมพิวเตอร์เบื้องต้น",
            "บัญชีเบื้องต้น",
            "วิทยาศาสตร์"});
            this.lsbSubjectRegis.Location = new System.Drawing.Point(66, 548);
            this.lsbSubjectRegis.Margin = new System.Windows.Forms.Padding(4);
            this.lsbSubjectRegis.Name = "lsbSubjectRegis";
            this.lsbSubjectRegis.Size = new System.Drawing.Size(295, 220);
            this.lsbSubjectRegis.TabIndex = 26;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip2.Location = new System.Drawing.Point(0, 800);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1399, 25);
            this.toolStrip2.TabIndex = 34;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // tslbUsername
            // 
            this.tslbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(55, 22);
            this.tslbUsername.Text = "name?";
            this.tslbUsername.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(76, 22);
            this.tslbDateTime.Text = "datetime?";
            this.tslbDateTime.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // lsbSubjectSelectedRegis
            // 
            this.lsbSubjectSelectedRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lsbSubjectSelectedRegis.FormattingEnabled = true;
            this.lsbSubjectSelectedRegis.ItemHeight = 24;
            this.lsbSubjectSelectedRegis.Items.AddRange(new object[] {
            "IsbStuSubjectSelect"});
            this.lsbSubjectSelectedRegis.Location = new System.Drawing.Point(519, 548);
            this.lsbSubjectSelectedRegis.Margin = new System.Windows.Forms.Padding(4);
            this.lsbSubjectSelectedRegis.Name = "lsbSubjectSelectedRegis";
            this.lsbSubjectSelectedRegis.Size = new System.Drawing.Size(295, 220);
            this.lsbSubjectSelectedRegis.TabIndex = 26;
            // 
            // tbNameRegis
            // 
            this.tbNameRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbNameRegis.Location = new System.Drawing.Point(519, 309);
            this.tbNameRegis.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameRegis.Name = "tbNameRegis";
            this.tbNameRegis.Size = new System.Drawing.Size(295, 26);
            this.tbNameRegis.TabIndex = 36;
            this.tbNameRegis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoRegis_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(515, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 28);
            this.label5.TabIndex = 35;
            this.label5.Text = "ชื่อ-สกุล";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(515, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "เลขประจำตัวนักเรียน";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNoRegis
            // 
            this.tbNoRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbNoRegis.Location = new System.Drawing.Point(519, 225);
            this.tbNoRegis.Margin = new System.Windows.Forms.Padding(4);
            this.tbNoRegis.Name = "tbNoRegis";
            this.tbNoRegis.Size = new System.Drawing.Size(295, 26);
            this.tbNoRegis.TabIndex = 36;
            this.tbNoRegis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoRegis_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(515, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 28);
            this.label7.TabIndex = 35;
            this.label7.Text = "ประเภทนักเรียน";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdNormalRegis
            // 
            this.rdNormalRegis.AutoSize = true;
            this.rdNormalRegis.Checked = true;
            this.rdNormalRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdNormalRegis.Location = new System.Drawing.Point(519, 388);
            this.rdNormalRegis.Margin = new System.Windows.Forms.Padding(4);
            this.rdNormalRegis.Name = "rdNormalRegis";
            this.rdNormalRegis.Size = new System.Drawing.Size(60, 24);
            this.rdNormalRegis.TabIndex = 37;
            this.rdNormalRegis.TabStop = true;
            this.rdNormalRegis.Tag = "1";
            this.rdNormalRegis.Text = "ปกติ";
            this.rdNormalRegis.UseVisualStyleBackColor = true;
            // 
            // rdFundRegis
            // 
            this.rdFundRegis.AutoSize = true;
            this.rdFundRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdFundRegis.Location = new System.Drawing.Point(636, 388);
            this.rdFundRegis.Margin = new System.Windows.Forms.Padding(4);
            this.rdFundRegis.Name = "rdFundRegis";
            this.rdFundRegis.Size = new System.Drawing.Size(87, 24);
            this.rdFundRegis.TabIndex = 37;
            this.rdFundRegis.Tag = "1";
            this.rdFundRegis.Text = "กองทุนฯ";
            this.rdFundRegis.UseVisualStyleBackColor = true;
            // 
            // btSelectImageRegis
            // 
            this.btSelectImageRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSelectImageRegis.Location = new System.Drawing.Point(1272, 516);
            this.btSelectImageRegis.Margin = new System.Windows.Forms.Padding(4);
            this.btSelectImageRegis.Name = "btSelectImageRegis";
            this.btSelectImageRegis.Size = new System.Drawing.Size(72, 28);
            this.btSelectImageRegis.TabIndex = 39;
            this.btSelectImageRegis.Text = "...";
            this.btSelectImageRegis.UseVisualStyleBackColor = true;
            this.btSelectImageRegis.Click += new System.EventHandler(this.btSelectImageRegis_Click);
            // 
            // cbConfirmRegis
            // 
            this.cbConfirmRegis.AutoSize = true;
            this.cbConfirmRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbConfirmRegis.Location = new System.Drawing.Point(878, 578);
            this.cbConfirmRegis.Margin = new System.Windows.Forms.Padding(4);
            this.cbConfirmRegis.Name = "cbConfirmRegis";
            this.cbConfirmRegis.Size = new System.Drawing.Size(224, 33);
            this.cbConfirmRegis.TabIndex = 40;
            this.cbConfirmRegis.Text = "ยืนยันการลงทะเบียน";
            this.cbConfirmRegis.UseVisualStyleBackColor = true;
            // 
            // pbImageRegis
            // 
            this.pbImageRegis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageRegis.Location = new System.Drawing.Point(878, 143);
            this.pbImageRegis.Margin = new System.Windows.Forms.Padding(4);
            this.pbImageRegis.Name = "pbImageRegis";
            this.pbImageRegis.Size = new System.Drawing.Size(369, 401);
            this.pbImageRegis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageRegis.TabIndex = 38;
            this.pbImageRegis.TabStop = false;
            // 
            // btRegis
            // 
            this.btRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegis.Image = global::DTIWinformProject.Properties.Resources.add;
            this.btRegis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRegis.Location = new System.Drawing.Point(1198, 578);
            this.btRegis.Margin = new System.Windows.Forms.Padding(4);
            this.btRegis.Name = "btRegis";
            this.btRegis.Size = new System.Drawing.Size(146, 46);
            this.btRegis.TabIndex = 22;
            this.btRegis.Text = "ลงทะเบียน";
            this.btRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRegis.UseVisualStyleBackColor = true;
            this.btRegis.Click += new System.EventHandler(this.btRegis_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.Location = new System.Drawing.Point(878, 631);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(466, 60);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Image = global::DTIWinformProject.Properties.Resources.exit3;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.Location = new System.Drawing.Point(878, 708);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(466, 60);
            this.btExit.TabIndex = 22;
            this.btExit.Text = "ปิดโปรแกรม";
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // btMainMenu
            // 
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.Location = new System.Drawing.Point(1087, 26);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(257, 106);
            this.btMainMenu.TabIndex = 41;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // btSelectSub
            // 
            this.btSelectSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSelectSub.ForeColor = System.Drawing.Color.Green;
            this.btSelectSub.Location = new System.Drawing.Point(392, 548);
            this.btSelectSub.Margin = new System.Windows.Forms.Padding(4);
            this.btSelectSub.Name = "btSelectSub";
            this.btSelectSub.Size = new System.Drawing.Size(100, 42);
            this.btSelectSub.TabIndex = 42;
            this.btSelectSub.Text = ">";
            this.btSelectSub.UseVisualStyleBackColor = true;
            this.btSelectSub.Click += new System.EventHandler(this.btSelectSub_Click);
            // 
            // btSelectAllSub
            // 
            this.btSelectAllSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSelectAllSub.ForeColor = System.Drawing.Color.Green;
            this.btSelectAllSub.Location = new System.Drawing.Point(392, 609);
            this.btSelectAllSub.Margin = new System.Windows.Forms.Padding(4);
            this.btSelectAllSub.Name = "btSelectAllSub";
            this.btSelectAllSub.Size = new System.Drawing.Size(100, 42);
            this.btSelectAllSub.TabIndex = 42;
            this.btSelectAllSub.Text = ">>";
            this.btSelectAllSub.UseVisualStyleBackColor = true;
            this.btSelectAllSub.Click += new System.EventHandler(this.btSelectAllSub_Click);
            // 
            // btUnSelectSub
            // 
            this.btUnSelectSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btUnSelectSub.ForeColor = System.Drawing.Color.Red;
            this.btUnSelectSub.Location = new System.Drawing.Point(392, 671);
            this.btUnSelectSub.Margin = new System.Windows.Forms.Padding(4);
            this.btUnSelectSub.Name = "btUnSelectSub";
            this.btUnSelectSub.Size = new System.Drawing.Size(100, 42);
            this.btUnSelectSub.TabIndex = 42;
            this.btUnSelectSub.Text = "<";
            this.btUnSelectSub.UseVisualStyleBackColor = true;
            this.btUnSelectSub.Click += new System.EventHandler(this.btUnSelectSub_Click);
            // 
            // btUnSelectAllSub
            // 
            this.btUnSelectAllSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btUnSelectAllSub.ForeColor = System.Drawing.Color.Red;
            this.btUnSelectAllSub.Location = new System.Drawing.Point(392, 726);
            this.btUnSelectAllSub.Margin = new System.Windows.Forms.Padding(4);
            this.btUnSelectAllSub.Name = "btUnSelectAllSub";
            this.btUnSelectAllSub.Size = new System.Drawing.Size(100, 42);
            this.btUnSelectAllSub.TabIndex = 42;
            this.btUnSelectAllSub.Text = "<<";
            this.btUnSelectAllSub.UseVisualStyleBackColor = true;
            this.btUnSelectAllSub.Click += new System.EventHandler(this.btUnSelectAllSub_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmSAURegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 825);
            this.Controls.Add(this.btUnSelectAllSub);
            this.Controls.Add(this.btUnSelectSub);
            this.Controls.Add(this.btSelectAllSub);
            this.Controls.Add(this.btSelectSub);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.cbConfirmRegis);
            this.Controls.Add(this.pbImageRegis);
            this.Controls.Add(this.btSelectImageRegis);
            this.Controls.Add(this.rdFundRegis);
            this.Controls.Add(this.rdNormalRegis);
            this.Controls.Add(this.tbNoRegis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNameRegis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.lsbSubjectSelectedRegis);
            this.Controls.Add(this.lsbSubjectRegis);
            this.Controls.Add(this.cbbLevelRegis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcRegis);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btRegis);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSAURegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ลงทะเบียนเรียน - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmSAURegister_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageRegis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcRegis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLevelRegis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbSubjectRegis;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.ListBox lsbSubjectSelectedRegis;
        private System.Windows.Forms.TextBox tbNameRegis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNoRegis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdNormalRegis;
        private System.Windows.Forms.RadioButton rdFundRegis;
        private System.Windows.Forms.PictureBox pbImageRegis;
        private System.Windows.Forms.Button btSelectImageRegis;
        private System.Windows.Forms.CheckBox cbConfirmRegis;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Button btSelectSub;
        private System.Windows.Forms.Button btSelectAllSub;
        private System.Windows.Forms.Button btUnSelectSub;
        private System.Windows.Forms.Button btUnSelectAllSub;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}