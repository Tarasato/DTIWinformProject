namespace DTIWinformProject
{
    partial class FrmShapeArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShapeArea));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btCalcel = new System.Windows.Forms.Button();
            this.btCircleCal = new System.Windows.Forms.Button();
            this.rdCircleRound = new System.Windows.Forms.RadioButton();
            this.rdCircleArea = new System.Windows.Forms.RadioButton();
            this.lbCircleShow = new System.Windows.Forms.Label();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btRectCancel = new System.Windows.Forms.Button();
            this.btRectCal = new System.Windows.Forms.Button();
            this.rdRectRound = new System.Windows.Forms.RadioButton();
            this.rdRectArea = new System.Windows.Forms.RadioButton();
            this.lbRectShow = new System.Windows.Forms.Label();
            this.tbRectHeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btTriCancel = new System.Windows.Forms.Button();
            this.btTriCal = new System.Windows.Forms.Button();
            this.rdTriRound = new System.Windows.Forms.RadioButton();
            this.rdTriArea = new System.Windows.Forms.RadioButton();
            this.lbTriShow = new System.Windows.Forms.Label();
            this.tbSideAngle = new System.Windows.Forms.TextBox();
            this.tbTriHeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip2.Location = new System.Drawing.Point(0, 560);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1153, 25);
            this.toolStrip2.TabIndex = 29;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
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
            // btMainMenu
            // 
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.Location = new System.Drawing.Point(845, 39);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(224, 86);
            this.btMainMenu.TabIndex = 31;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(85, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 86);
            this.label1.TabIndex = 30;
            this.label1.Text = "คำนวณรูปทรง";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabControl1.Location = new System.Drawing.Point(91, 175);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(978, 358);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btCalcel);
            this.tabPage1.Controls.Add(this.btCircleCal);
            this.tabPage1.Controls.Add(this.rdCircleRound);
            this.tabPage1.Controls.Add(this.rdCircleArea);
            this.tabPage1.Controls.Add(this.lbCircleShow);
            this.tabPage1.Controls.Add(this.tbRadius);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วงกลม";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btCalcel
            // 
            this.btCalcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcel.Image = global::DTIWinformProject.Properties.Resources.cancel1;
            this.btCalcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCalcel.Location = new System.Drawing.Point(796, 165);
            this.btCalcel.Name = "btCalcel";
            this.btCalcel.Size = new System.Drawing.Size(152, 86);
            this.btCalcel.TabIndex = 31;
            this.btCalcel.Text = "ยกเลิก";
            this.btCalcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCalcel.UseVisualStyleBackColor = true;
            this.btCalcel.Click += new System.EventHandler(this.btCalcel_Click);
            // 
            // btCircleCal
            // 
            this.btCircleCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCircleCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btCircleCal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCircleCal.Location = new System.Drawing.Point(796, 73);
            this.btCircleCal.Name = "btCircleCal";
            this.btCircleCal.Size = new System.Drawing.Size(152, 86);
            this.btCircleCal.TabIndex = 32;
            this.btCircleCal.Text = "คำนวณ";
            this.btCircleCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCircleCal.UseVisualStyleBackColor = true;
            this.btCircleCal.Click += new System.EventHandler(this.btCircleCal_Click);
            // 
            // rdCircleRound
            // 
            this.rdCircleRound.AutoSize = true;
            this.rdCircleRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdCircleRound.Location = new System.Drawing.Point(55, 172);
            this.rdCircleRound.Name = "rdCircleRound";
            this.rdCircleRound.Size = new System.Drawing.Size(115, 24);
            this.rdCircleRound.TabIndex = 2;
            this.rdCircleRound.TabStop = true;
            this.rdCircleRound.Tag = "1";
            this.rdCircleRound.Text = "เส้นรอบวงกลม";
            this.rdCircleRound.UseVisualStyleBackColor = true;
            // 
            // rdCircleArea
            // 
            this.rdCircleArea.AutoSize = true;
            this.rdCircleArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdCircleArea.Location = new System.Drawing.Point(55, 135);
            this.rdCircleArea.Name = "rdCircleArea";
            this.rdCircleArea.Size = new System.Drawing.Size(107, 24);
            this.rdCircleArea.TabIndex = 2;
            this.rdCircleArea.TabStop = true;
            this.rdCircleArea.Tag = "1";
            this.rdCircleArea.Text = "พื้นที่ทรงกลม";
            this.rdCircleArea.UseVisualStyleBackColor = true;
            // 
            // lbCircleShow
            // 
            this.lbCircleShow.BackColor = System.Drawing.Color.Yellow;
            this.lbCircleShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCircleShow.ForeColor = System.Drawing.Color.Red;
            this.lbCircleShow.Location = new System.Drawing.Point(49, 253);
            this.lbCircleShow.Name = "lbCircleShow";
            this.lbCircleShow.Size = new System.Drawing.Size(736, 51);
            this.lbCircleShow.TabIndex = 30;
            this.lbCircleShow.Text = "0.00";
            this.lbCircleShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRadius
            // 
            this.tbRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbRadius.Location = new System.Drawing.Point(55, 75);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(162, 29);
            this.tbRadius.TabIndex = 1;
            this.tbRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadius_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(51, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "ผลลัพธ์";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(51, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ป้อนรัศมี";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btRectCancel);
            this.tabPage2.Controls.Add(this.btRectCal);
            this.tabPage2.Controls.Add(this.rdRectRound);
            this.tabPage2.Controls.Add(this.rdRectArea);
            this.tabPage2.Controls.Add(this.lbRectShow);
            this.tabPage2.Controls.Add(this.tbRectHeight);
            this.tabPage2.Controls.Add(this.tbWidth);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "สี่เหลี่ยม";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btRectCancel
            // 
            this.btRectCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRectCancel.Image = global::DTIWinformProject.Properties.Resources.cancel1;
            this.btRectCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRectCancel.Location = new System.Drawing.Point(786, 158);
            this.btRectCancel.Name = "btRectCancel";
            this.btRectCancel.Size = new System.Drawing.Size(152, 86);
            this.btRectCancel.TabIndex = 39;
            this.btRectCancel.Text = "ยกเลิก";
            this.btRectCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRectCancel.UseVisualStyleBackColor = true;
            this.btRectCancel.Click += new System.EventHandler(this.btRectCancel_Click);
            // 
            // btRectCal
            // 
            this.btRectCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRectCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btRectCal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRectCal.Location = new System.Drawing.Point(786, 66);
            this.btRectCal.Name = "btRectCal";
            this.btRectCal.Size = new System.Drawing.Size(152, 86);
            this.btRectCal.TabIndex = 40;
            this.btRectCal.Text = "คำนวณ";
            this.btRectCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRectCal.UseVisualStyleBackColor = true;
            this.btRectCal.Click += new System.EventHandler(this.btRectCal_Click);
            // 
            // rdRectRound
            // 
            this.rdRectRound.AutoSize = true;
            this.rdRectRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdRectRound.Location = new System.Drawing.Point(42, 165);
            this.rdRectRound.Name = "rdRectRound";
            this.rdRectRound.Size = new System.Drawing.Size(123, 24);
            this.rdRectRound.TabIndex = 36;
            this.rdRectRound.TabStop = true;
            this.rdRectRound.Tag = "1";
            this.rdRectRound.Text = "เส้นรอบสี่เหลี่ยม";
            this.rdRectRound.UseVisualStyleBackColor = true;
            // 
            // rdRectArea
            // 
            this.rdRectArea.AutoSize = true;
            this.rdRectArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdRectArea.Location = new System.Drawing.Point(42, 128);
            this.rdRectArea.Name = "rdRectArea";
            this.rdRectArea.Size = new System.Drawing.Size(105, 24);
            this.rdRectArea.TabIndex = 37;
            this.rdRectArea.TabStop = true;
            this.rdRectArea.Tag = "1";
            this.rdRectArea.Text = "พื้นที่สี่เหลี่ยม";
            this.rdRectArea.UseVisualStyleBackColor = true;
            // 
            // lbRectShow
            // 
            this.lbRectShow.BackColor = System.Drawing.Color.Yellow;
            this.lbRectShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRectShow.ForeColor = System.Drawing.Color.Red;
            this.lbRectShow.Location = new System.Drawing.Point(36, 246);
            this.lbRectShow.Name = "lbRectShow";
            this.lbRectShow.Size = new System.Drawing.Size(736, 51);
            this.lbRectShow.TabIndex = 38;
            this.lbRectShow.Text = "0.00";
            this.lbRectShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRectHeight
            // 
            this.tbRectHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbRectHeight.Location = new System.Drawing.Point(319, 68);
            this.tbRectHeight.Name = "tbRectHeight";
            this.tbRectHeight.Size = new System.Drawing.Size(162, 29);
            this.tbRectHeight.TabIndex = 35;
            this.tbRectHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadius_KeyPress);
            // 
            // tbWidth
            // 
            this.tbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbWidth.Location = new System.Drawing.Point(42, 68);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(162, 29);
            this.tbWidth.TabIndex = 35;
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadius_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(38, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "ผลลัพธ์";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(315, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "ป้อนยาว";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(38, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "ป้อนกว้าง";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btTriCancel);
            this.tabPage3.Controls.Add(this.btTriCal);
            this.tabPage3.Controls.Add(this.rdTriRound);
            this.tabPage3.Controls.Add(this.rdTriArea);
            this.tabPage3.Controls.Add(this.lbTriShow);
            this.tabPage3.Controls.Add(this.tbSideAngle);
            this.tabPage3.Controls.Add(this.tbTriHeight);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.tbBase);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(970, 329);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "สามเหลี่ยมมุมฉาก";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btTriCancel
            // 
            this.btTriCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTriCancel.Image = global::DTIWinformProject.Properties.Resources.cancel1;
            this.btTriCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTriCancel.Location = new System.Drawing.Point(787, 158);
            this.btTriCancel.Name = "btTriCancel";
            this.btTriCancel.Size = new System.Drawing.Size(152, 86);
            this.btTriCancel.TabIndex = 39;
            this.btTriCancel.Text = "ยกเลิก";
            this.btTriCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTriCancel.UseVisualStyleBackColor = true;
            // 
            // btTriCal
            // 
            this.btTriCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTriCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btTriCal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTriCal.Location = new System.Drawing.Point(787, 66);
            this.btTriCal.Name = "btTriCal";
            this.btTriCal.Size = new System.Drawing.Size(152, 86);
            this.btTriCal.TabIndex = 40;
            this.btTriCal.Text = "คำนวณ";
            this.btTriCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTriCal.UseVisualStyleBackColor = true;
            this.btTriCal.Click += new System.EventHandler(this.btTriCal_Click);
            // 
            // rdTriRound
            // 
            this.rdTriRound.AutoSize = true;
            this.rdTriRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdTriRound.Location = new System.Drawing.Point(42, 165);
            this.rdTriRound.Name = "rdTriRound";
            this.rdTriRound.Size = new System.Drawing.Size(140, 24);
            this.rdTriRound.TabIndex = 36;
            this.rdTriRound.TabStop = true;
            this.rdTriRound.Tag = "1";
            this.rdTriRound.Text = "เส้นรอบสามเหลี่ยม";
            this.rdTriRound.UseVisualStyleBackColor = true;
            // 
            // rdTriArea
            // 
            this.rdTriArea.AutoSize = true;
            this.rdTriArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdTriArea.Location = new System.Drawing.Point(42, 128);
            this.rdTriArea.Name = "rdTriArea";
            this.rdTriArea.Size = new System.Drawing.Size(122, 24);
            this.rdTriArea.TabIndex = 37;
            this.rdTriArea.TabStop = true;
            this.rdTriArea.Tag = "1";
            this.rdTriArea.Text = "พื้นที่สามเหลี่ยม";
            this.rdTriArea.UseVisualStyleBackColor = true;
            // 
            // lbTriShow
            // 
            this.lbTriShow.BackColor = System.Drawing.Color.Yellow;
            this.lbTriShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTriShow.ForeColor = System.Drawing.Color.Red;
            this.lbTriShow.Location = new System.Drawing.Point(36, 246);
            this.lbTriShow.Name = "lbTriShow";
            this.lbTriShow.Size = new System.Drawing.Size(736, 51);
            this.lbTriShow.TabIndex = 38;
            this.lbTriShow.Text = "0.00";
            this.lbTriShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSideAngle
            // 
            this.tbSideAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSideAngle.Location = new System.Drawing.Point(610, 68);
            this.tbSideAngle.Name = "tbSideAngle";
            this.tbSideAngle.Size = new System.Drawing.Size(162, 29);
            this.tbSideAngle.TabIndex = 35;
            this.tbSideAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadius_KeyPress);
            // 
            // tbTriHeight
            // 
            this.tbTriHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTriHeight.Location = new System.Drawing.Point(326, 68);
            this.tbTriHeight.Name = "tbTriHeight";
            this.tbTriHeight.Size = new System.Drawing.Size(162, 29);
            this.tbTriHeight.TabIndex = 35;
            this.tbTriHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadius_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(606, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 24);
            this.label13.TabIndex = 34;
            this.label13.Text = "ป้อนด้านตรงข้ามมุมฉาก";
            // 
            // tbBase
            // 
            this.tbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbBase.Location = new System.Drawing.Point(42, 68);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(162, 29);
            this.tbBase.TabIndex = 35;
            this.tbBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadius_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(322, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 24);
            this.label12.TabIndex = 34;
            this.label12.Text = "ป้อนสูง";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(38, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "ผลลัพธ์";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(38, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "ป้อนฐาน";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmShapeArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 585);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmShapeArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "คำนวณรูปทรง - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmShapeArea_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.RadioButton rdCircleArea;
        private System.Windows.Forms.RadioButton rdCircleRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCircleShow;
        private System.Windows.Forms.Button btCalcel;
        private System.Windows.Forms.Button btCircleCal;
        private System.Windows.Forms.Button btRectCancel;
        private System.Windows.Forms.Button btRectCal;
        private System.Windows.Forms.RadioButton rdRectRound;
        private System.Windows.Forms.RadioButton rdRectArea;
        private System.Windows.Forms.Label lbRectShow;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRectHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btTriCancel;
        private System.Windows.Forms.Button btTriCal;
        private System.Windows.Forms.RadioButton rdTriRound;
        private System.Windows.Forms.RadioButton rdTriArea;
        private System.Windows.Forms.Label lbTriShow;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTriHeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSideAngle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer;
    }
}