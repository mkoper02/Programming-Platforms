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
            listBoxSchemas = new ListBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            dataGridViewMain = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Favourite = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDownload.Location = new Point(12, 258);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(210, 60);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download data";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += BtnDownloadClick;
            // 
            // textBoxResponse
            // 
            textBoxResponse.Location = new Point(240, 416);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ReadOnly = true;
            textBoxResponse.ScrollBars = ScrollBars.Vertical;
            textBoxResponse.Size = new Size(588, 200);
            textBoxResponse.TabIndex = 1;
            // 
            // listBoxSchemas
            // 
            listBoxSchemas.BackColor = SystemColors.Control;
            listBoxSchemas.BorderStyle = BorderStyle.FixedSingle;
            listBoxSchemas.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxSchemas.ForeColor = Color.Peru;
            listBoxSchemas.FormattingEnabled = true;
            listBoxSchemas.ItemHeight = 37;
            listBoxSchemas.Items.AddRange(new object[] { "Creatures", "Equipment", "Materials", "Monsters", "Treasure" });
            listBoxSchemas.Location = new Point(12, 65);
            listBoxSchemas.Name = "listBoxSchemas";
            listBoxSchemas.ScrollAlwaysVisible = true;
            listBoxSchemas.Size = new Size(210, 187);
            listBoxSchemas.TabIndex = 0;
            listBoxSchemas.SelectedIndexChanged += ListBoxSchemasSelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(12, 416);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(12, 324);
            button1.Name = "button1";
            button1.Size = new Size(210, 60);
            button1.TabIndex = 5;
            button1.Text = "Show Favourites";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(868, 54);
            label1.TabIndex = 6;
            label1.Text = "Hyrule Compendium API";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Category, Favourite });
            dataGridViewMain.Location = new Point(240, 65);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowHeadersWidth = 51;
            dataGridViewMain.Size = new Size(610, 320);
            dataGridViewMain.TabIndex = 7;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 200;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 125;
            // 
            // Favourite
            // 
            Favourite.HeaderText = "Favourite";
            Favourite.MinimumWidth = 6;
            Favourite.Name = "Favourite";
            Favourite.Width = 85;
            // 
            // FormZelda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(866, 625);
            Controls.Add(dataGridViewMain);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxResponse);
            Controls.Add(listBoxSchemas);
            Controls.Add(pictureBox1);
            Controls.Add(btnDownload);
            Text = "Zelda BOTW Compendium";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownload;
        private TextBox textBoxResponse;
        private ListBox listBoxSchemas;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private DataGridView dataGridViewMain;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewCheckBoxColumn Favourite;
    }
}
