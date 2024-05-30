namespace ZeldaApi {
    partial class FormDetails {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pictureBoxDetails = new PictureBox();
            textBoxDetails = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetails).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDetails
            // 
            pictureBoxDetails.Location = new Point(12, 60);
            pictureBoxDetails.Name = "pictureBoxDetails";
            pictureBoxDetails.Size = new Size(300, 300);
            pictureBoxDetails.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDetails.TabIndex = 0;
            pictureBoxDetails.TabStop = false;
            // 
            // textBoxDetails
            // 
            textBoxDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDetails.BackColor = SystemColors.ControlDark;
            textBoxDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxDetails.Location = new Point(318, 60);
            textBoxDetails.Multiline = true;
            textBoxDetails.Name = "textBoxDetails";
            textBoxDetails.ReadOnly = true;
            textBoxDetails.ScrollBars = ScrollBars.Vertical;
            textBoxDetails.Size = new Size(636, 300);
            textBoxDetails.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(-3, -6);
            label1.Name = "label1";
            label1.Size = new Size(966, 54);
            label1.TabIndex = 7;
            label1.Text = "Hyrule Compendium API - Details";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(963, 372);
            Controls.Add(label1);
            Controls.Add(textBoxDetails);
            Controls.Add(pictureBoxDetails);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormDetails";
            Text = "FormDetails";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxDetails;
        private TextBox textBoxDetails;
        private Label label1;
    }
}