# Bar code generator

## AGENDA
## Table of Contents
- [Introduction](#introduction)
- [Code samples](#code-samples)
- [Instalation](#installation)
- [Testing](#testing)


## Introduction

> Hello, this is my school project. Program will create a graphic file (BMP, JPG, PNG, ...) based on the given bar code string.

## Code Samples

> Create barcode from textbox:

``` C#
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
```
> Save to file using save file dialog:
``` C#
        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Type|*." + imageFormat.ToString().ToLower();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(dialog.FileName, imageFormat);
            }
        }
```

## Installation

> Not ready yet.

## Testing

> Not ready yet.
>Will be added in the nearest future.
