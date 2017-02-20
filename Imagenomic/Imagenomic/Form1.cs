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
            //DialogResult result = openFileDialog1.ShowDialog(); // show the dialog.
            //if (result == DialogResult.OK)
            //{
            //    string file = openFileDialog1.FileName;
            //    try
            //    {
            //        string text = File.ReadAllText(file);
            //        size = text.Length;
            //    }
            //    catch (IOException)
            //    {

            //        throw;
            //    }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //read image
            //Bitmap bmp = new Bitmap("C:\\Users\\GevorgDaniel\\Desktop\\fb_bug.png");

            //load original image in picturebox1
            //picOriginal.Image = Image.FromFile("C:\\Users\\GevorgDaniel\\Desktop\\fb_bug.png");

            //get image dimension
            //int width = bmp.Width;
            //int height = bmp.Height;

            //color of pixel
            //Color pix;

            //grayscale
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        pix = bmp.GetPixel(x, y);

            //        //extract pixel component ARGB
            //        int a = pix.A;
            //        int r = pix.R;
            //        int g = pix.G;
            //        int b = pix.B;

            //        //find average 
            //        int avg = (r + g + b) / 3;

            //        //set new pixel value 
            //        bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
            //    }
            //}

            //load grayscale image in picturebox2
            //picResult.Image = bmp;

            ////write the grayscale image
            //bmp.Save("C:\\Users\\GevorgDaniel\\Desktop\\bug.png");
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Processing.ConvertToGray(copy);
            this.picResult.Image = copy;
        }

        //public Bitmap GrayScale(Bitmap Bmp)
        //{
        //    int rgb;
        //    Color color;
        //    for (int y = 0; y < Bmp.Height; y++)
        //        for (int x = 0; x < Bmp.Width; x++)
        //        {
        //            color = Bmp.GetPixel(x, y);
        //            rgb = color.R + color.G + color.B
        //        }
        //    return Bmp;
        //}

    }
}
