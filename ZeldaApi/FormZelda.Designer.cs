namespace ZeldaApi {
    partial class FormZelda {
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
            btnDownload = new Button();
            textBoxResponse = new TextBox();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(12, 409);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(776, 29);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download data";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += BtnDownloadClick;
            // 
            // textBoxResponse
            // 
            textBoxResponse.Location = new Point(12, 12);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ReadOnly = true;
            textBoxResponse.ScrollBars = ScrollBars.Vertical;
            textBoxResponse.Size = new Size(776, 391);
            textBoxResponse.TabIndex = 1;
            // 
            // FormZelda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResponse);
            Controls.Add(btnDownload);
            Name = "FormZelda";
            Text = "Zelda BOTW Compendium";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownload;
        private TextBox textBoxResponse;
    }
}
