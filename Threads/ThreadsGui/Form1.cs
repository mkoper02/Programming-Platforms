using System.Drawing.Imaging;

namespace ThreadsGui {
    public partial class Form1 : Form {
        private string? _imgPath;

        public Form1() {
            InitializeComponent();
        }

        private void UploadImgBtn_Click(object sender, EventArgs e) {
            var fileDialog = new OpenFileDialog {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
            };

            if (fileDialog.ShowDialog() != DialogResult.OK) 
                return;

            _imgPath = fileDialog.FileName;
            MainImg.Image = new Bitmap(_imgPath);
        }

        private void ProcessImgBtn_Click(object sender, EventArgs e) {
            if (_imgPath is null) {
                MessageBox.Show("Please upload an image first.");
                return;
            }

            var threads = new Thread[4];

            for (var i = 0; i < 4; i++) {
                if (i == 0) {
                    var image = new ImageProcessing(new Bitmap(_imgPath), TopLeftImg);
                    threads[i] = new Thread(() => image.InvertColors());
                }

                else if (i == 1) { 
                    var image = new ImageProcessing(new Bitmap(_imgPath), TopRightImg);
                    threads[i] = new Thread(() => image.Grayscale());
                }

                else if (i == 2) {
                    var image = new ImageProcessing(new Bitmap(_imgPath), BottomLeftImg);
                    threads[i] = new Thread(() => image.Thresholding(127));
                }

                else {
                    var image = new ImageProcessing(new Bitmap(_imgPath), BottomRightImg);
                    threads[i] = new Thread(() => image.RedChannelColor());
                }

                threads[i].Start();
            }

            foreach (var thread in threads)
                thread.Join();
        }
    }
}
