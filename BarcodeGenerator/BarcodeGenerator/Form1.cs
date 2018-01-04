using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BarcodeGenerator
{
    public partial class Form1 : Form
    {
        PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        ImageFormat imageFormat;
        Bitmap bitmap;
        string resource = @"..\..\assets\Fonts\idautomationhc39m\IDAutomationHC39MBarcode.ttf";

        public Form1()
        {
            imageFormat = ImageFormat.Jpeg;
            AddFontToCollection();
            InitializeComponent();
        }

        private void BreateBarcodeButton_Click(object sender, EventArgs e)
        {
            var textToGenerate = textBox1.Text;
            bitmap = new Bitmap(textToGenerate.Length * 28, 150);
            var oFont = new Font(privateFontCollection.Families[0], 20);
            PointF point = new PointF(2f, 2f);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            using (Graphics graphic = Graphics.FromImage(bitmap))
            {
                graphic.FillRectangle(whiteBrush, 0, 0, bitmap.Width, bitmap.Height);
                graphic.DrawString(textToGenerate, oFont, blackBrush, point);
            }

            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, imageFormat);
                pictureBox1.Image = bitmap;
                pictureBox1.Height = bitmap.Height;
                pictureBox1.Width = bitmap.Width;
            }

        }

        private void AddFontToCollection()
        {
            privateFontCollection.AddFontFile(resource);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            imageFormat = ImageFormat.Jpeg;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            imageFormat = ImageFormat.Bmp;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            imageFormat = ImageFormat.Png;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            imageFormat = ImageFormat.Gif;
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Type|*." + imageFormat.ToString().ToLower();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(dialog.FileName, imageFormat);
            }
        }
    }
}
