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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide(); //ปิดหน้าจอปัจจุบัน
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.LoginName + " (" + ShareData.LoginType + ")";
            timer.Start();
            cbbDecimal.SelectedIndex = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void cbbDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void tbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void tbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void calNumber(string opt)
        {
            double num1 = double.Parse(tbNum1.Text.Trim());
            double num2 = double.Parse(tbNum2.Text.Trim());
            double result;
            if (opt == "+")
            {
                result = num1 + num2;
            }
            else if (opt == "-")
            {
                result = num1 - num2;
            }
            else if (opt == "*")
            {
                result = num1 * num2;
            }
            else if (opt == "/")
            {
                if (num2 == 0) { 
                    ShareData.showWarningMSG("ไม่สามารถหารด้วย 0 ได้");
                    return;
                }
                result = num1 / num2;
            }
            else { 
                result = Math.Pow(num1, num2);
            }

            if (cbbDecimal.SelectedIndex == 0)
            {
                lbShowResult.Text = result.ToString("N2");
            }
            else if (cbbDecimal.SelectedIndex == 1)
            {
                lbShowResult.Text = result.ToString("N4");
            }
            else
            {
                lbShowResult.Text = result.ToString("N8");
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            if (tbNum1.Text.Trim().Length == 0 || tbNum2.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกตัวเลขให้ครบถ้วน");
            }
            else
            {
                calNumber("+");
            }
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (tbNum1.Text.Trim().Length == 0 || tbNum2.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกตัวเลขให้ครบถ้วน");
            }
            else
            {
                calNumber("-");
            }
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            if (tbNum1.Text.Trim().Length == 0 || tbNum2.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกตัวเลขให้ครบถ้วน");
            }
            else
            {
                calNumber("*");
            }
        }

        private void btDevide_Click(object sender, EventArgs e)
        {
            if (tbNum1.Text.Trim().Length == 0 || tbNum2.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกตัวเลขให้ครบถ้วน");
            }
            else
            {
                calNumber("/");
            }
        }

        private void btPow_Click(object sender, EventArgs e)
        {
            if (tbNum1.Text.Trim().Length == 0 || tbNum2.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกตัวเลขให้ครบถ้วน");
            }
            else
            {
                calNumber("^");
            }
        }
    }
}
