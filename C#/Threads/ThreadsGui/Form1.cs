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

            var functions = new[] {
                ImageProcessing.InvertColors,
                ImageProcessing.Grayscale,
                (image) => ImageProcessing.Thresholding(image, 127),
                ImageProcessing.RedChannelColor,
            };

            var locations = new[] {
                TopLeftImg,
                TopRightImg,
                BottomLeftImg,
                BottomRightImg,
            };

            CountdownEvent countdown = new(locations.Length);

            for (var i = 0; i < locations.Length; i++) {
                var index = i;
                var image = new Bitmap(_imgPath);

                new Thread(() => {
                    var result = functions[index](image);
                    locations[index].Invoke(new Action(() => locations[index].Image = result));
                    countdown.Signal();
                }).Start();
            }
        }
    }
}
