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
    public partial class FrmShapeArea : Form
    {
        public FrmShapeArea()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void FrmShapeArea_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.LoginName + " (" + ShareData.LoginType + ")";
            timer.Start();
            rdCircleArea.Checked = true;
            rdRectArea.Checked = true;
            rdTriArea.Checked = true;
        }

        private void tbRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.keyNumberAndDotOnly(sender, e);
        }

        private void btCircleCal_Click(object sender, EventArgs e)
        {
            if (tbRadius.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกขนาดของรัศมี");
            }
            else
            {
                if(rdCircleArea.Checked == true)
                {
                    double radius = double.Parse(tbRadius.Text);
                    double area = Math.PI * Math.Pow(radius, 2);
                    lbCircleShow.Text = area.ToString("N2");
                }
                else
                {
                    double radius = double.Parse(tbRadius.Text);
                    double circumference = 2 * Math.PI * radius;
                    lbCircleShow.Text = circumference.ToString("N2");
                }
            }
        }

        private void btCalcel_Click(object sender, EventArgs e)
        {
            tbRadius.Clear();
            rdCircleArea.Checked = true;
            lbCircleShow.Text = "0.00";
        }

        private void btRectCal_Click(object sender, EventArgs e)
        {
            if (tbWidth.Text.Trim().Length == 0 || tbRectHeight.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกขนาดของความกว้างและความยาว");
            }
            else
            {
                if (rdRectArea.Checked == true)
                {
                    double width = double.Parse(tbWidth.Text);
                    double height = double.Parse(tbRectHeight.Text);
                    double area = width * height;
                    lbRectShow.Text = area.ToString("N2");
                }
                else
                {
                    double width = double.Parse(tbWidth.Text);
                    double height = double.Parse(tbRectHeight.Text);
                    double perimeter = 2 * (width + height);
                    lbRectShow.Text = perimeter.ToString("N2");
                }
            }
        }

        private void btRectCancel_Click(object sender, EventArgs e)
        {
            tbWidth.Clear();
            tbRectHeight.Clear();
            rdRectArea.Checked = true;
            lbRectShow.Text = "0.00";
        }

        private void btTriCal_Click(object sender, EventArgs e)
        {
            if (tbBase.Text.Trim().Length == 0 || tbTriHeight.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกขนาดของฐานและความสูง");
            }
            else
            {
                if (rdTriArea.Checked == true)
                {
                    double triBase = double.Parse(tbBase.Text);
                    double triHeight = double.Parse(tbTriHeight.Text);
                    double area = 0.5 * triBase * triHeight;
                    lbTriShow.Text = area.ToString("N2");
                }
                else
                {
                    double triBase = double.Parse(tbBase.Text);
                    double triHeight = double.Parse(tbTriHeight.Text);
                    double perimeter = triBase + 2 * Math.Sqrt(Math.Pow(triBase / 2, 2) + Math.Pow(triHeight, 2));
                    lbTriShow.Text = perimeter.ToString("N2");
                }
            }
        }
    }
}
