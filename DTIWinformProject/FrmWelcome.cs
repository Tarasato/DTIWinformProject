using System;
using System.Globalization;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.LoginName + " (" + ShareData.LoginType + ")";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //validate UI
            if (tbName.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกชื่อ...");
                tbName.Focus();
                return;
            }
            else if (dtpBirthDate.Value.Year >= DateTime.Now.Year)
            {
                ShareData.showWarningMSG("ปีเกิดต้องน้อยกว่าปีปัจจุบัน...");
            }
            else {
                //นําข้อมูลไปแสดงผล โดยต้องคำนวณอายุ แล้ววันเดือนปีเกิดต้องแสดงผลเป็นวันที่ไทย
                int age = DateTime.Now.Year - dtpBirthDate.Value.Year;

                string birthDate = dtpBirthDate.Value.ToString("วันที่ d เดือน MMM พ.ศ. yyyy", new CultureInfo("th-TH"));

                string gender = rbMale.Checked ? "ชาย" : "หญิง";

                //เอาข้อมูลที่จะแสดงผลมารวมกัน
                string dataShow = "ชื่อ: " + tbName.Text + "\n" +
                                    "วันเกิด: " + birthDate + "\n" +
                                    "อายุ: " + age + " ปี\n" +
                                    "เพศ" + gender;
                //เอสข้อมูลไปแสดงผล
                lbShowResult.Text = dataShow;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            //เคลียร์ข้อมูล
            tbName.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            rbMale.Checked = true;
            lbShowResult.Text = "Welcome";
            tbName.Focus();
        }
    }
}
