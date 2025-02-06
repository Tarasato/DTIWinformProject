using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmSAURegister : Form
    {
        public FrmSAURegister()
        {
            InitializeComponent();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void FrmSAURegister_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.LoginName + " (" + ShareData.LoginType + ")";
            timer.Start();
            mcRegis.SetDate(DateTime.Now);
            tbNoRegis.Clear();
            tbNameRegis.Clear();
            cbbLevelRegis.SelectedIndex = 0;
            rdNormalRegis.Checked = true;
            cbConfirmRegis.Checked = false;
            lsbSubjectRegis.Items.Clear();
            lsbSubjectSelectedRegis.Items.Clear();
            pbImageRegis.Image = null;

            List<string> lsbSubjectRegisItems = new List<string>()
            {
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
                    "วิทยาศาสตร์"
            };

            lsbSubjectRegis.Items.AddRange(lsbSubjectRegisItems.ToArray());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิกการลงทะเบียนใช่ไหม?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mcRegis.SetDate(DateTime.Now);
                tbNoRegis.Clear();
                tbNameRegis.Clear();
                cbbLevelRegis.SelectedIndex = 0;
                rdNormalRegis.Checked = true;
                cbConfirmRegis.Checked = false;
                lsbSubjectRegis.Items.Clear();
                lsbSubjectSelectedRegis.Items.Clear();
                pbImageRegis.Image = null;

                //lsbSubjectRegis.Items.Add("ภาษาไทย");
                //lsbSubjectRegis.Items.Add("ภาษาอังกฤษ");
                //lsbSubjectRegis.Items.Add("ภาษาญี่ปุ่น");
                //lsbSubjectRegis.Items.Add("ภาษาจีน");
                //lsbSubjectRegis.Items.Add("สังคมศึกษา");
                //lsbSubjectRegis.Items.Add("คณิตศาสตร์");
                //lsbSubjectRegis.Items.Add("พลศึกษา");
                //lsbSubjectRegis.Items.Add("ประวัติศาสตร์");
                //lsbSubjectRegis.Items.Add("คอมพิวเตอร์เบื้องต้น");
                //lsbSubjectRegis.Items.Add("บัญชีเบื้องต้น");
                //lsbSubjectRegis.Items.Add("วิทยาศาสตร์");

                List<string> lsbSubjectRegisItems = new List<string>()
            {
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
                    "วิทยาศาสตร์"
            };

                lsbSubjectRegis.Items.AddRange(lsbSubjectRegisItems.ToArray());
            }
            
        }

        private void btSelectImageRegis_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImageRegis.Image = new Bitmap(openFileDialog1.FileName);
                //pbImageRegis.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btSelectSub_Click(object sender, EventArgs e)
        {
            if (lsbSubjectRegis.SelectedIndex < 0) // ตรวจสอบว่ามีการเลือกวิชาหรือไม่
            {
                ShareData.showWarningMSG("กรุณาเลือกวิชาที่ต้องการลงทะเบียน");
            }else if (lsbSubjectSelectedRegis.Items.Count == 7) {
                ShareData.showWarningMSG("สามารถลงทะเบียนได้สูงสุด 7 วิชาเท่านั้น");
            }
            else
            {
                //lsbSubjectSelectedRegis.Items.Add(lsbSubjectRegis.SelectedItem);
                lsbSubjectSelectedRegis.Items.Add(lsbSubjectRegis.Items[lsbSubjectRegis.SelectedIndex]);
                lsbSubjectRegis.Items.RemoveAt(lsbSubjectRegis.SelectedIndex);
            }
        }

        private void btUnSelectSub_Click(object sender, EventArgs e)
        {
            if (lsbSubjectSelectedRegis.SelectedIndex < 0) // ตรวจสอบว่ามีการเลือกวิชาหรือไม่
            {
                ShareData.showWarningMSG("กรุณาเลือกวิชาที่ต้องการยกเลิกลงทะเบียน");
            }
            else
            {
                lsbSubjectRegis.Items.Add(lsbSubjectSelectedRegis.Items[lsbSubjectSelectedRegis.SelectedIndex]);
                lsbSubjectSelectedRegis.Items.RemoveAt(lsbSubjectSelectedRegis.SelectedIndex);
            }
        }

        private void btUnSelectAllSub_Click(object sender, EventArgs e)
        {
            lsbSubjectRegis.Items.AddRange(lsbSubjectSelectedRegis.Items);
            lsbSubjectSelectedRegis.Items.Clear();
        }

        private void btSelectAllSub_Click(object sender, EventArgs e)
        {
            if (lsbSubjectSelectedRegis.Items.Count == 7)
            {
                ShareData.showWarningMSG("สามารถลงทะเบียนได้สูงสุด 7 วิชาเท่านั้น");
            }
            else
            {
                for (int i = lsbSubjectSelectedRegis.Items.Count; i < 7; i++) {
                    lsbSubjectSelectedRegis.Items.Add(lsbSubjectRegis.Items[0]);
                    lsbSubjectRegis.Items.RemoveAt(0);
                }
            }
        }

        private void btRegis_Click(object sender, EventArgs e)
        {
            if (tbNoRegis.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณาป้อนเลขประจำตัวนักเรียน");
            }
            else if (tbNameRegis.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณาป้อนชื่อ-สกุล");
            }
            else if (openFileDialog1.FileName == "")
            {
                ShareData.showWarningMSG("กรุณาเลือกรูป");
            }
            else if (lsbSubjectSelectedRegis.Items.Count <= 0)
            {
                ShareData.showWarningMSG("กรุณาเลือกรายวิชาที่ต้องการลงทะเบียน");
            }
            else if (lsbSubjectSelectedRegis.Items.Count > 7)
            {
                ShareData.showWarningMSG("เลือกรายวิชาที่ต้องการลงทะเบียนได้สูงสุด 7 วิชาเท่านั้น");
            }
            
            else if (!cbConfirmRegis.Checked)
            {
                ShareData.showWarningMSG("กรุณายันยันการลงทะเบียน");
            }else{
                ShareData.noRegis = tbNoRegis.Text.Trim();
                ShareData.nameRegis = tbNameRegis.Text.Trim();
                CultureInfo cultureInfo = new CultureInfo("th-TH");
                ShareData.dateRegis = mcRegis.SelectionStart.ToString("d/MMMM/yyyy", cultureInfo);
                ShareData.typeRegis = rdNormalRegis.Checked ? "ปกติ" : "นักเรียนกองทุน";
                ShareData.levelRegis = cbbLevelRegis.SelectedItem.ToString();
                ShareData.pictureName = openFileDialog1.FileName;

                //เอาวิชาที่เลือกมาเก็บไว้ใน List
                foreach (var item in lsbSubjectSelectedRegis.Items)
                {
                    ShareData.subjectRegisItemsShow.Add(item.ToString());
                }

                //แปลง list เป็น string
                ShareData.subjectRegisItems = string.Join("\n", ShareData.subjectRegisItemsShow);

                FrmSAURegisterResult frmregisterResult = new FrmSAURegisterResult();
                frmregisterResult.Show();
                Hide();
            }
        }

        private void tbNoRegis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
    }
}
