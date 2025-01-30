namespace DTIWinformProject
{
    partial class FrmLotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLotto));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpLotto = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLotto1 = new System.Windows.Forms.Label();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLotto3Top02 = new System.Windows.Forms.Label();
            this.lbLotto3Top01 = new System.Windows.Forms.Label();
            this.btLotto3Top = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbLotto3Bottom02 = new System.Windows.Forms.Label();
            this.lbLotto3Bottom01 = new System.Windows.Forms.Label();
            this.btlbLotto3Bottom = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbLotto2Bottom = new System.Windows.Forms.Label();
            this.btLottoBottom = new System.Windows.Forms.Button();
            this.rdOpen = new System.Windows.Forms.RadioButton();
            this.rdClose = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btLotto1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 86);
            this.label1.TabIndex = 15;
            this.label1.Text = "LOTTO หวยออนไลน์";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpLotto
            // 
            this.dtpLotto.CustomFormat = "dddd, MMMM d, yyyy";
            this.dtpLotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLotto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLotto.Location = new System.Drawing.Point(441, 147);
            this.dtpLotto.Name = "dtpLotto";
            this.dtpLotto.Size = new System.Drawing.Size(321, 29);
            this.dtpLotto.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "ประจำงวดวันที่";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLotto1);
            this.groupBox1.Controls.Add(this.lbLotto1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(115, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 143);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รางวัลที่ 1";
            // 
            // lbLotto1
            // 
            this.lbLotto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto1.ForeColor = System.Drawing.Color.Red;
            this.lbLotto1.Location = new System.Drawing.Point(319, 52);
            this.lbLotto1.Name = "lbLotto1";
            this.lbLotto1.Size = new System.Drawing.Size(180, 44);
            this.lbLotto1.TabIndex = 0;
            this.lbLotto1.Text = "??????";
            this.lbLotto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMainMenu
            // 
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.Location = new System.Drawing.Point(798, 30);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(224, 86);
            this.btMainMenu.TabIndex = 16;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLotto3Top02);
            this.groupBox2.Controls.Add(this.lbLotto3Top01);
            this.groupBox2.Controls.Add(this.btLotto3Top);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(115, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 165);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รางวัลที่ 3 ตัวบน";
            // 
            // lbLotto3Top02
            // 
            this.lbLotto3Top02.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Top02.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Top02.Location = new System.Drawing.Point(133, 106);
            this.lbLotto3Top02.Name = "lbLotto3Top02";
            this.lbLotto3Top02.Size = new System.Drawing.Size(89, 44);
            this.lbLotto3Top02.TabIndex = 0;
            this.lbLotto3Top02.Text = "???";
            this.lbLotto3Top02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLotto3Top01
            // 
            this.lbLotto3Top01.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Top01.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Top01.Location = new System.Drawing.Point(133, 40);
            this.lbLotto3Top01.Name = "lbLotto3Top01";
            this.lbLotto3Top01.Size = new System.Drawing.Size(89, 44);
            this.lbLotto3Top01.TabIndex = 0;
            this.lbLotto3Top01.Text = "???";
            this.lbLotto3Top01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLotto3Top
            // 
            this.btLotto3Top.Cursor = System.Windows.Forms.Cursors.Default;
            this.btLotto3Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLotto3Top.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLotto3Top.Location = new System.Drawing.Point(260, 72);
            this.btLotto3Top.Name = "btLotto3Top";
            this.btLotto3Top.Size = new System.Drawing.Size(51, 44);
            this.btLotto3Top.TabIndex = 18;
            this.btLotto3Top.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLotto3Top.UseVisualStyleBackColor = true;
            this.btLotto3Top.Click += new System.EventHandler(this.btLotto3Top_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLotto3Bottom02);
            this.groupBox3.Controls.Add(this.lbLotto3Bottom01);
            this.groupBox3.Controls.Add(this.btlbLotto3Bottom);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(544, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 165);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "รางวัลที่ 3 ตัวล่าง";
            // 
            // lbLotto3Bottom02
            // 
            this.lbLotto3Bottom02.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Bottom02.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Bottom02.Location = new System.Drawing.Point(141, 106);
            this.lbLotto3Bottom02.Name = "lbLotto3Bottom02";
            this.lbLotto3Bottom02.Size = new System.Drawing.Size(89, 44);
            this.lbLotto3Bottom02.TabIndex = 0;
            this.lbLotto3Bottom02.Text = "???";
            this.lbLotto3Bottom02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLotto3Bottom01
            // 
            this.lbLotto3Bottom01.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Bottom01.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Bottom01.Location = new System.Drawing.Point(141, 40);
            this.lbLotto3Bottom01.Name = "lbLotto3Bottom01";
            this.lbLotto3Bottom01.Size = new System.Drawing.Size(89, 44);
            this.lbLotto3Bottom01.TabIndex = 0;
            this.lbLotto3Bottom01.Text = "???";
            this.lbLotto3Bottom01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btlbLotto3Bottom
            // 
            this.btlbLotto3Bottom.Cursor = System.Windows.Forms.Cursors.Default;
            this.btlbLotto3Bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlbLotto3Bottom.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btlbLotto3Bottom.Location = new System.Drawing.Point(268, 72);
            this.btlbLotto3Bottom.Name = "btlbLotto3Bottom";
            this.btlbLotto3Bottom.Size = new System.Drawing.Size(51, 44);
            this.btlbLotto3Bottom.TabIndex = 19;
            this.btlbLotto3Bottom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlbLotto3Bottom.UseVisualStyleBackColor = true;
            this.btlbLotto3Bottom.Click += new System.EventHandler(this.btlbLotto3Bottom_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbLotto2Bottom);
            this.groupBox4.Controls.Add(this.btLottoBottom);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(115, 564);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 104);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "รางวัลเลขท้าย 2 ตัวล่าง";
            // 
            // lbLotto2Bottom
            // 
            this.lbLotto2Bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto2Bottom.ForeColor = System.Drawing.Color.Red;
            this.lbLotto2Bottom.Location = new System.Drawing.Point(133, 40);
            this.lbLotto2Bottom.Name = "lbLotto2Bottom";
            this.lbLotto2Bottom.Size = new System.Drawing.Size(89, 44);
            this.lbLotto2Bottom.TabIndex = 0;
            this.lbLotto2Bottom.Text = "??";
            this.lbLotto2Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLottoBottom
            // 
            this.btLottoBottom.Cursor = System.Windows.Forms.Cursors.Default;
            this.btLottoBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLottoBottom.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLottoBottom.Location = new System.Drawing.Point(260, 40);
            this.btLottoBottom.Name = "btLottoBottom";
            this.btLottoBottom.Size = new System.Drawing.Size(51, 44);
            this.btLottoBottom.TabIndex = 16;
            this.btLottoBottom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLottoBottom.UseVisualStyleBackColor = true;
            this.btLottoBottom.Click += new System.EventHandler(this.btLottoBottom_Click);
            // 
            // rdOpen
            // 
            this.rdOpen.AutoSize = true;
            this.rdOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOpen.Location = new System.Drawing.Point(654, 583);
            this.rdOpen.Name = "rdOpen";
            this.rdOpen.Size = new System.Drawing.Size(149, 28);
            this.rdOpen.TabIndex = 20;
            this.rdOpen.Tag = "1";
            this.rdOpen.Text = "เปิดการออกรางวัล";
            this.rdOpen.UseVisualStyleBackColor = true;
            this.rdOpen.Click += new System.EventHandler(this.rdOpen_Click);
            // 
            // rdClose
            // 
            this.rdClose.AutoSize = true;
            this.rdClose.Checked = true;
            this.rdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdClose.Location = new System.Drawing.Point(654, 629);
            this.rdClose.Name = "rdClose";
            this.rdClose.Size = new System.Drawing.Size(144, 28);
            this.rdClose.TabIndex = 20;
            this.rdClose.TabStop = true;
            this.rdClose.Tag = "1";
            this.rdClose.Text = "ปิดการออกรางวัล";
            this.rdClose.UseVisualStyleBackColor = true;
            this.rdClose.Click += new System.EventHandler(this.rdClose_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 716);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1063, 25);
            this.toolStrip1.TabIndex = 21;
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
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btLotto1
            // 
            this.btLotto1.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLotto1.Location = new System.Drawing.Point(683, 43);
            this.btLotto1.Name = "btLotto1";
            this.btLotto1.Size = new System.Drawing.Size(81, 75);
            this.btLotto1.TabIndex = 22;
            this.btLotto1.UseVisualStyleBackColor = true;
            this.btLotto1.Click += new System.EventHandler(this.btLotto1_Click);
            // 
            // FrmLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 741);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rdClose);
            this.Controls.Add(this.rdOpen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpLotto);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLotto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto-DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmLotto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpLotto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLotto1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbLotto3Top01;
        private System.Windows.Forms.Button btLotto3Top;
        private System.Windows.Forms.Label lbLotto3Top02;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbLotto3Bottom02;
        private System.Windows.Forms.Label lbLotto3Bottom01;
        private System.Windows.Forms.Button btlbLotto3Bottom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbLotto2Bottom;
        private System.Windows.Forms.Button btLottoBottom;
        private System.Windows.Forms.RadioButton rdOpen;
        private System.Windows.Forms.RadioButton rdClose;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btLotto1;
    }
}