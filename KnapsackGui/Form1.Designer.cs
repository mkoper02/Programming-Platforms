namespace KnapsackGui {
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
            labelNumbOfItems = new Label();
            labelSeed = new Label();
            labelCapacity = new Label();
            textBoxNumbOfItems = new TextBox();
            textBoxSeed = new TextBox();
            textBoxCapacity = new TextBox();
            buttonRun = new Button();
            labelInstance = new Label();
            labelResult = new Label();
            textBoxResult = new TextBox();
            textBoxInstance = new TextBox();
            SuspendLayout();
            // 
            // labelNumbOfItems
            // 
            labelNumbOfItems.AutoSize = true;
            labelNumbOfItems.Location = new Point(12, 9);
            labelNumbOfItems.Name = "labelNumbOfItems";
            labelNumbOfItems.Size = new Size(121, 20);
            labelNumbOfItems.TabIndex = 0;
            labelNumbOfItems.Text = "Number of items";
            // 
            // labelSeed
            // 
            labelSeed.AutoSize = true;
            labelSeed.Location = new Point(11, 62);
            labelSeed.Name = "labelSeed";
            labelSeed.Size = new Size(42, 20);
            labelSeed.TabIndex = 1;
            labelSeed.Text = "Seed";
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Location = new Point(12, 115);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(66, 20);
            labelCapacity.TabIndex = 2;
            labelCapacity.Text = "Capacity";
            // 
            // textBoxNumbOfItems
            // 
            textBoxNumbOfItems.Location = new Point(11, 32);
            textBoxNumbOfItems.Name = "textBoxNumbOfItems";
            textBoxNumbOfItems.Size = new Size(218, 27);
            textBoxNumbOfItems.TabIndex = 3;
            // 
            // textBoxSeed
            // 
            textBoxSeed.Location = new Point(11, 85);
            textBoxSeed.Name = "textBoxSeed";
            textBoxSeed.Size = new Size(218, 27);
            textBoxSeed.TabIndex = 4;
            // 
            // textBoxCapacity
            // 
            textBoxCapacity.Location = new Point(12, 138);
            textBoxCapacity.Name = "textBoxCapacity";
            textBoxCapacity.Size = new Size(217, 27);
            textBoxCapacity.TabIndex = 5;
            // 
            // buttonRun
            // 
            buttonRun.ForeColor = SystemColors.ActiveCaptionText;
            buttonRun.Location = new Point(12, 185);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(217, 29);
            buttonRun.TabIndex = 6;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // labelInstance
            // 
            labelInstance.AutoSize = true;
            labelInstance.Location = new Point(380, 9);
            labelInstance.Name = "labelInstance";
            labelInstance.Size = new Size(63, 20);
            labelInstance.TabIndex = 9;
            labelInstance.Text = "Instance";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(180, 229);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(49, 20);
            labelResult.TabIndex = 10;
            labelResult.Text = "Result";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(12, 252);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(217, 184);
            textBoxResult.TabIndex = 11;
            // 
            // textBoxInstance
            // 
            textBoxInstance.Location = new Point(235, 32);
            textBoxInstance.Multiline = true;
            textBoxInstance.Name = "textBoxInstance";
            textBoxInstance.ScrollBars = ScrollBars.Vertical;
            textBoxInstance.Size = new Size(208, 404);
            textBoxInstance.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 443);
            Controls.Add(textBoxInstance);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(labelInstance);
            Controls.Add(buttonRun);
            Controls.Add(textBoxCapacity);
            Controls.Add(textBoxSeed);
            Controls.Add(textBoxNumbOfItems);
            Controls.Add(labelCapacity);
            Controls.Add(labelSeed);
            Controls.Add(labelNumbOfItems);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumbOfItems;
        private Label labelSeed;
        private Label labelCapacity;
        private TextBox textBoxNumbOfItems;
        private TextBox textBoxSeed;
        private TextBox textBoxCapacity;
        private Button buttonRun;
        private Label labelInstance;
        private Label labelResult;
        private TextBox textBoxResult;
        private TextBox textBoxInstance;
    }
}
