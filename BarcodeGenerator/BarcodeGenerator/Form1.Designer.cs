namespace BarcodeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GifRadioButton = new System.Windows.Forms.RadioButton();
            this.PngRadioButton = new System.Windows.Forms.RadioButton();
            this.BmpRadioButton = new System.Windows.Forms.RadioButton();
            this.JpegRadioButton = new System.Windows.Forms.RadioButton();
            this.saveFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create barcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BreateBarcodeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 216);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GifRadioButton);
            this.groupBox1.Controls.Add(this.PngRadioButton);
            this.groupBox1.Controls.Add(this.BmpRadioButton);
            this.groupBox1.Controls.Add(this.JpegRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose file type";
            // 
            // GifRadioButton
            // 
            this.GifRadioButton.AutoSize = true;
            this.GifRadioButton.Location = new System.Drawing.Point(64, 42);
            this.GifRadioButton.Name = "GifRadioButton";
            this.GifRadioButton.Size = new System.Drawing.Size(42, 17);
            this.GifRadioButton.TabIndex = 3;
            this.GifRadioButton.Text = "GIF";
            this.GifRadioButton.UseVisualStyleBackColor = true;
            this.GifRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // PngRadioButton
            // 
            this.PngRadioButton.AutoSize = true;
            this.PngRadioButton.Location = new System.Drawing.Point(6, 42);
            this.PngRadioButton.Name = "PngRadioButton";
            this.PngRadioButton.Size = new System.Drawing.Size(48, 17);
            this.PngRadioButton.TabIndex = 2;
            this.PngRadioButton.Text = "PNG";
            this.PngRadioButton.UseVisualStyleBackColor = true;
            this.PngRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // BmpRadioButton
            // 
            this.BmpRadioButton.AutoSize = true;
            this.BmpRadioButton.Location = new System.Drawing.Point(64, 19);
            this.BmpRadioButton.Name = "BmpRadioButton";
            this.BmpRadioButton.Size = new System.Drawing.Size(48, 17);
            this.BmpRadioButton.TabIndex = 1;
            this.BmpRadioButton.Text = "BMP";
            this.BmpRadioButton.UseVisualStyleBackColor = true;
            this.BmpRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // JpegRadioButton
            // 
            this.JpegRadioButton.AutoSize = true;
            this.JpegRadioButton.Checked = true;
            this.JpegRadioButton.Location = new System.Drawing.Point(6, 19);
            this.JpegRadioButton.Name = "JpegRadioButton";
            this.JpegRadioButton.Size = new System.Drawing.Size(52, 17);
            this.JpegRadioButton.TabIndex = 0;
            this.JpegRadioButton.TabStop = true;
            this.JpegRadioButton.Text = "JPEG";
            this.JpegRadioButton.UseVisualStyleBackColor = true;
            this.JpegRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(340, 266);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(119, 72);
            this.saveFile.TabIndex = 6;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 349);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GifRadioButton;
        private System.Windows.Forms.RadioButton PngRadioButton;
        private System.Windows.Forms.RadioButton BmpRadioButton;
        private System.Windows.Forms.RadioButton JpegRadioButton;
        private System.Windows.Forms.Button saveFile;
    }
}

