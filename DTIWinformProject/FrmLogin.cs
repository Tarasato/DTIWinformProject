using System;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmLogin : Form
    {
        private void showWarningMSG(string msg) {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมใช่ไหม?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            rdStudent.Checked = true;
            tbUsername.Focus();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim().Length == 0)
            {
                showWarningMSG("กรุณาป้อนชื่อผู้ใช้");
            }
            else if (tbPassword.Text.Trim().Length == 0)
            {
                showWarningMSG("กรุณาป้อนรหัสผ่าน");
            }
            else if (tbPassword.Text.Trim().Length < 6)
            {
                showWarningMSG("กรุณาป้อนรหัสผ่านอย่างน้อย 6 ตัว");
            }
            else {
                // Check username and password
                if (
                    !(
                        ((tbUsername.Text.Trim().ToLower() == "sau") && (tbPassword.Text.Trim() == "123456789")) ||
                    ((tbUsername.Text.Trim().ToLower() == "dti") && (tbPassword.Text.Trim() == "987654321")) ||
                    ((tbUsername.Text.Trim().ToLower() == "tarasato") && (tbPassword.Text.Trim() == "123456"))
                        )
                    )
                {
                    showWarningMSG("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
                }
                else {
                    // if username and password are correct go to main form
                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.Show();
                    Hide(); //ปิดหน้าจอปัจจุบัน
                }
            }
        }
    }
}
