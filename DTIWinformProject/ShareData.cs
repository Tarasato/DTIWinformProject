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

        public static string pictureName;
        public static string dateRegis;
        public static string noRegis;
        public static string nameRegis;
        public static string typeRegis;
        public static string levelRegis;
        public static string subjectRegisItems;
        public static List<string> subjectRegisItemsShow = new List<string>();
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
