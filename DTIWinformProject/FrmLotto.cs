using System;
using System.Globalization;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmLotto : Form
    {
        public FrmLotto()
        {
            InitializeComponent();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void FrmLotto_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.LoginName + " (" + ShareData.LoginType + ")";
            timer.Start();
            rdClose.PerformClick();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void rdClose_Click(object sender, EventArgs e)
        {
            if (rdClose.Checked == true)
            {
                lbLotto1.Text = "??????";
                lbLotto3Top01.Text = "???";
                lbLotto3Top02.Text = "???";
                lbLotto3Bottom01.Text = "???";
                lbLotto3Bottom02.Text = "???";
                lbLotto3Bottom02.Text = "??";
                btLotto1.Enabled = false;
                btLotto3Top.Enabled = false;
                btlbLotto3Bottom.Enabled = false;
                btLottoBottom.Enabled = false;

                dtpLotto.Value = DateTime.Now;
            }
        }

        private void rdOpen_Click(object sender, EventArgs e)
        {
            btLotto1.Enabled = true;
            btLotto3Top.Enabled = true;
            btlbLotto3Bottom.Enabled = true;
            btLottoBottom.Enabled = true;
        }

        private void btLotto1_Click(object sender, EventArgs e)
        {
            if (dtpLotto.Value.Day != 1 && dtpLotto.Value.Day != 16)
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที่ 1 และ 16 ของทุกเดือน");
            }
            else
            {
                Random rnd = new Random();
                String lotto = rnd.Next(1000000).ToString("000000");
                lbLotto1.Text = lotto;
                btLotto1.Enabled = false;
            }
        }

        private void btLotto3Top_Click(object sender, EventArgs e)
        {
            if (dtpLotto.Value.Day != 1 && dtpLotto.Value.Day != 16)
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที่ 1 และ 16 ของทุกเดือน");
            }
            else
            {
                Random rnd = new Random();
                String lotto3Top01 = rnd.Next(1000).ToString("000");
                String lotto3Top02 = rnd.Next(1000).ToString("000");
                lbLotto3Top01.Text = lotto3Top01;
                lbLotto3Top02.Text = lotto3Top02;
                btLotto3Top.Enabled = false;
            }
        }

        private void btlbLotto3Bottom_Click(object sender, EventArgs e)
        {
            if(dtpLotto.Value.Day != 1 && dtpLotto.Value.Day != 16)
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที่ 1 และ 16 ของทุกเดือน");
            }
            else
            {
                Random rnd = new Random();
                String lotto3Bottom01 = rnd.Next(1000).ToString("000");
                String lotto3Bottom02 = rnd.Next(1000).ToString("000");
                String lotto3Bottom03 = rnd.Next(1000).ToString("000");
                lbLotto3Bottom01.Text = lotto3Bottom01;
                lbLotto3Bottom02.Text = lotto3Bottom02;
                btlbLotto3Bottom.Enabled = false;
            }
        }

        private void btLottoBottom_Click(object sender, EventArgs e)
        {
            if(dtpLotto.Value.Day != 1 && dtpLotto.Value.Day != 16)
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที่ 1 และ 16 ของทุกเดือน");
            }
            else
            {
                Random rnd = new Random();
                String lottoBottom = rnd.Next(100).ToString("00");
                lbLotto2Bottom.Text = lottoBottom;
                btLottoBottom.Enabled = false;
            }
        }
    }
}
