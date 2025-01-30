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
    public partial class FrmDooDung : Form
    {
        public FrmDooDung()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void FrmDooDung_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.LoginName + " (" + ShareData.LoginType + ")";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            mtbIDcard.Clear();
            tbFullname.Clear();
            dtpBirthDate.Value = DateTime.Now;
            nudHeight.Value = 0;
            nudWeight.Value = 0;

            lbIDcard.Text = "XXXXXXXXXX";
            lbFullname.Text = "XXXXXXXXXX";
            lbBirthDate.Text = "XXXXXXXXXX";
            lbAge.Text = "XXXXXXXXXX";
            lbHeight.Text = "XXXXXXXXXX";
            lbWeight.Text = "XXXXXXXXXX";
            lbBMI.Text = "XXXXXXXXXX";

            lbShowResult.Text = "ผลดวง";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void btDooDung_Click(object sender, EventArgs e)
        {
            if (mtbIDcard.MaskCompleted == false)
            {
                ShareData.showWarningMSG("กรุณากรอกเลขบัตรประชาชนให้ครบ");
            }
            else if (tbFullname.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกชื่อ-นามสกุล");
            }else if (nudWeight.Value == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกน้ำหนัก");
            }else if(nudHeight.Value == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกส่วนสูง");
            }
            else
            {
                lbIDcard.Text = mtbIDcard.Text;
                lbFullname.Text = tbFullname.Text;

                CultureInfo cultureInfo = new CultureInfo("th-TH");
                lbBirthDate.Text = dtpBirthDate.Value.ToString("วันที่ dd เดือน MMM พ.ศ. yyyy", cultureInfo);
                DateTime b = dtpBirthDate.Value, t = DateTime.Today;
                int y = t.Year - b.Year, m = t.Month - b.Month, d = t.Day - b.Day;
                if (d < 0) { m--; d += DateTime.DaysInMonth(t.Year, t.Month == 1 ? 12 : t.Month - 1); }
                if (m < 0) { y--; m += 12; }
                lbAge.Text = $"{y} ปี {m} เดือน {d} วัน";
                //lbAge.Text = (DateTime.Now.Year - dtpBirthDate.Value.Year).ToString();

                lbHeight.Text = nudHeight.Value.ToString("N2");
                lbWeight.Text = nudWeight.Value.ToString("N2");

                double height = (double)nudHeight.Value / 100;
                double weight = (double)nudWeight.Value / Math.Pow(height, 2);
                lbBMI.Text = weight.ToString("N2");

                // คำนวณดวงจากเดือนเกิด
                int month = dtpBirthDate.Value.Month;
                
                switch (month)
                {
                    case 1:
                        lbShowResult.Text = "โชคดีระดับ1"; break;
                    case 2:
                        lbShowResult.Text = "โชคดีระดับ2"; break;
                    case 3:
                        lbShowResult.Text = "โชคดีระดับ3"; break;
                    case 4:
                        lbShowResult.Text = "โชคดีระดับ4"; break;
                    case 5:
                        lbShowResult.Text = "โชคดีระดับ5"; break;
                    case 6:
                        lbShowResult.Text = "โชคดีระดับ6"; break;
                    case 7:
                        lbShowResult.Text = "โชคดีระดับ7"; break;
                    case 8:
                        lbShowResult.Text = "โชคดีระดับ8"; break;
                    case 9:
                        lbShowResult.Text = "โชคดีระดับ9"; break;
                    case 10:
                        lbShowResult.Text = "โชคดีระดับ10"; break;
                    case 11:
                        lbShowResult.Text = "โชคดีระดับ11"; break;
                    case 12:
                        lbShowResult.Text = "โชคดีระดับ12"; break;
                }
            }
        }

        private void mtbIDcard_Click(object sender, EventArgs e)
        {
            mtbIDcard.SelectionStart = 0;
        }

        private void tbFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
