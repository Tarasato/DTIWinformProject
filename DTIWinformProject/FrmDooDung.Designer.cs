namespace DTIWinformProject
{
    partial class FrmDooDung
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gb1 = new System.Windows.Forms.GroupBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIDcard = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btDooDung = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbBMI = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.mtbIDcard = new System.Windows.Forms.MaskedTextBox();
            this.Gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 86);
            this.label1.TabIndex = 21;
            this.label1.Text = "ดูดวงแม่นๆ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gb1
            // 
            this.Gb1.Controls.Add(this.mtbIDcard);
            this.Gb1.Controls.Add(this.nudHeight);
            this.Gb1.Controls.Add(this.nudWeight);
            this.Gb1.Controls.Add(this.dtpBirthDate);
            this.Gb1.Controls.Add(this.label6);
            this.Gb1.Controls.Add(this.tbFullname);
            this.Gb1.Controls.Add(this.label20);
            this.Gb1.Controls.Add(this.label7);
            this.Gb1.Controls.Add(this.label5);
            this.Gb1.Controls.Add(this.label4);
            this.Gb1.Controls.Add(this.label3);
            this.Gb1.Controls.Add(this.label2);
            this.Gb1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Gb1.Location = new System.Drawing.Point(90, 158);
            this.Gb1.Name = "Gb1";
            this.Gb1.Size = new System.Drawing.Size(685, 283);
            this.Gb1.TabIndex = 23;
            this.Gb1.TabStop = false;
            this.Gb1.Text = "ข้อมูลส่วนตัว";
            // 
            // nudHeight
            // 
            this.nudHeight.DecimalPlaces = 2;
            this.nudHeight.Location = new System.Drawing.Point(99, 226);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 26);
            this.nudHeight.TabIndex = 36;
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.Location = new System.Drawing.Point(99, 180);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(120, 26);
            this.nudWeight.TabIndex = 36;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "                  dddd, MMMM d, yyyy";
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(99, 132);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(561, 29);
            this.dtpBirthDate.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "ส่วนสูง";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(99, 83);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(561, 26);
            this.tbFullname.TabIndex = 1;
            this.tbFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFullname_KeyPress);
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(234, 230);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 23);
            this.label20.TabIndex = 0;
            this.label20.Text = "เซนติเมตร";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(234, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "กิโลกรัม";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "นํ้าหนัก";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "ว/ด/ป เกิด";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "ชื่อ-สกุล";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Card";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIDcard
            // 
            this.lbIDcard.ForeColor = System.Drawing.Color.Green;
            this.lbIDcard.Location = new System.Drawing.Point(102, 29);
            this.lbIDcard.Name = "lbIDcard";
            this.lbIDcard.Size = new System.Drawing.Size(192, 23);
            this.lbIDcard.TabIndex = 0;
            this.lbIDcard.Text = "XXXXXXXXXX";
            this.lbIDcard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbIDcard.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbShowResult);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbBMI);
            this.groupBox1.Controls.Add(this.lbHeight);
            this.groupBox1.Controls.Add(this.lbWeight);
            this.groupBox1.Controls.Add(this.lbAge);
            this.groupBox1.Controls.Add(this.lbBirthDate);
            this.groupBox1.Controls.Add(this.lbFullname);
            this.groupBox1.Controls.Add(this.lbIDcard);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(799, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 487);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ผลดวงของคุณ";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "อายุ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID Card";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "ชื่อ-สกุล";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "ส่วนสูง";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHeight
            // 
            this.lbHeight.ForeColor = System.Drawing.Color.Green;
            this.lbHeight.Location = new System.Drawing.Point(102, 271);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(129, 23);
            this.lbHeight.TabIndex = 0;
            this.lbHeight.Text = "XXXXXXXXXX";
            this.lbHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeight.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbWeight
            // 
            this.lbWeight.ForeColor = System.Drawing.Color.Green;
            this.lbWeight.Location = new System.Drawing.Point(102, 223);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(129, 23);
            this.lbWeight.TabIndex = 0;
            this.lbWeight.Text = "XXXXXXXXXX";
            this.lbWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWeight.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbAge
            // 
            this.lbAge.ForeColor = System.Drawing.Color.Green;
            this.lbAge.Location = new System.Drawing.Point(102, 174);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(192, 23);
            this.lbAge.TabIndex = 0;
            this.lbAge.Text = "XXXXXXXXXX";
            this.lbAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAge.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.ForeColor = System.Drawing.Color.Green;
            this.lbBirthDate.Location = new System.Drawing.Point(102, 129);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(259, 23);
            this.lbBirthDate.TabIndex = 0;
            this.lbBirthDate.Text = "XXXXXXXXXX";
            this.lbBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBirthDate.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbFullname
            // 
            this.lbFullname.ForeColor = System.Drawing.Color.Green;
            this.lbFullname.Location = new System.Drawing.Point(102, 77);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(129, 23);
            this.lbFullname.TabIndex = 0;
            this.lbFullname.Text = "XXXXXXXXXX";
            this.lbFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbFullname.Click += new System.EventHandler(this.label8_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "นํ้าหนัก";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "ว/ด/ป เกิด";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 657);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1178, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // tslbUsername
            // 
            this.tslbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(43, 22);
            this.tslbUsername.Text = "name?";
            this.tslbUsername.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(59, 22);
            this.tslbDateTime.Text = "datetime?";
            this.tslbDateTime.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(417, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 190);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button6.Location = new System.Drawing.Point(276, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::DTIWinformProject.Properties.Resources.marvel1;
            this.pictureBox1.Image = global::DTIWinformProject.Properties.Resources.marvel1;
            this.pictureBox1.InitialImage = global::DTIWinformProject.Properties.Resources.marvel1;
            this.pictureBox1.Location = new System.Drawing.Point(108, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 139);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btExit.Image = global::DTIWinformProject.Properties.Resources.exit31;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.Location = new System.Drawing.Point(90, 587);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(219, 56);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "จบโปรแกรม";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDooDung
            // 
            this.btDooDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btDooDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDooDung.Image = global::DTIWinformProject.Properties.Resources.find1;
            this.btDooDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDooDung.Location = new System.Drawing.Point(90, 520);
            this.btDooDung.Name = "btDooDung";
            this.btDooDung.Size = new System.Drawing.Size(219, 61);
            this.btDooDung.TabIndex = 1;
            this.btDooDung.Text = "ดูดวง";
            this.btDooDung.UseVisualStyleBackColor = true;
            this.btDooDung.Click += new System.EventHandler(this.btDooDung_Click);
            // 
            // btNew
            // 
            this.btNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNew.Image = global::DTIWinformProject.Properties.Resources.new1;
            this.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNew.Location = new System.Drawing.Point(90, 453);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(219, 61);
            this.btNew.TabIndex = 1;
            this.btNew.Text = "ใหม่";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btMainMenu
            // 
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.Location = new System.Drawing.Point(942, 34);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(224, 86);
            this.btMainMenu.TabIndex = 22;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbBMI
            // 
            this.lbBMI.ForeColor = System.Drawing.Color.Green;
            this.lbBMI.Location = new System.Drawing.Point(102, 314);
            this.lbBMI.Name = "lbBMI";
            this.lbBMI.Size = new System.Drawing.Size(129, 23);
            this.lbBMI.TabIndex = 0;
            this.lbBMI.Text = "XXXXXXXXXX";
            this.lbBMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBMI.Click += new System.EventHandler(this.label8_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 314);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "BMI";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbShowResult
            // 
            this.lbShowResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShowResult.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbShowResult.Location = new System.Drawing.Point(10, 353);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(351, 123);
            this.lbShowResult.TabIndex = 1;
            this.lbShowResult.Text = "ผลดวง";
            this.lbShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbIDcard
            // 
            this.mtbIDcard.Location = new System.Drawing.Point(99, 32);
            this.mtbIDcard.Mask = "0-0000-00000-00-0";
            this.mtbIDcard.Name = "mtbIDcard";
            this.mtbIDcard.Size = new System.Drawing.Size(176, 26);
            this.mtbIDcard.TabIndex = 27;
            this.mtbIDcard.Click += new System.EventHandler(this.mtbIDcard_Click);
            // 
            // FrmDooDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDooDung);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gb1);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDooDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ดูดวงแม่นๆ - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmDooDung_Load);
            this.Gb1.ResumeLayout(false);
            this.Gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbIDcard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDooDung;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbBMI;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.MaskedTextBox mtbIDcard;
    }
}