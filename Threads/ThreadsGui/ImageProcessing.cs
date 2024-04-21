namespace ThreadsGui {
    public class ImageProcessing(Bitmap Image, PictureBox Picture) {
        public Bitmap Image = Image;
        public PictureBox Picture = Picture;

        public void InvertColors() {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    Image.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }

            Picture.Image = Image;
        }

        public void Grayscale() {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    var avg = (pixel.R + pixel.G + pixel.B) / 3;
                    Image.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }

            Picture.Image = Image;
        }

        public void Thresholding(int value) {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    var avg = (pixel.R + pixel.G + pixel.B) / 3;
                    Image.SetPixel(i, j, avg > value ? Color.Black : Color.White);
                }

            Picture.Image = Image;
        }

        public void Sepia() {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    var r = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    var g = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    var b = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);
                    Image.SetPixel(i, j, Color.FromArgb(r > 255 ? 255 : r, g > 255 ? 255 : g, b > 255 ? 255 : b));
                }

            Picture.Image = Image;
        }

        public void Brightness(int value) {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    var r = pixel.R + value;
                    var g = pixel.G + value;
                    var b = pixel.B + value;
                    Image.SetPixel(i, j, Color.FromArgb(r > 255 ? 255 : r, g > 255 ? 255 : g, b > 255 ? 255 : b));
                }

            Picture.Image = Image;
        }

        public void RedChannelColor() {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    Image.SetPixel(i, j, Color.FromArgb(pixel.R, 0, 0));
                }

            Picture.Image = Image;
        }

        public void GreenChannelColor() {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    Image.SetPixel(i, j, Color.FromArgb(0, pixel.G, 0));
                }

            Picture.Image = Image;
        }

        public void BlueChannelColor() {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    Image.SetPixel(i, j, Color.FromArgb(0, 0, pixel.B));
                }

            Picture.Image = Image;
        }
    }
}
