namespace DTIWinformProject
{
    partial class FrmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btDevide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.btPow = new System.Windows.Forms.Button();
            this.cbbDecimal = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNum1
            // 
            this.tbNum1.AccessibleDescription = "";
            this.tbNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum1.Location = new System.Drawing.Point(281, 159);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(414, 29);
            this.tbNum1.TabIndex = 22;
            this.tbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum1_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "ป้อนตัวเลข";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btMainMenu
            // 
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.Location = new System.Drawing.Point(811, 31);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(224, 86);
            this.btMainMenu.TabIndex = 20;
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
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 86);
            this.label1.TabIndex = 19;
            this.label1.Text = "Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNum2
            // 
            this.tbNum2.AccessibleDescription = "";
            this.tbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum2.Location = new System.Drawing.Point(281, 214);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(414, 29);
            this.tbNum2.TabIndex = 24;
            this.tbNum2.TextChanged += new System.EventHandler(this.tbNum2_TextChanged);
            this.tbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum2_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "ป้อนตัวเลข";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlus.ForeColor = System.Drawing.Color.Blue;
            this.btPlus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPlus.Location = new System.Drawing.Point(66, 297);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(115, 107);
            this.btPlus.TabIndex = 25;
            this.btPlus.Text = "+";
            this.btPlus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinus.ForeColor = System.Drawing.Color.Blue;
            this.btMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMinus.Location = new System.Drawing.Point(219, 297);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(115, 107);
            this.btMinus.TabIndex = 26;
            this.btMinus.Text = "-";
            this.btMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiply.ForeColor = System.Drawing.Color.Blue;
            this.btMultiply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMultiply.Location = new System.Drawing.Point(372, 297);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(115, 107);
            this.btMultiply.TabIndex = 27;
            this.btMultiply.Text = "X";
            this.btMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMultiply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.btMultiply_Click);
            // 
            // btDevide
            // 
            this.btDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDevide.ForeColor = System.Drawing.Color.Blue;
            this.btDevide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDevide.Location = new System.Drawing.Point(525, 297);
            this.btDevide.Name = "btDevide";
            this.btDevide.Size = new System.Drawing.Size(115, 107);
            this.btDevide.TabIndex = 28;
            this.btDevide.Text = "÷";
            this.btDevide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDevide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDevide.UseVisualStyleBackColor = true;
            this.btDevide.Click += new System.EventHandler(this.btDevide_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 37);
            this.label4.TabIndex = 29;
            this.label4.Text = "ผลลัพธ์";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.Yellow;
            this.lbShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowResult.ForeColor = System.Drawing.Color.Red;
            this.lbShowResult.Location = new System.Drawing.Point(213, 546);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(574, 86);
            this.lbShowResult.TabIndex = 30;
            this.lbShowResult.Text = "???";
            this.lbShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPow
            // 
            this.btPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPow.ForeColor = System.Drawing.Color.Blue;
            this.btPow.Location = new System.Drawing.Point(678, 297);
            this.btPow.Name = "btPow";
            this.btPow.Size = new System.Drawing.Size(115, 107);
            this.btPow.TabIndex = 31;
            this.btPow.Text = "^";
            this.btPow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPow.UseVisualStyleBackColor = true;
            this.btPow.Click += new System.EventHandler(this.btPow_Click);
            // 
            // cbbDecimal
            // 
            this.cbbDecimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDecimal.FormattingEnabled = true;
            this.cbbDecimal.Items.AddRange(new object[] {
            "ทศนิยม 2 ตำแหน่ง",
            "ทศนิยม 4 ตำแหน่ง",
            "ทศนิยม 8 ตำแหน่ง"});
            this.cbbDecimal.Location = new System.Drawing.Point(281, 466);
            this.cbbDecimal.Name = "cbbDecimal";
            this.cbbDecimal.Size = new System.Drawing.Size(414, 32);
            this.cbbDecimal.TabIndex = 32;
            this.cbbDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbDecimal_KeyPress);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip2.Location = new System.Drawing.Point(0, 688);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1102, 25);
            this.toolStrip2.TabIndex = 33;
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
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 713);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.cbbDecimal);
            this.Controls.Add(this.btPow);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btDevide);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หนเาจอเครื่องคิดเลข-DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btDevide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.Button btPow;
        private System.Windows.Forms.ComboBox cbbDecimal;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer;
    }
}