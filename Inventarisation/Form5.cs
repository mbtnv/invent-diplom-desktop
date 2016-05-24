using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Inventarisation
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawImage(pictureBox1.Image, 20, 20); //Point.Empty
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(Form2.curint + ".bmp");
            pictureBox1.Image = image1;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            PrintDocument printDoc = new PrintDocument();
            PrintDialog dlg = new PrintDialog();
            dlg.Document = printDoc;
            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
                printDoc.Print();
            }
        }
    }
}
