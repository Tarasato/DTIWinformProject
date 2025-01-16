using System;
using System.Globalization;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btWelcome_Click(object sender, EventArgs e)
        {
            FrmWelcome frmWelcome = new FrmWelcome();
            frmWelcome.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void btExitToLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.LoginName + " (" + ShareData.LoginType + ")";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //แสดงเวลาเป็นภาษาไทย
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void btCalculator_Click(object sender, EventArgs e)
        {
            FrmCalculator frmCalculator = new FrmCalculator();
            frmCalculator.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void btSAUShop_Click(object sender, EventArgs e)
        {
            FrmSAUShop frmSAUShop = new FrmSAUShop();
            frmSAUShop.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void btLotto_Click(object sender, EventArgs e)
        {
            FrmLotto frmLotto = new FrmLotto();
            frmLotto.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void btDooDung_Click(object sender, EventArgs e)
        {
            FrmDooDung frmDooDung = new FrmDooDung();
            frmDooDung.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void brShapeArea_Click(object sender, EventArgs e)
        {
            FrmShapeArea frmShapeArea = new FrmShapeArea();
            frmShapeArea.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            FrmSAURegister frmSAURegister = new FrmSAURegister();
            frmSAURegister.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }
    }
}
