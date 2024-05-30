namespace ThreadsGui {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            MainImg = new PictureBox();
            UploadImgBtn = new Button();
            ProcessImgBtn = new Button();
            TopLeftImg = new PictureBox();
            TopRightImg = new PictureBox();
            BottomLeftImg = new PictureBox();
            BottomRightImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MainImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TopLeftImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TopRightImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BottomLeftImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BottomRightImg).BeginInit();
            SuspendLayout();
            // 
            // MainImg
            // 
            MainImg.BackColor = SystemColors.ButtonShadow;
            MainImg.Location = new Point(12, 12);
            MainImg.Name = "MainImg";
            MainImg.Size = new Size(400, 400);
            MainImg.SizeMode = PictureBoxSizeMode.StretchImage;
            MainImg.TabIndex = 0;
            MainImg.TabStop = false;
            // 
            // UploadImgBtn
            // 
            UploadImgBtn.Location = new Point(418, 125);
            UploadImgBtn.Name = "UploadImgBtn";
            UploadImgBtn.Size = new Size(90, 60);
            UploadImgBtn.TabIndex = 1;
            UploadImgBtn.Text = "Upload Image";
            UploadImgBtn.UseVisualStyleBackColor = true;
            UploadImgBtn.Click += UploadImgBtn_Click;
            // 
            // ProcessImgBtn
            // 
            ProcessImgBtn.Location = new Point(418, 215);
            ProcessImgBtn.Name = "ProcessImgBtn";
            ProcessImgBtn.Size = new Size(90, 60);
            ProcessImgBtn.TabIndex = 2;
            ProcessImgBtn.Text = "Process Image";
            ProcessImgBtn.UseVisualStyleBackColor = true;
            ProcessImgBtn.Click += ProcessImgBtn_Click;
            // 
            // TopLeftImg
            // 
            TopLeftImg.BackColor = SystemColors.ButtonShadow;
            TopLeftImg.Location = new Point(514, 12);
            TopLeftImg.Name = "TopLeftImg";
            TopLeftImg.Size = new Size(195, 195);
            TopLeftImg.SizeMode = PictureBoxSizeMode.StretchImage;
            TopLeftImg.TabIndex = 3;
            TopLeftImg.TabStop = false;
            // 
            // TopRightImg
            // 
            TopRightImg.BackColor = SystemColors.ButtonShadow;
            TopRightImg.Location = new Point(715, 12);
            TopRightImg.Name = "TopRightImg";
            TopRightImg.Size = new Size(195, 195);
            TopRightImg.SizeMode = PictureBoxSizeMode.StretchImage;
            TopRightImg.TabIndex = 4;
            TopRightImg.TabStop = false;
            // 
            // BottomLeftImg
            // 
            BottomLeftImg.BackColor = SystemColors.ButtonShadow;
            BottomLeftImg.Location = new Point(514, 217);
            BottomLeftImg.Name = "BottomLeftImg";
            BottomLeftImg.Size = new Size(195, 195);
            BottomLeftImg.SizeMode = PictureBoxSizeMode.StretchImage;
            BottomLeftImg.TabIndex = 5;
            BottomLeftImg.TabStop = false;
            // 
            // BottomRightImg
            // 
            BottomRightImg.BackColor = SystemColors.ButtonShadow;
            BottomRightImg.Location = new Point(715, 217);
            BottomRightImg.Name = "BottomRightImg";
            BottomRightImg.Size = new Size(195, 195);
            BottomRightImg.SizeMode = PictureBoxSizeMode.StretchImage;
            BottomRightImg.TabIndex = 6;
            BottomRightImg.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 423);
            Controls.Add(BottomRightImg);
            Controls.Add(BottomLeftImg);
            Controls.Add(TopRightImg);
            Controls.Add(TopLeftImg);
            Controls.Add(ProcessImgBtn);
            Controls.Add(UploadImgBtn);
            Controls.Add(MainImg);
            Name = "Form1";
            Text = "Image processing";
            ((System.ComponentModel.ISupportInitialize)MainImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)TopLeftImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)TopRightImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)BottomLeftImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)BottomRightImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox MainImg;
        private Button UploadImgBtn;
        private Button ProcessImgBtn;
        private PictureBox TopLeftImg;
        private PictureBox TopRightImg;
        private PictureBox BottomLeftImg;
        private PictureBox BottomRightImg;
    }
}
