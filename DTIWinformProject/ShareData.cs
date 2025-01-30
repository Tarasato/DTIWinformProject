using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    internal class ShareData
    {
        // ต้องใช้ static เพื่อให้สามารถเรียกใช้ได้โดยไม่ต้องสร้าง instance ของคลาสนี้
        public static string LoginName;
        public static string LoginType;
        public static void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void keyNumberAndDotOnly(object sender, KeyPressEventArgs e)
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
    }
    }
