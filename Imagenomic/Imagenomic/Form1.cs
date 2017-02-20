using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagenomic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "Image File (*.bmp,*.jpg, *.png)|*.bmp;*.jpg; *.png";
            if (DialogResult.OK == oFile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(oFile.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Processing.ConvertToGray(copy);
            this.picResult.Image = copy;
        }
    }
}
