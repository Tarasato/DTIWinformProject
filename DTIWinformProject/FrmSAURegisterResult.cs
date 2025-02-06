using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmSAURegisterResult : Form
    {
        public FrmSAURegisterResult()
        {
            InitializeComponent();
        }

        private void FrmSAURegisterResult_Load(object sender, EventArgs e)
        {
            pbImageRegisShow.Image = new Bitmap(ShareData.pictureName);
            lbDateShow.Text = ShareData.dateRegis;
            lbNoShow.Text = ShareData.noRegis;
            lbNameShow.Text = ShareData.nameRegis;
            lbLevelShow.Text = ShareData.levelRegis;
            lbtypeShow.Text = ShareData.typeRegis;
            lbSubjectShow.Text = ShareData.subjectRegisItems;

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            FrmSAURegister frmSAURegister = new FrmSAURegister();
            frmSAURegister.Show();
            Hide();
        }
    }
}
