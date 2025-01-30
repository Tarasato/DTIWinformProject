using System;
using System.Globalization;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmSAUShop : Form
    {
        public FrmSAUShop()
        {
            InitializeComponent();
        }

        private void FrmSAUShop_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.LoginName + " (" + ShareData.LoginType + ")";
            timer.Start();
            //เรียกปุ่ม Cancel ให้ทำงาน
            btCancel.PerformClick();
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            cbPen.Checked = false;
            cbPencil.Checked = false;
            cbRuler.Checked = false;
            cbRubber.Checked = false;
            cbBook.Checked = false;
            tbBook.Clear();
            tbPen.Clear();
            tbPencil.Clear();
            tbRuler.Clear();
            tbRubber.Clear();
            tbPen.Enabled = false;
            tbPencil.Enabled = false;
            tbRuler.Enabled = false;
            tbRubber.Enabled = false;
            tbBook.Enabled = false;
            lbPen.Text = "0.00";
            lbPencil.Text = "0.00";
            lbRuler.Text = "0.00";
            lbRubber.Text = "0.00";
            lbBook.Text = "0.00";
            lbShowTotalPay.Text = "0.00";
            cbbSale.SelectedIndex = 0;
        }

        private void cbPen_Click(object sender, EventArgs e)
        {
            if (cbPen.Checked == true)
            {
                tbPen.Enabled = true;
            }
            else
            {
                tbPen.Clear();
                tbPen.Enabled = false;
                lbPen.Text = "0.00";
            }
        }

        private void cbPencil_Click(object sender, EventArgs e)
        {
            if (cbPencil.Checked == true)
            {
                tbPencil.Enabled = true;
            }
            else
            {
                tbPencil.Clear();
                tbPencil.Enabled = false;
                lbPencil.Text = "0.00";
            }
        }

        private void cbRubber_Click(object sender, EventArgs e)
        {
            if (cbRubber.Checked == true)
            {
                tbRubber.Enabled = true;
            }
            else
            {
                tbRubber.Clear();
                tbRubber.Enabled = false;
                lbRubber.Text = "0.00";
            }
        }

        private void cbRuler_Click(object sender, EventArgs e)
        {
            if (cbRuler.Checked == true)
            {
                tbRuler.Enabled = true;
            }
            else
            {
                tbRuler.Clear();
                tbRuler.Enabled = false;
                lbRuler.Text = "0.00";
            }
        }

        private void cbBook_Click(object sender, EventArgs e)
        {
            if (cbBook.Checked == true)
            {
                tbBook.Enabled = true;
            }
            else
            {
                tbBook.Clear();
                tbBook.Enabled = false;
                lbBook.Text = "0.00";
            }
        }

        private void tbPen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPencil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRubber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRuler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPen_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPen.Text.Trim().Length > 0)
            {
                int quantity = int.Parse(tbPen.Text);
                double price = 5 * quantity;
                lbPen.Text = price.ToString("N2");
            }
            else
            {
                lbPen.Text = "0.00";
            }
        }

        private void tbPencil_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPencil.Text.Trim().Length > 0)
            {
                int quantity = int.Parse(tbPencil.Text);
                double price = 1.5 * quantity;
                lbPencil.Text = price.ToString("N2");
            }
            else
            {
                lbPencil.Text = "0.00";
            }
        }

        private void tbRubber_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRubber.Text.Trim().Length > 0)
            {
                int quantity = int.Parse(tbRubber.Text);
                double price = 2.5 * quantity;
                lbRubber.Text = price.ToString("N2");
            }
            else
            {
                lbRubber.Text = "0.00";
            }
        }

        private void tbRuler_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRuler.Text.Trim().Length > 0)
            {
                int quantity = int.Parse(tbRuler.Text);
                double price = 2 * quantity;
                lbRuler.Text = price.ToString("N2");
            }
            else
            {
                lbRuler.Text = "0.00";
            }
        }

        private void tbBook_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbBook.Text.Trim().Length > 0)
            {
                int quantity = int.Parse(tbBook.Text);
                double price = 10.25 * quantity;
                lbBook.Text = price.ToString("N2");
            }
            else
            {
                lbBook.Text = "0.00";
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            double totalPay = (double.Parse(lbPen.Text) + double.Parse(lbPencil.Text) + double.Parse(lbRubber.Text) + double.Parse(lbRuler.Text) + double.Parse(lbBook.Text));
            if (cbbSale.SelectedIndex == 0)
            {   
                totalPay = totalPay * 0.95;
                lbShowTotalPay.Text = totalPay.ToString("N2");
            }
            else if (cbbSale.SelectedIndex == 1)
            {
                totalPay = totalPay * 0.9;
                lbShowTotalPay.Text = totalPay.ToString("N2");

            }
            else if (cbbSale.SelectedIndex == 2)
            {
                totalPay = totalPay * 0.85;
                lbShowTotalPay.Text = totalPay.ToString("N2");
            }
        }
    }
}
