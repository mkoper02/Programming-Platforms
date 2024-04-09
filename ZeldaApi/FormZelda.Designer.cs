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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnDownload = new Button();
            listBoxSchemas = new ListBox();
            button1 = new Button();
            label1 = new Label();
            dataGridViewMain = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Favourite = new DataGridViewCheckBoxColumn();
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
            // listBoxSchemas
            // 
            listBoxSchemas.BackColor = SystemColors.ButtonShadow;
            listBoxSchemas.BorderStyle = BorderStyle.FixedSingle;
            listBoxSchemas.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxSchemas.ForeColor = Color.Blue;
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
            label1.Size = new Size(816, 54);
            label1.TabIndex = 6;
            label1.Text = "Hyrule Compendium API";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.BackgroundColor = Color.White;
            dataGridViewMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gold;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { ItemID, Name, Category, Favourite });
            dataGridViewMain.Location = new Point(240, 65);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowHeadersVisible = false;
            dataGridViewMain.RowHeadersWidth = 51;
            dataGridViewMain.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMain.Size = new Size(565, 320);
            dataGridViewMain.TabIndex = 7;
            dataGridViewMain.CellContentClick += DataGridViewMainCellContentClick;
            // 
            // ItemID
            // 
            ItemID.HeaderText = "ItemID";
            ItemID.MinimumWidth = 6;
            ItemID.Name = "ItemID";
            ItemID.ReadOnly = true;
            ItemID.Resizable = DataGridViewTriState.False;
            ItemID.Width = 90;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Resizable = DataGridViewTriState.False;
            Name.Width = 200;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Resizable = DataGridViewTriState.False;
            Category.Width = 125;
            // 
            // Favourite
            // 
            Favourite.HeaderText = "Favourite";
            Favourite.MinimumWidth = 6;
            Favourite.Name = "Favourite";
            Favourite.Resizable = DataGridViewTriState.False;
            Favourite.SortMode = DataGridViewColumnSortMode.Automatic;
            Favourite.Width = 125;
            // 
            // FormZelda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(818, 398);
            Controls.Add(dataGridViewMain);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBoxSchemas);
            Controls.Add(btnDownload);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Text = "Zelda BOTW Compendium";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDownload;
        private ListBox listBoxSchemas;
        private Button button1;
        private Label label1;
        private DataGridView dataGridViewMain;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewCheckBoxColumn Favourite;
    }
}
