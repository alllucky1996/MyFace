using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamCapture;

namespace FaceVSFace
{
    public partial class frmSoSanh : Form
    {
        public frmSoSanh()
        {
            InitializeComponent();
        }
        void LoadForm()
        {
            imgFromCammera.Image = Commons.ImgFaceCamera; ;
        }
        

        private void frmSoSanh_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            var chup = new Cammera();
            chup.ShowDialog();
            LoadForm();
            
        }

        private void imgCMT_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image format|*.jpg;*.jpge;*.bmp;*.png | All file|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imgCMT.Image = new Bitmap(new Bitmap(op.FileName),new Size(imgCMT.Width,imgCMT.Height));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("file không hợp lệ");
                   
                }
            }
        }

        private void btnVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Khác nhau hết", "Kết quả demo",MessageBoxButtons.OK);
        }
    }
}
