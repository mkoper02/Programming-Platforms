namespace ZeldaApi {
    public partial class FormDetails : Form {
        public FormDetails() {
            InitializeComponent();
        }

        public FormDetails(string? description, string imageUrl, string detailName) {
            InitializeComponent();

            Text = detailName;
            textBoxDetails.Text = description;
            pictureBoxDetails.Load(imageUrl);
        }

    }
}
