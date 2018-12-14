using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceVSFace
{
    public partial class Cammera : Form
    {
        public Cammera()
        {
            InitializeComponent();
        }

        private void Cammera_Load(object sender, EventArgs e)
        {
            userControl11.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Commons.ImgFaceCamera = new Bitmap(userControl11.GetImageCapture());
            this.Close();
        }
    }
}
